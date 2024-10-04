Public Class Student
    Inherits Person

    ' "StudentIdNumber"
    Public Property StudentIdNumber As String

    ' ToString() metode
    Public Overrides Function ToString() As String
        Return MyBase.ToString() & ", StudentIdNumber: " & StudentIdNumber
    End Function
End Class
