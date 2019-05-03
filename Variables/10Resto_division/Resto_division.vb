Imports System

Module Resto_division
    Sub Main(args As String())
        Dim numero As Integer
        Console.WriteLine("Ingrese un valor:")
        numero = Console.ReadLine()
        Console.WriteLine("El resto del numero ingresado dividido 2 es: " & (numero Mod 2))
    End Sub
End Module
