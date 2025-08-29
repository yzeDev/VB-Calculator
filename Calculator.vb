Public Class Calculator

    Dim hasResult As Boolean = False
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Nothing
        DisplayLabel.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "1"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "1"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "2"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "2"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "3"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "3"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PlusBtn.Click
        hasResult = False
        DisplayLabel.Text = DisplayLabel.Text & " + "
        DisplayLabel.Select()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "4"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "4"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "5"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "5"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "6"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "6"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles MinusBtn.Click
        hasResult = False
        DisplayLabel.Text = DisplayLabel.Text & " - "
        DisplayLabel.Select()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "7"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "7"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "8"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "8"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "9"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "9"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles MultiplyBtn.Click
        hasResult = False
        DisplayLabel.Text = DisplayLabel.Text & " x "
        DisplayLabel.Select()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        hasResult = False
        DisplayLabel.Text = ""
        DisplayLabel.Select()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "0"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "0"
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles EqualBtn.Click
        CalculateResult()
        DisplayLabel.Select()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles DivideBtn.Click
        hasResult = False
        DisplayLabel.Text = DisplayLabel.Text & " ÷ "
        DisplayLabel.Select()
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles ClrBtn.Click
        hasResult = False
        DisplayLabel.Text = ""
        DisplayLabel.Select()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles DecimalBtn.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "."
        Else
            DisplayLabel.Text = DisplayLabel.Text & "."
        End If
        DisplayLabel.Select()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles BackspaceBtn.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            Return
        ElseIf DisplayLabel.Text.Length = 0 Then
            Return
        ElseIf hasResult = False Then
            DisplayLabel.Text = DisplayLabel.Text.Remove(DisplayLabel.Text.Length - 1)
            Return
        End If
        DisplayLabel.Select()
    End Sub
    Private Sub CalculateResult()
        Try
            Dim expression As String = DisplayLabel.Text

            expression = expression.Replace("÷", "/")
            expression = expression.Replace("x", "*")

            Dim result As Object = New DataTable().Compute(expression, Nothing)
            DisplayLabel.Text = result.ToString()
            hasResult = True
        Catch ex As Exception
            DisplayLabel.Text = "Error"
            hasResult = True
        End Try
        DisplayLabel.Select()
    End Sub
    Private Sub Calculator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' Digits (0–9)
        If Char.IsDigit(e.KeyChar) Then
            If hasResult Then
                DisplayLabel.Text = ""
                hasResult = False
            End If
            DisplayLabel.Text &= e.KeyChar
        End If

        ' Operators (+ - x ÷)
        If "+-x÷".Contains(e.KeyChar) Then
            hasResult = False
            DisplayLabel.Text &= " " & e.KeyChar & " "
        End If

        ' Decimal point
        If e.KeyChar = "."c Then
            DisplayLabel.Text &= "."
        End If

        ' Backspace
        If e.KeyChar = ChrW(Keys.Back) Then
            If DisplayLabel.Text.Length > 0 Then
                DisplayLabel.Text = DisplayLabel.Text.Substring(0, DisplayLabel.Text.Length - 1)
            End If
            e.Handled = True
        End If

        ' Enter (=)
        If e.KeyChar = ChrW(Keys.Enter) Then
            CalculateResult()
            e.Handled = True
        End If
    End Sub

End Class