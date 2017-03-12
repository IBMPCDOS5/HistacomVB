Public Class ManageTextFile
    Public Shared Sub OpenNewTextFile(ByVal filePath As String)
        Select Case My.Computer.FileSystem.GetFileInfo(filePath).Extension
            Case ".txt"
                Dim nnotes As New notepad
                nnotes.maintxt.Text = IO.File.ReadAllText(filePath)
                nnotes.currentWorkingFile = My.Computer.FileSystem.GetName(filePath)
                nnotes.Show()
        End Select
    End Sub

    Public Shared Sub SaveTextFile(ByVal filePath As String, ByVal text As String)
        If Not filePath = Nothing Then
            FileOpen(1, filePath, OpenMode.Output)
            PrintLine(1, text)
            FileClose(1)
        End If
        ' Saved!
    End Sub

    Public Sub RenderGraphics(ByVal filePath As String)
        ' There will be stuff for rendering here
    End Sub
End Class
