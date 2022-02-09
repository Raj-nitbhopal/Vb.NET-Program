Public Class Form1
    Dim Numbertxt As Double
    Dim Intializer As Integer = 1
    Sub Clearlist()
        lstResult.Items.Clear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        Numbertxt = txtLCD.Text
        Dim counter As Integer = 0
        Clearlist()
        For intialzer = 1 To Numbertxt
            If Numbertxt Mod intialzer = 0 Then
                counter = counter + 1
            End If
        Next intialzer
        If counter <> 2 Then
            lstResult.Items.Add("Number is Not  Prime.")
        Else
            lstResult.Items.Add("Number is Prime")
        End If
    End Sub


    Private Sub btnArmstrong_Click(sender As Object, e As EventArgs) Handles btnArmstrong.Click
        Clearlist()
        Numbertxt = txtLCD.Text
        Dim Remainder As Integer
        Dim LocalInt As Integer
        Dim ResultNum As Integer = 0
        LocalInt = Numbertxt
        While LocalInt > 0
            Remainder = LocalInt Mod 10
            ResultNum = ResultNum + Remainder * Remainder * Remainder
            LocalInt = LocalInt / 10
        End While
        If ResultNum <> txtLCD.Text Then
            lstResult.Items.Add("Entered Number is Not Armstrong")
        Else
            lstResult.Items.Add("Entered Number is  Armstrong Number")
        End If

    End Sub

    Private Sub btnPallindrome_Click(sender As Object, e As EventArgs) Handles btnPallindrome.Click
        Clearlist()
        Numbertxt = txtLCD.Text
        Dim Remainder As Integer
        Dim LocalInt As Integer
        Dim ResultNum As Integer = 0
        LocalInt = Numbertxt
        While LocalInt > 0
            Remainder = LocalInt Mod 10
            ResultNum = ResultNum * 10 + Remainder
            LocalInt = LocalInt / 10
        End While
        If ResultNum <> Numbertxt Then
            lstResult.Items.Add("Entered Number is Not Pallindrome")
        Else
            lstResult.Items.Add("Entered Number Is  Pallindrome")
        End If
    End Sub

    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        Clearlist()
        Numbertxt = txtLCD.Text
        Dim table As Integer
        For Intializer = 1 To 10
            table = Numbertxt * Intializer
            lstResult.Items.Add(table)
            'intializer += 1
            table += 1
        Next Intializer
    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        Clearlist()
        Numbertxt = txtLCD.Text
        Dim ResultNum As Double = 1
        For Intializer = 1 To Numbertxt
            ResultNum = ResultNum * Intializer
        Next Intializer
        lstResult.Items.Add(ResultNum)
    End Sub


    Private Sub btnCLEAR_LCD_Click(sender As Object, e As EventArgs) Handles btnCLEAR_LCD.Click
        txtLCD.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clearlist()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
