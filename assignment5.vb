Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Thischar As Char
        Dim count, acount, icount, ecount, ocount, ucount As Integer

        Str1 = ""
        Thischar = ""
        count = 0
        acount = 0
        icount = 0
        ecount = 0
        ocount = 0
        ucount = 0

        Console.Write("please enter string to be used: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        For count = 1 To Len(Str1)
            Thischar = Mid(Str1, count, 1)
            Select Case Thischar
                Case "A" : acount = acount + 1
                Case "I" : icount = icount + 1
                Case "E" : ecount = ecount + 1
                Case "O" : ocount = ocount + 1
                Case "U" : ucount = ucount + 1

            End Select
        Next

        Console.WriteLine("the vowel A appeared: " & acount)
        Console.WriteLine("the vowel I appeared: " & icount)
        Console.WriteLine("the vowel E appeared: " & ecount)
        Console.WriteLine("the vowel O appeared: " & ocount)
        Console.WriteLine("the vowel U appeared: " & ucount)
        Console.ReadKey()
    End Sub

End Module
