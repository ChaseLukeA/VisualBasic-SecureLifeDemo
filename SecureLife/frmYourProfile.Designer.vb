<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYourProfile
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
		Me.lstResults = New System.Windows.Forms.ListBox()
		Me.mnuStrip = New System.Windows.Forms.MenuStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCreateAccount = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSeparatorFile = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAutoLogin = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCopyAll = New System.Windows.Forms.ToolStripMenuItem()
		Me.grpSearch = New System.Windows.Forms.GroupBox()
		Me.btnFindNow = New System.Windows.Forms.Button()
		Me.txtFindNow = New System.Windows.Forms.TextBox()
		Me.btnCreateAccount = New System.Windows.Forms.Button()
		Me.btnShowAccounts = New System.Windows.Forms.Button()
		Me.mnuStrip.SuspendLayout()
		Me.grpSearch.SuspendLayout()
		Me.SuspendLayout()
		'
		'lstResults
		'
		Me.lstResults.FormattingEnabled = True
		Me.lstResults.Location = New System.Drawing.Point(12, 79)
		Me.lstResults.Name = "lstResults"
		Me.lstResults.Size = New System.Drawing.Size(545, 329)
		Me.lstResults.TabIndex = 4
		'
		'mnuStrip
		'
		Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit})
		Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
		Me.mnuStrip.Name = "mnuStrip"
		Me.mnuStrip.Size = New System.Drawing.Size(569, 24)
		Me.mnuStrip.TabIndex = 5
		Me.mnuStrip.Text = "MenuStrip1"
		'
		'mnuFile
		'
		Me.mnuFile.Checked = True
		Me.mnuFile.CheckState = System.Windows.Forms.CheckState.Indeterminate
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreateAccount, Me.mnuSeparatorFile, Me.mnuLogout, Me.mnuAutoLogin})
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Size = New System.Drawing.Size(37, 20)
		Me.mnuFile.Text = "&File"
		'
		'mnuCreateAccount
		'
		Me.mnuCreateAccount.Name = "mnuCreateAccount"
		Me.mnuCreateAccount.Size = New System.Drawing.Size(183, 22)
		Me.mnuCreateAccount.Text = "Create &New Account"
		'
		'mnuSeparatorFile
		'
		Me.mnuSeparatorFile.Name = "mnuSeparatorFile"
		Me.mnuSeparatorFile.Size = New System.Drawing.Size(180, 6)
		'
		'mnuLogout
		'
		Me.mnuLogout.Name = "mnuLogout"
		Me.mnuLogout.Size = New System.Drawing.Size(183, 22)
		Me.mnuLogout.Text = "&Log Out"
		'
		'mnuAutoLogin
		'
		Me.mnuAutoLogin.CheckOnClick = True
		Me.mnuAutoLogin.Name = "mnuAutoLogin"
		Me.mnuAutoLogin.Size = New System.Drawing.Size(183, 22)
		Me.mnuAutoLogin.Text = "Auto Login"
		'
		'mnuEdit
		'
		Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuCopyAll})
		Me.mnuEdit.Name = "mnuEdit"
		Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
		Me.mnuEdit.Text = "&Edit"
		'
		'mnuCopy
		'
		Me.mnuCopy.Name = "mnuCopy"
		Me.mnuCopy.Size = New System.Drawing.Size(119, 22)
		Me.mnuCopy.Text = "&Copy"
		'
		'mnuCopyAll
		'
		Me.mnuCopyAll.Name = "mnuCopyAll"
		Me.mnuCopyAll.Size = New System.Drawing.Size(119, 22)
		Me.mnuCopyAll.Text = "Copy &All"
		'
		'grpSearch
		'
		Me.grpSearch.Controls.Add(Me.btnFindNow)
		Me.grpSearch.Controls.Add(Me.txtFindNow)
		Me.grpSearch.Location = New System.Drawing.Point(303, 25)
		Me.grpSearch.Name = "grpSearch"
		Me.grpSearch.Size = New System.Drawing.Size(254, 48)
		Me.grpSearch.TabIndex = 7
		Me.grpSearch.TabStop = False
		Me.grpSearch.Text = "Locate an Account"
		'
		'btnFindNow
		'
		Me.btnFindNow.Location = New System.Drawing.Point(173, 18)
		Me.btnFindNow.Name = "btnFindNow"
		Me.btnFindNow.Size = New System.Drawing.Size(75, 23)
		Me.btnFindNow.TabIndex = 1
		Me.btnFindNow.Text = "&Find Now"
		Me.btnFindNow.UseVisualStyleBackColor = True
		'
		'txtFindNow
		'
		Me.txtFindNow.Location = New System.Drawing.Point(6, 19)
		Me.txtFindNow.Name = "txtFindNow"
		Me.txtFindNow.Size = New System.Drawing.Size(161, 20)
		Me.txtFindNow.TabIndex = 0
		'
		'btnCreateAccount
		'
		Me.btnCreateAccount.Location = New System.Drawing.Point(12, 41)
		Me.btnCreateAccount.Name = "btnCreateAccount"
		Me.btnCreateAccount.Size = New System.Drawing.Size(133, 23)
		Me.btnCreateAccount.TabIndex = 8
		Me.btnCreateAccount.Text = "Create &New Account"
		Me.btnCreateAccount.UseVisualStyleBackColor = True
		'
		'btnShowAccounts
		'
		Me.btnShowAccounts.Location = New System.Drawing.Point(164, 41)
		Me.btnShowAccounts.Name = "btnShowAccounts"
		Me.btnShowAccounts.Size = New System.Drawing.Size(133, 23)
		Me.btnShowAccounts.TabIndex = 9
		Me.btnShowAccounts.Text = "Show Accounts"
		Me.btnShowAccounts.UseVisualStyleBackColor = True
		'
		'frmYourProfile
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(569, 420)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnShowAccounts)
		Me.Controls.Add(Me.btnCreateAccount)
		Me.Controls.Add(Me.grpSearch)
		Me.Controls.Add(Me.lstResults)
		Me.Controls.Add(Me.mnuStrip)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MainMenuStrip = Me.mnuStrip
		Me.MaximizeBox = False
		Me.Name = "frmYourProfile"
		Me.Text = "Your SecureLife Profile"
		Me.mnuStrip.ResumeLayout(False)
		Me.mnuStrip.PerformLayout()
		Me.grpSearch.ResumeLayout(False)
		Me.grpSearch.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lstResults As System.Windows.Forms.ListBox
	Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
	Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuCreateAccount As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuCopyAll As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents mnuSeparatorFile As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
	Friend WithEvents txtFindNow As System.Windows.Forms.TextBox
	Friend WithEvents btnFindNow As System.Windows.Forms.Button
	Friend WithEvents btnCreateAccount As System.Windows.Forms.Button
	Friend WithEvents btnShowAccounts As System.Windows.Forms.Button
	Friend WithEvents mnuAutoLogin As System.Windows.Forms.ToolStripMenuItem
End Class
