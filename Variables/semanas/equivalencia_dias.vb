Imports System

Module equivalencia_dias
    Sub Main(args As String())
        Dim diasporsemana As Byte = 7
        Dim horaspordia As Byte = 24
        Dim minutosporhora As Byte = 60
        Dim dias As Single
        Console.WriteLine("Ingrese cantidad de dias: ")
        dias = Console.ReadLine()
        Console.WriteLine("el numero de dias ingresado corresponde a: " & dias / diasporsemana & " semanas, " & dias * horaspordia & " horas por dia, " & (dias * horaspordia) * minutosporhora & " minutos.")
    End Sub
End Module
