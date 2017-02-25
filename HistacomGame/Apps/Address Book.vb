Public Class Address_Book
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        MsgBox("This is not supported in the game yet... YOU ARE PLAYING A BETA BUILD")
    End Sub

    Private Sub Address_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winman.setupwindow(Me, "Address Book", My.Resources.windows2000addressbookstartmenuicon)
    End Sub
End Class