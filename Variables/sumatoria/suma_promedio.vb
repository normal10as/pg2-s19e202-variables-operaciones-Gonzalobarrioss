Imports System

Module suma_promedio
    Sub Main(args As String())
        Dim a, b, c, d, sumatoria As Integer
        Console.WriteLine("ingrese numero: ")
        a = Console.ReadLine()
        Console.WriteLine("ingrese numero: ")
        b = Console.ReadLine()
        Console.WriteLine("ingrese numero: ")
        c = Console.ReadLine()
        Console.WriteLine("ingrese numero: ")
        d = Console.ReadLine()
        Console.WriteLine("sumatoria de numeros: " & a & "+" & b & "+" & c & "+" & d & "=" & a + b + c + d)
        sumatoria = a + b + c + d
        Console.WriteLine("la media de numeros: " & sumatoria / 4)
    End Sub
End Module
