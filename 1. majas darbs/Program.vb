Imports System.IO

Module Program
    Sub Main(args As String())

        'ce�� uz C:\Temp\ mapi:
        Dim path As String = ("C:\Temp\data.txt")

        ' P�rbauda vai C:\Temp mape eksist�, 
        If Not Directory.Exists("C:\Temp") Then
            Directory.CreateDirectory("C:\Temp")
        End If

        ' Izveido jaunu DataManager instanci
        Dim dm As New DataManager()

        ' 1. Izveido testa datus
        dm.CreateTestData()
        Console.WriteLine("Dati p�c izveides:")
        Console.WriteLine(dm.Print())

        ' 2. Saglab� datus fail�
        dm.Save(path)
        Console.WriteLine("Dati saglab�ti fail�: " & path)

        ' 3. Atiestata datus (iztuk�o)
        dm.Reset()
        Console.WriteLine("Dati p�c atiestat��anas:")
        Console.WriteLine(dm.Print())

        ' 4. Iel�d� datus no faila
        dm.Load(path)
        Console.WriteLine("Dati p�c iel�des no faila:")
        Console.WriteLine(dm.Print())


        Console.ReadLine()
    End Sub
End Module

