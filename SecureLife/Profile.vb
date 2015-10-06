Public Class Profile

	Dim mUsername As String
	Dim mPassword As String
	Dim mEmail As String
	Dim mAutoLogin As Boolean

	Public Property username() As String
		Get
			Return mUsername
		End Get
		Set(ByVal value As String)
			mUsername = value
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

	Public Property autoLogin() As Boolean
		Get
			Return mAutoLogin
		End Get
		Set(value As Boolean)
			mAutoLogin = value
		End Set
	End Property

End Class
