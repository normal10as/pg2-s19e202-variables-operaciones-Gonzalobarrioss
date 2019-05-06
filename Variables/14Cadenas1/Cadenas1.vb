Module Cadenas1

    Sub Main()
        Dim palabra As String
        Dim buscarletra As String = "a"
        Dim buscarletra1 As String = "o"
        Dim startposition As Byte = 1
        Console.WriteLine("ingrese una palabra: ")
        palabra = Console.ReadLine()
        Console.WriteLine("La letra 'a' esta en la posicion: " & InStr(startposition, palabra, buscarletra, CompareMethod.Text))
        Console.WriteLine("La letra 'o' esta en la posicion: " & InStr(startposition, palabra, buscarletra1, CompareMethod.Text))
        Console.WriteLine("La palabra invertida sería: " & StrReverse(palabra))

    End Sub

End Module
