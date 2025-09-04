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
    Private Const MaxLength As Integer = 21
    Private Sub NumberButton_Click(sender As Object, e As EventArgs) _
    Handles Button0.Click, Button1.Click, Button2.Click, Button3.Click,
         Button4.Click, Button5.Click, Button6.Click, Button7.Click,
         Button8.Click, Button9.Click, DecimalBtn.Click

        Dim btn As Button = CType(sender, Button)

        If hasResult Then
            CurrentResultLabel.Text = ""
            PreviousResultLabel.Text = ""
            hasResult = False
        End If

        If CurrentResultLabel.Text.Length >= MaxLength Then
            Return
        End If

        ' Decimal handling
        If btn.Text = "." Then
            If CurrentResultLabel.Text.Contains(".") Then
                Return
            End If

            If CurrentResultLabel.Text = "" Then
                CurrentResultLabel.Text = "0"
            End If
        End If

        CurrentResultLabel.Text &= btn.Text
        CurrentResultLabel.Text = FormatWithCommas(CurrentResultLabel.Text.Replace(",", ""))
        AdjustLabelFont(CurrentResultLabel)

        CurrentResultLabel.Select()
        AdjustLabelFont(CurrentResultLabel)

    End Sub

    ' ========= OPERATOR BUTTONS =========
    Private Sub OperatorButton_Click(sender As Object, e As EventArgs) _
    Handles PlusBtn.Click, MinusBtn.Click, MultiplyBtn.Click, DivideBtn.Click

        Dim btn As Button = CType(sender, Button)
        Dim newOperation As String = btn.Text

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
                        CurrentResultLabel.Text = "Math Error!"
                        Exit Sub
                    End If
            End Select

            firstNum = result
            CurrentResultLabel.Text = ""
            PreviousResultLabel.Text = firstNum.ToString() & " " & newOperation

        ElseIf operation <> "" AndAlso CurrentResultLabel.Text = "" Then
            operation = newOperation
            PreviousResultLabel.Text = firstNum.ToString() & " " & operation
            AdjustLabelFont(PreviousResultLabel)


        ElseIf Double.TryParse(CurrentResultLabel.Text, firstNum) Then
            CurrentResultLabel.Text = ""
            PreviousResultLabel.Text = firstNum.ToString() & " " & newOperation
            AdjustLabelFont(PreviousResultLabel)

        End If

        operation = newOperation
        hasResult = False
        CurrentResultLabel.Select()
    End Sub


    ' ========= EQUAL BUTTON =========
    Private Sub EqualBtn_Click(sender As Object, e As EventArgs) Handles EqualBtn.Click

        If String.IsNullOrEmpty(operation) Then
            If PreviousResultLabel.Text <> "" Then
                PreviousResultLabel.Text = ""
            End If
            CurrentResultLabel.Select()
            Return
        End If

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
                    CurrentResultLabel.Text = "Math Error!"
                    AdjustLabelFont(CurrentResultLabel)
                    CurrentResultLabel.Select()
                    Return
                End If
                result = firstNum / secondNum
            Case Else
                CurrentResultLabel.Select()
                Return
        End Select

        PreviousResultLabel.Text = $"{firstNum} {operation} {secondNum} ="
        AdjustLabelFont(PreviousResultLabel)
        CurrentResultLabel.Text = FormatWithCommas(result.ToString())
        AdjustLabelFont(CurrentResultLabel)

        operation = ""
        firstNum = result
        hasResult = True
        CurrentResultLabel.Select()
    End Sub


    ' ========= CLEAR (C) BUTTON =========
    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        PreviousResultLabel.Text = ""
        CurrentResultLabel.Text = ""
        AdjustLabelFont(CurrentResultLabel, True)
        AdjustLabelFont(PreviousResultLabel, True)


        firstNum = 0
        secondNum = 0
        operation = ""
        hasResult = False
        CurrentResultLabel.Select()
    End Sub

    ' ========= CLEAR ENTRY (CE) BUTTON =========
    Private Sub CeBtn_Click(sender As Object, e As EventArgs) Handles CeBtn.Click
        ' clears the current entry, not the entire calculation
        CurrentResultLabel.Text = ""
        hasResult = False
        CurrentResultLabel.Select()
    End Sub

    ' ========= BACKSPACE BUTTON =========
    Private Sub BackspaceBtn_Click(sender As Object, e As EventArgs) Handles BackspaceBtn.Click
        If Not hasResult AndAlso CurrentResultLabel.Text.Length > 0 Then
            CurrentResultLabel.Text = CurrentResultLabel.Text.Substring(0, CurrentResultLabel.Text.Length - 1)
            AdjustLabelFont(CurrentResultLabel)
        End If
        CurrentResultLabel.Select()
    End Sub

    ' ========= KEYBOARD INPUT =========
    Private Sub CalculatorForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim key As Char = e.KeyChar

        ' ===== DIGITS & DECIMAL =====
        If Char.IsDigit(key) OrElse key = "."c Then

            ' Prevent exceeding max length
            If CurrentResultLabel.Text.Length >= MaxLength Then
                e.Handled = True
                Return
            End If

            ' Decimal handling
            If key = "."c Then
                If CurrentResultLabel.Text.Contains(".") Then
                    e.Handled = True
                    Return
                End If

                If CurrentResultLabel.Text = "" Then
                    CurrentResultLabel.Text = "0"
                End If
            End If

            ' Append digit/decimal
            CurrentResultLabel.Text &= key

            ' Format with commas (strip commas first)
            CurrentResultLabel.Text = FormatWithCommas(CurrentResultLabel.Text.Replace(",", ""))

            AdjustLabelFont(CurrentResultLabel)

            e.Handled = True
            Return
        End If

        ' ===== OPERATORS =====
        Select Case key
            Case "+"c, "-"c, "*"c, "/"c
                Dim opBtn As New Button()

                Select Case key
                    Case "+"c : opBtn.Text = "+"
                    Case "-"c : opBtn.Text = "-"
                    Case "*"c : opBtn.Text = "x"   ' match MultiplyBtn
                    Case "/"c : opBtn.Text = "÷"   ' match DivideBtn
                End Select

                OperatorButton_Click(opBtn, EventArgs.Empty)
                e.Handled = True
                Return
        End Select

        ' ===== ENTER (=) =====
        If key = ChrW(Keys.Enter) OrElse key = "="c Then
            EqualBtn_Click(EqualBtn, EventArgs.Empty)
            e.Handled = True
            Return
        End If

        ' ===== BACKSPACE =====
        If key = ChrW(Keys.Back) Then
            BackspaceBtn_Click(BackspaceBtn, EventArgs.Empty)
            e.Handled = True
            Return
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

    ' ========= FONT AUTO-RESIZE =========
    Private Sub AdjustLabelFont(targetLabel As Label, Optional reset As Boolean = False)
        Dim baseFontSize As Single = 34 ' Default for CurrentResultLabel
        Dim minFontSize As Single = 12  ' Smallest allowed

        If targetLabel.Name = "PreviousResultLabel" Then
            baseFontSize = 22
            minFontSize = 11
        End If

        If reset OrElse String.IsNullOrEmpty(targetLabel.Text) Then
            targetLabel.Font = New Font(targetLabel.Font.FontFamily, baseFontSize, targetLabel.Font.Style)
            Return
        End If

        Dim currentLength As Integer = targetLabel.Text.Length
        Dim newFontSize As Single = baseFontSize

        If currentLength > 19 Then
            newFontSize = baseFontSize - ((currentLength - 19) * 2)
        End If

        ' Clamp font size between min and base
        If newFontSize < minFontSize Then
            newFontSize = minFontSize
        ElseIf newFontSize > baseFontSize Then
            newFontSize = baseFontSize
        End If

        targetLabel.Font = New Font(targetLabel.Font.FontFamily, newFontSize, targetLabel.Font.Style)
    End Sub


    '========= NUMBER FORMAT =========
    Private Function FormatWithCommas(input As String) As String
        ' Don’t format if empty or ends with a decimal point
        If String.IsNullOrEmpty(input) OrElse input.EndsWith(".") Then
            Return input
        End If

        Dim num As Double
        If Double.TryParse(input, num) Then
            ' Preserve decimals if any
            If input.Contains(".") Then
                Dim parts() As String = input.Split("."c)
                Dim intPart As Double
                If Double.TryParse(parts(0), intPart) Then
                    Return intPart.ToString("N0") & "." & parts(1)
                End If
            Else
                ' Whole numbers
                Return num.ToString("N0")
            End If
        End If

        Return input ' If parsing fails, just return original
    End Function

End Class
