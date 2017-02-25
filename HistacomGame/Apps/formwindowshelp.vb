Public Class formwindowshelp
    Private Sub formwindowshelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winman.setupwindow(Me, "Windows Help", My.Resources.windows2000help)
    End Sub
End Class