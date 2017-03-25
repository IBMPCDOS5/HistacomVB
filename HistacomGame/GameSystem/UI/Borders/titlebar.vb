Public Class titlebar
    Dim moveable As Boolean = True
    Dim DoMove As Boolean
    Dim oldmpos As Point
    Private Sub titlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If moveable Then
            DoMove = True
            oldmpos = New Point(-e.X, -e.Y)
        End If
    End Sub

    Private Sub btnmax_Click(sender As Object, e As EventArgs) Handles btnmax.Click
        If Not FindForm.WindowState = FormWindowState.Maximized Then
            FindForm.WindowState = FormWindowState.Maximized
            moveable = False
            btnmax.Image = My.Resources.unmaximizebutton
        Else
            FindForm.WindowState = FormWindowState.Normal
            moveable = True
            btnmax.Image = My.Resources.Maximize
        End If
    End Sub

    Private Sub titlebar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case GameMain.OS
            Case 1 ' Windows 95
                Me.BackColor = Windows95.titlebarcol.BackColor
                Me.BackgroundImage = Windows95.titlebarcol.BackgroundImage
            Case 2 ' Windows 98
                Me.BackColor = Color.DarkBlue
            Case 3 ' Windows XP
                Me.BackColor = Color.Transparent
                Me.BackgroundImage = My.Resources.windowsxptopbarmiddle
                Panel1.Hide()
            Case 4 ' Windows 2000
                Me.BackColor = Color.Transparent
                Me.BackgroundImage = My.Resources.windows2000gradient
        End Select
    End Sub

    Private Sub titlebar_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        DoMove = False
    End Sub

    Private Sub titlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If DoMove = True Then
            Dim nowmpos As Point
            nowmpos = Control.MousePosition
            nowmpos.Offset(oldmpos.X, oldmpos.Y)
            FindForm.Location = nowmpos
        End If
    End Sub

    Private Sub look_Tick(sender As Object, e As EventArgs) Handles look.Tick
        If GameMain.OS = 1 Then
            Me.BackColor = Windows95.titlebarcol.BackColor
            Me.BackgroundImage = Windows95.titlebarcol.BackgroundImage
            Me.BackColor = Windows95.titlebarcol.BackColor
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        FindForm.Close()
    End Sub
End Class
