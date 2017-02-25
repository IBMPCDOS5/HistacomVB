Public Class notepad

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub notepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winman.setupwindow(Me, "Notepad", My.Resources.windows95notepadstartmenuicon)
    End Sub
End Class