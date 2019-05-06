Imports System
Imports System.DateTime
Imports System.String

Module Reloj
    Sub Main(args As String())
        Dim dia, mes, hora, minuto As Date
        dia = dia.Now
        mes = mes.Now
        hora = hora.Now
        minuto = minuto.Now
        Console.WriteLine("Dia del año: " & dia.DayOfYear)
        Console.WriteLine("Mes del año: " & mes.Month)
        Console.WriteLine("Hora del dia: " & hora.Hour)
        Console.WriteLine("Minuto : " & minuto.Minute)
    End Sub
End Module
