Public Class Teacher
    Inherits Person

    ' "ContractDate"
    Public Property ContractDate As Date

    ' ToString() metode
    Public Overrides Function ToString() As String
        Return MyBase.ToString() & ", ContractDate: " & ContractDate.ToShortDateString()
    End Function
End Class
