Module Module1

    Sub Main()
        Dim str1, str2, str3, str4 As String
        Dim thischar As Char
        Dim count As Integer
        Dim lencheck As Boolean

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        thischar = ""
        count = 0
        lencheck = True

        Console.Write("please enter the string to use: ")
        str1 = Console.ReadLine

        If Len(str1) < "2" Then lencheck = False
        If lencheck = True Then
            str2 = Left(str1, 2)
            str3 = Right(str1, 2)
            str4 = str2 & str3
        Else
            str4 = str1
        End If

        Console.WriteLine("output string: " & str4)
        Console.ReadKey()
    End Sub

End Module
