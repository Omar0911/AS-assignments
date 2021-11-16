Module Module1

    Sub Main()
        Dim InputStr, abcd As String
        Dim ThisChar As Char
        Dim Count As Integer
        Dim PanagramState As Boolean

        ThisChar = ""
        InputStr = ""
        abcd = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Count = 0
        PanagramState = True

        Console.Write("Please enter string: ")
        InputStr = Console.ReadLine
        InputStr = UCase(InputStr)

        For Count = 1 To Len(abcd)
            ThisChar = Mid(abcd, Count, 1)
            If InStr(InputStr, ThisChar) = 0 Then
                PanagramState = False
                Exit For

            End If
        Next
        If PanagramState = False Then
            Console.WriteLine("The given string is not a panagram")
        End If
        If PanagramState = True Then
            Console.WriteLine("The given string is  a panagram")

        End If

        Console.ReadKey()


    End Sub

End Module
