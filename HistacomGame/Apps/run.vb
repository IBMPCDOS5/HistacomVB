Public Class run
    Private Sub run_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        winman.setupwindow(Me, "Run", My.Resources.Run_pic_start)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.Text
            Case "winver"
                About.Show()
                Me.Close()
            Case Else
                GameMain.OpenMsg("Windows cannot find the specified file or directory")
        End Select
    End Sub
End Class