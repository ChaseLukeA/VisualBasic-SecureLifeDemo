Public Class frmNewAccount

	Dim mRecord As Integer
	Dim mAcctType As Integer
	Dim mAcctName As String
	Dim mAcctNumber As String
	Dim mRouting As String
	Dim mCode As String
	Dim mAcctPhone As String
	Dim mAcctAddress As String
	Dim mAcctCity As String
	Dim mAcctState As String
	Dim mAcctZip As String
	Dim mURL As String
	Dim mNotes As String
	Dim mUserName As String
	Dim mPassword As String
	Dim mEmail As String
	Dim mDOB As String
	Dim mSecretQuestion As String
	Dim mSecretAnswer As String

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		If radBank.Checked Then
			acctType = 1
		ElseIf radDigitalWallet.Checked Then
			acctType = 2
		ElseIf radCard.Checked Then
			acctType = 3
		ElseIf radGift.Checked Then
			acctType = 4
		ElseIf radEmail.Checked Then
			acctType = 5
		ElseIf radSocialMedia.Checked Then
			acctType = 6
		ElseIf radEducation.Checked Then
			acctType = 7
		ElseIf radWebsite.Checked Then
			acctType = 8
		ElseIf radSoftware.Checked Then
			acctType = 9
		ElseIf radLegal.Checked Then
			acctType = 10
		ElseIf radInsurance.Checked Then
			acctType = 11
		ElseIf radOther.Checked Then
			acctType = 12
		End If

		acctName = cboAcctName.Text
		acctNumber = txtAcctNumber.Text
		routing = txtRouting.Text
		code = txtCode.Text
		acctPhone = txtAcctPhone.Text
		acctAddress = txtAcctAddress.Text
		acctCity = txtAcctCity.Text
		acctState = txtAcctState.Text
		acctZip = txtAcctZip.Text
		url = txtURL.Text
		notes = rtbNotes.Text
		userName = txtUserName.Text
		password = txtPassword.Text
		email = txtEmail.Text
		dob = txtDOB.Text
		secretQuestion = txtSecretQuestion.Text
		secretAnswer = txtSecretAnswer.Text

		frmYourProfile.Show()
		Me.Close()

	End Sub

	Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
		record += 1
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		Dim areYouSure As New frmAlert
		areYouSure.Text = "Are you sure?"
		areYouSure.lblAlertMessage.Text = "Are you sure you want to clear the current form?"
		areYouSure.btnOK.Text = "Cl&ear Form"
		areYouSure.btnCancel.Text = "&Cancel"
		areYouSure.ShowDialog()

		If areYouSure.answer = True Then
			For Each input As Control In grpAccountDetails.Controls
				If TypeOf input Is TextBox Then
					input.Text = ""
				End If
			Next
			cboAcctName.Text = ""
			rtbNotes.Text = ""
			radBank.Focus()
		End If
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		frmYourProfile.Show()
		Me.Close()
	End Sub

	Public Property record() As Integer
		Get
			Return mRecord
		End Get
		Set(value As Integer)
			mRecord = record
		End Set
	End Property

	Public Property acctType() As Integer
		Get
			Return mAcctType
		End Get
		Set(ByVal value As Integer)
			mAcctType = value
		End Set
	End Property

	Public Property acctName() As String
		Get
			Return mAcctName
		End Get
		Set(ByVal value As String)
			mAcctName = value
		End Set
	End Property

	Public Property acctNumber() As String
		Get
			Return mAcctNumber
		End Get
		Set(ByVal value As String)
			mAcctNumber = value
		End Set
	End Property

	Public Property routing() As String
		Get
			Return mRouting
		End Get
		Set(ByVal value As String)
			mRouting = value
		End Set
	End Property

	Public Property code() As String
		Get
			Return mCode
		End Get
		Set(ByVal value As String)
			mCode = value
		End Set
	End Property

	Public Property acctPhone() As String
		Get
			Return mAcctPhone
		End Get
		Set(ByVal value As String)
			mAcctPhone = value
		End Set
	End Property

	Public Property acctAddress() As String
		Get
			Return mAcctAddress
		End Get
		Set(ByVal value As String)
			mAcctAddress = value
		End Set
	End Property

	Public Property acctCity() As String
		Get
			Return mAcctCity
		End Get
		Set(ByVal value As String)
			mAcctCity = value
		End Set
	End Property

	Public Property acctState() As String
		Get
			Return mAcctState
		End Get
		Set(ByVal value As String)
			mAcctState = value
		End Set
	End Property

	Public Property acctZip() As String
		Get
			Return mAcctZip
		End Get
		Set(ByVal value As String)
			mAcctZip = value
		End Set
	End Property

	Public Property url() As String
		Get
			Return mURL
		End Get
		Set(ByVal value As String)
			mURL = value
		End Set
	End Property

	Public Property notes() As String
		Get
			Return mNotes
		End Get
		Set(ByVal value As String)
			mNotes = value
		End Set
	End Property

	Public Property userName() As String
		Get
			Return mUserName
		End Get
		Set(ByVal value As String)
			mUserName = value
		End Set
	End Property

	Public Property password() As String
		Get
			Return mPassword
		End Get
		Set(ByVal value As String)
			mPassword = value
		End Set
	End Property

	Public Property email() As String
		Get
			Return mEmail
		End Get
		Set(ByVal value As String)
			mEmail = value
		End Set
	End Property

	Public Property dob() As String
		Get
			Return mDOB
		End Get
		Set(ByVal value As String)
			mDOB = value
		End Set
	End Property

	Public Property secretQuestion() As String
		Get
			Return mSecretQuestion
		End Get
		Set(ByVal value As String)
			mSecretQuestion = value
		End Set
	End Property

	Public Property secretAnswer() As String
		Get
			Return mSecretAnswer
		End Get
		Set(ByVal value As String)
			mSecretAnswer = value
		End Set
	End Property

	Private Sub lblAcctAddress_GotFocus(sender As Object, e As EventArgs) Handles lblAcctAddress.GotFocus
		rtbNotes.SelectAll()
	End Sub

End Class