Imports System

Module aritmetica
    Sub Main(args As String())
        Dim entero As Integer = 10
        Dim entero1 As Integer = 20
        Dim flotante As Decimal = 10.5
        Dim flotante1 As Decimal = 2.5
        Console.WriteLine("sumar entero con entero " & entero & " + " & entero1 & " = " & entero + entero1)
        Console.WriteLine("sumar entero con flotante " & entero & " + " & flotante & " = " & entero + flotante)
        Console.WriteLine("sumar flotante con flotante " & flotante & " + " & flotante1 & " = " & flotante + flotante1)
        Console.WriteLine("multiplicar entero con flotante " & entero & " x " & flotante & " = " & entero * flotante)
        Console.WriteLine("multiplicar entero con entero " & entero & " x " & entero1 & " = " & entero * entero1)
        Console.WriteLine("multiplicar flotante con flotante " & flotante1 & " x " & flotante & " = " & flotante1 * flotante)
        Console.WriteLine("restar entero con flotante " & entero & " - " & flotante & " = " & entero - flotante)
        Console.WriteLine("restar entero con entero " & entero & " - " & entero1 & " = " & entero - entero1)
        Console.WriteLine("restar flotante con flotante " & flotante1 & " - " & flotante & " = " & flotante1 - flotante)
        Console.WriteLine("division real entre entero y flotante " & entero1 & " / " & flotante & " = " & entero1 / flotante)
        Console.WriteLine("division real entre entero y entero " & entero1 & " / " & entero & " = " & entero1 / entero)
        Console.WriteLine("division real entre flotante y flotante " & flotante1 & " / " & flotante & " = " & flotante1 / flotante)
        Console.WriteLine("division entera entre enteros " & entero1 & " \ " & entero & " = " & entero1 \ entero)
        Console.WriteLine("division entera entre flotantes " & flotante & " \ " & flotante1 & " = " & flotante \ flotante1)
        Console.WriteLine("division entera entre entero y flotantes " & entero & " \ " & flotante1 & " = " & entero \ flotante1)
        Console.WriteLine("exponenciacion entre enteros " & entero1 & " ^ " & entero & " = " & entero1 ^ entero)
        Console.WriteLine("exponenciacion entre flotantes " & flotante & " ^ " & flotante1 & " = " & flotante ^ flotante1)
        Console.WriteLine("exponenciacion entre entero y flotante " & flotante1 & " ^ " & entero & " = " & flotante ^ entero)
        Console.WriteLine("resto entre enteros " & entero1 & " mod " & entero & " = " & entero1 Mod entero)
        Console.WriteLine("resto entre flotantes " & flotante & " mod " & flotante1 & " = " & flotante Mod flotante1)
        Console.WriteLine("resto entre entero y flotante " & entero1 & " mod " & flotante1 & " = " & entero1 Mod flotante1)
    End Sub
End Module
