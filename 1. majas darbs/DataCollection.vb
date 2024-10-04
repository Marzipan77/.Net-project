Public Class DataCollection
    ' Kolekcijas dažādu tipu datiem
    Public Property Courses As List(Of Course)
    Public Property Assignments As List(Of Assignment)
    Public Property Students As List(Of Student)
    Public Property Submissions As List(Of Submission)

    ' Konstruktors, lai inicializētu tukšās kolekcijas
    Public Sub New()
        Courses = New List(Of Course)()
        Assignments = New List(Of Assignment)()
        Students = New List(Of Student)()
        Submissions = New List(Of Submission)()
    End Sub
End Class
