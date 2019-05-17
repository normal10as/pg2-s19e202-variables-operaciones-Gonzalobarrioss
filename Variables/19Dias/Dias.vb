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
        Console.WriteLine("Los dias de la semana en orden ascendente son: ")
        Console.WriteLine(DiasDeSemana.Lunes & ") " & DiasDeSemana.Lunes.ToString())
        Console.WriteLine(DiasDeSemana.Martes & ") " & DiasDeSemana.Martes.ToString())
        Console.WriteLine(DiasDeSemana.Miercoles & ") " & DiasDeSemana.Miercoles.ToString())
        Console.WriteLine(DiasDeSemana.Jueves & ") " & DiasDeSemana.Jueves.ToString())
        Console.WriteLine(DiasDeSemana.Viernes & ") " & DiasDeSemana.Viernes.ToString())
        Console.WriteLine(DiasDeSemana.Sabado & ") " & DiasDeSemana.Sabado.ToString())
        Console.WriteLine(DiasDeSemana.Domingo & ") " & DiasDeSemana.Domingo.ToString())


    End Sub
End Module
