Public Class formDisplayproperties

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedItem = "Small Fonts" Then
            fontsizeinfo.Text = "Normal size (96 dpi)"
        End If
        If ComboBox5.SelectedItem = "Large Fonts" Then
            fontsizeinfo.Text = "125% Normal size (120 dpi)"
        End If
    End Sub
    Private Sub TrackBarscreenres_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarscreenres.Scroll
        If TrackBarscreenres.Value = 1 Then
            screenreslabel.Text = "640 by 480 pixels"
        End If
        If TrackBarscreenres.Value = 2 Then
            screenreslabel.Text = "800 by 512 pixels"
        End If
        If TrackBarscreenres.Value = 3 Then
            screenreslabel.Text = "800 by 600 pixels"
        End If
        If TrackBarscreenres.Value = 4 Then
            screenreslabel.Text = "896 by 600 pixels"
        End If
        If TrackBarscreenres.Value = 5 Then
            screenreslabel.Text = "912 by 642 pixels"
        End If
        If TrackBarscreenres.Value = 6 Then
            screenreslabel.Text = "1024 by 768 pixels"
        End If
        If TrackBarscreenres.Value = 7 Then
            screenreslabel.Text = "1152 by 768 pixels"
        End If
        If TrackBarscreenres.Value = 8 Then
            screenreslabel.Text = "1152 by 864 pixels"
        End If
        If TrackBarscreenres.Value = 9 Then
            screenreslabel.Text = "1280 by 1024 pixels"
        End If
        If TrackBarscreenres.Value = 10 Then
            screenreslabel.Text = "1440 by 900 pixels"
        End If
        If TrackBarscreenres.Value = 11 Then
            screenreslabel.Text = "1600 by 1024 pixels"
        End If
        If TrackBarscreenres.Value = 12 Then
            screenreslabel.Text = "1600 by 1200 pixels"
        End If
    End Sub

    Private Sub colorpalettecbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorpalettecbox.SelectedIndexChanged
        If colorpalettecbox.SelectedItem = "16 Color" Then
            colourpaletepicturebox.Image = My.Resources.sixteencolor
        End If
        If colorpalettecbox.SelectedItem = "256 Color" Then
            colourpaletepicturebox.Image = My.Resources.two_five_six_color
        End If
        If colorpalettecbox.SelectedItem = "High Color (16 bit)" Then
            colourpaletepicturebox.Image = My.Resources.high_color
        End If
        If colorpalettecbox.SelectedItem = "True Color (32 bit)" Then
            colourpaletepicturebox.Image = My.Resources.true_color
        End If
    End Sub
    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles form1.Click
        colourselectorexample.Hide()
    End Sub

    Private Sub Whitecs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Whitecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.White
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.White
        End If
    End Sub

    Private Sub blackcs_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles blackcs.MouseClick
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Black
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Black
        End If
    End Sub

    Private Sub lightgreycs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lightgreycs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.LightGray
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub greycs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles greycs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Gray
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Gray
        End If
    End Sub

    Private Sub redcs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redcs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Red
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Red
        End If
    End Sub

    Private Sub darkredcs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles darkredcs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.DarkRed
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.DarkRed
        End If
    End Sub

    Private Sub yellowcs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yellowcs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Yellow
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub olivecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles olivecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Olive
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Olive
        End If
    End Sub

    Private Sub limecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Lime
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Lime
        End If
    End Sub

    Private Sub forestgreencs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forestgreencs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.ForestGreen
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.ForestGreen
        End If
    End Sub

    Private Sub cyancs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cyancs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Cyan
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Cyan
        End If
    End Sub

    Private Sub tealcs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tealcs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Teal
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Teal
        End If
    End Sub

    Private Sub bluecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bluecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Blue
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Blue
        End If
    End Sub

    Private Sub darkbluecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles darkbluecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.DarkBlue
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.DarkBlue
        End If
    End Sub

    Private Sub DarkMagentacs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarkMagentacs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.DarkMagenta
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.DarkMagenta
        End If
    End Sub

    Private Sub palegreencs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles palegreencs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.PaleGreen
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub lightbluecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lightbluecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.LightBlue
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub whitesmokecs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles whitesmokecs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.WhiteSmoke
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub darkgraycs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles darkgraycs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.DarkGray
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.DarkGray
        End If
    End Sub

    Private Sub magentacs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles magentacs.Click
        If cboxitemselect.SelectedItem = "Desktop" Then
            appearencesettingspanel.BackColor = Color.Magenta
        End If
        If cboxitemselect.SelectedItem = "Active Title Bar" Then
            exampletopbaractivewindow.BackColor = Color.Magenta
        End If
    End Sub

    Private Sub applysettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles applysettings.Click
        Windows95.BackColor = appearencesettingspanel.BackColor
        'Windows95.exampleprogramtopbar.BackColor = exampletopbaractivewindow.BackColor
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        colourselectorexample.Show()
    End Sub

    Private Sub formDisplayproperties_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        look.Start()
    End Sub
End Class