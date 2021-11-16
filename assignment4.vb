Module Module1

    Sub Main()
        Dim Str1 As String
        Dim ThisChar, ThisChar2, MostChar As Char
        Dim Count, Count2, CurrCount, MostCount As Integer

        Str1 = ""
        ThisChar = ""
        ThisChar2 = ""
        MostChar = ""
        Count = 0
        MostCount = 0
        CurrCount = 0

        Console.Write("please enter string to be used: ")
        Str1 = Console.ReadLine

        For Count = 1 To Len(Str1)
            ThisChar = Mid(Str1, Count, 1)
            CurrCount = 0
            For Count2 = 1 To Len(Str1)
                ThisChar2 = Mid(Str1, Count2, 1)

                If ThisChar2 = ThisChar Then
                    CurrCount = CurrCount + 1
                End If
            Next

            If CurrCount > MostCount Then
                MostCount = CurrCount
                MostChar = ThisChar
            End If


        Next

        Console.WriteLine("The most used char is: " & MostChar & " and it appeared: " & MostCount)
        Console.ReadKey()

    End Sub

End Module
