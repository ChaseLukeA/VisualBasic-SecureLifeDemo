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
		Me.lblUsername = New System.Windows.Forms.Label()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.chkRememberMe = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'lblUsername
		'
		Me.lblUsername.AutoSize = True
		Me.lblUsername.Location = New System.Drawing.Point(49, 70)
		Me.lblUsername.Name = "lblUsername"
		Me.lblUsername.Size = New System.Drawing.Size(55, 13)
		Me.lblUsername.TabIndex = 1
		Me.lblUsername.Text = "Username"
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Location = New System.Drawing.Point(51, 104)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(53, 13)
		Me.lblPassword.TabIndex = 3
		Me.lblPassword.Text = "Password"
		'
		'txtUsername
		'
		Me.txtUsername.Location = New System.Drawing.Point(110, 67)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(140, 20)
		Me.txtUsername.TabIndex = 2
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(110, 101)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(140, 20)
		Me.txtPassword.TabIndex = 4
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(152, 164)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(103, 23)
		Me.btnCancel.TabIndex = 7
		Me.btnCancel.Text = "Canc&el"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnLogin
		'
		Me.btnLogin.Location = New System.Drawing.Point(43, 164)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(103, 23)
		Me.btnLogin.TabIndex = 6
		Me.btnLogin.Text = "&Login"
		Me.btnLogin.UseVisualStyleBackColor = True
		'
		'lblMessage
		'
		Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMessage.Location = New System.Drawing.Point(11, 9)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(277, 55)
		Me.lblMessage.TabIndex = 0
		Me.lblMessage.Text = "Please enter your username and password to continue:"
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'chkRememberMe
		'
		Me.chkRememberMe.AutoSize = True
		Me.chkRememberMe.Location = New System.Drawing.Point(68, 136)
		Me.chkRememberMe.Name = "chkRememberMe"
		Me.chkRememberMe.Size = New System.Drawing.Size(161, 17)
		Me.chkRememberMe.TabIndex = 5
		Me.chkRememberMe.Text = "Remember Me / Auto Log In"
		Me.chkRememberMe.UseVisualStyleBackColor = True
		'
		'frmLogin
		'
		Me.AcceptButton = Me.btnLogin
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(299, 203)
		Me.ControlBox = False
		Me.Controls.Add(Me.chkRememberMe)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.btnLogin)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.txtUsername)
		Me.Controls.Add(Me.lblPassword)
		Me.Controls.Add(Me.lblUsername)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "frmLogin"
		Me.Text = "Login to Your SecureLife Account"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
	Friend WithEvents lblMessage As System.Windows.Forms.Label
	Friend WithEvents chkRememberMe As System.Windows.Forms.CheckBox
End Class
