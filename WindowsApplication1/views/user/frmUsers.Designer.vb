<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(365, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(68, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Users"
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(278, 94)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(497, 216)
        Me.dgvUsers.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(119, 94)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(130, 20)
        Me.txtId.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(119, 141)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(130, 20)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(119, 191)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(130, 20)
        Me.txtPassword.TabIndex = 4
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(119, 241)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(130, 21)
        Me.cmbRole.TabIndex = 5
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(568, 49)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(174, 287)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Simpan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(700, 49)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(31, 287)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Keluar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(28, 97)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 13)
        Me.lblId.TabIndex = 10
        Me.lblId.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Passowrd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Role"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 370)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmUsers"
        Me.Text = "Akses Users"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblId As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
