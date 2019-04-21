Imports System

Module tablasdeverdad
    Sub Main(args As String())
        Dim verdadero As Boolean = True
        Dim falso As Boolean = False
        Console.WriteLine("TABLAS DE VERDAD BOLEANAS")
        Console.WriteLine("----------Tabla AND----------")
        Console.WriteLine("verdadero y verdadero: " & (verdadero And verdadero))
        Console.WriteLine("verdadero y falso:     " & (verdadero And falso))
        Console.WriteLine("falso y verdadero:     " & (falso And verdadero))
        Console.WriteLine("falso y falso:         " & (falso And falso))
        Console.WriteLine("----------Tabla NOT----------")
        Console.WriteLine("verdadero :            " & (Not verdadero))
        Console.WriteLine("falso     :            " & (Not falso))
        Console.WriteLine("----------Tabla  OR----------")
        Console.WriteLine("verdadero o verdadero: " & (verdadero Or verdadero))
        Console.WriteLine("verdadero o falso:     " & (verdadero Or falso))
        Console.WriteLine("falso o verdadero:     " & (falso Or verdadero))
        Console.WriteLine("falso o falso:         " & (falso Or falso))
        Console.WriteLine("----------Tabla Xor----------")
        Console.WriteLine("verdadero ô verdadero: " & (verdadero Xor verdadero))
        Console.WriteLine("verdadero ô falso:     " & (verdadero Xor falso))
        Console.WriteLine("falso ô verdadero:     " & (falso Xor verdadero))
        Console.WriteLine("falso ô falso:         " & (falso Xor falso))
    End Sub
End Module
