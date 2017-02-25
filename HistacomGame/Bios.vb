Public Class Bios

    Dim counter As Integer = 0

    Private Sub Bios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Left = 0
        Me.Top = 0
    End Sub
    Dim winbootground As Image
    Public Sub winload(ByVal image As Image, ByVal winver As Form)
        Biosload.Enabled = True
        winbootground = image
        windowsboot.winversion = winver
    End Sub

    Private Sub Biosload_Tick(sender As Object, e As EventArgs) Handles Biosload.Tick
        Select Case counter
            Case 5
                biostxt1.Visible = True
            Case 6
                biostxt2.Visible = True
            Case 7
                biostxt3.Visible = True
            Case 8
                biostxt4.Visible = True
            Case 9
                biostxt5.Visible = True
            Case 10
                biostxt6.Visible = True
            Case 11
                biostxt7.Visible = True
                Biosload.Interval = 900
            Case 12
                biostxt8.Visible = True
                Biosload.Interval = 500
            Case 13
                biostxt9.Visible = True
            Case 14
                biostxt10.Visible = True
            Case 15
                biostxt11.Visible = True
            Case 16
                biostxt12.Visible = True
            Case 17
                biostxt13.Visible = True
            Case 25
                windowsboot.Show()
                windowsboot.bootimage.Image = winbootground
                counter = -1
                Biosload.Enabled = False
                Me.Hide()
                biostxt1.Visible = False
                biostxt2.Visible = False
                biostxt3.Visible = False
                biostxt4.Visible = False
                biostxt5.Visible = False
                biostxt6.Visible = False
                biostxt7.Visible = False
                biostxt8.Visible = False
                biostxt9.Visible = False
                biostxt10.Visible = False
                biostxt11.Visible = False
                biostxt12.Visible = False
                biostxt13.Visible = False
        End Select
        counter = counter + 1
    End Sub
End Class