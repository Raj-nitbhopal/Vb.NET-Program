Public Class Form1
    Dim FirstNumber As Double
    Dim SecondNumber As Double
    Dim Operator_Selector As Boolean = False
    Dim Operations As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        If lcd.Text <> "0" Then
            lcd.Text += "1"
        Else
            lcd.Text = "1"
        End If
    End Sub

    Private Sub BTN2_Click(sender As Object, e As EventArgs) Handles BTN2.Click
        If lcd.Text <> "0" Then
            lcd.Text += "2"
        Else
            lcd.Text = "2"
        End If
    End Sub

    Private Sub BTN3_Click(sender As Object, e As EventArgs) Handles BTN3.Click
        If lcd.Text <> "0" Then
            lcd.Text += "3"
        Else
            lcd.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If lcd.Text <> "0" Then
            lcd.Text += "4"
        Else
            lcd.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If lcd.Text <> "0" Then
            lcd.Text += "5"
        Else
            lcd.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If lcd.Text <> "0" Then
            lcd.Text += "6"
        Else
            lcd.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If lcd.Text <> "0" Then
            lcd.Text += "7"
        Else
            lcd.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If lcd.Text <> "0" Then
            lcd.Text += "8"
        Else
            lcd.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If lcd.Text <> "0" Then
            lcd.Text += "9"
        Else
            lcd.Text = "9"
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If lcd.Text <> "0" Then
            lcd.Text += "0"
        Else
            lcd.Text = "0"
        End If
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        If lcd.Text <> "0" Then
            lcd.Text += "00"
        Else
            lcd.Text = "00"
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If Not (lcd.Text.Contains(".")) Then
            lcd.Text += "."

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lcd.Clear()
    End Sub

    Private Sub BTNplus_Click(sender As Object, e As EventArgs) Handles BTNplus.Click
        FirstNumber = lcd.Text
        lcd.Text = "0"
        Operator_Selector = True
        Operations = 1
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        FirstNumber = lcd.Text
        lcd.Text = "0"
        Operator_Selector = True
        Operations = 2
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        FirstNumber = lcd.Text
        lcd.Text = "0"
        Operator_Selector = True
        Operations = 3
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        FirstNumber = lcd.Text
        lcd.Text = "0"
        Operator_Selector = True
        Operations = 4
    End Sub

    Private Sub btnpercent_Click(sender As Object, e As EventArgs) Handles btnpercent.Click
        FirstNumber = lcd.Text
        lcd.Text = "0"
        Operator_Selector = True
        Operations = 5
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        If Operator_Selector = True Then
            SecondNumber = lcd.Text

            If Operations = 1 Then
                lcd.Text = FirstNumber + SecondNumber
            ElseIf Operations = 2 Then
                lcd.Text = FirstNumber - SecondNumber
            ElseIf Operations = 3 Then
                lcd.Text = FirstNumber * SecondNumber
            ElseIf Operations = 5 Then
                lcd.Text = FirstNumber * SecondNumber / 100
            Else
                If SecondNumber = 0 Then
                    lcd.Text = "Error"

                ElseIf Operations = 4 Then
                    lcd.Text = FirstNumber / SecondNumber
                End If
            End If
            End If

    End Sub
End Class
