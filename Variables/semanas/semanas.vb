Imports System

Module semanas
    Sub Main(args As String())
        Dim diasdela�o As Integer = 365
        Dim diaslaborales As Integer = 250
        Dim diasdesemana As Integer = 7
        Console.WriteLine("el a�o tiene: " & diasdela�o \ diasdesemana & " semanas.")
        Console.WriteLine("y hay: " & diaslaborales \ diasdesemana & " semanas laborales.")
    End Sub
End Module
