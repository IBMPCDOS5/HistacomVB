Public Class GameMain
    Public Shared MyDocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    Public Shared GameVersion As String = "2.0"
    Public Shared GameVersionSmall As String = "Alpha-1"
#Region "Save Things"
    Public Shared SaveProfile As String

    Public Shared MainSave As New SaveBlock
#End Region
    Public Shared OS As Integer
    Public Shared guessInstalled As Boolean
    Public Shared webChatInstalled As Boolean
    Public Shared startRInstalled As Boolean
    Public Shared time1Installed As Boolean

    Public Shared Sub saveGame()

    End Sub

    Public Shared Sub setUpFolders(ByVal dir As String)
        If Not My.Computer.FileSystem.DirectoryExists(dir & "\C") Then My.Computer.FileSystem.CreateDirectory(dir & "\C")
        If Not My.Computer.FileSystem.DirectoryExists(dir & "\C\Doc") Then My.Computer.FileSystem.CreateDirectory(dir & "\C\Doc")
        If Not My.Computer.FileSystem.DirectoryExists(dir & "\C\Prog") Then My.Computer.FileSystem.CreateDirectory(dir & "\C\Prog")
        If Not My.Computer.FileSystem.DirectoryExists(dir & "\C\Win") Then My.Computer.FileSystem.CreateDirectory(dir & "\C\Win")
    End Sub

    Public Shared Sub newGame(ByVal profileName As String)
        If Not My.Computer.FileSystem.DirectoryExists(MyDocuments & "\HistacomVB") Then
            MsgBox("The game save files are missing, game will now restart")
            Application.Restart()
        Else
            If My.Computer.FileSystem.DirectoryExists(MyDocuments & "\HistacomVB\" & profileName) Then
                MsgBox("The profile already exists!")
                Application.Restart()
            Else
                OS = 1
                My.Computer.FileSystem.CreateDirectory(MyDocuments & "\HistacomVB\" & profileName)
                My.Computer.FileSystem.CreateDirectory(MyDocuments & "\HistacomVB\" & profileName & "\folders")
                setUpFolders(MyDocuments & "\HistacomVB\" & profileName & "\folders")
                Dim main As New SaveBlock
                Dim filesys As New SaveBlock
                Dim filesC As New SaveBlock
                Dim filesCDoc As New SaveBlock
                Dim filesCProg As New SaveBlock
                Dim filesCWin As New SaveBlock
                Dim startedver As New SaveBlock
                Dim currentver As New SaveBlock
                SaveProfile = profileName
                startedver.AddProperty("Version", GameVersion)
                startedver.AddProperty("VersionSmall", GameVersionSmall)
                currentver.AddProperty("Version", GameVersion)
                currentver.AddProperty("VersionSmall", GameVersionSmall)

#Region "FileSystem"
                filesys.AddProperty("protected", "false")
                filesys.AddProperty("label", "My Computer")
                filesys.AddProperty("allowback", "false")

                filesC.AddProperty("protected", "false")
                filesC.AddProperty("label", "Win_95")
                filesC.AddProperty("allowback", "true")

                filesCDoc.AddProperty("protected", "false")
                filesCDoc.AddProperty("label", "My Documents")
                filesCDoc.AddProperty("allowback", "true")
                filesCDoc.AddProperty("isMyDocuments", "true")

                filesCProg.AddProperty("protected", "true")
                filesCProg.AddProperty("label", "My Programs")
                filesCProg.AddProperty("allowback", "true")
                filesCProg.AddProperty("isMyPrograms", "true")

                filesCWin.AddProperty("protected", "true")
                filesCWin.AddProperty("label", "Windows")
                filesCWin.AddProperty("allowback", "true")
                filesCWin.AddProperty("isWindows", "true")

                filesys.SaveToFile(MyDocuments & "\HistacomVB\" & SaveProfile & "\folders\_data.txt")
                filesC.SaveToFile(MyDocuments & "\HistacomVB\" & SaveProfile & "\folders\C\_data.txt")
                filesCDoc.SaveToFile(MyDocuments & "\HistacomVB\" & SaveProfile & "\folders\C\Doc\_data.txt")
                filesCProg.SaveToFile(MyDocuments & "\HistacomVB\" & SaveProfile & "\folders\C\Prog\_data.txt")
                filesCWin.SaveToFile(MyDocuments & "\HistacomVB\" & SaveProfile & "\folders\C\Win\_data.txt")
#End Region

                main.AddProperty("os", OS)

                MainSave.AddBlock("startedVersion", startedver)
                MainSave.AddBlock("currentVersion", currentver)
                MainSave.AddBlock("mainData", main)
                'MainSave.AddBlock("FileSystem", filesys)

                MainSave.SaveToFile(MyDocuments & "\HistacomVB\" & SaveProfile & "\Main.txt")
            End If
        End If
    End Sub
    Public Shared Sub OpenInstaller(ByVal toInstall As String, ByVal img As Image, ByVal license As String, ByVal progName As String, ByVal dwnSize As Integer)
        Dim Install As New NewInstaller
        Install.apptoinstall = toInstall
        Install.sideimg.Image = img
        Install.txtlicense.Text = license
        Install.Label3.Text = "You are currently installing: " & vbCrLf & progName
        Install.dwnSize = dwnSize
        Install.Progress.Maximum = dwnSize
        Install.Show()
    End Sub

    Public Shared Sub AddApp(ByVal appID As String)
        Select Case appID
            Case "guessNum"
                guessInstalled = True
                Windows95.GuessTheNumberToolStripMenuItem.Visible = True
                Windows98.GuessTheNumberToolStripMenuItem.Visible = True
                Windows2000.GuessTheNumberToolStripMenuItem.Visible = True
                Windows95.pnlGuess.Show()
            Case "webChat"
                webChatInstalled = True
                Windows95.WebChatToolStripMenuItem.Visible = True
                Windows98.WebChatToolStripMenuItem.Visible = True
                Windows2000.WebChatToolStripMenuItem.Visible = True
                Windows95.pnlWeb.Show()
            Case "startR"
                startRInstalled = True
                Windows95.StartRunnerToolStripMenuItem.Visible = True
                Windows98.StartRunnerToolStripMenuItem.Visible = True
                Windows2000.StartRunnerToolStripMenuItem.Visible = True
                Windows95.pnlStartR.Show()
            Case "time1"
                time1Installed = True
                Windows95.TimeDistorterToolStripMenuItem.Visible = True
                Windows95.pnlTime.Show()
        End Select
    End Sub

    Public Shared Sub OpenMsg(ByVal message As String)
        Dim msg As New createmsg
        msg.infomessage.Text = message
        msg.ShowDialog()
    End Sub
End Class
