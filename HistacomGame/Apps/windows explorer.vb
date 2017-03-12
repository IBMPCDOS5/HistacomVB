Public Class windows_explorer
    Dim ToReplaceWith As String = GameMain.MyDocuments & "\HistacomVB\" & GameMain.SaveProfile
    Dim directory As String = GameMain.MyDocuments & "\HistacomVB\" & GameMain.SaveProfile & "\folders"
    Dim fileType As Integer = 6
    Dim attemptedDirectory As String = ""

    'Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
    '    mainView.Items.Clear()
    '    Dim childamount As TreeNodeCollection
    '    childamount = TreeView1.SelectedNode.Nodes
    '    lblamountofobjects.Text = (childamount.Count & " objects(s)")
    '    For Each TreeNode In TreeView1.SelectedNode.Nodes
    '        If TreeNode.tag = "file" Then
    '            TreeNode.forecolor = TreeView1.BackColor
    '        End If
    '        mainView.Items.Add(TreeNode.text)
    '    Next
    'End Sub
    Private Sub fileexplore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        icons.Images.Add(My.Resources.documents_pic_start)
        icons.Images.Add(My.Resources.My_Computer_icon)
        winman.setupwindow(Me, "Windows Explorer", My.Resources.windows2000windowsexplorerstartmenuicon)
        program.BringToFront()
        dirLbl.Text = "folders"
        diskView.Items.Add("My Computer", 0)
        CheckLbl()
        RefreshAll()
    End Sub

    Sub CheckLbl()
        dirLbl.Text = dirLbl.Text.Replace(GameMain.MyDocuments, "")
        dirLbl.Text = dirLbl.Text.Replace("\HistacomVB\", "")
        dirLbl.Text = dirLbl.Text.Replace(GameMain.SaveProfile, "")
        dirLbl.Text = dirLbl.Text.Replace("folders", "My Computer")
        ' = dirLbl.Text.Substring(7, dirLbl.Text.Length - 7)
    End Sub

    Function ReadDataFile(ByVal directory As String, ByVal returnYesIsProtected As Boolean)
        Dim RdFile As SaveBlock = New SaveBlock
        Dim Val As String = ""
        Try
            RdFile.LoadFromFile(directory & "\_data.txt")
            If returnYesIsProtected = True Then
                If RdFile.FindProperty("protected").Value = "true" Then
                    Val = "yes"
                    Exit Try
                End If
            Else
                Val = RdFile.FindProperty("label").Value
            End If
        Catch ex As Exception
        End Try
        Return Val
    End Function

    Sub RefreshAll()
        Try
            ' Refresh the right listview
            icons.Images.Clear()
            mainView.Items.Clear()
            diskView.SmallImageList = icons
            mainView.LargeImageList = icons
            'For Each drive As String In My.Computer.FileSystem.GetDirectories(GameMain.MyDocuments & "\HistacomVB\" & GameMain.SaveProfile & "\HistacomVB\Folders")
            '    If GetPropetiesForDir(drive)(4) = "isMyDocuments" Then
            '        diskView.Items.Add("", 0)
            '    End If
            'Next
            For Each str As String In My.Computer.FileSystem.GetDirectories(directory)
                Dim Label = ReadDataFile(str, False)
                If Label = "" Then
                    mainView.Items.Add(My.Computer.FileSystem.GetName(str), 0)
                    mainView.FindItemWithText(My.Computer.FileSystem.GetName(str)).Tag = My.Computer.FileSystem.GetName(str)
                Else
                    mainView.Items.Add(Label, 0)
                    mainView.FindItemWithText(Label).Tag = My.Computer.FileSystem.GetName(str)
                End If

                '        diskView.Items.Add("", 0)
                '    End If
            Next
            For Each str As String In My.Computer.FileSystem.GetFiles(directory)
                'ReturnType(My.Computer.FileSystem.GetFileInfo(str).Extension)
                If Not My.Computer.FileSystem.GetName(str) = "_data" Then mainView.Items.Add(My.Computer.FileSystem.GetName(str))
            Next
            CheckLbl()
        Catch ex As Exception
            GameMain.OpenMsg("Error with the file explorer" & vbCrLf & ex.Message)
            Me.Close()
        End Try
    End Sub

    Function ReturnType(ByVal extension As String)
        Dim returnVal As String = ""
        fileType = 1
        Select Case extension
            Case ".txt"
                fileType = 1
                returnVal = "Text Document" & vbCrLf & "createtext"
            Case ".dat"
                fileType = 1
                returnVal = "Text Document" & vbCrLf & "createtext"
            Case ".rtf"
                fileType = 2
                returnVal = "Rich Text Document" & vbCrLf & "createtext"
            Case ".cfg"
                fileType = 1
                returnVal = "Config file" & vbCrLf & "createtext"
            Case ".log"
                fileType = 1
                returnVal = "log text file" & vbCrLf & "createtext"
            Case ".properties"
                fileType = 1
                returnVal = "Config file" & vbCrLf & "createtext"
            Case ".json"
                fileType = 1
                returnVal = "Config file" & vbCrLf & "createtext"
            Case ".doc"
                fileType = 3
                returnVal = "Word Document (Old)" & vbCrLf & "word"
            Case ".docx"
                fileType = 3
                returnVal = "Word Document" & vbCrLf & "word"
            Case ".docm"
                fileType = 3
                returnVal = "Macro-Enabled Word Document" & vbCrLf & "word"
            Case ".xls"
                fileType = 4
                returnVal = "Excel Spreadsheets (Old)" & vbCrLf & "excel"
            Case ".xlsx"
                fileType = 4
                returnVal = "Excel Spreadsheets" & vbCrLf & "excel"
            Case ".ppt"
                fileType = 5
                returnVal = "Powerpoint Presentation (Old)" & vbCrLf & "powerpoint"
            Case ".pptx"
                fileType = 5
                returnVal = "Powerpoint Presentation" & vbCrLf & "powerpoint"
            Case ".pub"
                fileType = 7
                returnVal = "Publisher Document" & vbCrLf & "powerpoint"
            Case ".xps"
                fileType = 8
                returnVal = "XPS Document" & vbCrLf & "xpsview"
            Case ".htm"
                fileType = 9
                returnVal = "HTML web page" & vbCrLf & "html"
            Case ".html"
                fileType = 9
                returnVal = "HTML web page" & vbCrLf & "html"
            Case ".wps"
                fileType = 10
                returnVal = "Works document" & vbCrLf & "works"
            Case ".wmf"
                fileType = 11
                returnVal = "Windows Metafile (A picture)" & vbCrLf & "createart"
            Case ".emf"
                fileType = 11
                returnVal = "Enhanced Metafile (A picture)" & vbCrLf & "createart"
            Case ".png"
                fileType = 11
                returnVal = "Picture file (Portable Network Graphics)" & vbCrLf & "createart"
            Case ".jpg"
                fileType = 11
                returnVal = "Picture file" & vbCrLf & "createart"
            Case ".jpeg"
                fileType = 11
                returnVal = "Picture file" & vbCrLf & "createart"
            Case ".gif"
                fileType = 12
                returnVal = "Picture file" & vbCrLf & "gifman"
            Case ".tif"
                fileType = 11
                returnVal = "Picture file" & vbCrLf & "createart"
            Case ".bmp"
                fileType = 11
                returnVal = "Picture file" & vbCrLf & "createart"
            Case ".zip"
                fileType = 11
                returnVal = "Compressed ZIP file" & vbCrLf & "winrar"
            Case ".rar"
                fileType = 11
                returnVal = "WINRAR Compressed file" & vbCrLf & "winrar"
            Case ".gz"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".7z"
                fileType = 11
                returnVal = "7ZIP file" & vbCrLf & "7z"
            Case ".ace"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".arj"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".bz2"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".gzip"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".lzh"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".tar"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".uue"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".xz"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".z"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".001"
                fileType = 11
                returnVal = "WINRAR file" & vbCrLf & "winrar"
            Case ".exe"
                fileType = 12
                returnVal = "Program" & vbCrLf & "exe"
            Case ".jar"
                fileType = 13
                returnVal = "Java file" & vbCrLf & "java"
            Case ".iso"
                fileType = 14
                returnVal = "CD Image file" & vbCrLf & "iso"
            Case ".avi"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".m4v"
                fileType = 15
                returnVal = "Video (MPEG-4)" & vbCrLf & "video"
            Case ".mp4"
                fileType = 15
                returnVal = "Video (MPEG-4)" & vbCrLf & "video"
            Case ".wmv"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".m2v"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".m3u"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".m4v"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".mts"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".dv"
                fileType = 15
                returnVal = "Video (Digital Video)" & vbCrLf & "video"
            Case ".flv"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".m1v"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".m2ts"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".mkv"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".mov"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".mpeg4"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".mpeg"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".mpg"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".3gp"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".m4p"
                fileType = 15
                returnVal = "Video" & vbCrLf & "video"
            Case ".mp2"
                fileType = 21
                returnVal = "Audio" & vbCrLf & "video"
            Case ".mp3"
                fileType = 21
                returnVal = "Audio" & vbCrLf & "video"
            Case ".mp4"
                fileType = 21
                returnVal = "Audio" & vbCrLf & "video"
            Case ".wav"
                fileType = 21
                returnVal = "Audio" & vbCrLf & "video"
            Case ".nls"
                fileType = 16
                returnVal = "Font file" & vbCrLf & "font"
            Case ".dll"
                fileType = 17
                returnVal = "System File" & vbCrLf & "sys"
            Case ".bat"
                fileType = 18
                returnVal = "MS-DOS Batch file" & vbCrLf & "winterm"
            Case ".url"
                fileType = 19
                returnVal = "Shortcut" & vbCrLf & "short"
            Case ".sh"
                fileType = 20
                returnVal = "BASH file" & vbCrLf & "winterm"
            Case ".win"
                fileType = 17
                returnVal = "System file" & vbCrLf & "sys"
        End Select
        Return returnVal
    End Function

    Private Sub dirView_DoubleClick(sender As Object, e As EventArgs) Handles mainView.DoubleClick
        Try
            If My.Computer.FileSystem.DirectoryExists(directory & "\" & mainView.FocusedItem.Tag) Then
                dirLbl.Text = dirLbl.Text & "\" & mainView.FocusedItem.Tag
                GoToDir(directory & "\" & mainView.FocusedItem.Tag)
            Else
                ReturnType(My.Computer.FileSystem.GetFileInfo(mainView.FocusedItem.Text).Extension)
                If fileType = 1 Then

                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        GoToDir(GameMain.MyDocuments & "\HistacomVB\" & GameMain.SaveProfile & "\" & dirLbl.Text.Replace("My Computer", "folders"))
    End Sub

    Sub GoToDir(ByVal dir As String, Optional ByVal GoneThoughHidden As Boolean = False)
        If ReadDataFile(dir, True) = "yes" And GoneThoughHidden = False Then
            attemptedDirectory = dir
            mainView.Hide()
            pnlHidden.BringToFront()
            pnlHidden.Show()
        Else
            pnlHidden.Hide()
            mainView.Show()
            mainView.BringToFront()
            directory = dir
            RefreshAll()
        End If
    End Sub

    Private Sub diskView_DoubleClick(sender As Object, e As EventArgs) Handles diskView.DoubleClick
        Try
            If diskView.FocusedItem.Text = "My Computer" Then
                GoToDir(GameMain.MyDocuments & "\HistacomVB\" & GameMain.SaveProfile & "\folders")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GoToDir(attemptedDirectory, True)
    End Sub

    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem.Click
        If My.Computer.FileSystem.DirectoryExists(directory & "\New Folder") Then
            GameMain.OpenMsg("This directory already exists")
        Else
            Dim newProperties As SaveBlock = New SaveBlock
            My.Computer.FileSystem.CreateDirectory(directory & "\New Folder")
            newProperties.AddProperty("label", "New Folder")
            newProperties.SaveToFile(directory & "\New Folder\_data.txt")
            RefreshAll()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub mainView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mainView.SelectedIndexChanged

    End Sub

    Private Sub TextDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextDocumentToolStripMenuItem.Click

    End Sub
End Class