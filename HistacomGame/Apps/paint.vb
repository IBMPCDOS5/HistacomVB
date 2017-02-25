Public Class paint
    Dim selectedtool As String

    Private Sub toolfreeformslect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolfreeformslect.Click
        selectedtool = "freeformselect"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectpush
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub


    Private Sub toolrectanglarselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolrectanglarselect.Click
        selectedtool = "rectanglarselect"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselectpress
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolerracer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolerracer.Click
        selectedtool = "rubber"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95paintrubberpress
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolfillcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolfillcan.Click
        selectedtool = "fillcan"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfillpress
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolcolorpick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolcolorpick.Click
        selectedtool = "colorpick"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorselectpress
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolmagnify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolmagnify.Click
        selectedtool = "magnify"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95paintmagnifypress
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolpencil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpencil.Click
        selectedtool = "pencil"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencilpress
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolbrush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbrush.Click
        selectedtool = "brush"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95paintbrushpress
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolspraycan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolspraycan.Click
        selectedtool = "spraycan"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95paintspraycanpress
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub tooltext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tooltext.Click
        selectedtool = "text"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttextpress
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolline.Click
        selectedtool = "line"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintlinepress
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolcurvyline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolcurvyline.Click
        selectedtool = "curvyline"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvylinepress
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolrectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolrectangle.Click
        selectedtool = "rectangle"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95rectanglepress
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolpolygon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpolygon.Click
        selectedtool = "polygon"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygonepress
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolovel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolovel.Click
        selectedtool = "ovel"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95paintovelpress
        toolroundedrectangle.Image = My.Resources.windows95paintroundedcircle
    End Sub

    Private Sub toolroundedrectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolroundedrectangle.Click
        selectedtool = "roundedrectangle"
        toolfreeformslect.Image = My.Resources.windows95paintfreeselectoricon
        toolrectanglarselect.Image = My.Resources.windows95paintrectangleselector
        toolerracer.Image = My.Resources.windows95painteracer
        toolfillcan.Image = My.Resources.windows95paintfill
        toolcolorpick.Image = My.Resources.windows95paintcolorpick
        toolmagnify.Image = My.Resources.windows95zoom
        toolpencil.Image = My.Resources.windows95paintpencil
        toolbrush.Image = My.Resources.windows95painbrush
        toolspraycan.Image = My.Resources.windows95spraycan
        tooltext.Image = My.Resources.windows95painttext
        toolline.Image = My.Resources.windows95paintline
        toolcurvyline.Image = My.Resources.windows95paintcurvyline
        toolrectangle.Image = My.Resources.windows95paintrectangle
        toolpolygon.Image = My.Resources.windows95paintpolygon
        toolovel.Image = My.Resources.windows95painoval
        toolroundedrectangle.Image = My.Resources.windows95roundedrectanglepress
    End Sub

    Private Sub csblack_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csblack.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Black
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Black
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub cswhite_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cswhite.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.White
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.White
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csgray_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csgray.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Gray
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Gray
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub cssilver_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cssilver.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Silver
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Silver
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csdarkred_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csdarkred.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DarkRed
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DarkRed
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csred_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csred.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Red
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Red
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csolive_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csolive.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Olive
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Olive
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csyellow_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csyellow.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Yellow
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Yellow
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csseagreen_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csseagreen.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.SeaGreen
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.SeaGreen
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub cslime_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cslime.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Lime
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Lime
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csdarkcyan_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csdarkcyan.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DarkCyan
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DarkCyan
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub cscyan_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cscyan.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Cyan
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Cyan
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csdarkblue_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csdarkblue.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DarkBlue
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DarkBlue
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csblue_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csblue.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Blue
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Blue
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub cspurple_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cspurple.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Purple
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Purple
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csmagenta_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csmagenta.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Magenta
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Magenta
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csdarkgoldenrod_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csdarkgoldenrod.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DarkGoldenrod
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DarkGoldenrod
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub


    Private Sub cskhaki_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cskhaki.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Khaki
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Khaki
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csdarkgreen_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csdarkgreen.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DarkGreen
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DarkGreen
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csspringgreen_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csspringgreen.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.SpringGreen
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.SpringGreen
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csdodgerblue_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csdodgerblue.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DodgerBlue
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DodgerBlue
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csdarkslategray_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csdarkslategray.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DarkSlateGray
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DarkSlateGray
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csslateblue_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csslateblue.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DarkSlateBlue
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DarkSlateBlue
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csblueviolet_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csblueviolet.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.BlueViolet
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.BlueViolet
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csdeeppink_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csdeeppink.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DeepPink
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DeepPink
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub cssaddlebrown_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cssaddlebrown.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.SaddleBrown
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.SaddleBrown
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csdarkorange_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csdarkorange.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.DarkOrange
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.DarkOrange
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub csaquamarine_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles csaquamarine.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bottomcolor.BackColor = Color.Aquamarine
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            topcolor.BackColor = Color.Aquamarine
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If
    End Sub

    Private Sub paint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        look.Start()
    End Sub
End Class