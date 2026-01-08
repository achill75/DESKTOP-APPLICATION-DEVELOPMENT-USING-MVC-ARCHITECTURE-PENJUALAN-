<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblAplikasi = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(398, 23)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(181, 25)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "LOGIN"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAplikasi
        '
        Me.lblAplikasi.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAplikasi.ForeColor = System.Drawing.Color.Red
        Me.lblAplikasi.Location = New System.Drawing.Point(338, 52)
        Me.lblAplikasi.Name = "lblAplikasi"
        Me.lblAplikasi.Size = New System.Drawing.Size(295, 25)
        Me.lblAplikasi.TabIndex = 1
        Me.lblAplikasi.Text = "Madura Mart 25 Jam Tutup Setelah Kiamat"
        Me.lblAplikasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(372, 292)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(73, 33)
        Me.btnKeluar.TabIndex = 13
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(529, 292)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(64, 33)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Username"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkShowPassword)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Controls.Add(Me.lblAplikasi)
        Me.Panel1.Location = New System.Drawing.Point(22, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 349)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(33, 117)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(294, 101)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(366, 214)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(366, 142)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(402, 147)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(191, 21)
        Me.txtUsername.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(402, 221)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(191, 21)
        Me.txtPassword.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(399, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(402, 259)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(121, 17)
        Me.chkShowPassword.TabIndex = 17
        Me.chkShowPassword.Text = "Show Passowrd Bro"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(679, 394)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblAplikasi As System.Windows.Forms.Label
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents chkShowPassword As CheckBox
End Class
