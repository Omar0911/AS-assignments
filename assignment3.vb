Module Module1

    Sub Main()
        Dim Str1, Ustr As String
        Dim ThisChar, countedchar As Char
        Dim counter, countedcounter, alphacounter, numcounter, symcounter As Integer

        Str1 = ""
        Ustr = ""
        ThisChar = ""
        countedchar = ""
        counter = 0
        countedcounter = 0
        alphacounter = 0
        numcounter = 0
        symcounter = 0

        Console.Write("Please enter string to be used: ")
        Str1 = Console.ReadLine
        Ustr = UCase(Str1)

        Console.Write("Please enter character to be counted: ")
        countedchar = Console.ReadLine

        For counter = 1 To Len(Str1)
            ThisChar = Mid(Str1, counter, 1)
            If ThisChar = countedchar Then
                countedcounter = countedcounter + 1
            End If
        Next

        For counter = 1 To Len(Str1)
            ThisChar = Mid(Ustr, counter, 1)
            If ThisChar >= "A" And ThisChar <= "Z" Then
                alphacounter = alphacounter + 1
            ElseIf ThisChar >= "0" And ThisChar <= "9" Then
                numcounter = numcounter + 1
            ElseIf Asc(ThisChar) >= 34 And Asc(ThisChar) <= 47 Then
                symcounter = symcounter + 1
            End If

        Next
        Console.WriteLine("selected character appeared: " & countedcounter)
        Console.WriteLine("number of alphabets: " & alphacounter)
        Console.WriteLine("number of numbers: " & numcounter)
        Console.WriteLine("number of symbols: " & symcounter)

        Console.ReadKey()





    End Sub

End Module
