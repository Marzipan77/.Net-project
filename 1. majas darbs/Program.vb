Imports System.IO

Module Program
    Sub Main(args As String())

        'ceïð uz C:\Temp\ mapi:
        Dim path As String = ("C:\Temp\data.txt")

        ' Pârbauda vai C:\Temp mape eksistç, 
        If Not Directory.Exists("C:\Temp") Then
            Directory.CreateDirectory("C:\Temp")
        End If

        ' Izveido jaunu DataManager instanci
        Dim dm As New DataManager()

        ' 1. Izveido testa datus
        dm.CreateTestData()
        Console.WriteLine("Dati pçc izveides:")
        Console.WriteLine(dm.Print())

        ' 2. Saglabâ datus failâ
        dm.Save(path)
        Console.WriteLine("Dati saglabâti failâ: " & path)

        ' 3. Atiestata datus (iztukðo)
        dm.Reset()
        Console.WriteLine("Dati pçc atiestatîðanas:")
        Console.WriteLine(dm.Print())

        ' 4. Ielâdç datus no faila
        dm.Load(path)
        Console.WriteLine("Dati pçc ielâdes no faila:")
        Console.WriteLine(dm.Print())


        Console.ReadLine()
    End Sub
End Module

