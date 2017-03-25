Public Class time_distorter_0
    Dim count As Integer
    Dim year As Integer
    Dim maximize As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        waitfor02download = False
        Label3.Show()
        If Label3.Text = "Preparing travel: 180 Seconds" Then
            countdown.Start()
            count2000 = 180
            Button1.Hide()
        End If

    End Sub

    Private Sub labelcurrentyear_Click(sender As Object, e As EventArgs) Handles labelcurrentyear.Click

    End Sub

    Private Sub countdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countdown.Tick
        If count = 145 Then
            WebChat_1999.history.Text = WebChat_1999.history.Text + ("12padams: The most important thing now is preparing for when " & mainname & " gets to the year 2000" & Environment.NewLine)
        End If
        If count = 149 Then
            WebChat_1999.history.Text = WebChat_1999.history.Text + ("12padams: Now we have to stop chatting about who gets to do what now " & Environment.NewLine)
        End If
        If count = 153 Then
            WebChat_1999.history.Text = WebChat_1999.history.Text + ("The Hidden Hacker: Hmm I would prefere to be me then..." & Environment.NewLine)
        End If
        If count = 157 Then
            WebChat_1999.history.Text = WebChat_1999.history.Text + ("12padams: Well accually " & mainname & " will need to go back to 1998 after experiencing all the future tech so..." & Environment.NewLine)
        End If
        If count = 161 Then
            WebChat_1999.history.Text = WebChat_1999.history.Text + ("The Hidden Hacker: Ok... " & mainname & " you should feel happy that you don't have to wait a whole year for results " & Environment.NewLine)
        End If
        If count = 166 Then
            WebChat_1999.history.Text = WebChat_1999.history.Text + ("12padams: Hey hidden hacker... if your doing tests like this they take time... just be patient " & Environment.NewLine)
        End If
        If count = 171 Then
            WebChat_1999.history.Text = WebChat_1999.history.Text + ("The Hidden Hacker: Oh great not another whole year :( " & Environment.NewLine)
        End If
        If count = 174 Then
            WebChat_1999.history.Text = WebChat_1999.history.Text + ("12padams: your wrong... 3 minutes for " & mainname & " and 1 year for us..." & Environment.NewLine)
        End If
        If count = 178 Then
            WebChat_1999.history.Text = WebChat_1999.history.Text + ("The Hidden Hacker: Hmm 3 minutes and we get to see the results to this test " & Environment.NewLine)
        End If
        count2000 = count2000 - 1
        Label3.Text = "Preparing travel: " & count2000 & " Seconds"

        If count2000 = 0 Then

            Label3.Hide()
        End If


        If count2000 = -1 Then

            Label2.Hide()

        End If

        If count2000 = -2 Then Label1.Hide()
        If count2000 = -3 Then

            countdown.Interval = 200
            Windows98.startbutton.Hide()
        End If

        If count2000 = -4 Then Windows98.desktopicons.Hide()
        If count2000 = -5 Then Windows98.taskbar.Hide()
        If count2000 = -6 Then Me.Location = New Point(400, 600)
        If count2000 = -7 Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If
        'If count2000 = -8 Then Me.programtopbar.Hide()
        'If count2000 = -9 Then Windows98.Hide()
        'If count2000 = -10 Then Top.Hide()
        'If count2000 = -11 Then Left.Hide()
        'If count2000 = -12 Then Bottom.Hide()
        'If count2000 = -13 Then Right.Hide()
        If count2000 = -14 Then
            toprightcorner.Hide()
            bottomleftcorner.Hide()
            bottomrightcorner.Hide()
            topleftcorner.Hide()
        End If
        If count2000 = -15 Then
            program.BackColor = Color.Black
            labelcurrentyear.ForeColor = Color.Lime
        End If
        If count2000 = -16 Then
            labelcurrentyear.Text = "1999"
            countdown.Interval = 100
        End If
        If count2000 = -17 Then
            labelcurrentyear.Text = "1999"
        End If
        If count2000 = -18 Then
            labelcurrentyear.Text = "1999"
        End If
        If count2000 = -19 Then
            labelcurrentyear.Text = "1999"
        End If
        If count2000 = -20 Then
            labelcurrentyear.Text = "1999"
        End If
        If count2000 = -21 Then
            labelcurrentyear.Text = "1999"
        End If
        If count2000 = -22 Then
            labelcurrentyear.Text = "1999"
        End If
        If count2000 = -23 Then
            labelcurrentyear.Text = "2000"
        End If
        If count2000 = -24 Then
            labelcurrentyear.Text = "2000"
        End If
        If count2000 = -25 Then
            labelcurrentyear.Text = "2000"
        End If
        If count2000 = -26 Then
            labelcurrentyear.Text = "1900"
        End If
        If count2000 = -27 Then
            labelcurrentyear.Hide()
        End If
        If count2000 = -28 Then
            labelcurrentyear.Show()
        End If
        If count2000 = -29 Then
            labelcurrentyear.Text = "2000"
        End If
        If count2000 = -30 Then
            labelcurrentyear.Text = "1900"
            year = labelcurrentyear.Text
        End If
        If count2000 < -30 And count2000 > -130 Then
            countdown.Interval = 80
            year = year + 1
            labelcurrentyear.Text = year
        End If
        If count2000 = -131 Then labelcurrentyear.Hide()
        If count2000 = -132 Then labelcurrentyear.Show()
        If count2000 = -133 Then labelcurrentyear.Hide()
        If count2000 = -134 Then labelcurrentyear.Show()
        If count2000 = -135 Then
            labelcurrentyear.Text = "2000"
        End If
        If count2000 = -136 Then labelcurrentyear.Hide()
        If count2000 = -137 Then labelcurrentyear.Show()
        If count2000 = -138 Then labelcurrentyear.Hide()
        If count2000 = -139 Then labelcurrentyear.Show()
        If count2000 = -140 Then labelcurrentyear.Text = "2001"
        If count2000 = -141 Then labelcurrentyear.Hide()
        If count2000 = -142 Then labelcurrentyear.Show()
        If count2000 = -143 Then labelcurrentyear.Hide()
        If count2000 = -144 Then labelcurrentyear.Show()
        If count2000 = -145 Then labelcurrentyear.Text = "2002"
        If count2000 = -146 Then labelcurrentyear.Hide()
        If count2000 = -147 Then labelcurrentyear.Show()
        If count2000 = -148 Then labelcurrentyear.Hide()
        If count2000 = -149 Then labelcurrentyear.Show()
        If count2000 = -169 Then Windowsxp2002damaged.Show()
        If count2000 = -170 Then Me.Hide()
    End Sub

    Private Sub time_distorter_0_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        winman.setupwindow(Me, "Time distorter", My.Resources.Time_Distorter_icon)
        Label3.Hide()
    End Sub
End Class