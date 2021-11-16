Module Module1

    Sub Main()
        Dim str1, str2, str1F2C, str2F2C, str3, str4 As String
        Dim count As Integer
        Dim thischar As Char

        str1 = ""
        str2 = ""
        str1F2C = ""
        str2F2C = ""
        count = 0
        thischar = ""
        str3 = ""
        str4 = ""

        Console.Write("enter first string to use: ")
        str1 = Console.ReadLine

        Console.Write("enter second string to use: ")
        str2 = Console.ReadLine

        str1F2C = Mid(str1, 1, 2)
        str4 = str1F2C
        str2F2C = Mid(str2, 1, 2)
        str3 = str2F2C

        For count = 3 To Len(str1)
            thischar = Mid(str1, count, 1)
            str3 = str3 & thischar
        Next

        For count = 3 To Len(str2)
            thischar = Mid(str2, count, 1)
            str4 = str4 & thischar
        Next

        Console.WriteLine(str3 & " " & str4)
        Console.ReadKey()
    End Sub

End Module
