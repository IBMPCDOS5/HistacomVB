Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case GameMain.OS
            Case 1
                Label1.Text = "Windows 95"
            Case 2
                Label1.Text = "Windows 98"
        End Select
        winman.setupwindow(Me, "Windows", My.Resources.win9xlogo)
    End Sub
End Class