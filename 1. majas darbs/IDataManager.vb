Public Class DataManager
    Implements IDataManager

    Private Data As DataCollection

    ' Konstruktors
    Public Sub New()
        Data = New DataCollection()
    End Sub

    '  datu printēšana
    Public Function Print() As String Implements IDataManager.Print
        Dim output As String = ""

        For Each course In Data.Courses
            output &= course.ToString() & Environment.NewLine
        Next

        For Each assignment In Data.Assignments
            output &= assignment.ToString() & Environment.NewLine
        Next

        For Each submission In Data.Submissions
            output &= submission.ToString() & Environment.NewLine
        Next

        Return output
    End Function

    ' Datu saglabāšanai failā
    Public Sub Save(path As String) Implements IDataManager.Save
        ' kods datu saglabāšanai failā
        ' Piemēram, var izmantot System.IO.File.WriteAllText(path, Print())
    End Sub

    ' Metode datu ielādei no faila
    Public Sub Load(path As String) Implements IDataManager.Load
        ' kods datu ielādei no faila
        ' Piemēram, var izmantot System.IO.File.ReadAllText(path)
    End Sub

    '  Testa datu izveidošana
    Public Sub CreateTestData() Implements IDataManager.CreateTestData
        '  piemēri
        Dim teacher1 As New Teacher With {.Name = "John", .Surname = "Doe", .Gender = GenderType.Man, .ContractDate = DateTime.Now}
        Dim student1 As New Student With {.Name = "Alice", .Surname = "Smith", .Gender = GenderType.Woman, .StudentIdNumber = "S001"}

        Dim course1 As New Course With {.Name = "Math", .Teacher = teacher1}
        Dim assignment1 As New Assignment With {.Deadline = DateTime.Now.AddDays(7), .Course = course1, .Description = "Math homework"}

        Dim submission1 As New Submission With {.Assignment = assignment1, .Student = student1, .SubmissionTime = DateTime.Now, .Score = 90}

        Data.Courses.Add(course1)
        Data.Assignments.Add(assignment1)
        Data.Students.Add(student1)
        Data.Submissions.Add(submission1)
    End Sub

    ' datu atiestatīšanai
    Public Sub Reset() Implements IDataManager.Reset
        Data = New DataCollection()
    End Sub
End Class
