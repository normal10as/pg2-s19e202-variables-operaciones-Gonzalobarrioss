Imports System

Module variables
    Sub Main(args As String())
        Dim nombre As String
        Dim apellido As String
        Dim fecha As Date
        Console.WriteLine("Ingrese su nombre")
        nombre = Console.ReadLine()
        Console.WriteLine("Ingrese su apellido")
        apellido = Console.ReadLine()
        Console.WriteLine("Ingrese fecha de nacimiento")
        fecha = Console.ReadLine()
        Console.WriteLine(nombre & " " & apellido & " " & "nacio en el dia" & " " & fecha)
        Console.WriteLine("pausa")
    End Sub
End Module
