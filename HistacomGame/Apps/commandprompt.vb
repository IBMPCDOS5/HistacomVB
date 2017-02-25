Public Class commandprompt

    Private Sub Command_prompt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        winman.setupwindow(Me, "Command Prompt", My.Resources.windows95dosstartmenuicon)
        Me.Location = New Point(20, 20)
    End Sub

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub
End Class