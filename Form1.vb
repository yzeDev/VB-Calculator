Public Class Form1

    Dim hasResult As Boolean = False
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub DisplayLabel_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "1"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "2"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "3"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PlusBtn.Click
        hasResult = False
        DisplayLabel.Text = DisplayLabel.Text & " + "
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "4"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "4"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "5"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "5"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "6"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "6"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles MinusBtn.Click
        hasResult = False
        DisplayLabel.Text = DisplayLabel.Text & " - "
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "7"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "7"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "8"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "8"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "9"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "9"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles MultiplyBtn.Click
        hasResult = False
        DisplayLabel.Text = DisplayLabel.Text & " x "
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        hasResult = False
        DisplayLabel.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "0"
        Else
            DisplayLabel.Text = DisplayLabel.Text & "0"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles EqualBtn.Click
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
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles DivideBtn.Click
        hasResult = False
        DisplayLabel.Text = DisplayLabel.Text & " ÷ "
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles ClrBtn.Click
        hasResult = False
        DisplayLabel.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles DecimalBtn.Click
        If hasResult Then
            DisplayLabel.Text = ""
            hasResult = False
            DisplayLabel.Text = DisplayLabel.Text & "."
        Else
            DisplayLabel.Text = DisplayLabel.Text & "."
        End If
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
    End Sub
End Class