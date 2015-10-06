Public Class frmMain

	Private Sub bntNewProfile_Click(sender As Object, e As EventArgs) Handles bntNewProfile.Click
		frmNewProfile.ShowDialog()
	End Sub

    Private Sub btnExistingProfile_Click(sender As Object, e As EventArgs) Handles btnExistingProfile.Click
		frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("SecureLife " & ControlChars.CrLf &
                        "Version 1.0" & ControlChars.CrLf &
                        "Copyright 2015" & ControlChars.CrLf &
                        "Luke A Chase - IT Mobile & IT Software Developer" & ControlChars.CrLf &
                        "lchase1@student.cvtc.edu")
    End Sub

End Class
