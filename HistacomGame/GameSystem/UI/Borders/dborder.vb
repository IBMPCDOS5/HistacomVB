Public Class dborder
    Private Sub dborder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case GameMain.OS
            Case 3
                Me.BackgroundImage = My.Resources.windowsxpbottom
                lcorner.BackgroundImage = My.Resources.windowsxpbottomleftcorner
                rcorner.BackgroundImage = My.Resources.windowsxpbottomcorner
        End Select
    End Sub
End Class
