Imports System

Module concatenacion
    Sub Main(args As String())
        Dim nombreempresa, nombrecalle As String
        Dim alturacalle As Integer
        Dim fechainicio As Date
        Dim nombreempresa1, nombrecalle1, fechainicio1, alturacalle1
        Console.WriteLine("nombre de empresa")
        nombreempresa = Console.ReadLine()
        Console.WriteLine("nombre calle")
        nombrecalle = Console.ReadLine()
        Console.WriteLine("altura calle")
        alturacalle = Console.ReadLine()
        Console.WriteLine("fecha inicio actividades")
        fechainicio = Console.ReadLine()
        Console.WriteLine(nombreempresa & " " & nombrecalle & " " & alturacalle & " " & fechainicio)
        nombreempresa1 = Convert.ToString(nombreempresa)
        nombrecalle1 = Convert.ToString(nombrecalle)
        alturacalle1 = Convert.ToString(alturacalle)
        fechainicio1 = Convert.ToString(fechainicio)
        Console.WriteLine(nombreempresa1 + " " + nombrecalle1 + " " + alturacalle1 + " " + fechainicio1)
    End Sub
End Module
