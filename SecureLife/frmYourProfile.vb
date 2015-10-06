Public Class frmYourProfile

	Public newAccount As New frmNewAccount

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
		Dim areYouSure As New frmAlert
		areYouSure.Text = "Are you sure?"
		areYouSure.lblAlertMessage.Text = "Are you sure you want to log out of your SecureLife account?"
		areYouSure.btnOK.Text = "Log &Out"
		areYouSure.btnCancel.Text = "&Cancel"
		areYouSure.ShowDialog()

		If areYouSure.answer = True Then
			frmMain.Show()
			Me.Close()
		End If
	End Sub

	Private Sub mnu_Click(sender As Object, e As EventArgs) Handles mnuCreateAccount.Click, btnCreateAccount.Click
		newAccount.ShowDialog()
	End Sub

	Private Sub btnFindNow_Click(sender As Object, e As EventArgs) Handles btnFindNow.Click
		' SQL search query will run from here
	End Sub

	Private Sub btnShowAccounts_Click(sender As Object, e As EventArgs) Handles btnShowAccounts.Click
		lstResults.Items.Clear()
		lstResults.Items.Add("Record Number: " & newAccount.record)
		lstResults.Items.Add("Account Type: " & newAccount.acctType)
		lstResults.Items.Add("Account Name: " & newAccount.acctName)
		lstResults.Items.Add("Account Number: " & newAccount.acctNumber)
		lstResults.Items.Add("Routing Number: " & newAccount.routing)
		lstResults.Items.Add("PIN / CVV / Code: " & newAccount.code)
		lstResults.Items.Add("Account Phone Number: " & newAccount.acctPhone)
		lstResults.Items.Add("Account Address: " & newAccount.acctAddress)
		lstResults.Items.Add("Account City: " & newAccount.acctCity)
		lstResults.Items.Add("Account State: " & newAccount.acctState)
		lstResults.Items.Add("Account Zip: " & newAccount.acctZip)
		lstResults.Items.Add("Website URL: " & newAccount.url)
		lstResults.Items.Add("Notes: " & newAccount.notes)
		lstResults.Items.Add("UserName: " & newAccount.userName)
		lstResults.Items.Add("Password: " & newAccount.password)
		lstResults.Items.Add("Email Address: " & newAccount.email)
		lstResults.Items.Add("Date of Birth: " & newAccount.dob)
		lstResults.Items.Add("Secret Question: " & newAccount.secretQuestion)
		lstResults.Items.Add("Secret Answer: " & newAccount.secretAnswer)
	End Sub

	Private Sub mnuAutoLogin_Click(sender As Object, e As EventArgs) Handles mnuAutoLogin.Click, MyBase.Load
		If SecureLife.newProfile.autoLogin = True Then
			mnuAutoLogin.CheckState = CheckState.Checked
			SecureLife.newProfile.autoLogin = True
		Else
			mnuAutoLogin.CheckState = CheckState.Unchecked
			SecureLife.newProfile.autoLogin = False
		End If
	End Sub

End Class