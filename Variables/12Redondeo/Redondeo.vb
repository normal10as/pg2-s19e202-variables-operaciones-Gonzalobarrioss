Imports System

Imports System.Math
Module Redondeo
    Sub Main(args As String())
        Dim numero As Single
        Console.WriteLine("Ingrese un numero: ")
        numero = Console.ReadLine()
        Console.WriteLine(numero)
        Console.WriteLine("Valor aproximado por exceso: " & Math.Ceiling(numero))
        Console.WriteLine("Valor aproximado por defecto: " & Math.Floor(numero))
        Console.WriteLine("Valor redondeado: " & Math.Round(numero))
    End Sub
End Module
