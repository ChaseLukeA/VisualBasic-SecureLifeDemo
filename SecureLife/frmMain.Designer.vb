<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Me.bntNewProfile = New System.Windows.Forms.Button()
		Me.btnExistingProfile = New System.Windows.Forms.Button()
		Me.lblIntro = New System.Windows.Forms.Label()
		Me.btnAbout = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'bntNewProfile
		'
		Me.bntNewProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bntNewProfile.Location = New System.Drawing.Point(56, 186)
		Me.bntNewProfile.Name = "bntNewProfile"
		Me.bntNewProfile.Size = New System.Drawing.Size(284, 60)
		Me.bntNewProfile.TabIndex = 2
		Me.bntNewProfile.Text = "Create a &New Profile"
		Me.bntNewProfile.UseVisualStyleBackColor = True
		'
		'btnExistingProfile
		'
		Me.btnExistingProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExistingProfile.Location = New System.Drawing.Point(56, 120)
		Me.btnExistingProfile.Name = "btnExistingProfile"
		Me.btnExistingProfile.Size = New System.Drawing.Size(284, 60)
		Me.btnExistingProfile.TabIndex = 1
		Me.btnExistingProfile.Text = "&Log In to Existing Profile"
		Me.btnExistingProfile.UseVisualStyleBackColor = True
		'
		'lblIntro
		'
		Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIntro.Location = New System.Drawing.Point(8, 5)
		Me.lblIntro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblIntro.Name = "lblIntro"
		Me.lblIntro.Size = New System.Drawing.Size(380, 112)
		Me.lblIntro.TabIndex = 0
		Me.lblIntro.Text = "Welcome to SecureLife, your personal account manager and security suite. Keep sec" & _
	"ure track of all your accounts, account information, finances, and more!"
		Me.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnAbout
		'
		Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAbout.Location = New System.Drawing.Point(173, 259)
		Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
		Me.btnAbout.Name = "btnAbout"
		Me.btnAbout.Size = New System.Drawing.Size(51, 25)
		Me.btnAbout.TabIndex = 3
		Me.btnAbout.TabStop = False
		Me.btnAbout.Text = "&About"
		Me.btnAbout.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(396, 296)
		Me.Controls.Add(Me.btnAbout)
		Me.Controls.Add(Me.lblIntro)
		Me.Controls.Add(Me.btnExistingProfile)
		Me.Controls.Add(Me.bntNewProfile)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.Text = "SecureLife"
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents bntNewProfile As System.Windows.Forms.Button
    Friend WithEvents btnExistingProfile As System.Windows.Forms.Button
    Friend WithEvents lblIntro As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button

End Class
