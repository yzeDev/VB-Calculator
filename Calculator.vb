Public Class Calculator

    Dim hasResult As Boolean = False
    Dim firstNum As Double
    Dim secondNum As Double
    Dim operation As String

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Nothing
        CurrentResultLabel.Select()
    End Sub

    ' ========= NUMBER BUTTONS =========
    Private Sub NumberButton_Click(sender As Object, e As EventArgs) _
    Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click,
            Button4.Click, Button5.Click, Button6.Click, Button7.Click,
            Button8.Click, Button9.Click, DecimalBtn.Click

        Dim btn As Button = CType(sender, Button)

        If hasResult Then
            ' Starting a new calculation after showing a result
            CurrentResultLabel.Text = ""
            PreviousResultLabel.Text = ""     ' <<< clear the top line
            hasResult = False
        End If

        CurrentResultLabel.Text &= btn.Text
        CurrentResultLabel.Select()
    End Sub


    ' ========= OPERATOR BUTTONS =========
    Private Sub OperatorButton_Click(sender As Object, e As EventArgs) _
    Handles PlusBtn.Click, MinusBtn.Click, MultiplyBtn.Click, DivideBtn.Click

        Dim btn As Button = CType(sender, Button)
        Dim newOperation As String = btn.Text

        ' CASE 1: If operation already exists AND CurrentResultLabel has a number → calculate first
        If operation <> "" AndAlso CurrentResultLabel.Text <> "" AndAlso Double.TryParse(CurrentResultLabel.Text, secondNum) Then
            Dim result As Double
            Select Case operation
                Case "+"
                    result = firstNum + secondNum
                Case "-"
                    result = firstNum - secondNum
                Case "x", "×"
                    result = firstNum * secondNum
                Case "÷", "/"
                    If secondNum <> 0 Then
                        result = firstNum / secondNum
                    Else
                        MessageBox.Show("Cannot divide by zero!")
                        Exit Sub
                    End If
            End Select

            ' Update firstNum with result for chaining
            firstNum = result
            CurrentResultLabel.Text = ""
            PreviousResultLabel.Text = firstNum.ToString() & " " & newOperation

            ' CASE 2: No second number typed yet → just replace operator
        ElseIf operation <> "" AndAlso CurrentResultLabel.Text = "" Then
            operation = newOperation
            PreviousResultLabel.Text = firstNum.ToString() & " " & operation

            ' CASE 3: First time operator pressed (normal case)
        ElseIf Double.TryParse(CurrentResultLabel.Text, firstNum) Then
            CurrentResultLabel.Text = ""
            PreviousResultLabel.Text = firstNum.ToString() & " " & newOperation
        End If

        operation = newOperation
        hasResult = False
        CurrentResultLabel.Select()
    End Sub


    ' ========= EQUAL BUTTON =========
    Private Sub EqualBtn_Click(sender As Object, e As EventArgs) Handles EqualBtn.Click
        ' If there is no pending operation, treat '=' as "clear the previous expression"
        If String.IsNullOrEmpty(operation) Then
            If PreviousResultLabel.Text <> "" Then
                PreviousResultLabel.Text = ""   ' <<< remove "… ="
            End If
            CurrentResultLabel.Select()
            Return
        End If

        ' Need a second number to compute
        If Not Double.TryParse(CurrentResultLabel.Text, secondNum) Then
            CurrentResultLabel.Select()
            Return
        End If

        Dim result As Double
        Select Case operation
            Case "+"
                result = firstNum + secondNum
            Case "-"
                result = firstNum - secondNum
            Case "x", "×"
                result = firstNum * secondNum
            Case "÷", "/"
                If secondNum = 0 Then
                    MessageBox.Show("Cannot divide by zero!")
                    CurrentResultLabel.Select()
                    Return
                End If
                result = firstNum / secondNum
            Case Else
                CurrentResultLabel.Select()
                Return
        End Select

        ' Show the full equation once
        PreviousResultLabel.Text = $"{firstNum} {operation} {secondNum} ="
        CurrentResultLabel.Text = result.ToString()

        ' Reset pending operation so pressing '=' again won't append " = result" again
        operation = ""
        firstNum = result          ' lets you pick a new operator to continue from the result
        hasResult = True
        CurrentResultLabel.Select()
    End Sub


    ' ========= CLEAR BUTTON =========
    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        PreviousResultLabel.Text = ""
        CurrentResultLabel.Text = ""
        firstNum = 0
        secondNum = 0
        operation = ""
        hasResult = False
        CurrentResultLabel.Select()
    End Sub

    ' ========= BACKSPACE BUTTON =========
    Private Sub BackspaceBtn_Click(sender As Object, e As EventArgs) Handles BackspaceBtn.Click
        If Not hasResult AndAlso CurrentResultLabel.Text.Length > 0 Then
            CurrentResultLabel.Text = CurrentResultLabel.Text.Substring(0, CurrentResultLabel.Text.Length - 1)
        End If
        CurrentResultLabel.Select()
    End Sub

    ' ========= KEYBOARD INPUT =========
    ' Handles character input (numbers, ., +, -, *, /)
    Private Sub Calculator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' Digits and decimal
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c Then
            NumberButton_Click(New Button() With {.Text = e.KeyChar}, Nothing)
        End If

        ' Operators
        Select Case e.KeyChar
            Case "+"c, "-"c
                OperatorButton_Click(New Button() With {.Text = e.KeyChar}, Nothing)

            Case "*"c
                ' Map * to x
                OperatorButton_Click(New Button() With {.Text = "x"}, Nothing)

            Case "/"c
                ' Map / to ÷
                OperatorButton_Click(New Button() With {.Text = "÷"}, Nothing)
        End Select

        ' Enter (=)
        If e.KeyChar = ChrW(Keys.Enter) Then
            EqualBtn_Click(Nothing, Nothing)
            e.Handled = True
        End If

        ' Backspace
        If e.KeyChar = ChrW(Keys.Back) Then
            BackspaceBtn_Click(Nothing, Nothing)
            e.Handled = True
        End If
    End Sub

    ' Handles special keys (like numpad multiply/divide)
    Private Sub Calculator_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Multiply
                OperatorButton_Click(New Button() With {.Text = "x"}, Nothing)
                e.Handled = True

            Case Keys.Divide
                OperatorButton_Click(New Button() With {.Text = "÷"}, Nothing)
                e.Handled = True

            Case Keys.Add
                OperatorButton_Click(New Button() With {.Text = "+"}, Nothing)
                e.Handled = True

            Case Keys.Subtract
                OperatorButton_Click(New Button() With {.Text = "-"}, Nothing)
                e.Handled = True

            Case Keys.Decimal
                NumberButton_Click(New Button() With {.Text = "."}, Nothing)
                e.Handled = True
        End Select
    End Sub

End Class
