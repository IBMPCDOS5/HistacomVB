Public Class Calculator
    Dim cAnswer, pAnswer As Integer ' cAnswer = Current Answer pAnswer = Previous answer
    Dim Calc As Integer ' Helps to calculate the number
    Dim hasFirst, hasOperation, IsInvalid As Boolean
    Dim calcOps As New List(Of String) ' Calculator operations - stores all the operations

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winman.setupwindow(Me, "Calculator", My.Resources.windows95calcualatorstartmenuicon)
    End Sub

    Sub calculate()
        Dim i As Integer
        Dim oldP As Integer
        Dim NLength As Integer
        Dim CNumber As Integer
        Dim OnOps As Integer
        Dim tmpI As Integer
        Dim isFirstRunThrough As Boolean = True ' This is so it treats the first number in a special way
        oldP = pAnswer
        pAnswer = cAnswer
        Do Until i >= (Cdisplay.Text.Length - 1)

            NLength = 0
            tmpI = i
            ' Checks how long the number is
            Try
                Do While i = i ' (Endlessly loop until the Exit Do)
                    If Not Asc(Cdisplay.Text.Chars(tmpI)) < 48 And Not Asc(Cdisplay.Text.Chars(tmpI)) > 57 Then
                        NLength += 1
                    Else
                        If Not Asc(Cdisplay.Text.Chars(tmpI)) = 40 Then 'If it isn't a '('
                            Exit Do
                        Else
                            i += 1
                        End If
                    End If
                    tmpI += 1
                Loop
            Catch ex As Exception
            End Try


            ' Depending on how big the number is it gets the number

            CNumber = Cdisplay.Text.Substring(i, NLength)
            i = i + NLength

            ' Checks the operation and applys it
            If calcOps.Count > OnOps And isFirstRunThrough = False Then
                Select Case calcOps(OnOps)
                    Case "+"
                        Calc += CNumber
                    Case "-"
                        Calc -= CNumber
                    Case "*"
                        Calc *= CNumber
                    Case "/"
                        Calc /= CNumber
                    Case Else
                        ' Failed to calculate
                        cAnswer = pAnswer
                        pAnswer = oldP
                End Select
                If isFirstRunThrough = False Then OnOps += 1
            End If
            If isFirstRunThrough = True Then
                Calc += CNumber
            End If
            i += 1
            tmpI += 1
            isFirstRunThrough = False
        Loop
        cAnswer = Calc
    End Sub

    Private Sub count_Tick(sender As Object, e As EventArgs) Handles count.Tick
        IsInvalid = False
        Cdisplay.Enabled = True
        Cdisplay.Text = "0"
        count.Stop()
    End Sub

    Private Sub btncl_Click(sender As Object, e As EventArgs) Handles btncl.Click

    End Sub

    Private Sub Cdisplay_TextChanged(sender As Object, e As EventArgs) Handles Cdisplay.TextChanged

    End Sub

    Sub invalid()
        IsInvalid = True
        Cdisplay.Enabled = False
        Cdisplay.Text = "Error"
        count.Start()
    End Sub

    Sub AddANumber(ByVal Number As Integer)
        If cAnswer <> 0 Then
            Cdisplay.Text = ""
        End If
        ClearCalc()
        Cdisplay.Text &= Number
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        AddANumber(sender.Text)
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        ClearCalc()
        Cdisplay.Text &= "+"
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        ClearCalc()
        Cdisplay.Text &= "-"
    End Sub

    Private Sub btnmul_Click(sender As Object, e As EventArgs) Handles btnmul.Click
        ClearCalc()
        Cdisplay.Text &= "*"
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        ClearCalc()
        Cdisplay.Text &= "/"
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        manvals()
        If Not IsInvalid Then calculate()
        Cdisplay.Text &= cAnswer
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub

    Sub manvals()
        Dim i As Integer
        Dim a As Boolean ' This is if the previous character was a symbol
        CDisplay.Text &= "="
        CDisplay.Text = CDisplay.Text.Replace("x", "*")
        CDisplay.Text = CDisplay.Text.Replace("X", "*")
        calcOps.Clear()

        Do Until i = CDisplay.Text.Length
            If i = 0 Then
                ' If it is the first character
                If Asc(CDisplay.Text.Chars(i)) < 48 Or Asc(CDisplay.Text.Chars(i)) > 57 Then
                    If Not Asc(CDisplay.Text.Chars(i)) = 40 Then 'If it isn't a '('
                        invalid()
                        Exit Sub
                    End If
                Else
                    hasFirst = True
                End If
            Else
                If Asc(CDisplay.Text.Chars(i)) = 42 Or Asc(CDisplay.Text.Chars(i)) = 43 Or Asc(CDisplay.Text.Chars(i)) = 45 Or Asc(CDisplay.Text.Chars(i)) = 47 Then
                    If a = False Then
                        a = True
                        calcOps.Add(CDisplay.Text.Chars(i).ToString)
                    Else
                        invalid()
                        Exit Sub
                    End If
                End If
                If Not Asc(CDisplay.Text.Chars(i)) < 48 And Not Asc(CDisplay.Text.Chars(i)) > 57 Then
                    a = False
                End If
            End If
            i += 1
        Loop
    End Sub

    Sub ClearCalc()
        cAnswer = 0
        Calc = 0
    End Sub

    Private Sub Cdisplay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cdisplay.KeyPress
        ClearCalc()
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Not Asc(e.KeyChar) = 40 And Not Asc(e.KeyChar) = 41 And Not Asc(e.KeyChar) = 42 And Not Asc(e.KeyChar) = 43 And Not Asc(e.KeyChar) = 45 And Not Asc(e.KeyChar) = 47 And Not Asc(e.KeyChar) = 88 And Not Asc(e.KeyChar) = 120 Then
                    ' This line above checks if you HAVE NOT pressed '(' or ')' or '*' or '+' or '-' or '/' or 'X' or 'x'
                    If Asc(e.KeyChar) = 61 Then
                        manvals()
                        If Not IsInvalid Then calculate()
                        Cdisplay.Text &= cAnswer
                    End If
                    e.Handled = True ' Does not allow you to type it
                End If
            Else
            End If
        End If
    End Sub
End Class