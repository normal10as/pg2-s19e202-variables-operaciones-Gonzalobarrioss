Imports System

Module cuadratica
    Sub Main(args As String())
        Dim a As Byte = 1
        Dim b As Byte = 5
        Dim c As Byte = 2
        Console.WriteLine("el resultado es: x = " & (b ^ 2 - 4 * a * c) / 2 * a)
    End Sub
End Module
