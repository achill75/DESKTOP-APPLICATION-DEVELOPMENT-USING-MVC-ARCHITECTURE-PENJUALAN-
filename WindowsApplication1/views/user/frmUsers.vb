Imports MySql.Data.MySqlClient

Public Class frmUsers
    Dim ctrl As New UserController()

    Private isEdit As Boolean = False
    Private _mode As String = ""   ' "" / "kasir"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(mode As String)
        InitializeComponent()
        _mode = If(mode, "").ToLower().Trim()
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Clear()
        cmbRole.Items.Add("admin")
        cmbRole.Items.Add("kasir")

        If _mode = "kasir" Then
            Me.Text = "Data Kasir"
            lblTitle.Text = "KASIR"
            cmbRole.SelectedItem = "kasir"
            cmbRole.Enabled = False
        Else
            Me.Text = "Data Users"
            lblTitle.Text = "USERS"
            cmbRole.Enabled = True
        End If

        LoadData()
        ClearForm()
    End Sub

    Private Sub LoadData()
        Try
            Dim dt As New DataTable()
            Dim sql As String

            If _mode = "kasir" Then
                sql = "SELECT id, username, role FROM users WHERE role='kasir' ORDER BY id DESC"
            Else
                sql = "SELECT id, username, role FROM users ORDER BY id DESC"
            End If

            Using conn = OpenConnection()
                Using da As New MySqlDataAdapter(sql, conn)
                    da.Fill(dt)
                End Using
            End Using

            dgvUsers.DataSource = dt
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvUsers.ReadOnly = True
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Catch ex As Exception
            MessageBox.Show("Load user gagal: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearForm()
        txtId.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        isEdit = False

        If _mode = "kasir" Then
            cmbRole.SelectedItem = "kasir"
        Else
            cmbRole.SelectedIndex = -1
        End If

        txtUsername.Focus()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearForm()

        ' AUTO GENERATE ID (SAMA KONSEP DENGAN frmPurchase)
        txtId.Text = ctrl.GetNewUserId().ToString()
    End Sub


    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvUsers.Rows(e.RowIndex)

        txtId.Text = row.Cells("id").Value.ToString()
        txtUsername.Text = row.Cells("username").Value.ToString()
        cmbRole.SelectedItem = row.Cells("role").Value.ToString()

        txtPassword.Text = "" ' password tidak ditampilkan
        isEdit = True

        If _mode = "kasir" Then
            cmbRole.SelectedItem = "kasir"
            cmbRole.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Username wajib diisi.")
            Return
        End If

        Dim roleVal As String = If(_mode = "kasir", "kasir", If(cmbRole.SelectedItem, "").ToString())
        If String.IsNullOrWhiteSpace(roleVal) Then
            MessageBox.Show("Role wajib dipilih.")
            Return
        End If

        Try
            Using conn = OpenConnection()
                If Not isEdit Then
                    If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                        MessageBox.Show("Password wajib diisi untuk user baru.")
                        Return
                    End If

                    ' ===============================
                    ' INSERT USER BARU (AUTO ID)
                    ' ===============================
                    Dim sql As String =
                    "INSERT INTO users (id, username, password, role)VALUES (@id, @u, @p, @r)"

                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@id", CInt(txtId.Text))
                        cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
                        cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim())
                        cmd.Parameters.AddWithValue("@r", roleVal)
                        cmd.ExecuteNonQuery()
                    End Using

                Else
                    ' update tanpa ganti password kalau kosong
                    If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                        Dim sql As String = "UPDATE users SET username=@u, role=@r WHERE id=@id"
                        Using cmd As New MySqlCommand(sql, conn)
                            cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
                            cmd.Parameters.AddWithValue("@r", roleVal)
                            cmd.Parameters.AddWithValue("@id", CInt(txtId.Text))
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        Dim sql As String = "UPDATE users SET username=@u, password=@p, role=@r WHERE id=@id"
                        Using cmd As New MySqlCommand(sql, conn)
                            cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
                            cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim())
                            cmd.Parameters.AddWithValue("@r", roleVal)
                            cmd.Parameters.AddWithValue("@id", CInt(txtId.Text))
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    MessageBox.Show("User berhasil diupdate.")
                End If
            End Using

            LoadData()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Simpan gagal: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtId.Text) Then
            MessageBox.Show("Pilih user dulu di tabel.")
            Return
        End If

        If MessageBox.Show("Yakin hapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Try
            Using conn = OpenConnection()
                Dim sql As String = "DELETE FROM users WHERE id=@id"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(txtId.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User berhasil dihapus.")
            LoadData()
            ClearForm()
        Catch ex As Exception
            MessageBox.Show("Hapus gagal: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub
End Class
