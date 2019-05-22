Module Refrase

    Sub Main()
        Dim frase As String = " Aunque la cadena sea de oro, sirve para lo mismo."
        Dim palabra, palabra1, frasenueva As String
        Console.WriteLine(frase)
        Console.WriteLine("Ingrese palabra a reemplazar: ")
        palabra = Console.ReadLine()
        Console.WriteLine("Ingrese palabra nueva: ")
        palabra1 = Console.ReadLine()
        palabra = " " + palabra + " "
        palabra1 = " " + palabra1 + " "
        frasenueva = (Replace(frase, palabra, palabra1, 1, -1, 1))
        palabra = palabra + ","
        palabra1 = palabra1 + ","
        frasenueva = (Replace(frasenueva, palabra, palabra1, 1, -1, 1))
        palabra = " " + palabra + "."
        palabra1 = " " + palabra1 + "."
        frasenueva = (Replace(frasenueva, palabra, palabra1, 1, -1, 1))
        Console.WriteLine(frasenueva)

    End Sub

End Module
