Imports System

Module Program
    Sub Main(args As String())
        Dim nombre, lugarnacimiento, nombrecalle As String
        Dim altura, pesoenkg As Byte
        Dim alturacalle, distanciaenkms, profundidaddemar As UShort
        Dim canthabitantes, documento As UInteger
        Dim fechanacimiento As Date
        Dim temperatura As SByte
        Dim montodearticulo As Decimal
        Dim argentino As Boolean

        nombre = "Gonzalo"
        lugarnacimiento = "posadas"
        nombrecalle = "Av. Lavalle"
        documento = 40500600
        alturacalle = 5555
        canthabitantes = 130000
        fechanacimiento = #1996/10/16#
        altura = 178
        temperatura = 39.5
        distanciaenkms = 300.5
        profundidaddemar = 675.12
        pesoenkg = 70.4
        montodearticulo = 650.37
        argentino = True

        Console.WriteLine("Nombre de la persona: " & nombre)
        Console.WriteLine("Numero de dni: " & documento)
        Console.WriteLine("Lugar de nacimiento: " & lugarnacimiento)
        Console.WriteLine("Fecha de nacimiento: " & fechanacimiento)
        Console.WriteLine("Altura corporal en cms: " & altura)
        Console.WriteLine("Esta persona es de argentina: " & argentino)
        Console.WriteLine("La temperatura alli es de: " & temperatura)
        Console.WriteLine("Nombre de calle: " & nombrecalle)
        Console.WriteLine("altura: " & alturacalle)
        Console.WriteLine("Distancia en kms entre posadas y buenos aires es de : " & distanciaenkms & "kms")
        Console.WriteLine("La profundidad del mar argentino es de :" & profundidaddemar & "mts")
        Console.WriteLine("La cantidad de habitantes es de :" & canthabitantes & " personas")
        Console.WriteLine("El peso del queso es de :" & pesoenkg & "kg")
        Console.WriteLine("Y su precio es de: " & montodearticulo & "$")

    End Sub
End Module
