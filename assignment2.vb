Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim ThisChar, NewChar, ReplChar As Char
        Dim Count As Integer

        Str1 = ""
        Str2 = ""
        ThisChar = ""
        ReplChar = ""
        NewChar = ""
        Count = 0

        Console.Write("Please enter the string: ")
        Str1 = Console.ReadLine

        Console.Write("Please enter char to remove: ")
        ReplChar = Console.ReadLine

        Console.Write("Please enter char to replace with: ")
        NewChar = Console.ReadLine

        For Count = 1 To Len(Str1)
            ThisChar = Mid(Str1, Count, 1)
            If ThisChar = ReplChar Then
                ThisChar = NewChar
            End If
            Str2 = Str2 & ThisChar
        Next
        Console.WriteLine("The converted string: " & Str2)
        Console.ReadKey()
    End Sub

End Module
