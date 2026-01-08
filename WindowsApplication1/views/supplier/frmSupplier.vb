Imports MySql.Data.MySqlClient

Public Class frmSupplier

    '========================
    ' MODE FORM
    '========================
    Private Enum FormMode
        IdleSearch
        AddNew
        EditExisting
    End Enum

    Private mode As FormMode = FormMode.IdleSearch

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetMode(FormMode.IdleSearch)
    End Sub

    '========================
    ' MODE HANDLER
    '========================
    Private Sub SetMode(m As FormMode)
        mode = m

        Select Case mode
            Case FormMode.IdleSearch
                ClearFields()

                txtKode.Enabled = True
                txtNamaSupplier.Enabled = False
                txtAlamat.Enabled = False
                txtTelpHp.Enabled = False
                txtKontakPerson.Enabled = False

                btnTambah.Enabled = True
                btnEdit.Enabled = False
                btnEdit.Text = "Edit"
                btnHapus.Enabled = False
                btnBatal.Enabled = True

                txtKode.Focus()

            Case FormMode.AddNew
                ClearFields()

                txtKode.Enabled = False 'kode auto
                txtNamaSupplier.Enabled = True
                txtAlamat.Enabled = True
                txtTelpHp.Enabled = True
                txtKontakPerson.Enabled = True

                btnTambah.Enabled = False
                btnEdit.Enabled = True
                btnEdit.Text = "Simpan"
                btnHapus.Enabled = False
                btnBatal.Enabled = True

                txtNamaSupplier.Focus()

            Case FormMode.EditExisting
                txtKode.Enabled = False

                txtNamaSupplier.Enabled = True
                txtAlamat.Enabled = True
                txtTelpHp.Enabled = True
                txtKontakPerson.Enabled = True

                btnTambah.Enabled = False
                btnEdit.Enabled = True
                btnEdit.Text = "Simpan"
                btnHapus.Enabled = True
                btnBatal.Enabled = True

                txtNamaSupplier.Focus()
        End Select
    End Sub

    Private Sub ClearFields()
        txtKode.Text = ""
        txtNamaSupplier.Text = ""
        txtAlamat.Text = ""
        txtTelpHp.Text = ""
        txtKontakPerson.Text = ""
    End Sub

    Private Function ValidateInput() As Boolean
        If txtKode.Text.Trim() = "" Then
            MessageBox.Show("Kode supplier wajib ada.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If txtNamaSupplier.Text.Trim() = "" Then
            MessageBox.Show("Nama supplier wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaSupplier.Focus()
            Return False
        End If
        Return True
    End Function

    '========================
    ' AUTO GENERATE KODE
    '========================
    Private Function GenerateKodeSupplier() As String
        Dim kodeBaru As String = "SUP0001"

        Try
            Using conn As MySqlConnection = Koneksi.OpenConnection()
                Using cmd As New MySqlCommand(
                    "SELECT kode_supplier FROM supplier ORDER BY kode_supplier DESC LIMIT 1", conn)

                    Using rd = cmd.ExecuteReader()
                        If rd.Read() Then
                            Dim kodeLama As String = rd("kode_supplier").ToString() 'SUP0007
                            Dim nomor As Integer = CInt(kodeLama.Substring(3)) + 1
                            kodeBaru = "SUP" & nomor.ToString("0000")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' jika tabel kosong / error: tetap SUP0001
        End Try

        Return kodeBaru
    End Function

    '========================
    ' LOAD BY KODE (Enter)
    '========================
    Private Sub txtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadByKode(txtKode.Text.Trim())
        End If
    End Sub

    Private Sub LoadByKode(kode As String)
        If kode = "" Then
            MessageBox.Show("Isi kode supplier dulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtKode.Focus()
            Return
        End If

        Try
            Using conn As MySqlConnection = Koneksi.OpenConnection()
                Using cmd As New MySqlCommand(
                    "SELECT kode_supplier, nama_supplier, alamat, telp, kontak_person
                     FROM supplier WHERE kode_supplier=@k LIMIT 1", conn)

                    cmd.Parameters.AddWithValue("@k", kode)

                    Using rd = cmd.ExecuteReader()
                        If rd.Read() Then
                            txtKode.Text = rd("kode_supplier").ToString()
                            txtNamaSupplier.Text = rd("nama_supplier").ToString()
                            txtAlamat.Text = If(IsDBNull(rd("alamat")), "", rd("alamat").ToString())
                            txtTelpHp.Text = If(IsDBNull(rd("telp")), "", rd("telp").ToString())
                            txtKontakPerson.Text = If(IsDBNull(rd("kontak_person")), "", rd("kontak_person").ToString())

                            'sesuai request: ketemu -> langsung bisa ubah
                            SetMode(FormMode.EditExisting)
                        Else
                            MessageBox.Show("Kode tidak ditemukan. Klik Tambah untuk input supplier baru.",
                                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtKode.Focus()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal load: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '========================
    ' BUTTON EVENTS
    '========================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        SetMode(FormMode.AddNew)

        txtKode.Text = GenerateKodeSupplier()
        txtKode.Enabled = False 'biar tidak bisa diubah (opsional, tapi biasanya begitu)
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        SetMode(FormMode.IdleSearch)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If mode = FormMode.AddNew Then
            InsertSupplier()
        ElseIf mode = FormMode.EditExisting Then
            UpdateSupplier()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If mode <> FormMode.EditExisting Then Return

        Dim kode = txtKode.Text.Trim()
        If kode = "" Then Return

        If MessageBox.Show($"Hapus supplier {kode} ?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        Try
            Using conn As MySqlConnection = Koneksi.OpenConnection()
                Using cmd As New MySqlCommand("DELETE FROM supplier WHERE kode_supplier=@k", conn)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data berhasil dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SetMode(FormMode.IdleSearch)

        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '========================
    ' INSERT / UPDATE
    '========================
    Private Sub InsertSupplier()
        If Not ValidateInput() Then Return

        Try
            Using conn As MySqlConnection = Koneksi.OpenConnection()

                Dim sql As String =
                    "INSERT INTO supplier (kode_supplier, nama_supplier, alamat, telp, kontak_person)
                     VALUES (@k, @n, @a, @t, @kp)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@k", txtKode.Text.Trim())
                    cmd.Parameters.AddWithValue("@n", txtNamaSupplier.Text.Trim())
                    cmd.Parameters.AddWithValue("@a", If(txtAlamat.Text.Trim() = "", DBNull.Value, txtAlamat.Text.Trim()))
                    cmd.Parameters.AddWithValue("@t", If(txtTelpHp.Text.Trim() = "", DBNull.Value, txtTelpHp.Text.Trim()))
                    cmd.Parameters.AddWithValue("@kp", If(txtKontakPerson.Text.Trim() = "", DBNull.Value, txtKontakPerson.Text.Trim()))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Supplier berhasil disimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SetMode(FormMode.IdleSearch)

        Catch ex As MySqlException When ex.Number = 1062
            ' Duplicate primary key: kode sudah ada -> buka untuk edit
            MessageBox.Show("Kode supplier sudah ada. Data akan dibuka untuk diubah.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadByKode(txtKode.Text.Trim())

        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateSupplier()
        If Not ValidateInput() Then Return

        Try
            Using conn As MySqlConnection = Koneksi.OpenConnection()

                Dim sql As String =
                    "UPDATE supplier
                     SET nama_supplier=@n, alamat=@a, telp=@t, kontak_person=@kp
                     WHERE kode_supplier=@k"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@k", txtKode.Text.Trim())
                    cmd.Parameters.AddWithValue("@n", txtNamaSupplier.Text.Trim())
                    cmd.Parameters.AddWithValue("@a", If(txtAlamat.Text.Trim() = "", DBNull.Value, txtAlamat.Text.Trim()))
                    cmd.Parameters.AddWithValue("@t", If(txtTelpHp.Text.Trim() = "", DBNull.Value, txtTelpHp.Text.Trim()))
                    cmd.Parameters.AddWithValue("@kp", If(txtKontakPerson.Text.Trim() = "", DBNull.Value, txtKontakPerson.Text.Trim()))

                    Dim affected = cmd.ExecuteNonQuery()
                    If affected = 0 Then
                        MessageBox.Show("Data tidak ditemukan untuk diupdate.", "Info",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        SetMode(FormMode.IdleSearch)
                        Return
                    End If
                End Using
            End Using

            MessageBox.Show("Supplier berhasil diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SetMode(FormMode.IdleSearch)

        Catch ex As Exception
            MessageBox.Show("Gagal update: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
