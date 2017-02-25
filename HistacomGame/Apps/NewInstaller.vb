Public Class NewInstaller
    Dim page As Integer = 1
    Dim intDwn As Integer
    Public apptoinstall As String
    Public dwnSize As Integer
    Private Sub NewInstaller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLic.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        lblins.Hide()
        Select Case page
            Case 0
                Label1.Hide()
                Label2.Hide()
                Label3.Hide()
                pnlLic.Dock = DockStyle.Fill
                pnlLic.Show()
                btnNext.Text = "I Agree"
                btnPrev.Text = "I Decline"
                btnPrev.Show()
                page = 2
            Case 1
                Label1.Hide()
                Label2.Hide()
                Label3.Hide()
                pnlLic.Dock = DockStyle.Fill
                pnlLic.Show()
                btnNext.Text = "I Agree"
                btnPrev.Text = "I Decline"
                page = 2
            Case 2
                pnlLic.Hide()
                download.Start()
                Label1.Text = "We are now installing the application"
                Label2.Text = "0MB Out of 80MB"
                Label1.Show()
                Label2.Show()
                Progress.Show()
                btnNext.Text = "Next >"
                btnNext.Hide()
                btnPrev.Hide()
                page = 3
            Case 3
                btnNext.Text = "Finish"
                Label1.Text = "Congratulations!"
                Label2.Text = "You have successfully installed the application"
                Label3.Text = "Click the next button to exit the Installer"
                btnPrev.Hide()
                page = 4
            Case 4
                Me.Close()
        End Select
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Select Case page
            Case 2
                page = 0
                btnNext.Text = "Go Back"
                Label1.Text = "You have declined"
                Label2.Text = "You cannot continue if you have declined"
                pnlLic.Hide()
                Label1.Show()
                Label2.Show()
                btnPrev.Hide()
        End Select
    End Sub

    Private Sub download_Tick(sender As Object, e As EventArgs) Handles download.Tick
        If intDwn >= dwnSize Then
            download.Stop()
            btnNext.Show()
            Progress.Value = dwnSize
            GameMain.AddApp(apptoinstall)
            Exit Sub
        End If
        If (intDwn + 15) >= dwnSize Then
            Label2.Text = dwnSize & "MB out of " & dwnSize & "MB"
            download.Stop()
            btnNext.Show()
            Progress.Value = dwnSize
            GameMain.AddApp(apptoinstall)
            Exit Sub
        End If
        intDwn += 15
        Progress.Value = intDwn
        Label2.Text = intDwn & "MB out of " & dwnSize & "MB"
    End Sub
End Class