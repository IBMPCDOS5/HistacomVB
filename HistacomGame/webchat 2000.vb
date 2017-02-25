Public Class webchat_2000
    Dim waiting As Boolean = False
    Dim waiting2 As Boolean = False
    Dim con As Integer = 1
    Dim ran As New Random
    Dim username As String
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        Me.Close()
    End Sub

    Private Sub me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        look.Start()
        Button5.Hide()
        Label5.Hide()
        ListBox1.Items.Add("12padams")
        ListBox1.Items.Add("The Hidden Hacker")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        username = txtscreenname.Text
        login.Hide()
        Chat.Start()
        ListBox1.Items.Add(username)
        history.Text += (username & " Has Logged On" & Environment.NewLine)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If waiting = True Then
            If typechat.Text = "star" Then
                Chat.Start()
                con = con + 1
                history.Text += (username & ": " & typechat.Text & Environment.NewLine)
                typechat.Text = ""
                history.Focus()
                history.SelectionStart = 999999
                history.ScrollToCaret()
                typechat.Focus()
                waiting = False
            Else
                history.Text += (username & ": " & typechat.Text & Environment.NewLine)
                history.Text += ("12padams: sorry that was the wrong password... remember that you should only type the 4 letter password and nothing else." & Environment.NewLine)
                typechat.Text = ""
                history.Focus()
                history.SelectionStart = 999999
                history.ScrollToCaret()
                typechat.Focus()
            End If
            
        Else
            history.Text += (username & ": " & typechat.Text & Environment.NewLine)
            typechat.Text = ""
            typechat.Focus()
            history.SelectionStart = 999999
            history.ScrollToCaret()
        End If

    End Sub

    Private Sub Chat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chat.Tick
    	Select Case con
	        Case 34
	            Me.Close()
	            Chat.Interval = 2000
	        Case 33
	            history.Text += ("12padams: Close any open programs now!!!" & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 32
	            history.Text += ("12padams: And I will close this chat... its not good to have open programs while time traveling" & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 31
	            history.Text += ("12padams: Bye " & mainname & " and Hidden Hacker. Ill see you in the FUTURE!!!" & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 30
	            history.Text += ("The Hidden Hacker: Ok bye 12padams and thanks for letting me time travel this time." & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 29
	            history.Text += ("12padams: Yep Its all fixed and time travel is a lot smoother... anyway see ya" & Environment.NewLine)
	            Chat.Interval = 7000
	        Case 28
	            history.Text += ("The Hidden Hacker: So that wont happen anymore?" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 27
	            history.Text += ("12padams: Basically the time distorter program may have made things flash which currupted a few files" & Environment.NewLine)
	            Chat.Interval = 8000
	        Case 26
	            history.Text += ("The Hidden Hacker: What do you mean time holes?" & Environment.NewLine)
	            Chat.Interval = 7000
	        Case 25
	            history.Text += ("12padams: I should mention that time distorter used to cause a few time holes" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 24
	            history.Text += ("12padams: Good and " & mainname & "'s timer is counting down too" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 23
	            history.Text += ("The Hidden Hacker: Ok my Time Distorter has started the countdown" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 22
	            Label5.Show()
	            Button5.Show()
	            Chat.Interval = 2000
	            Chat.Stop()
	            waitingdownload.Start()
	            con -= 1
	        Case 21
	            history.Text += ("12padams: Ok then ill send " & mainname & " the new version of time distorter then you can both go off on your journey" & Environment.NewLine)
	            Chat.Interval = 4000
	            waitfor02download = True
	        Case 20
	            history.Text += ("12padams: So ready to get started?" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 19
	            history.Text += ("12padams: I just need to make sure that when 2 people both time travel at the same time nothing goes wrong" & Environment.NewLine)
	            Chat.Interval = 7000
	        Case 18
	            history.Text += ("12padams: Thats corrent yes... " & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 17
	            history.Text += ("The Hidden Hacker: you mean 2 people at once... me and " & mainname & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 16
	            history.Text += ("12padams: Today we are going to be doing our first multi time travel test" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 15
	            history.Text += ("The Hidden Hacker: Sorry got a bit to excited... go ahead 12padams and explain it :)" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 14
	            history.Text += ("12padams: Ok Hidden Hacker I am glad your happy but lets accually start talking about what the aim of this time travel is..." & Environment.NewLine)
	            Chat.Interval = 9000
	        Case 13
	            history.Text += ("The Hidden Hacker: I get to time travel with you " & mainname & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 12
	            history.Text += ("The Hidden Hacker: Now I dont have to wait at all!!!" & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 11
	            history.Text += ("The Hidden Hacker: " & mainname & " you dont understand how boring it is to wait a whole year for you to return..." & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 10
	            history.Text += ("The Hidden Hacker: YAAY OMG I AM SO EXCITED!!!!" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 9
	            history.Text += ("12padams: Yes you do." & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 8
	            history.Text += ("The Hidden Hacker: Now do we get to time travel" & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 7
	            history.Text += ("12padams: ok good that was the password." & Environment.NewLine)
	            Chat.Interval = 5000
	        Case 6
	            waiting = True
	            Chat.Stop()
	        Case 5
	            history.Text += ("12padams: Just say the 4 letter password without anything else." & Environment.NewLine)
	            Chat.Interval = 1000
	        Case 4
	            history.Text += ("12padams: wait a minute... " & mainname & " tell me the password you were given at the end of survive the day." & Environment.NewLine)
	            Chat.Interval = 3000
	        Case 3
	            history.Text += ("The Hidden Hacker: Ok lets time travel now!!!" & Environment.NewLine)
	            Chat.Interval = 6000
	        Case 2
	            history.Text += ("12padams: Oh hi " & mainname & " its good to see you again." & Environment.NewLine)
	            Chat.Interval = 4000
	        Case 1
	            history.Text += ("The Hidden Hacker: YESSSS!!! " & mainname & " has finally come on!!!" & Environment.NewLine)
	            Chat.Interval = 5000
		End Select
		con += 1
        history.Focus()
        history.SelectionStart = 999999
        history.ScrollToCaret()
        typechat.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim opendownload As New downloader2000
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Time Distorter 0.3"
    End Sub
    Dim moveable As Boolean = True
    Dim mexlocation, meylocation As Integer
    Dim mewidth, meheight As Integer
    Dim maximize As Boolean

    Private Sub programtopbar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles programtopbar.MouseDown
        If moveable Then
            If e.Button = MouseButtons.Left Then
                programtopbar.Capture = False
                Const WM_NCLBUTTONDOWN As Integer = &HA1S
                Const HTCAPTION As Integer = 2
                Dim msg As Message = _
                    Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                        New IntPtr(HTCAPTION), IntPtr.Zero)
                Me.DefWndProc(msg)
            End If
        End If
    End Sub

    Private Sub pullside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullside.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
    End Sub

    Private Sub pullbottom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullbottom.Tick
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub pullbs_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pullbs.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub Rightpull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles right.MouseDown
        pullside.Start()
    End Sub

    Private Sub rightpull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles right.MouseUp
        pullside.Stop()
    End Sub

    Private Sub bottompull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottom.MouseDown
        pullbottom.Start()
    End Sub

    Private Sub buttompull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottom.MouseUp
        pullbottom.Stop()
    End Sub

    Private Sub bspull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseDown
        pullbs.Start()
    End Sub

    Private Sub bspull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseUp
        pullbs.Stop()
    End Sub

    Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximizebutton.Click
        If maximize = False Then
            meylocation = Windows2000.desktopicons.Height - Me.Height
            mexlocation = Windows2000.desktopicons.Width - Me.Width
            mewidth = Me.Width
            meheight = Me.Height
            toprightcorner.Hide()
            topleftcorner.Hide()
            bottomrightcorner.Hide()
            bottomleftcorner.Hide()
            left.Hide()
            top.Hide()
            bottom.Hide()
            right.Hide()
            Dim w, h As Integer
            w = Windows2000.desktopicons.Width
            h = Windows2000.desktopicons.Height
            Me.Location = New Point(0, 0)
            Me.Size = New Size(w, h)
            moveable = False
            maximizebutton.Image = My.Resources.unmaximizebutton
            maximize = True
        Else
            toprightcorner.Show()
            topleftcorner.Show()
            bottomrightcorner.Show()
            bottomleftcorner.Show()
            left.Show()
            top.Show()
            bottom.Show()
            right.Show()
            Me.Location = New Point(mexlocation, meylocation)
            Me.Size = New Size(mewidth, meheight)
            moveable = True
            maximizebutton.Image = My.Resources.Maximize
            maximize = False
        End If
    End Sub

    Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
        Me.programtopbar.BackColor = Windows2000.exampleprogramtopbar.BackColor
        Me.programtopbar.BackgroundImage = Windows2000.exampleprogramtopbar.BackgroundImage
        Me.programname.BackColor = Windows2000.exampleprogramtext.BackColor
    End Sub

    Private Sub waitingdownload_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waitingdownload.Tick
        If Not waitfor02download Then
            Chat.Start()
            waitingdownload.Stop()
            con += 1
        End If

    End Sub

End Class