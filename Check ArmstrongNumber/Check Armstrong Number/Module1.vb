Imports System
Module Module1

    Sub Main()
        Console.WriteLine("***CHECK NUMBER IS ARMSTRONG OR NOT***")
        Check_armstrong()
        Console.ReadLine()
    End Sub
    Sub Check_armstrong()
        Console.WriteLine("Enter A number as integer:")
        Dim intinput, intinput1, remainder As Integer
        Dim sum As Integer = 0
        intinput = Console.ReadLine()
        intinput1 = intinput
        While intinput1 > 0
            remainder = intinput1 Mod 10
            sum = sum + remainder * remainder * remainder
            intinput1 = intinput1 / 10
        End While
        If sum = intinput Then
            Console.WriteLine("Number is armstrong")
        Else
            Console.WriteLine("Number is not Armstrong")
        End If

    End Sub

End Module
