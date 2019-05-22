Imports System

Module Dias
    Enum DiasDeSemana
        Lunes = 1
        Martes = 2
        Miercoles = 3
        Jueves = 4
        Viernes = 5
        Sabado = 6
        Domingo = 7
    End Enum
    Sub Main(args As String())
        Dim dias As DiasDeSemana
        Console.WriteLine("Ingrese numero de dia(entre 1 y 7): ")
        dias = Console.ReadLine()
        Console.WriteLine("El dia seleccionado es: " & dias.ToString)
    End Sub
End Module
