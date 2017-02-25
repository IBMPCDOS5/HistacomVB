Public Class internet_explorer_4
    Dim chistory As Integer
    Dim history(99) As String
    Dim currentpage As String

    Private Sub internet_explorer_5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        history(1) = "www.microsoft.com/internetexplorer4/welcome"
        chistory = 1
        winman.setupwindow(Me, "Internet Explorer 4", My.Resources.windows95internetexplorerstartmenuicon)
        removewebsites()
        welcomeinternetscreen.Show()
        welcomeinternetscreen.Dock = DockStyle.Fill
        If close_everything_.timesoftware = "yes" Then
            Label57.Show()
            Button26.Show()
        Else
            Button26.Hide()
            Label57.Hide()
        End If
    End Sub

    Sub GoToPage(ByVal page As String, Optional special As Boolean = False, Optional fromBack As Boolean = False)
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
        padamsbackgrounds.Dock = DockStyle.None
        hotmailmain.Dock = DockStyle.None
        padamsmain.Dock = DockStyle.None
        googlealpha.Dock = DockStyle.None
        googlemain.Dock = DockStyle.None
        googleprototype.Dock = DockStyle.None
        welcomeinternetscreen.Dock = DockStyle.None
        addressbar.Text = page

        Select Case page
            Case "www.google.com"
                googlemain.Dock = DockStyle.Fill
                googlemain.Show()
            Case "www.microsoft.com/internetexplorer4/welcome"
                welcomeinternetscreen.Dock = DockStyle.Fill
                welcomeinternetscreen.Show()
            Case "www.google.stanford.edu"
                googleprototype.Dock = DockStyle.Fill
                googleprototype.Show()
            Case "www.alpha.google.com"
                googlealpha.Dock = DockStyle.Fill
                googlealpha.Show()
            Case "www.12padams.com"
                padamsmain.Dock = DockStyle.Fill
                padamsmain.Show()
            Case "www.hotmail.com"
                hotmailmain.Dock = DockStyle.Fill
                hotmailmain.Show()
            Case "www.12padams.com/backgrounds"
                padamsbackgrounds.Dock = DockStyle.Fill
                padamsbackgrounds.Show()
            Case "www.12padams.com/skindows"
                skindows95advertisment.Dock = DockStyle.Fill
                skindows95advertisment.Show()
            Case "www.12padams.com/???"
                GameMain.OpenMsg("NOTE TO 12PADAMS:" & vbCrLf & "Use the hidden link on my website to access this page")
                addressbar.Text = "www.12padams.com"
                padamsmain.Dock = DockStyle.Fill
                padamsmain.Show()
            Case "www.hotmail.com/seculink/145624987903246EGS4HFO954325UPWEM5N8BSSA5634S"
                If special = False Then
                    GameMain.OpenMsg("For security reasons please login normally")
                    addressbar.Text = "www.12padams.com"
                    hotmailmain.Dock = DockStyle.Fill
                    hotmailmain.Show()
                Else
                    hotmailpadams.Dock = DockStyle.Fill
                    hotmailpadams.Show()
                End If

            Case "www.???.com"
                secretwebsite.Dock = DockStyle.Fill
                secretwebsite.Show()
        End Select
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        GoToPage(addressbar.Text)
    End Sub

    Private Sub googleprototypelink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles googleprototypelink.LinkClicked

    End Sub


    Private Sub googlebetalink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles googlebetalink.LinkClicked
        GoToPage("www.alpha.google.com")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Array.Clear(history, 0, history.Length)
        GoToPage("www.microsoft.com/internetexplorer4/welcome")
    End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        GoToPage("www.google.com")
    End Sub

    Private Sub LinkLabel16_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        GoToPage("www.12padams.com")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If Not GameMain.guessInstalled Then
            GameMain.OpenInstaller("guessNum", My.Resources.guess_the_number_one, AppsLicense.normalLicense, "Guess The Number", 20)
        Else
            GameMain.OpenMsg("You already have Guess The Number Installed!")
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If Not GameMain.startRInstalled Then
            GameMain.OpenInstaller("startR", My.Resources.start_run__install___white_with_programname_, AppsLicense.normalLicense, "Start Runner", 60)
        Else
            GameMain.OpenMsg("You already have Start Runner Installed!")
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim opendownload As New downloader
        opendownload.Show()
        opendownload.Label2.Text = "Downloading: Error Blaster"
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Previewimage.Image = win95background.Image
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Previewimage.Image = mclarinflimage.Image
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Windows95.desktopicons.BackgroundImage = win95background.Image
        Dim w, h As Integer
        w = Windows95.desktopicons.Width
        h = Windows95.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Windows95.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Windows95.BackgroundImage = bmp
        Windows95.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Windows95.desktopicons.BackgroundImage = mclarinflimage.Image
        Dim w, h As Integer
        w = Windows95.desktopicons.Width
        h = Windows95.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Windows95.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Windows95.BackgroundImage = bmp
        Windows95.desktopicons.BackgroundImage = bmp
    End Sub

    Private Sub LinkLabel17_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        GoToPage("www.hotmail.com")
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        GoToPage("www.12padams.com/backgrounds")
    End Sub
    Private Sub removewebsites()
        googlemain.Hide()
        welcomeinternetscreen.Hide()
        googleprototype.Hide()
        googlealpha.Hide()
        padamsmain.Hide()
        hotmailmain.Hide()
        padamsbackgrounds.Hide()
        skindows95advertisment.Hide()
        secretwebsite.Hide()
        padamshidden.Hide()
        email1.Hide()
        email2.Hide()
        email3.Hide()
        hotmailpadams.Hide()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        GoToPage("www.12padams.com/skindows")
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        'Dim opendownload As New downloader
        'opendownload.Show()
        'opendownload.Label2.Text = "Downloading: Web Chat"
        If Not GameMain.webChatInstalled Then
            GameMain.OpenInstaller("webChat", My.Resources.chat_big, AppsLicense.normalLicense, "Web Chat 1998", 100)
        Else
            GameMain.OpenMsg("The application Web Chat 1998 is already installed!")
        End If
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click
        GoToPage("www.12padams.com/???", True)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        removewebsites()
        addressbar.Text = "www.???.com"
        secretwebsite.Dock = DockStyle.Fill
        secretwebsite.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
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

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        'Dim opendownload As New downloader
        'opendownload.Show()
        'opendownload.Label2.Text = "Downloading: Time Distorter"
        If Not GameMain.time1Installed Then
            GameMain.OpenInstaller("time1", My.Resources.time_distorter__install_Black_, AppsLicense.normalLicense, "Time Distorter v1", 1000)
        End If
    End Sub

    Private Sub checkhid_Tick(sender As Object, e As EventArgs) Handles checkhid.Tick
        If close_everything_.timesoftware = "yes" Then
            Label57.Show()
            Button26.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not chistory <= 1 Then
            GoToPage(history(chistory - 1), False, True)
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
            GoToPage(history(chistory + 1), False, True)
            chistory += 1
        Else
            GameMain.OpenMsg("You cannot go any further forward")
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim nexplorer As New internet_explorer_4
        nexplorer.Show()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Me.WindowState = 2
    End Sub
End Class