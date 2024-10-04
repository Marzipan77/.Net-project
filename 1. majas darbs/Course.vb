Public Class Course
    ' "Name"
    Public Property Name As String

    ' Teacher tips
    Public Property Teacher As Teacher

    ' ToString() metode
    Public Overrides Function ToString() As String
        Return "Course: " & Name & ", Teacher: " & Teacher.ToString()
    End Function
End Class
