<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewAccount
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
		Me.radBank = New System.Windows.Forms.RadioButton()
		Me.radDigitalWallet = New System.Windows.Forms.RadioButton()
		Me.radCard = New System.Windows.Forms.RadioButton()
		Me.radGift = New System.Windows.Forms.RadioButton()
		Me.radEmail = New System.Windows.Forms.RadioButton()
		Me.radWebsite = New System.Windows.Forms.RadioButton()
		Me.radSocialMedia = New System.Windows.Forms.RadioButton()
		Me.radEducation = New System.Windows.Forms.RadioButton()
		Me.grpAccountType = New System.Windows.Forms.GroupBox()
		Me.radOther = New System.Windows.Forms.RadioButton()
		Me.radInsurance = New System.Windows.Forms.RadioButton()
		Me.radLegal = New System.Windows.Forms.RadioButton()
		Me.radSoftware = New System.Windows.Forms.RadioButton()
		Me.tipExamples = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtDOB = New System.Windows.Forms.TextBox()
		Me.txtAcctNumber = New System.Windows.Forms.TextBox()
		Me.txtUserName = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.txtCode = New System.Windows.Forms.TextBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.lblAcctName = New System.Windows.Forms.Label()
		Me.lblAcctPhone = New System.Windows.Forms.Label()
		Me.lblPassword = New System.Windows.Forms.Label()
		Me.lblUsername = New System.Windows.Forms.Label()
		Me.lblAcctNumber = New System.Windows.Forms.Label()
		Me.rtbNotes = New System.Windows.Forms.RichTextBox()
		Me.cboAcctName = New System.Windows.Forms.ComboBox()
		Me.grpAccountDetails = New System.Windows.Forms.GroupBox()
		Me.txtSecretAnswer = New System.Windows.Forms.TextBox()
		Me.lblSecretAnswer = New System.Windows.Forms.Label()
		Me.txtSecretQuestion = New System.Windows.Forms.TextBox()
		Me.lblSecretQuestion = New System.Windows.Forms.Label()
		Me.txtRouting = New System.Windows.Forms.TextBox()
		Me.lblRouting = New System.Windows.Forms.Label()
		Me.lblAcctZip = New System.Windows.Forms.Label()
		Me.lblAcctState = New System.Windows.Forms.Label()
		Me.lblAcctCity = New System.Windows.Forms.Label()
		Me.txtAcctZip = New System.Windows.Forms.TextBox()
		Me.txtAcctState = New System.Windows.Forms.TextBox()
		Me.lblAcctAddress = New System.Windows.Forms.Label()
		Me.txtAcctCity = New System.Windows.Forms.TextBox()
		Me.txtAcctAddress = New System.Windows.Forms.TextBox()
		Me.txtAcctPhone = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtURL = New System.Windows.Forms.TextBox()
		Me.lblURL = New System.Windows.Forms.Label()
		Me.lblRegisteredEmail = New System.Windows.Forms.Label()
		Me.lblCode = New System.Windows.Forms.Label()
		Me.btnCopy = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.grpAccountType.SuspendLayout()
		Me.grpAccountDetails.SuspendLayout()
		Me.SuspendLayout()
		'
		'radBank
		'
		Me.radBank.AutoSize = True
		Me.radBank.Location = New System.Drawing.Point(6, 19)
		Me.radBank.Name = "radBank"
		Me.radBank.Size = New System.Drawing.Size(93, 17)
		Me.radBank.TabIndex = 0
		Me.radBank.TabStop = True
		Me.radBank.Text = "Bank Account"
		Me.tipExamples.SetToolTip(Me.radBank, "Local or online bank accounts." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Create deposit (i.e. checking)," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "loan (i.e. home," & _
		" vehicle) and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "savings account records.")
		Me.radBank.UseVisualStyleBackColor = True
		'
		'radDigitalWallet
		'
		Me.radDigitalWallet.AutoSize = True
		Me.radDigitalWallet.Location = New System.Drawing.Point(6, 42)
		Me.radDigitalWallet.Name = "radDigitalWallet"
		Me.radDigitalWallet.Size = New System.Drawing.Size(87, 17)
		Me.radDigitalWallet.TabIndex = 1
		Me.radDigitalWallet.TabStop = True
		Me.radDigitalWallet.Text = "Digital Wallet"
		Me.tipExamples.SetToolTip(Me.radDigitalWallet, "Online finance accounts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "such as PayPal, Apple Pay," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Google Wallet, Bitcoin and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
		"more.")
		Me.radDigitalWallet.UseVisualStyleBackColor = True
		'
		'radCard
		'
		Me.radCard.AutoSize = True
		Me.radCard.Location = New System.Drawing.Point(6, 65)
		Me.radCard.Name = "radCard"
		Me.radCard.Size = New System.Drawing.Size(113, 17)
		Me.radCard.TabIndex = 2
		Me.radCard.TabStop = True
		Me.radCard.Text = "Credit / Debit Card"
		Me.tipExamples.SetToolTip(Me.radCard, "Credit cards, debit cards, store" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cards like Target, Best Buy, etc.")
		Me.radCard.UseVisualStyleBackColor = True
		'
		'radGift
		'
		Me.radGift.AutoSize = True
		Me.radGift.Location = New System.Drawing.Point(6, 88)
		Me.radGift.Name = "radGift"
		Me.radGift.Size = New System.Drawing.Size(66, 17)
		Me.radGift.TabIndex = 3
		Me.radGift.TabStop = True
		Me.radGift.Text = "Gift Card"
		Me.tipExamples.SetToolTip(Me.radGift, "Gift card information for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "local and online retailers.")
		Me.radGift.UseVisualStyleBackColor = True
		'
		'radEmail
		'
		Me.radEmail.AutoSize = True
		Me.radEmail.Location = New System.Drawing.Point(6, 111)
		Me.radEmail.Name = "radEmail"
		Me.radEmail.Size = New System.Drawing.Size(50, 17)
		Me.radEmail.TabIndex = 4
		Me.radEmail.TabStop = True
		Me.radEmail.Text = "Email"
		Me.tipExamples.SetToolTip(Me.radEmail, "Email address account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "information such as Yahoo," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gmail, Live mail and more.")
		Me.radEmail.UseVisualStyleBackColor = True
		'
		'radWebsite
		'
		Me.radWebsite.AutoSize = True
		Me.radWebsite.Location = New System.Drawing.Point(6, 180)
		Me.radWebsite.Name = "radWebsite"
		Me.radWebsite.Size = New System.Drawing.Size(102, 17)
		Me.radWebsite.TabIndex = 7
		Me.radWebsite.TabStop = True
		Me.radWebsite.Text = "Website Access"
		Me.tipExamples.SetToolTip(Me.radWebsite, "Account information for online" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "website accounts like Google," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Netflix, Pandora, " & _
		"Microsoft," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ESPN, Apple IDs and more.")
		Me.radWebsite.UseVisualStyleBackColor = True
		'
		'radSocialMedia
		'
		Me.radSocialMedia.AutoSize = True
		Me.radSocialMedia.Location = New System.Drawing.Point(6, 134)
		Me.radSocialMedia.Name = "radSocialMedia"
		Me.radSocialMedia.Size = New System.Drawing.Size(86, 17)
		Me.radSocialMedia.TabIndex = 5
		Me.radSocialMedia.TabStop = True
		Me.radSocialMedia.Text = "Social Media"
		Me.tipExamples.SetToolTip(Me.radSocialMedia, "Social media accounts such" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as Facebook, Twitter and YouTube.")
		Me.radSocialMedia.UseVisualStyleBackColor = True
		'
		'radEducation
		'
		Me.radEducation.AutoSize = True
		Me.radEducation.Location = New System.Drawing.Point(6, 157)
		Me.radEducation.Name = "radEducation"
		Me.radEducation.Size = New System.Drawing.Size(73, 17)
		Me.radEducation.TabIndex = 6
		Me.radEducation.TabStop = True
		Me.radEducation.Text = "Education"
		Me.tipExamples.SetToolTip(Me.radEducation, "Education accounts like your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "school or college information," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "online class inform" & _
		"ation, book," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "course or grading information.")
		Me.radEducation.UseVisualStyleBackColor = True
		'
		'grpAccountType
		'
		Me.grpAccountType.Controls.Add(Me.radOther)
		Me.grpAccountType.Controls.Add(Me.radInsurance)
		Me.grpAccountType.Controls.Add(Me.radLegal)
		Me.grpAccountType.Controls.Add(Me.radSoftware)
		Me.grpAccountType.Controls.Add(Me.radBank)
		Me.grpAccountType.Controls.Add(Me.radEducation)
		Me.grpAccountType.Controls.Add(Me.radDigitalWallet)
		Me.grpAccountType.Controls.Add(Me.radSocialMedia)
		Me.grpAccountType.Controls.Add(Me.radCard)
		Me.grpAccountType.Controls.Add(Me.radWebsite)
		Me.grpAccountType.Controls.Add(Me.radGift)
		Me.grpAccountType.Controls.Add(Me.radEmail)
		Me.grpAccountType.Location = New System.Drawing.Point(12, 12)
		Me.grpAccountType.Name = "grpAccountType"
		Me.grpAccountType.Size = New System.Drawing.Size(125, 296)
		Me.grpAccountType.TabIndex = 0
		Me.grpAccountType.TabStop = False
		Me.grpAccountType.Text = "Account Type"
		'
		'radOther
		'
		Me.radOther.AutoSize = True
		Me.radOther.Location = New System.Drawing.Point(7, 273)
		Me.radOther.Name = "radOther"
		Me.radOther.Size = New System.Drawing.Size(99, 17)
		Me.radOther.TabIndex = 11
		Me.radOther.TabStop = True
		Me.radOther.Text = "Other Accounts"
		Me.tipExamples.SetToolTip(Me.radOther, "Information for any other" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "accounts that don't really" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fit any other categoreis.")
		Me.radOther.UseVisualStyleBackColor = True
		'
		'radInsurance
		'
		Me.radInsurance.AutoSize = True
		Me.radInsurance.Location = New System.Drawing.Point(7, 250)
		Me.radInsurance.Name = "radInsurance"
		Me.radInsurance.Size = New System.Drawing.Size(72, 17)
		Me.radInsurance.TabIndex = 10
		Me.radInsurance.TabStop = True
		Me.radInsurance.Text = "Insurance"
		Me.tipExamples.SetToolTip(Me.radInsurance, "Insurance account information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "such as homeowners, health," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "life and other types " & _
		"of insurance.")
		Me.radInsurance.UseVisualStyleBackColor = True
		'
		'radLegal
		'
		Me.radLegal.AutoSize = True
		Me.radLegal.Location = New System.Drawing.Point(6, 226)
		Me.radLegal.Name = "radLegal"
		Me.radLegal.Size = New System.Drawing.Size(99, 17)
		Me.radLegal.TabIndex = 9
		Me.radLegal.TabStop = True
		Me.radLegal.Text = "Legal Accounts"
		Me.tipExamples.SetToolTip(Me.radLegal, "Legal account information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "such as driver's licenses," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ID cards, birth certificat" & _
		"es," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "social security numbers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and more.")
		Me.radLegal.UseVisualStyleBackColor = True
		'
		'radSoftware
		'
		Me.radSoftware.AutoSize = True
		Me.radSoftware.Location = New System.Drawing.Point(6, 203)
		Me.radSoftware.Name = "radSoftware"
		Me.radSoftware.Size = New System.Drawing.Size(105, 17)
		Me.radSoftware.TabIndex = 8
		Me.radSoftware.TabStop = True
		Me.radSoftware.Text = "Software Access"
		Me.tipExamples.SetToolTip(Me.radSoftware, "Software access information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "like licenses, cd keys, access" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "information and more" & _
		".")
		Me.radSoftware.UseVisualStyleBackColor = True
		'
		'txtDOB
		'
		Me.txtDOB.Location = New System.Drawing.Point(346, 170)
		Me.txtDOB.Name = "txtDOB"
		Me.txtDOB.Size = New System.Drawing.Size(121, 20)
		Me.txtDOB.TabIndex = 28
		'
		'txtAcctNumber
		'
		Me.txtAcctNumber.Location = New System.Drawing.Point(107, 42)
		Me.txtAcctNumber.Name = "txtAcctNumber"
		Me.txtAcctNumber.Size = New System.Drawing.Size(121, 20)
		Me.txtAcctNumber.TabIndex = 3
		'
		'txtUserName
		'
		Me.txtUserName.Location = New System.Drawing.Point(346, 94)
		Me.txtUserName.Name = "txtUserName"
		Me.txtUserName.Size = New System.Drawing.Size(121, 20)
		Me.txtUserName.TabIndex = 22
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(346, 120)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(121, 20)
		Me.txtPassword.TabIndex = 24
		'
		'txtCode
		'
		Me.txtCode.Location = New System.Drawing.Point(107, 94)
		Me.txtCode.Name = "txtCode"
		Me.txtCode.Size = New System.Drawing.Size(121, 20)
		Me.txtCode.TabIndex = 7
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(346, 144)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(121, 20)
		Me.txtEmail.TabIndex = 26
		'
		'lblAcctName
		'
		Me.lblAcctName.AutoSize = True
		Me.lblAcctName.Location = New System.Drawing.Point(20, 19)
		Me.lblAcctName.Name = "lblAcctName"
		Me.lblAcctName.Size = New System.Drawing.Size(78, 13)
		Me.lblAcctName.TabIndex = 0
		Me.lblAcctName.Text = "Account Name"
		'
		'lblAcctPhone
		'
		Me.lblAcctPhone.AutoSize = True
		Me.lblAcctPhone.Location = New System.Drawing.Point(17, 123)
		Me.lblAcctPhone.Name = "lblAcctPhone"
		Me.lblAcctPhone.Size = New System.Drawing.Size(81, 13)
		Me.lblAcctPhone.TabIndex = 8
		Me.lblAcctPhone.Text = "Account Phone"
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Location = New System.Drawing.Point(284, 123)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(53, 13)
		Me.lblPassword.TabIndex = 23
		Me.lblPassword.Text = "Password"
		'
		'lblUsername
		'
		Me.lblUsername.AutoSize = True
		Me.lblUsername.Location = New System.Drawing.Point(282, 97)
		Me.lblUsername.Name = "lblUsername"
		Me.lblUsername.Size = New System.Drawing.Size(55, 13)
		Me.lblUsername.TabIndex = 21
		Me.lblUsername.Text = "Username"
		'
		'lblAcctNumber
		'
		Me.lblAcctNumber.AutoSize = True
		Me.lblAcctNumber.Location = New System.Drawing.Point(11, 45)
		Me.lblAcctNumber.Name = "lblAcctNumber"
		Me.lblAcctNumber.Size = New System.Drawing.Size(87, 13)
		Me.lblAcctNumber.TabIndex = 2
		Me.lblAcctNumber.Text = "Account Number"
		'
		'rtbNotes
		'
		Me.rtbNotes.Location = New System.Drawing.Point(242, 42)
		Me.rtbNotes.Name = "rtbNotes"
		Me.rtbNotes.Size = New System.Drawing.Size(225, 42)
		Me.rtbNotes.TabIndex = 20
		Me.rtbNotes.Text = "Notes"
		'
		'cboAcctName
		'
		Me.cboAcctName.FormattingEnabled = True
		Me.cboAcctName.Location = New System.Drawing.Point(107, 16)
		Me.cboAcctName.Name = "cboAcctName"
		Me.cboAcctName.Size = New System.Drawing.Size(121, 21)
		Me.cboAcctName.TabIndex = 1
		'
		'grpAccountDetails
		'
		Me.grpAccountDetails.Controls.Add(Me.txtSecretAnswer)
		Me.grpAccountDetails.Controls.Add(Me.lblSecretAnswer)
		Me.grpAccountDetails.Controls.Add(Me.txtSecretQuestion)
		Me.grpAccountDetails.Controls.Add(Me.lblSecretQuestion)
		Me.grpAccountDetails.Controls.Add(Me.txtRouting)
		Me.grpAccountDetails.Controls.Add(Me.lblRouting)
		Me.grpAccountDetails.Controls.Add(Me.lblAcctZip)
		Me.grpAccountDetails.Controls.Add(Me.lblAcctState)
		Me.grpAccountDetails.Controls.Add(Me.lblAcctCity)
		Me.grpAccountDetails.Controls.Add(Me.txtAcctZip)
		Me.grpAccountDetails.Controls.Add(Me.txtAcctState)
		Me.grpAccountDetails.Controls.Add(Me.lblAcctAddress)
		Me.grpAccountDetails.Controls.Add(Me.txtAcctCity)
		Me.grpAccountDetails.Controls.Add(Me.txtAcctAddress)
		Me.grpAccountDetails.Controls.Add(Me.txtAcctPhone)
		Me.grpAccountDetails.Controls.Add(Me.Label1)
		Me.grpAccountDetails.Controls.Add(Me.txtURL)
		Me.grpAccountDetails.Controls.Add(Me.lblURL)
		Me.grpAccountDetails.Controls.Add(Me.lblRegisteredEmail)
		Me.grpAccountDetails.Controls.Add(Me.lblCode)
		Me.grpAccountDetails.Controls.Add(Me.lblAcctName)
		Me.grpAccountDetails.Controls.Add(Me.rtbNotes)
		Me.grpAccountDetails.Controls.Add(Me.cboAcctName)
		Me.grpAccountDetails.Controls.Add(Me.txtDOB)
		Me.grpAccountDetails.Controls.Add(Me.txtAcctNumber)
		Me.grpAccountDetails.Controls.Add(Me.lblAcctNumber)
		Me.grpAccountDetails.Controls.Add(Me.txtUserName)
		Me.grpAccountDetails.Controls.Add(Me.lblUsername)
		Me.grpAccountDetails.Controls.Add(Me.txtPassword)
		Me.grpAccountDetails.Controls.Add(Me.lblPassword)
		Me.grpAccountDetails.Controls.Add(Me.txtCode)
		Me.grpAccountDetails.Controls.Add(Me.lblAcctPhone)
		Me.grpAccountDetails.Controls.Add(Me.txtEmail)
		Me.grpAccountDetails.Location = New System.Drawing.Point(143, 12)
		Me.grpAccountDetails.Name = "grpAccountDetails"
		Me.grpAccountDetails.Size = New System.Drawing.Size(478, 254)
		Me.grpAccountDetails.TabIndex = 1
		Me.grpAccountDetails.TabStop = False
		Me.grpAccountDetails.Text = "Account Details"
		'
		'txtSecretAnswer
		'
		Me.txtSecretAnswer.Location = New System.Drawing.Point(346, 222)
		Me.txtSecretAnswer.Name = "txtSecretAnswer"
		Me.txtSecretAnswer.Size = New System.Drawing.Size(121, 20)
		Me.txtSecretAnswer.TabIndex = 32
		'
		'lblSecretAnswer
		'
		Me.lblSecretAnswer.AutoSize = True
		Me.lblSecretAnswer.Location = New System.Drawing.Point(261, 225)
		Me.lblSecretAnswer.Name = "lblSecretAnswer"
		Me.lblSecretAnswer.Size = New System.Drawing.Size(76, 13)
		Me.lblSecretAnswer.TabIndex = 31
		Me.lblSecretAnswer.Text = "Secret Answer"
		'
		'txtSecretQuestion
		'
		Me.txtSecretQuestion.Location = New System.Drawing.Point(346, 196)
		Me.txtSecretQuestion.Name = "txtSecretQuestion"
		Me.txtSecretQuestion.Size = New System.Drawing.Size(121, 20)
		Me.txtSecretQuestion.TabIndex = 30
		'
		'lblSecretQuestion
		'
		Me.lblSecretQuestion.AutoSize = True
		Me.lblSecretQuestion.Location = New System.Drawing.Point(254, 199)
		Me.lblSecretQuestion.Name = "lblSecretQuestion"
		Me.lblSecretQuestion.Size = New System.Drawing.Size(83, 13)
		Me.lblSecretQuestion.TabIndex = 29
		Me.lblSecretQuestion.Text = "Secret Question"
		'
		'txtRouting
		'
		Me.txtRouting.Location = New System.Drawing.Point(107, 68)
		Me.txtRouting.Name = "txtRouting"
		Me.txtRouting.Size = New System.Drawing.Size(121, 20)
		Me.txtRouting.TabIndex = 5
		'
		'lblRouting
		'
		Me.lblRouting.AutoSize = True
		Me.lblRouting.Location = New System.Drawing.Point(14, 71)
		Me.lblRouting.Name = "lblRouting"
		Me.lblRouting.Size = New System.Drawing.Size(84, 13)
		Me.lblRouting.TabIndex = 4
		Me.lblRouting.Text = "Routing Number"
		'
		'lblAcctZip
		'
		Me.lblAcctZip.AutoSize = True
		Me.lblAcctZip.Location = New System.Drawing.Point(5, 226)
		Me.lblAcctZip.Name = "lblAcctZip"
		Me.lblAcctZip.Size = New System.Drawing.Size(93, 13)
		Me.lblAcctZip.TabIndex = 16
		Me.lblAcctZip.Text = "Account Zip Code"
		'
		'lblAcctState
		'
		Me.lblAcctState.AutoSize = True
		Me.lblAcctState.Location = New System.Drawing.Point(23, 199)
		Me.lblAcctState.Name = "lblAcctState"
		Me.lblAcctState.Size = New System.Drawing.Size(75, 13)
		Me.lblAcctState.TabIndex = 14
		Me.lblAcctState.Text = "Account State"
		'
		'lblAcctCity
		'
		Me.lblAcctCity.AutoSize = True
		Me.lblAcctCity.Location = New System.Drawing.Point(31, 175)
		Me.lblAcctCity.Name = "lblAcctCity"
		Me.lblAcctCity.Size = New System.Drawing.Size(67, 13)
		Me.lblAcctCity.TabIndex = 12
		Me.lblAcctCity.Text = "Account City"
		'
		'txtAcctZip
		'
		Me.txtAcctZip.Location = New System.Drawing.Point(107, 223)
		Me.txtAcctZip.Name = "txtAcctZip"
		Me.txtAcctZip.Size = New System.Drawing.Size(121, 20)
		Me.txtAcctZip.TabIndex = 17
		'
		'txtAcctState
		'
		Me.txtAcctState.Location = New System.Drawing.Point(107, 197)
		Me.txtAcctState.Name = "txtAcctState"
		Me.txtAcctState.Size = New System.Drawing.Size(121, 20)
		Me.txtAcctState.TabIndex = 15
		'
		'lblAcctAddress
		'
		Me.lblAcctAddress.AutoSize = True
		Me.lblAcctAddress.Location = New System.Drawing.Point(10, 149)
		Me.lblAcctAddress.Name = "lblAcctAddress"
		Me.lblAcctAddress.Size = New System.Drawing.Size(88, 13)
		Me.lblAcctAddress.TabIndex = 10
		Me.lblAcctAddress.Text = "Account Address"
		'
		'txtAcctCity
		'
		Me.txtAcctCity.Location = New System.Drawing.Point(107, 172)
		Me.txtAcctCity.Name = "txtAcctCity"
		Me.txtAcctCity.Size = New System.Drawing.Size(121, 20)
		Me.txtAcctCity.TabIndex = 13
		'
		'txtAcctAddress
		'
		Me.txtAcctAddress.Location = New System.Drawing.Point(107, 146)
		Me.txtAcctAddress.Name = "txtAcctAddress"
		Me.txtAcctAddress.Size = New System.Drawing.Size(121, 20)
		Me.txtAcctAddress.TabIndex = 11
		'
		'txtAcctPhone
		'
		Me.txtAcctPhone.Location = New System.Drawing.Point(107, 120)
		Me.txtAcctPhone.Name = "txtAcctPhone"
		Me.txtAcctPhone.Size = New System.Drawing.Size(121, 20)
		Me.txtAcctPhone.TabIndex = 9
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(253, 173)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(84, 13)
		Me.Label1.TabIndex = 27
		Me.Label1.Text = "Registered DOB"
		'
		'txtURL
		'
		Me.txtURL.Location = New System.Drawing.Point(274, 16)
		Me.txtURL.Name = "txtURL"
		Me.txtURL.Size = New System.Drawing.Size(193, 20)
		Me.txtURL.TabIndex = 19
		Me.txtURL.Text = "http://"
		'
		'lblURL
		'
		Me.lblURL.AutoSize = True
		Me.lblURL.Location = New System.Drawing.Point(239, 19)
		Me.lblURL.Name = "lblURL"
		Me.lblURL.Size = New System.Drawing.Size(29, 13)
		Me.lblURL.TabIndex = 18
		Me.lblURL.Text = "URL"
		'
		'lblRegisteredEmail
		'
		Me.lblRegisteredEmail.AutoSize = True
		Me.lblRegisteredEmail.Location = New System.Drawing.Point(251, 147)
		Me.lblRegisteredEmail.Name = "lblRegisteredEmail"
		Me.lblRegisteredEmail.Size = New System.Drawing.Size(86, 13)
		Me.lblRegisteredEmail.TabIndex = 25
		Me.lblRegisteredEmail.Text = "Registered Email"
		'
		'lblCode
		'
		Me.lblCode.AutoSize = True
		Me.lblCode.Location = New System.Drawing.Point(14, 97)
		Me.lblCode.Name = "lblCode"
		Me.lblCode.Size = New System.Drawing.Size(85, 13)
		Me.lblCode.TabIndex = 6
		Me.lblCode.Text = "PIN / CVV Code"
		'
		'btnCopy
		'
		Me.btnCopy.Location = New System.Drawing.Point(264, 282)
		Me.btnCopy.Name = "btnCopy"
		Me.btnCopy.Size = New System.Drawing.Size(115, 23)
		Me.btnCopy.TabIndex = 3
		Me.btnCopy.Text = "Create A &New Copy"
		Me.btnCopy.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(143, 282)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(115, 23)
		Me.btnSave.TabIndex = 2
		Me.btnSave.Text = "&Save && Close"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(506, 282)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(115, 23)
		Me.btnCancel.TabIndex = 5
		Me.btnCancel.Text = "&Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(385, 282)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(115, 23)
		Me.btnClear.TabIndex = 4
		Me.btnClear.Text = "Cl&ear Form"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'frmNewAccount
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(636, 321)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnCopy)
		Me.Controls.Add(Me.grpAccountDetails)
		Me.Controls.Add(Me.grpAccountType)
		Me.Name = "frmNewAccount"
		Me.Text = "Create New Account"
		Me.grpAccountType.ResumeLayout(False)
		Me.grpAccountType.PerformLayout()
		Me.grpAccountDetails.ResumeLayout(False)
		Me.grpAccountDetails.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents radBank As System.Windows.Forms.RadioButton
	Friend WithEvents radDigitalWallet As System.Windows.Forms.RadioButton
	Friend WithEvents radCard As System.Windows.Forms.RadioButton
	Friend WithEvents radGift As System.Windows.Forms.RadioButton
	Friend WithEvents radEmail As System.Windows.Forms.RadioButton
	Friend WithEvents radWebsite As System.Windows.Forms.RadioButton
	Friend WithEvents radSocialMedia As System.Windows.Forms.RadioButton
	Friend WithEvents radEducation As System.Windows.Forms.RadioButton
	Friend WithEvents grpAccountType As System.Windows.Forms.GroupBox
	Friend WithEvents tipExamples As System.Windows.Forms.ToolTip
	Friend WithEvents radOther As System.Windows.Forms.RadioButton
	Friend WithEvents radInsurance As System.Windows.Forms.RadioButton
	Friend WithEvents radLegal As System.Windows.Forms.RadioButton
	Friend WithEvents radSoftware As System.Windows.Forms.RadioButton
	Friend WithEvents txtDOB As System.Windows.Forms.TextBox
	Friend WithEvents txtAcctNumber As System.Windows.Forms.TextBox
	Friend WithEvents txtUserName As System.Windows.Forms.TextBox
	Friend WithEvents txtPassword As System.Windows.Forms.TextBox
	Friend WithEvents txtCode As System.Windows.Forms.TextBox
	Friend WithEvents txtEmail As System.Windows.Forms.TextBox
	Friend WithEvents lblAcctName As System.Windows.Forms.Label
	Friend WithEvents lblAcctPhone As System.Windows.Forms.Label
	Friend WithEvents lblPassword As System.Windows.Forms.Label
	Friend WithEvents lblUsername As System.Windows.Forms.Label
	Friend WithEvents lblAcctNumber As System.Windows.Forms.Label
	Friend WithEvents rtbNotes As System.Windows.Forms.RichTextBox
	Friend WithEvents cboAcctName As System.Windows.Forms.ComboBox
	Friend WithEvents grpAccountDetails As System.Windows.Forms.GroupBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtURL As System.Windows.Forms.TextBox
	Friend WithEvents lblURL As System.Windows.Forms.Label
	Friend WithEvents lblRegisteredEmail As System.Windows.Forms.Label
	Friend WithEvents lblCode As System.Windows.Forms.Label
	Friend WithEvents txtSecretAnswer As System.Windows.Forms.TextBox
	Friend WithEvents lblSecretAnswer As System.Windows.Forms.Label
	Friend WithEvents txtSecretQuestion As System.Windows.Forms.TextBox
	Friend WithEvents lblSecretQuestion As System.Windows.Forms.Label
	Friend WithEvents txtRouting As System.Windows.Forms.TextBox
	Friend WithEvents lblRouting As System.Windows.Forms.Label
	Friend WithEvents lblAcctZip As System.Windows.Forms.Label
	Friend WithEvents lblAcctState As System.Windows.Forms.Label
	Friend WithEvents lblAcctCity As System.Windows.Forms.Label
	Friend WithEvents txtAcctZip As System.Windows.Forms.TextBox
	Friend WithEvents txtAcctState As System.Windows.Forms.TextBox
	Friend WithEvents lblAcctAddress As System.Windows.Forms.Label
	Friend WithEvents txtAcctCity As System.Windows.Forms.TextBox
	Friend WithEvents txtAcctAddress As System.Windows.Forms.TextBox
	Friend WithEvents txtAcctPhone As System.Windows.Forms.TextBox
	Friend WithEvents btnCopy As System.Windows.Forms.Button
	Friend WithEvents btnSave As System.Windows.Forms.Button
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
