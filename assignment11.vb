Module Module1

    Sub Main()
        Dim str1, str2, str3, str4 As String
        Dim lennot, lenbad As Integer
        Dim AFlag As Boolean

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        lennot = 0
        lenbad = 0
        AFlag = True

        Console.Write("please enter string to change: ")
        str1 = Console.ReadLine

        lennot = InStr(str1, "not")
        lenbad = InStr(str1, "bad")
        lenbad = lenbad + 2

        If lenbad <> 0 And lennot <> 0 Then
            If lenbad > lennot Then
                str3 = Left(str1, lennot - 1)
                str4 = Right(str1, Len(str1) - lenbad)
                str2 = str3 & "good" & str4
                AFlag = False
                Console.WriteLine(str2)


            End If
        End If

        If AFlag = True Then
            If str2 <> "good" Then
                Console.WriteLine("This string cannot be used")
            End If
        End If

        Console.ReadKey()
    End Sub

End Module
