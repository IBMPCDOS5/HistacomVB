Public Class winman
    Public Shared Sub setupwindow(ByRef win As Form, ByVal title As String, ByVal icon As Image)
        Dim ntitle As New titlebar
        Dim lbord As New lborder
        Dim rbord As New rborder
        Dim dbord As New dborder
        ntitle.Dock = DockStyle.Top
        lbord.Dock = DockStyle.Left
        rbord.Dock = DockStyle.Right
        dbord.Dock = DockStyle.Bottom
        ntitle.SendToBack()
        ntitle.appName.Text = title
        ntitle.appIcon.Image = icon
        win.Controls.Add(ntitle)
        win.Controls.Add(lbord)
        win.Controls.Add(rbord)
        win.Controls.Add(dbord)
        win.Height += ntitle.Height
        win.Width += lbord.Width
        win.Width += rbord.Width
        win.Height += dbord.Height
    End Sub




    'Private Sub Address_Book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    look.Start()
    'End Sub



    'Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Me.Close()
    'End Sub

    'Private Sub pullside_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullside.Tick
    '    Me.Width = Cursor.Position.X - Me.Location.X
    'End Sub

    'Private Sub pullbottom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pullbottom.Tick
    '    Me.Height = Cursor.Position.Y - Me.Location.Y
    'End Sub

    'Private Sub pullbs_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pullbs.Tick
    '    Me.Width = Cursor.Position.X - Me.Location.X
    '    Me.Height = Cursor.Position.Y - Me.Location.Y
    'End Sub

    'Private Sub Rightpull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    pullside.Start()
    'End Sub

    'Private Sub rightpull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    pullside.Stop()
    'End Sub

    'Private Sub bottompull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    pullbottom.Start()
    'End Sub

    'Private Sub buttompull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    pullbottom.Stop()
    'End Sub

    'Private Sub bspull_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseDown
    '    pullbs.Start()
    'End Sub

    'Private Sub bspull_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bottomrightcorner.MouseUp
    '    pullbs.Stop()
    'End Sub

    'Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not maximize Then
    '        meylocation = Windows95.desktopicons.Height - Me.Height
    '        mexlocation = Windows95.desktopicons.Width - Me.Width
    '        mewidth = Me.Width
    '        meheight = Me.Height
    '        toprightcorner.Hide()
    '        topleftcorner.Hide()
    '        bottomrightcorner.Hide()
    '        bottomleftcorner.Hide()
    '        Left.Hide()
    '        Top.Hide()
    '        Bottom.Hide()
    '        Right.Hide()
    '        Dim w, h As Integer
    '        w = Windows95.desktopicons.Width
    '        h = Windows95.desktopicons.Height
    '        Me.Location = New Point(0, 0)
    '        Me.Size = New Size(w, h)
    '        moveable = False
    '        maximizebutton.Image = My.Resources.unmaximizebutton
    '        maximize = True
    '    Else
    '        toprightcorner.Show()
    '        topleftcorner.Show()
    '        bottomrightcorner.Show()
    '        bottomleftcorner.Show()
    '        Left.Show()
    '        Top.Show()
    '        Bottom.Show()
    '        Right.Show()
    '        Me.Location = New Point(mexlocation, meylocation)
    '        Me.Size = New Size(mewidth, meheight)
    '        moveable = True
    '        maximizebutton.Image = My.Resources.Maximize
    '        maximize = False
    '    End If
    'End Sub

    'Private Sub look_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles look.Tick
    '    Me.programtopbar.BackColor = Windows95.exampleprogramtopbar.BackColor
    '    Me.programtopbar.BackgroundImage = Windows95.exampleprogramtopbar.BackgroundImage
    '    Me.programname.BackColor = Windows95.exampleprogramtext.BackColor
    'End Sub
End Class
