Imports System

Module ecuacion
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Console.WriteLine("ingrese valor de A")
        a = Console.ReadLine()
        Console.WriteLine("ingrese valor de B")
        b = Console.ReadLine()
        Console.WriteLine("ingrese valor de C")
        c = Console.ReadLine()
        Console.WriteLine("el resultado es: " & (b ^ 2 - 4 * a * c) / 2 * a)
    End Sub
End Module
