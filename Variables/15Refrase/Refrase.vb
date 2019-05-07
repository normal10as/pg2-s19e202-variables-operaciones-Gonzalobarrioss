Module Refrase

    Sub Main()
        Dim frase As String = "Aunque la cadena sea de oro, sirve para lo mismo"
        Dim palabra, palabra1 As String
        Console.WriteLine(frase)
        Console.WriteLine("Ingrese palabra a reemplazar: ")
        palabra = Console.ReadLine()
        Console.WriteLine("Ingrese palabra nueva: ")
        palabra1 = Console.ReadLine()
        Console.WriteLine(Replace(frase, palabra, palabra1))
    End Sub

End Module
