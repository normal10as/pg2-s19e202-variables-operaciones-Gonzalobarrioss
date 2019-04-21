Imports System

Module sumatoria
    Sub Main(args As String())
        Dim a, b, c, d, e As Integer
        Console.WriteLine("ingrese numero: ")
        a = Console.ReadLine()
        Console.WriteLine("ingrese numero: ")
        b = Console.ReadLine()
        Console.WriteLine("ingrese numero: ")
        c = Console.ReadLine()
        Console.WriteLine("ingrese numero: ")
        d = Console.ReadLine()
        Console.WriteLine("sumatoria de numeros: " & a & "+" & b & "+" & c & "+" & d & "=" & a + b + c + d)
        e = a + b + c + d
        Console.WriteLine("la media de numeros: " & e / 2)
    End Sub
End Module
