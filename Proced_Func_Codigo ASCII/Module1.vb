Module Module1

    Sub Main()
        ' Implementar una programa que realice lo siguiente: 
        '- Solicitar diez veces la entrada de una letra
        '- Ordenar de forma descendente las 10 letras leídas
        '- Mostrar por pantalla una lista de las letras en orden descendente junto con su correspondiente código ASCII

        'Se debe realizar de la siguiente forma: 
        '- Implementar una función que solicita una letra por consola y devuelva la letra leída por pantalla. - Implementar una función para ordenar las letras
        '- Implementar un procedimiento para mostrar la lista final

        Dim listaLetras(9) As Char
        Dim listaint(9) As Integer

        Console.WriteLine("Introduce 10 letras" & vbNewLine)

        For i = 0 To listaLetras.Length - 1
            listaLetras(i) = pedirLetras()
        Next

        For i = 0 To listaLetras.Length - 1
            listaint(i) = Asc(listaLetras(i))
        Next

        ordenarNumeros(listaint)

        Console.Write("" & vbNewLine)

        mostrar(listaint)

        Console.ReadLine()
    End Sub

    Function pedirLetras() As Char

        Dim letra As Char

        Console.Write("Introduce la letra :")
        letra = Console.ReadLine()

        Return letra

    End Function

    Function ordenarNumeros(ParamArray lista() As Integer) As Array

        Array.Sort(lista)
        Array.Reverse(lista)

        Return lista

    End Function

    Sub mostrar(ParamArray lista() As Integer)
        Console.Write("LETRA - ASCII" & vbNewLine)
        For i = 0 To lista.Length - 1
            Console.Write(Chr(lista(i)) & "     - " & lista(i) & vbNewLine)
        Next
    End Sub

End Module
