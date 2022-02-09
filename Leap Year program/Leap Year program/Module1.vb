Imports System
Module Module1

    Sub Main()
        Console.WriteLine()
        Leapyear()
        Console.ReadLine()
    End Sub
    Sub Leapyear()
        Console.WriteLine("***CHECK YEAR IS LEAP OR NOT***")
        Console.WriteLine()
        Dim year As Integer
        Console.WriteLine("Enter an year value:")
        year = Console.ReadLine
        If year Mod 4 = 0 Then

            Console.WriteLine("Year {0} is a Leap Year.", year)
        ElseIf year Mod 100 = 0 Then
        ElseIf year Mod 400 = 0 Then
            Console.WriteLine("Year {0} is  a leap year.", year)
        Else
            Console.WriteLine("Year {0} is not a leap year.", year)
            Console.WriteLine()
        End If

    End Sub

End Module
