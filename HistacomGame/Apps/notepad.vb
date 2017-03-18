Public Class notepad
    Public currentWorkingFile As String

    Private Sub notepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winman.setupwindow(Me, "Notepad", My.Resources.windows95notepadstartmenuicon)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        maintxt.Text = ""
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ManageTextFile.OpenNewTextFile(GameMain.ShowFileDialog(False, ".txt"))
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        ManageTextFile.SaveTextFile(GameMain.ShowFileDialog(True, ".txt"), maintxt.Text)
    End Sub

    Private Sub SaveAsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem1.Click
        ManageTextFile.SaveTextFile(GameMain.ShowFileDialog(True, ".txt"), maintxt.Text)
    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        maintxt.AppendText(DateTime.Now.Minute & ":" & DateTime.Now.Second & " " & DateTime.Now.Date.ToString)
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        maintxt.WordWrap = WordWrapToolStripMenuItem.Checked
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        maintxt.SelectAll()
    End Sub

    Private Sub AboutNotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutNotepadToolStripMenuItem.Click

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(maintxt.SelectedText)
        maintxt.Text = maintxt.Text.Remove(maintxt.SelectionStart, maintxt.SelectionLength)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(maintxt.SelectedText)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        maintxt.AppendText(My.Computer.Clipboard.GetText())
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        maintxt.Text = maintxt.Text.Remove(maintxt.SelectionStart, maintxt.SelectionLength)
    End Sub
End Class