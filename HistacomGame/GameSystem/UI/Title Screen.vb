Public Class Title_Screen
    Private Sub buttonexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonexit.Click
        Me.Close()
    End Sub

    Private Sub buttonnewgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonnewgame.Click
        lblNew.Show()
        btnNew.Show()
        txtNew.Show()

    End Sub

    Private Sub buttonnewgame_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonnewgame.MouseEnter
        buttonnewgame.Image = My.Resources.msnewgame
    End Sub

    Private Sub buttonnewgame_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonnewgame.MouseLeave
        buttonnewgame.Image = My.Resources.new_game
    End Sub

    Private Sub buttonexit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonexit.MouseEnter
        buttonexit.Image = My.Resources.msexit
    End Sub

    Private Sub buttonexit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonexit.MouseLeave
        buttonexit.Image = My.Resources.exitimg
    End Sub

    Private Sub buttonloadgame_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonloadgame.MouseEnter
        buttonloadgame.Image = My.Resources.msload_game
    End Sub

    Private Sub buttonloadgame_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonloadgame.MouseLeave
        buttonloadgame.Image = My.Resources.load_game
    End Sub

    Private Sub buttonloadgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonloadgame.Click
        loadsettings.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Here are some details for all you people who want to edit the save file and stuff:" & vbCrLf & "All the profiles are stored in the My Documents\HistacomVB folder. In there you will find all the profiles in folders. The rest is for you to figure out ;)")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Not txtNew.Text = "" Then
            GameMain.newGame(txtNew.Text)
            Windows95.Show()
            Me.Hide()
        Else
            MsgBox("There must be a profile name")
        End If
    End Sub

    Private Sub Title_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists(GameMain.MyDocuments & "\HistacomVB") Or Not My.Computer.FileSystem.FileExists(GameMain.MyDocuments & "\HistacomVB\main.txt") Then
            Dim setup As New SaveBlock
            If Not My.Computer.FileSystem.DirectoryExists(GameMain.MyDocuments & "\HistacomVB") Then My.Computer.FileSystem.CreateDirectory(GameMain.MyDocuments & "\HistacomVB")
            setup.AddProperty("gameVersion", GameMain.GameVersion) 'Adds a property to the file - if you don't know what this means be sure
            'to check out the custom save system in the forums (WHEN I GET MOD)
            setup.AddProperty("versionSmall", GameMain.GameVersionSmall)
            setup.MainStr = setup.MainStr & vbCrLf

            setup.SaveToFile(GameMain.MyDocuments & "\HistacomVB\Main.txt")
        End If
    End Sub
End Class