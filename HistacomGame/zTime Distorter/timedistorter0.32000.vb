Public Class timedistorter0
    Dim timergo As Boolean
    Dim countdownnum As Integer
    Dim maximize As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        countdownnum = 60
        timergo = True
        Countdownlabel.Location = New Point(312, 34)
        countdown.Location = New Point(337, 52)
        Label2.Show()
        Button1.Hide()
        Button2.Hide()
        countdowntimer.Start()
        waitfor02download = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim openerror As New createmsg
        openerror.infomessage.Text = "You are already in the year 2000"
        openerror.Show()
    End Sub

    Private Sub countdowntimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countdowntimer.Tick
        countdownnum = countdownnum - 1
        If countdownnum = -10 Then
            windows_me.Show()
            countdowntimer.Stop()
            time_travel_year_display.Hide()
            windows_me.BringToFront()
            Me.Close()
        End If
        If countdownnum = -9 Then
            time_travel_year_display.year.Show()
            Me.Hide()

        End If
        If countdownnum = -8 Then
            time_travel_year_display.year.Hide()
        End If
        If countdownnum = -6 Then
            time_travel_year_display.year.Text = "2001"
        End If
        If countdownnum = -2 Then
            time_travel_year_display.Show()
            time_travel_year_display.year.Text = "2000"
        End If
        If countdownnum = -1 Then
            Label2.Text = "Traveling"
            Countdownlabel.Text = "Year:"
            countdown.Text = "2002"
        End If
        If countdownnum = 59 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: Ok... you chose the year 2000." & Environment.NewLine)
        End If
        If timergo = True Then
            countdown.Text = countdownnum
        End If

        commandprompt.TextBox1.SelectionStart = 999999
        commandprompt.TextBox1.ScrollToCaret()
    End Sub

    Private Sub timedistorter0_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winman.setupwindow(Me, "Time distorter", My.Resources.Time_Distorter_icon)
    End Sub
End Class