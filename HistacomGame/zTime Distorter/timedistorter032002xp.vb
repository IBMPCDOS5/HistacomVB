Public Class timedistorter032002xp
    Dim timergo As Boolean
    Dim countdownnum As Integer
    Dim maximize As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim openerror As New createmsg
        openerror.infomessage.Text = "Time travel to this year is not completed in the current version of Histacom. bsdn98e5 is the save code for this bad 2002 year. I'll take you to a preview of 2001 but then reload the game back here and choose 2000 next time ;)"
        openerror.Show()
        Windowsxp2002damaged.Close()
        windows_me.Show()
        openerror.BringToFront()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        countdownnum = 60
        timergo = True
        Countdownlabel.Location = New Point(314, 52)
        countdown.Location = New Point(339, 75)
        Label2.Show()
        Button1.Hide()
        Button2.Hide()
        countdowntimer.Start()
    End Sub

    Private Sub countdowntimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countdowntimer.Tick
        countdownnum = countdownnum - 1
        If countdownnum = -10 Then
            Windows2000.Show()
            countdowntimer.Stop()
            time_travel_year_display.Hide()
            Windowsxp2002damaged.Close()
            Me.Close()
        End If
        If countdownnum = -9 Then
            time_travel_year_display.year.Show()
            commandprompt.Hide()
            Me.Hide()

        End If
        If countdownnum = -8 Then
            time_travel_year_display.year.Hide()
        End If
        If countdownnum = -7 Then
            time_travel_year_display.year.Text = "2000"
        End If
        If countdownnum = -6 Then
            time_travel_year_display.year.Text = "2001"
        End If
        If countdownnum = -2 Then
            time_travel_year_display.Show()
            time_travel_year_display.year.Text = "2002"
        End If
        If countdownnum = -1 Then
            Label2.Text = "Traveling"
            Countdownlabel.Text = "Year:"
            countdown.Text = "2002"
        End If
        If countdownnum = 1 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: good luck " & mainname & Environment.NewLine)
        End If
        If countdownnum = 5 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: and 2002 will no longer be a virus wasteland." & Environment.NewLine)
        End If
        If countdownnum = 9 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: We will be a team again" & Environment.NewLine)
        End If
        If countdownnum = 13 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: As soon as things are fixed in 2000 and 12padams sees you come back, he will not unlease the virus" & Environment.NewLine)
        End If
        If countdownnum = 18 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: Anyway don't worry about me... when you leave 2002 and go to 2000 to fix things up ill be ok" & Environment.NewLine)
        End If
        If countdownnum = 24 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: I am glad you choose 2000... I don't think you and I would have been able to tell this story to 12padams in 2001" & Environment.NewLine)
        End If
        If countdownnum = 29 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: So you are the only one with memory of this bad virus infected 2002" & Environment.NewLine)
        End If
        If countdownnum = 34 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: Remember when you get to 2000 the hidden hacker of that time will not know about the time travel stuffing up" & Environment.NewLine)
        End If
        If countdownnum = 40 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: ok since you are going to 2000 12padams will think his software worked without fail and you went 1998 -> 1999 -> 2000" & Environment.NewLine)
        End If
        If countdownnum = 44 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: Your travel from 1999 ->2000 stuffed up and took you here instead..." & Environment.NewLine)
        End If
        If countdownnum = 49 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: For you your experience has gone like this: 1998 -> 1999 -> 2002 and then 2000 in less then a minute" & Environment.NewLine)
        End If
        If countdownnum = 54 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: This means that you will have to pretend you never met me here." & Environment.NewLine)
        End If
        If countdownnum = 59 Then
            countdown.Text = countdownnum
            commandprompt.TextBox1.Text = commandprompt.TextBox1.Text + ("The Hidden Hacker: Ok... you chose the year 2000." & Environment.NewLine)
        End If
        If timergo Then
            countdown.Text = countdownnum
        End If

        commandprompt.TextBox1.SelectionStart = 999999
        commandprompt.TextBox1.ScrollToCaret()
    End Sub

    Private Sub timedistorter032002xp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winman.setupwindow(Me, "Time distorter", My.Resources.Time_Distorter_icon)
    End Sub
End Class