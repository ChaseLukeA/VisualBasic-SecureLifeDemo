<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewProfile
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
		Me.components = New System.ComponentModel.Container()
		Me.lblUserName = New System.Windows.Forms.Label()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.txtUserName = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnCreateProfile = New System.Windows.Forms.Button()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.lblEmail = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.txtRetype = New System.Windows.Forms.TextBox()
		Me.lblRetype = New System.Windows.Forms.Label()
		Me.lblUsernameError = New System.Windows.Forms.Label()
		Me.lblPasswordError = New System.Windows.Forms.Label()
		Me.lblRetypeError = New System.Windows.Forms.Label()
		Me.lblEmailError = New System.Windows.Forms.Label()
		Me.tipAlerts = New System.Windows.Forms.ToolTip(Me.components)
		Me.SuspendLayout()
		'
		'lblUserName
		'
		Me.lblUserName.AutoSize = True
		Me.lblUserName.Location = New System.Drawing.Point(56, 48)
		Me.lblUserName.Name = "lblUserName"
		Me.lblUserName.Size = New System.Drawing.Size(55, 13)
		Me.lblUserName.TabIndex = 1
		Me.lblUserName.Text = "Username"
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Location = New System.Drawing.Point(58, 82)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(53, 13)
		Me.lblPassword.TabIndex = 4
		Me.lblPassword.Text = "Password"
		'
		'txtUserName
		'
		Me.txtUserName.Location = New System.Drawing.Point(117, 45)
		Me.txtUserName.Name = "txtUserName"
		Me.txtUserName.Size = New System.Drawing.Size(140, 20)
		Me.txtUserName.TabIndex = 2
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(117, 79)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(140, 20)
		Me.txtPassword.TabIndex = 5
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(152, 182)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(103, 23)
		Me.btnCancel.TabIndex = 14
		Me.btnCancel.Text = "Canc&el"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnCreateProfile
		'
		Me.btnCreateProfile.Location = New System.Drawing.Point(43, 182)
		Me.btnCreateProfile.Name = "btnCreateProfile"
		Me.btnCreateProfile.Size = New System.Drawing.Size(103, 23)
		Me.btnCreateProfile.TabIndex = 13
		Me.btnCreateProfile.Text = "&Create Profile"
		Me.btnCreateProfile.UseVisualStyleBackColor = True
		'
		'lblMessage
		'
		Me.lblMessage.AutoSize = True
		Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMessage.Location = New System.Drawing.Point(11, 9)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(277, 24)
		Me.lblMessage.TabIndex = 0
		Me.lblMessage.Text = "Create a new SecureLife profile:"
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Location = New System.Drawing.Point(38, 149)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(73, 13)
		Me.lblEmail.TabIndex = 10
		Me.lblEmail.Text = "Email Address"
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(117, 147)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(140, 20)
		Me.txtEmail.TabIndex = 11
		'
		'txtRetype
		'
		Me.txtRetype.Enabled = False
		Me.txtRetype.Location = New System.Drawing.Point(117, 113)
		Me.txtRetype.Name = "txtRetype"
		Me.txtRetype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtRetype.Size = New System.Drawing.Size(140, 20)
		Me.txtRetype.TabIndex = 8
		'
		'lblRetype
		'
		Me.lblRetype.AutoSize = True
		Me.lblRetype.Location = New System.Drawing.Point(21, 116)
		Me.lblRetype.Name = "lblRetype"
		Me.lblRetype.Size = New System.Drawing.Size(90, 13)
		Me.lblRetype.TabIndex = 7
		Me.lblRetype.Text = "Retype Password"
		'
		'lblUsernameError
		'
		Me.lblUsernameError.AutoSize = True
		Me.lblUsernameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUsernameError.ForeColor = System.Drawing.Color.Red
		Me.lblUsernameError.Location = New System.Drawing.Point(259, 43)
		Me.lblUsernameError.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
		Me.lblUsernameError.Name = "lblUsernameError"
		Me.lblUsernameError.Size = New System.Drawing.Size(17, 20)
		Me.lblUsernameError.TabIndex = 3
		Me.lblUsernameError.Text = "x"
		Me.tipAlerts.SetToolTip(Me.lblUsernameError, "Username must be at least six characters long and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can only contain uppercase or " & _
		"lowercase letters," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "numbers, periods (""."") and underscores (""_"").")
		Me.lblUsernameError.Visible = False
		'
		'lblPasswordError
		'
		Me.lblPasswordError.AutoSize = True
		Me.lblPasswordError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPasswordError.ForeColor = System.Drawing.Color.Red
		Me.lblPasswordError.Location = New System.Drawing.Point(259, 77)
		Me.lblPasswordError.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
		Me.lblPasswordError.Name = "lblPasswordError"
		Me.lblPasswordError.Size = New System.Drawing.Size(17, 20)
		Me.lblPasswordError.TabIndex = 6
		Me.lblPasswordError.Text = "x"
		Me.tipAlerts.SetToolTip(Me.lblPasswordError, "Password must be at least eight characters long," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "must contain at least one upper" & _
		"case letter," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "one lowercase letter and at least one number.")
		Me.lblPasswordError.Visible = False
		'
		'lblRetypeError
		'
		Me.lblRetypeError.AutoSize = True
		Me.lblRetypeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRetypeError.ForeColor = System.Drawing.Color.Red
		Me.lblRetypeError.Location = New System.Drawing.Point(259, 111)
		Me.lblRetypeError.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
		Me.lblRetypeError.Name = "lblRetypeError"
		Me.lblRetypeError.Size = New System.Drawing.Size(17, 20)
		Me.lblRetypeError.TabIndex = 9
		Me.lblRetypeError.Text = "x"
		Me.tipAlerts.SetToolTip(Me.lblRetypeError, "The passwords do not match!")
		Me.lblRetypeError.Visible = False
		'
		'lblEmailError
		'
		Me.lblEmailError.AutoSize = True
		Me.lblEmailError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEmailError.ForeColor = System.Drawing.Color.Red
		Me.lblEmailError.Location = New System.Drawing.Point(259, 145)
		Me.lblEmailError.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
		Me.lblEmailError.Name = "lblEmailError"
		Me.lblEmailError.Size = New System.Drawing.Size(17, 20)
		Me.lblEmailError.TabIndex = 12
		Me.lblEmailError.Text = "x"
		Me.tipAlerts.SetToolTip(Me.lblEmailError, "Email address must be in this format:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "username>@<host>.<domain>")
		Me.lblEmailError.Visible = False
		'
		'tipAlerts
		'
		Me.tipAlerts.IsBalloon = True
		Me.tipAlerts.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
		'
		'frmNewProfile
		'
		Me.AcceptButton = Me.btnCreateProfile
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(299, 220)
		Me.ControlBox = False
		Me.Controls.Add(Me.lblEmailError)
		Me.Controls.Add(Me.lblRetypeError)
		Me.Controls.Add(Me.lblPasswordError)
		Me.Controls.Add(Me.lblUsernameError)
		Me.Controls.Add(Me.txtRetype)
		Me.Controls.Add(Me.lblRetype)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.lblEmail)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.btnCreateProfile)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.txtUserName)
		Me.Controls.Add(Me.lblPassword)
		Me.Controls.Add(Me.lblUserName)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "frmNewProfile"
		Me.Text = "New SecureLife Profile"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblUserName As System.Windows.Forms.Label
	Friend WithEvents lblPassword As System.Windows.Forms.Label
	Friend WithEvents txtUserName As System.Windows.Forms.TextBox
	Friend WithEvents txtPassword As System.Windows.Forms.TextBox
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents btnCreateProfile As System.Windows.Forms.Button
	Friend WithEvents lblMessage As System.Windows.Forms.Label
	Friend WithEvents lblEmail As System.Windows.Forms.Label
	Friend WithEvents txtEmail As System.Windows.Forms.TextBox
	Friend WithEvents txtRetype As System.Windows.Forms.TextBox
	Friend WithEvents lblRetype As System.Windows.Forms.Label
	Friend WithEvents lblUsernameError As System.Windows.Forms.Label
	Friend WithEvents lblPasswordError As System.Windows.Forms.Label
	Friend WithEvents lblRetypeError As System.Windows.Forms.Label
	Friend WithEvents lblEmailError As System.Windows.Forms.Label
	Friend WithEvents tipAlerts As System.Windows.Forms.ToolTip
End Class
