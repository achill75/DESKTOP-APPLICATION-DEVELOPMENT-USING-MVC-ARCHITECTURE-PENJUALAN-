<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtNamaSupplier = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtTelpHp = New System.Windows.Forms.TextBox()
        Me.txtKontakPerson = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telp / Hp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kontak Person"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(223, 51)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(206, 20)
        Me.txtKode.TabIndex = 5
        '
        'txtNamaSupplier
        '
        Me.txtNamaSupplier.Location = New System.Drawing.Point(223, 99)
        Me.txtNamaSupplier.Name = "txtNamaSupplier"
        Me.txtNamaSupplier.Size = New System.Drawing.Size(206, 20)
        Me.txtNamaSupplier.TabIndex = 6
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(223, 149)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(206, 20)
        Me.txtAlamat.TabIndex = 7
        '
        'txtTelpHp
        '
        Me.txtTelpHp.Location = New System.Drawing.Point(223, 210)
        Me.txtTelpHp.Name = "txtTelpHp"
        Me.txtTelpHp.Size = New System.Drawing.Size(206, 20)
        Me.txtTelpHp.TabIndex = 8
        '
        'txtKontakPerson
        '
        Me.txtKontakPerson.Location = New System.Drawing.Point(223, 270)
        Me.txtKontakPerson.Name = "txtKontakPerson"
        Me.txtKontakPerson.Size = New System.Drawing.Size(206, 20)
        Me.txtKontakPerson.TabIndex = 9
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(39, 343)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(83, 26)
        Me.btnTambah.TabIndex = 10
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(159, 343)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(83, 26)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(283, 343)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(83, 26)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(405, 343)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(83, 26)
        Me.btnBatal.TabIndex = 13
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 408)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtKontakPerson)
        Me.Controls.Add(Me.txtTelpHp)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNamaSupplier)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSupplier"
        Me.Text = "Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNamaSupplier As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelpHp As TextBox
    Friend WithEvents txtKontakPerson As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
End Class
