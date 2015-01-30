Public Class Register

#Region "Proporties"

    Private _Firstname As String
    Public Property Firstname() As String
        Get
            Return _Firstname
        End Get
        Set(ByVal value As String)
            _Firstname = value
        End Set
    End Property


    Private _Lastname As String
    Public Property Lastname() As String
        Get
            Return _Lastname
        End Get
        Set(ByVal value As String)
            _Lastname = value
        End Set
    End Property


    Private _Email As String
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property


    Private _Phonenumber As Integer
    Public Property Phonenumber() As Integer
        Get
            Return _Phonenumber
        End Get
        Set(ByVal value As Integer)
            _Phonenumber = value
        End Set
    End Property


    Private _Username As String
    Public Property Username() As String
        Get
            Return _Username
        End Get
        Set(ByVal value As String)
            _Username = value
        End Set
    End Property


    Private _Password As String
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

#End Region

End Class
