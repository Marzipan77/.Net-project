Public Class Assignment
    '"Deadline"
    Public Property Deadline As Date

    '"Course"
    Public Property Course As Course

    '"Description"
    Public Property Description As String

    ' ToString() metode
    Public Overrides Function ToString() As String
        Return "Assignment: " & Description & ", Deadline: " & Deadline.ToShortDateString() & ", Course: " & Course.ToString()
    End Function
End Class
