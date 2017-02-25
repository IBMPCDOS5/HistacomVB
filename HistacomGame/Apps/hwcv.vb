Public Class hwcv

    Private Sub run_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        look.Start()
        Label3.Hide()
        TextBox2.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "www.12padams.com" Then
            Label3.Show()
            Label3.Text = "Hidden Content Found: Time Distorter"
            close_everything_.timesoftware = "yes"
        Else
            Label3.Show()
            Label3.Text = "No Content Found"
        End If
    End Sub
End Class