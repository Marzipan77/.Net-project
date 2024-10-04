Public Interface IDataManager

    Function Print() As String

    ' datu saglabāšana failā
    Sub Save(ByVal path As String)

    ' datu ielādee no faila
    Sub Load(ByVal path As String)

    ' testa datu izveidošanai
    Sub CreateTestData()

    ' datu atiestatīšanai
    Sub Reset()
End Interface
