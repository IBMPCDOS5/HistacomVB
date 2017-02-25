Public Class createmsg
    Dim chosenx As Integer
    Dim choseny As Integer
    Dim desktopx As Integer
    Dim desktopy As Integer
    Dim yran As New Random
    Dim xran As New Random

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub windows2000messagebox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        winman.setupwindow(Me, "Critical Error", My.Resources.windows2000error)
        Me.Hide()
        Label1.Hide()
        Label2.Hide()
        desktopy = Windows2000.desktopicons.Size.Height
        desktopx = Windows2000.desktopicons.Size.Width
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        look.Start()
        If My.Resources.windows_98_error_sound.CanRead Then
            Dim bStr(My.Resources.windows_98_error_sound.Length) As Byte
            My.Resources.windows_98_error_sound.Read(bStr, 0, My.Resources.windows_98_error_sound.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        choseny = yran.Next(1, desktopy)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        chosenx = xran.Next(1, desktopx)
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Show()
        Label1.Text = chosenx
        Label2.Text = choseny
        Me.Location = New Point(Label1.Text, Label2.Text)
        Timer3.Stop()
    End Sub
End Class