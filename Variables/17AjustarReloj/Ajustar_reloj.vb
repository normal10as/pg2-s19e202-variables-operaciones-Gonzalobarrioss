Imports System

Module Ajustar_reloj
    Sub Main(args As String())
        Dim mes, a�o, minuto, segundo As Date
        Dim dia, hora, fecha As String
        mes = mes.Now
        a�o = a�o.Now
        minuto = minuto.now
        segundo = segundo.now
        Console.WriteLine("Ingrese dia: ")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese hora: ")
        hora = Console.ReadLine()
        fecha = New DateTime(a�o.Year, mes.Month, dia, hora, minuto.Minute, segundo.Second)
        Console.WriteLine("El reloj se ha ajustado a :" & fecha)

    End Sub
End Module
