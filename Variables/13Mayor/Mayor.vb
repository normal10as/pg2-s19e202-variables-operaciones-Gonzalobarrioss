Imports System
Imports System.Math
Module Mayor
    Sub Main(args As String())
        Dim num1, num2, num3, mayor As Integer
        Console.WriteLine("Ingrese el primer numnero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese el tercer numero: ")
        num3 = Console.ReadLine()
        mayor = Max(num1, num2)
        If num3 > mayor Then
            Console.WriteLine("el mayor es: " & num3)
        Else
            Console.WriteLine("el mayor es: " & mayor)
        End If
    End Sub
End Module
