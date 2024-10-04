Public Enum GenderType
    Man
    Woman
End Enum

Public MustInherit Class Person

    Private _name As String
    Private _surname As String


    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                _name = value
            End If
        End Set
    End Property

    Public Property Surname As String
        Get
            Return _surname
        End Get
        Set(ByVal value As String)
            _surname = value
        End Set
    End Property


    Public ReadOnly Property FullName As String
        Get
            Return Name & " " & Surname
        End Get
    End Property

    Public Property Gender As GenderType

    ' ToString() metode
    Public Overrides Function ToString() As String
        Return "Name: " & Name & ", Surname: " & Surname & ", Gender: " & Gender.ToString() & ", FullName: " & FullName
    End Function
End Class
