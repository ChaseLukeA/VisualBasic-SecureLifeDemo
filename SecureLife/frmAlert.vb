Public Class frmAlert

	Public answer As Boolean

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

	Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
		Me.answer = True
		Me.Close()
	End Sub
End Class