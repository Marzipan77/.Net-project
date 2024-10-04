Public Class Submission
    ' "Assignment"
    Public Property Assignment As Assignment

    ' "Student"
    Public Property Student As Student

    ' "SubmissionTime"
    Public Property SubmissionTime As Date

    ' "Score"
    Public Property Score As Integer

    ' ToString() metode
    Public Overrides Function ToString() As String
        Return "Submission by: " & Student.FullName & ", Assignment: " & Assignment.Description & ", Submitted at: " & SubmissionTime.ToString() & ", Score: " & Score.ToString()
    End Function
End Class

