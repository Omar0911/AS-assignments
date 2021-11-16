Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim count As Integer
        Dim thischar, firstchar As Char

        str1 = ""
        str2 = ""
        count = 0
        thischar = ""
        firstchar = ""


        Console.Write("please enter string: ")
        str1 = Console.ReadLine

        firstchar = Mid(str1, 1, 1)
        str2 = firstchar

        For count = 2 To Len(str1)
            thischar = Mid(str1, count, 1)
            If thischar = firstchar Then
                str2 = str2 & "*"
            Else
                str2 = str2 & thischar
            End If
        Next

        Console.WriteLine("converted string: " & str2)
        Console.ReadKey()


    End Sub

End Module
