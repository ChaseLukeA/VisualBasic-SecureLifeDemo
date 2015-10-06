Public Class frmLogin
    Public userName As String
    Public password As String
    Public email As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		If txtUsername.Text = SecureLife.newProfile.username Then
			If txtPassword.Text = SecureLife.newProfile.password Then
				frmYourProfile.Show()
				Me.Close()
			Else
				MessageBox.Show("The password you provided is not correct." & ControlChars.CrLf &
								"Please try again.")
			End If
		Else
			MessageBox.Show("The username you provided does not exist." & ControlChars.CrLf &
							"Please try again.")
		End If

		' KEEP - code I originally used to write data to a file. Will likely re-use some
		' of this code when I learn database accessing in a future lesson
		'
		'      Dim filename As String = txtUsername.Text + ".vlt"
		'Try
		'	Dim password As String = My.Computer.FileSystem.ReadAllText(filename)
		'	If txtPassword.Text = password Then
		'		frmYourProfile.Show()
		'		Me.Close()
		'	Else
		'		MessageBox.Show("The password you provided is not correct." & ControlChars.CrLf &
		'						"Please try again.")
		'	End If
		'Catch ex As Exception
		'	MessageBox.Show("The username you provided does not exist." & ControlChars.CrLf &
		'					"Please try again.")
		'End Try
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		frmMain.Show()
		Me.Close()
	End Sub

	Private Sub chkRememberMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkRememberMe.CheckedChanged
		If chkRememberMe.Checked Then
			SecureLife.newProfile.autoLogin = True
		End If
	End Sub

	Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If SecureLife.newProfile.autoLogin = True Then
			frmYourProfile.Show()
			Me.Close()
		End If
	End Sub
End Class