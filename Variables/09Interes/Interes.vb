Imports System

Module Interes
    Sub Main(args As String())
        Dim interes, monto As Integer
        Dim tiempo As Byte
        Dim tasa As Single
        Console.WriteLine("Ingrese monto:")
        monto = Console.ReadLine()
        Console.WriteLine("Ingrese tasa de interes:")
        tasa = Console.ReadLine()
        Console.WriteLine("Ingrese tiempo (en dias):")
        tiempo = Console.ReadLine()
        interes = (monto * tasa * tiempo) / (360 * 100)
        Console.WriteLine("El interes generado en esa tasa y en ese tiempo es de: $" & interes)
    End Sub
End Module
