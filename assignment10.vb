Module Module1

    Sub Main()
        Dim str1, str2, thischar As String
        Dim count As Integer
        Dim lencheck As Boolean

        str1 = ""
        str2 = ""
        count = 0
        thischar = ""
        lencheck = True

        Console.Write("enter the string to be used: ")
        str1 = Console.ReadLine

        If Len(str1) < "3" Then lencheck = False

        If lencheck = True Then
            thischar = Right(str1, 3)
            If thischar = "ing" Then
                str2 = str1 & "ly"
            Else
                str2 = str1 & "ing"
            End If
        End If

        If lencheck = True Then
            Console.Write("converted string is: " & str2)
        Else
            Console.Write(str1)
        End If
        Console.ReadKey()
    End Sub

End Module
