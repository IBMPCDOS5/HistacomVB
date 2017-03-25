Public Class Installer
    Dim programtoinstall As String
    Private Sub Installer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        welcome.Show()
        programtoinstall = installname.Text
        installname.Hide()
        'programname.Text = (programtoinstall & " Setup")
        Label1.Text = ("Setup Wizard ")
        Label2.Text = ("Welcome To " & programtoinstall)
        Label3.Text = ("Click Next to continue")
        Label4.Text = ("This Wizard will guide you through the installation of " & programtoinstall)
        Label11.Text = ("C:\Program Files\ " & programtoinstall)
        Label12.Text = ("Ready to start installing " & programtoinstall)
        Label13.Text = ("Please wait while " & programtoinstall & " is being installed")
        Label14.Text = ("Installing " & programtoinstall)
        Label16.Text = (programtoinstall & " was successfully installed.")
        finishinstallimage.Image = installimage.Image
        look.Start()
        licenceagreementinstallpic.Image = iconpic.Image
        suminstallpic.Image = iconpic.Image
        PictureBox2.Image = iconpic.Image
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Finish" Then
            If programtoinstall = "Guess The Number 2" Then
                Me.Close()
                Windows2000.GuessTheNumberToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Start Runner 2000" Then
                Me.Close()
                Windows2000.StartRunnerToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Error Blaster 2000" Then
                Me.Close()
                Windows2000.ErrorBlasterToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Skindows 95" Then
                Me.Close()
                Windows2000.SkindowsToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Web Chat 2000" Then
                Me.Close()
                Windows2000.WebChatToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Time Distorter 0.3" Then
                Me.Close()
                Windows2000.TimeDistorter03ToolStripMenuItem.Visible = True
                Windowsxp2002damaged.TimeDistorter03ToolStripMenuItem.Visible = True
            End If
            If programtoinstall = "Survive The Day" Then
                Me.Close()
                Windows2000.SurviveTheDayToolStripMenuItem.Visible = True
            End If
        End If
        If summary.Visible = True And licenseagreement.Visible = False Then
            summary.Hide()
            Button3.Hide()
            Timer1.Start()
        End If
        If licenseagreement.Visible = True And welcome.Visible = False Then
            licenseagreement.Hide()
        End If
        If welcome.Visible = True Then
            welcome.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
        If ProgressBar1.Value = 100 Then
            Button3.Show()
            installerproccess.Hide()
            Button3.Text = "Finish"
            Timer1.Stop()
        End If
    End Sub
End Class