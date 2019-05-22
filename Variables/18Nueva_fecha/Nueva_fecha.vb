Imports System
Imports System.DateTime
Imports System.String

Module Nueva_fecha
    Sub Main(args As String())
        Dim fecha As Date
        Dim dias As Byte
        Console.WriteLine("Ingresar fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("La fecha ingresada es: " & fecha)
        Console.WriteLine("Ingrese dias a agregar a la fecha: ")
        dias = Console.ReadLine()
        fecha = fecha.AddDays(dias)
        Console.WriteLine("La nueva fecha es: " & fecha)
    End Sub
End Module
