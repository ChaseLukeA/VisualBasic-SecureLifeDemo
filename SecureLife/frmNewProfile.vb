Public Class frmNewProfile

	'KEEP - possibly use instead of Profile.vb class
	'
	'Dim mUserName As String
	'Dim mPassword As String
	'Dim mEmail As String
	'Dim mAutoLogin As Boolean

	Dim userNameValid As Boolean
	Dim passwordValid As Boolean
	Dim emailValid As Boolean

	Private Sub btnCreateProfile_Click(sender As Object, e As EventArgs) Handles btnCreateProfile.Click
		If userNameValid And passwordValid And emailValid Then
			SecureLife.newProfile.username = txtUserName.Text
			SecureLife.newProfile.password = txtPassword.Text
			SecureLife.newProfile.email = txtEmail.Text
			SecureLife.newProfile.autoLogin = False
			Me.Close()

			' KEEP - for possibile re-use once creation and accessing of databases is learned
			'
			' Creating a vault ".vlt" file type with the userName
			' Just temporary file creation, will be using a database
			' As we learn how to create/update/access databases in VB
			'
			'Dim filename As String = txtUserName.Text + ".vlt"
			'My.Computer.FileSystem.WriteAllText(filename, txtPassword.Text, True)

			' Adding properties to the newUser object
			'mUserName = txtUserName.Text
			'mPassword = txtPassword.Text
			'mEmail = txtEmail.Text
		Else
			MessageBox.Show("Please complete all fields to continue.")
		End If
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
		Dim charsEntered As Boolean = txtUserName.Text <> ""
		Dim validUserName As Boolean = ValidateUserName(txtUserName.Text)

		If charsEntered Then
			If validUserName Then
				lblUsernameError.Visible = False
				userNameValid = True
			Else
				lblUsernameError.Visible = True
				userNameValid = False
			End If
		Else
			lblUsernameError.Visible = False
		End If

	End Sub

	Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
		Dim charsEntered As Boolean = txtPassword.Text <> ""
		Dim validPassword As Boolean = ValidatePassword(txtPassword.Text)

		If charsEntered Then
			If validPassword Then
				lblPasswordError.Visible = False
				passwordValid = True
				txtRetype.Enabled = True
			Else
				lblPasswordError.Visible = True
				txtRetype.Enabled = False
			End If
		Else
			lblPasswordError.Visible = False
			txtRetype.Enabled = False
		End If
	End Sub

	Private Sub txtRetype_TextChanged(sender As Object, e As EventArgs) Handles txtRetype.TextChanged
		Dim validPassword As Boolean = ValidatePassword(txtPassword.Text)

		' Checking retyped password to original
		If txtRetype.Text = txtPassword.Text Then
			If validPassword Then
				lblRetypeError.Visible = False
				passwordValid = True
			End If
		Else
			lblRetypeError.Visible = True
			passwordValid = False
		End If
	End Sub

	Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
		Dim charsEntered As Boolean = txtEmail.Text <> ""
		Dim validEmail As Boolean = ValidateEmail(txtEmail.Text)

		If charsEntered Then
			If validEmail Then
				lblEmailError.Visible = False
				emailValid = True
			Else
				lblEmailError.Visible = True
				emailValid = False
			End If
		Else
			lblEmailError.Visible = False
		End If

	End Sub

	' MY CODE LOOSELY BASED ON THE VALIDATING FILE NAMES AND PATHS FUNCTION EXAMPLE
	' AT MSDN: https://msdn.microsoft.com/en-us/library/vstudio/ms172834%28v=vs.100%29.aspx

	Function ValidateUserName(userName As String) As Boolean
		Dim validCharacters As New System.Text.RegularExpressions.Regex("^[a-zA-z0-9_.]*$")
		Dim userNameValid As System.Text.RegularExpressions.Match = validCharacters.Match(userName)

		If userName.Length >= 6 And userNameValid.Success Then
			Return True
		Else
			Return False
		End If

	End Function

    ' MY CODE LOOSELY BASED ON THE COMPLEX PASSWORD VALIDATION FUNCTION EXAMPLE
    ' AT MSDN: https://msdn.microsoft.com/en-us/library/b05h65z0.aspx

    Function ValidatePassword(password As String) As Boolean

        Dim uppercase As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lowercase As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim numbers As New System.Text.RegularExpressions.Regex("[0-9]")

        If password.Length < 8 Or
            uppercase.Matches(password).Count < 1 Or
            lowercase.Matches(password).Count < 1 Or
            numbers.Matches(password).Count < 1 Then
            Return False
        Else
            Return True
        End If

    End Function

    ' MY CODE BASED ON EMAIL ADDRESS STRING VALIDATION FUNCTION EXAMPLE
    ' AT MSDN: https://msdn.microsoft.com/en-us/library/vstudio/txk0hsah%28v=vs.100%29.aspx

    Function ValidateEmail(email As String) As Boolean

        Dim emailCheck As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailValid As System.Text.RegularExpressions.Match = emailCheck.Match(email)

        Return emailValid.Success

    End Function

	'KEEP - possibly use instead of Profile.vb class
	'
	'Public Property userName() As String
	'	Get
	'		Return mUserName
	'	End Get
	'	Set(value As String)
	'		mUserName = value
	'	End Set
	'End Property

	'Public Property password() As String
	'	Get
	'		Return mPassword
	'	End Get
	'	Set(value As String)
	'		mPassword = value
	'	End Set
	'End Property

	'Public Property email() As String
	'	Get
	'		Return mEmail
	'	End Get
	'	Set(value As String)
	'		mEmail = value
	'	End Set
	'End Property

	'Public Property autoLogin() As Boolean
	'	Get
	'		Return mAutoLogin
	'	End Get
	'	Set(value As Boolean)
	'		mAutoLogin = value
	'	End Set
	'End Property

End Class