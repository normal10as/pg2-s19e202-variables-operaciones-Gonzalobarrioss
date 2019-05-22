Imports System
Imports System.Math
Module Mayor
    Sub Main(args As String())
        Dim num1, num2, num3, mayor As Integer
        Console.WriteLine("Ingrese el primer numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese el tercer numero: ")
        num3 = Console.ReadLine()
        mayor = Max(num1, num2)
        mayor = Max(num3, mayor)
        Console.WriteLine("El numero mayor es: " & mayor)
    End Sub
End Module
