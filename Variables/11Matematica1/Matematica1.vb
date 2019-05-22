Imports System
Imports System.Math
Module Matematica1

    Sub Main(args As String())
        Dim numero As Integer
        Console.WriteLine("Ingrese un numero:")
        numero = Console.ReadLine()
        Console.WriteLine("Su valor absoluto: " & Abs(numero))
        Console.WriteLine("Numero elevado a la decima potencia: " & Pow(numero, 10))
        Console.WriteLine("Raiz cuadrada de numero: " & Sqrt(numero))
    End Sub
End Module
