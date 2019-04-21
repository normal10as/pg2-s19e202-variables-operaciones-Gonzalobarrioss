Imports System

Module semanas
    Sub Main(args As String())
        Dim diasdelaño As Integer = 365
        Dim diaslaborales As Integer = 250
        Dim diasdesemana As Integer = 7
        Console.WriteLine("el año tiene: " & diasdelaño \ diasdesemana & " semanas.")
        Console.WriteLine("y hay: " & diaslaborales \ diasdesemana & " semanas laborales.")
    End Sub
End Module
