Public Class internet_explorer_5
    Dim chistory As Integer
    Dim history(99) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not chistory <= 1 Then
            GoToPage(history(chistory - 1), True)
            chistory -= 1
        Else
            GameMain.OpenMsg("You cannot go any further backward")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim historyCount As Integer = 0
        i = 0
        Do Until i = history.Count
            If history(i) <> "" Then
                historyCount += 1
            End If
            i += 1
        Loop
        If Not chistory >= historyCount Then
            GoToPage(history(chistory + 1), True)
            chistory += 1
        Else
            GameMain.OpenMsg("You cannot go any further forward")
        End If
    End Sub

    Private Sub internet_explorer_5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        history(1) = "www.microsoft.com/internetexplorer4/welcome"
        chistory = 1
        winman.setupwindow(Me, "Internet Explorer 5", My.Resources.start_run)
        'programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
        removewebsites()
        welcomeinternetscreen.Show()
        welcomeinternetscreen.Dock = DockStyle.Fill
        look.Start()
    End Sub

    Sub GoToPage(ByVal page As String, ByVal fromBack As Boolean)
        If fromBack = False Then
            Dim i As Integer
            If chistory >= 99 Then chistory = 80
            i = chistory + 1
            Do Until i = history.Count
                history(i) = Nothing
                i += 1
            Loop
            Dim historyCount As Integer = 0
            i = 0
            Do Until i = history.Count
                If history(i) <> "" Then
                    historyCount += 1
                End If
                i += 1
            Loop
            chistory = historyCount
            history(chistory + 1) = page
            chistory += 1
        End If
        removewebsites()
        padamsbackground.Dock = DockStyle.None
        hotmailmain.Dock = DockStyle.None
        padamsmain.Dock = DockStyle.None
        googlemain.Dock = DockStyle.None
        googlemain.Dock = DockStyle.None
        welcomeinternetscreen.Dock = DockStyle.None

        Select Case addressbar.Text
            Case "www.google.com"
                googlemain.Dock = DockStyle.Fill
                googlemain.Show()
            Case "www.microsoft.com/internetexplorer5/welcome"
                welcomeinternetscreen.Dock = DockStyle.Fill
                welcomeinternetscreen.Show()
            Case "www.12padams.com"
                padamsmain.Dock = DockStyle.Fill
                padamsmain.Show()
            Case "www.hotmail.com"
                hotmailmain.Dock = DockStyle.Fill
                hotmailmain.Show()
            Case "www.12padams.com/background"
                padamsbackground.Dock = DockStyle.Fill
                padamsbackground.Show()
            Case "www.12padams.com/skindows"
                skindows98advertisment.Dock = DockStyle.Fill
                skindows98advertisment.Show()
            Case "www.12padams.com/y2k"
                padamsNewsstorys.Dock = DockStyle.Fill
                padamsNewsstorys.Show()
            Case "www.12padams.com/microsoftwindowshistory"
                padamscomputerhistorymicrosoft.Dock = DockStyle.Fill
                padamscomputerhistorymicrosoft.Show()
        End Select
    End Sub


    Private Sub googlebetalink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        removewebsites()
        googlemain.Dock = DockStyle.Fill
        googlemain.Show()
        addressbar.Text = "www.alpha.google.com"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        removewebsites()
        addressbar.Text = "www.microsoft.com/internetexplorer5/welcome"
        welcomeinternetscreen.Dock = DockStyle.Fill
        welcomeinternetscreen.Show()
    End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        removewebsites()
        addressbar.Text = "www.google.com"
        googlemain.Dock = DockStyle.Fill
        googlemain.Show()
    End Sub

    Private Sub LinkLabel16_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If Not GameMain.guessInstalled Then
            GameMain.OpenInstaller("guessNum", My.Resources.guess_the_number_one, AppsLicense.normalLicense, "Guess The Number v2", 20)
        Else
            GameMain.OpenMsg("You already have Guess The Number Installed!")
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        GameMain.OpenInstaller("guessNum", My.Resources.Guess_the_Number__install_, AppsLicense.normalLicense, "Guess The Number V2", 100)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not GameMain.startRInstalled Then
            GameMain.OpenInstaller("startR", My.Resources.start_run__install___white_with_programname_, AppsLicense.normalLicense, "Start Runner", 60)
        Else
            GameMain.OpenMsg("You already have Start Runner Installed!")
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        previewimage.Image = My.Resources.windows_95_background
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        previewimage.Image = My.Resources.mclaren_f1
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Windows98.BackgroundImage = My.Resources.windows_95_background
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Windows98.BackgroundImage = My.Resources.mclaren_f1
    End Sub

    Private Sub LinkLabel17_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        removewebsites()
        addressbar.Text = "www.hotmail.com"
        hotmailmain.Dock = DockStyle.Fill
        hotmailmain.Show()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        removewebsites()
        addressbar.Text = "www.12padams.com/backgrounds"
        padamsbackground.Dock = DockStyle.Fill
        padamsbackground.Show()
    End Sub
    Private Sub removewebsites()
        googlemain.Hide()
        welcomeinternetscreen.Hide()
        googlemain.Hide()
        padamsmain.Hide()
        hotmailmain.Hide()
        padamsbackground.Hide()
        padamsbackground.Hide()
        skindows98advertisment.Hide()
        padamshidden.Hide()
        email1.Hide()
        email2.Hide()
        email3.Hide()
        hotmailpadams.Hide()
        padamsNewsstorys.Hide()
        padamscomputerhistorymicrosoft.Hide()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        removewebsites()
        addressbar.Text = "www.12padams.com/skindows"
        skindows98advertisment.Dock = DockStyle.Fill
        skindows98advertisment.Show()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If Not GameMain.webChatInstalled Then
            GameMain.OpenInstaller("webChat", My.Resources.chat_big, AppsLicense.normalLicense, "Web Chat 1999", 150)
        Else
            GameMain.OpenMsg("The application Web Chat 1999 is already installed!")
        End If
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        removewebsites()
        addressbar.Text = "www.12padams.com/???"
        padamshidden.Dock = DockStyle.Fill
        padamshidden.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtloginname.Text = "12padams@hotmail.com" And txtpassword.Text = "projectdeath" Then
            removewebsites()
            addressbar.Text = "www.hotmail.com/seculink/145624987903246EGS4HFO954325UPWEM5N8BSSA5634S"
            hotmailpadams.Show()
            hotmailpadams.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "12padams.com datalog 1998" Then
            email1.Show()
            email2.Hide()
            email3.Hide()
        End If
        If ListBox1.SelectedItem = "What's the secret to your website?" Then
            email1.Hide()
            email2.Hide()
            email3.Show()
        End If
        If ListBox1.SelectedItem = "RE: What's the secrect to your website?" Then
            email1.Hide()
            email3.Hide()
            email2.Show()
        End If

    End Sub

    Private Sub LinkLabel18_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        Dim opendownload As New downloader
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: hwcv.exe"
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opendownload As New downloader
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Time Distorter"
    End Sub

    Private Sub LinkLabel20_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel20.LinkClicked
        removewebsites()
        addressbar.Text = "www.12padams.com/y2k"
        padamsNewsstorys.Dock = DockStyle.Fill
        padamsNewsstorys.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub LinkLabel19_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel19.LinkClicked
        removewebsites()
        addressbar.Text = "www.12padams.com/microsoftwindowshistory"
        padamscomputerhistorymicrosoft.Dock = DockStyle.Fill
        padamscomputerhistorymicrosoft.Show()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        removewebsites()
        addressbar.Text = "www.12padams.com"
        padamsmain.Dock = DockStyle.Fill
        padamsmain.Show()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        previewimage.Image = My.Resources.windows_98_background
    End Sub

    Private Sub Button26_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        previewimage.Image = My.Resources.sky
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Windows98.desktopicons.BackgroundImage = My.Resources.windows_98_background
        Dim w, h As Integer
        w = Windows98.desktopicons.Width
        h = Windows98.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Windows98.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Windows98.BackgroundImage = bmp
        Windows98.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Windows98.desktopicons.BackgroundImage = My.Resources.sky
        Dim w, h As Integer
        w = Windows98.desktopicons.Width
        h = Windows98.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Windows98.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Windows98.BackgroundImage = bmp
        Windows98.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GoToPage(addressbar.Text, False)
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        GameMain.OpenMsg("WELL DONE! YOU JUST FOUND AN EASTER EGG!")
        GameMain.OpenMsg("Send a picture of this to the discord!")
    End Sub
End Class