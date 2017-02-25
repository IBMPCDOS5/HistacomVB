Public Class Internetexplorer62002damaged
    Dim amount As Integer = 100
    Dim chosenx As Integer
    Dim choseny As Integer
    Dim desktopx As Integer
    Dim desktopy As Integer
    Dim yran As New Random
    Dim xran As New Random
    Dim white As Boolean = True

    Private Sub viruscountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelflash.Tick
        If white Then
            original.ForeColor = Color.Black
            white = False
        Else
            original.ForeColor = Color.White
            white = True
        End If
    End Sub

    Private Sub Internetexplorer62002damaged_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        labelflash.Start()
        amounttimer.Start()
        commandprompt.Close()
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        desktopy = Windowsxp2002damaged.desktopicons.Size.Height
        desktopx = Windowsxp2002damaged.desktopicons.Size.Width
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        choseny = yran.Next(1, desktopy)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        chosenx = xran.Next(1, desktopx)
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim newlabel As New _2002_virus_labels
        newlabel.Show()
        Label1.Text = chosenx
        Label2.Text = choseny
        newlabel.Location = New Point(Label1.Text, Label2.Text)
        newlabel.original.ForeColor = Color.Black
    End Sub

    Private Sub amounttimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amounttimer.Tick
        'If amount = 90 Then maximizebutton.Image = closebutton.Image
        'If amount = 89 Then minimizebutton.Image = closebutton.Image
        'If amount = 88 Then Button8.Image = closebutton.Image
        If amount = 87 Then Button13.Image = My.Resources.windowsxperror
        If amount = 86 Then Button12.Image = My.Resources.windowsxperror
        If amount = 85 Then Button11.Image = My.Resources.windowsxperror
        If amount = 84 Then Button10.Image = My.Resources.windowsxperror
        If amount = 83 Then Button7.Image = My.Resources.windowsxperror
        If amount = 82 Then Button9.Image = My.Resources.windowsxperror
        If amount = 81 Then Button6.Image = My.Resources.windowsxperror
        If amount = 80 Then Button5.Image = My.Resources.windowsxperror
        If amount = 79 Then Button4.Image = My.Resources.windowsxperror
        If amount = 78 Then Button3.Image = My.Resources.windowsxperror
        If amount = 77 Then Button2.Image = My.Resources.windowsxperror
        If amount = 76 Then Button1.Image = My.Resources.windowsxperror
        If amount = 75 Then Button6.Text = ""
        If amount = 74 Then Button9.Text = ""
        If amount = 73 Then Button1.Text = ""
        'If amount = 72 Then programname.ForeColor = Color.Red
        'If amount = 71 Then programname.Text = "Internet Exploiter 6"
        If amount = 70 Then
            'programname.Text = "Internet Exploiter 66"
            addressbar.BackColor = Color.Lime
        End If

        If amount = 69 Then
            addressbar.ForeColor = Color.Red
            'programname.Text = "Internet Exploiter 666"
        End If

        If amount = 68 Then Button8.BackColor = Color.Purple
        If amount = 67 Then
            adresss.Text = "Virus:"
            Button13.BackColor = Color.Lime
            adresss.ForeColor = Color.Red
        End If
        If amount = 66 Then
            Panel24.BackColor = Color.Black
            Button12.BackColor = Color.Lime
            Button13.BackColor = Color.Red
            Button13.Image = Nothing
        End If
        If amount = 65 Then
            Button13.Hide()
            Button12.BackColor = Color.Red
            Button12.Image = Nothing
            Button11.BackColor = Color.Lime
            Button8.Image = Nothing
        End If
        If amount = 64 Then
            Button12.Hide()
            Button11.BackColor = Color.Red
            Button11.Image = Nothing
            Button10.BackColor = Color.Lime
            Button8.BackColor = Color.Black
        End If
        If amount = 63 Then
            Button11.Hide()
            Button10.BackColor = Color.Red
            Button10.Image = Nothing
            Button7.BackColor = Color.Lime
            addressbar.BackColor = Color.Black
        End If
        If amount = 62 Then
            Button10.Hide()
            Button7.BackColor = Color.Red
            Button7.Image = Nothing
            Button9.BackColor = Color.Lime
            addressbar.BackColor = Color.Black
        End If
        If amount = 61 Then
            Button7.Hide()
            Button9.BackColor = Color.Red
            Button9.Image = Nothing
            Button6.BackColor = Color.Lime
            addressbar.ForeColor = Color.Black
        End If
        If amount = 60 Then
            Button9.Hide()
            Button6.BackColor = Color.Red
            Button6.Image = Nothing
            Button5.BackColor = Color.Lime
            adresss.BackColor = Color.Black
        End If
        If amount = 59 Then
            Button6.Hide()
            Button5.BackColor = Color.Red
            Button5.Image = Nothing
            Button4.BackColor = Color.Lime
            adresss.ForeColor = Color.Black
        End If
        If amount = 58 Then
            Button5.Hide()
            Button4.BackColor = Color.Red
            Button4.Image = Nothing
            Button3.BackColor = Color.Lime
            Panel24.Hide()
        End If
        If amount = 57 Then
            Button4.Hide()
            Button3.BackColor = Color.Red
            Button3.Image = Nothing
            Button2.BackColor = Color.Lime
            Panel13.BackColor = Color.Black
        End If
        If amount = 56 Then
            Button3.Hide()
            Button2.BackColor = Color.Red
            Button2.Image = Nothing
            Button1.BackColor = Color.Lime
            MenuStrip3.BackColor = Color.White
        End If
        If amount = 54 Then
            Button2.Hide()
            Button1.BackColor = Color.Red
            Button1.Image = Nothing
            MenuStrip3.BackColor = Color.Black
        End If
        If amount = 54 Then
            Button1.Hide()
            Panel13.Hide()
        End If
        If amount = 53 Then
            MenuStrip3.Hide()
        End If
        If amount = 52 Then
            'top.BackgroundImage = My.Resources.windowsxperror
            'toprightcorner.Hide()
            bottomrightcorner.Hide()
            'left.Hide()
            'Right.Hide()
            'Bottom.Hide()
            topleftcorner.Hide()
            bottomleftcorner.Hide()
            browsingarea.BackColor = Color.Black
        End If
        If amount = 51 Then
            browsingarea.BackColor = Color.White
        End If
        If amount = 50 Then
            Me.Hide()
        End If
        If amount = 49 Then
            Windowsxp2002damaged.desktopicons.BackgroundImage = My.Resources.windowsxperror
            Windowsxp2002damaged.desktopicons.BackgroundImageTiled = True
            Windowsxp2002damaged.BackgroundImage = Nothing
        End If
        If amount = 48 Then
            Windowsxp2002damaged.Label1.Show()
        End If
        If amount = 47 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.Black
            Windowsxp2002damaged.taskbartime.BackColor = Color.Red
        End If
        If amount = 46 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.White
            Windowsxp2002damaged.taskbartime.Text = "infected"
        End If
        If amount = 45 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.Black
            Windowsxp2002damaged.desktopicons.BackgroundImage = Nothing
            Windowsxp2002damaged.desktopicons.Hide()
        End If
        If amount = 44 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.White
            Windowsxp2002damaged.BackColor = Color.Black
        End If
        If amount = 43 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.Black
            Windowsxp2002damaged.startbutton.Image = My.Resources.windowsxpclosebutton
        End If
        If amount = 42 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.White
            Windowsxp2002damaged.startbutton.Image = Nothing
        End If
        If amount = 41 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.Black
            Windowsxp2002damaged.startbutton.BackColor = Color.White
        End If
        If amount = 40 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.White
            Windowsxp2002damaged.startbutton.BackColor = Color.Black
            Windowsxp2002damaged.taskbar.BackgroundImage = My.Resources.windowsxpclosebutton
        End If
        If amount = 39 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.Black
            Windowsxp2002damaged.taskbar.BackgroundImage = Nothing
            Windowsxp2002damaged.taskbar.BackColor = Color.White
            Windowsxp2002damaged.startbutton.Hide()
            Windowsxp2002damaged.taskbartime.Image = My.Resources.windowsxpclosebutton
        End If
        If amount = 38 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.White
            Windowsxp2002damaged.taskbar.BackColor = Color.Black
            Windowsxp2002damaged.Panel10.BackgroundImage = Nothing
            Windowsxp2002damaged.Panel10.BackColor = Color.White
        End If
        If amount = 37 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.Black
            Windowsxp2002damaged.Panel10.BackColor = Color.Black
            Windowsxp2002damaged.taskbartime.Hide()
        End If
        If amount = 36 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.White
            Windowsxp2002damaged.Label1.Text = "Welcome To a World Without computers!"
        End If
        If amount = 35 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.Black
        End If
        If amount = 34 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.White
        End If
        If amount = 33 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.Black
        End If
        If amount = 32 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.White
        End If
        If amount = 31 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.Black
        End If
        If amount = 30 Then
            Windowsxp2002damaged.Label1.ForeColor = Color.White
        End If
        If amount = 20 Then
            Title_Screen.Close()
        End If
        amount -= 1
    End Sub

End Class