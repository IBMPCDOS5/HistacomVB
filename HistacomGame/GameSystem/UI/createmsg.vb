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
        desktopy = Windows2000.desktopicons.Size.Height
        desktopx = Windows2000.desktopicons.Size.Width
        look.Start()
        If My.Resources.windows_98_error_sound.CanRead Then
            Dim bStr(My.Resources.windows_98_error_sound.Length) As Byte
            My.Resources.windows_98_error_sound.Read(bStr, 0, My.Resources.windows_98_error_sound.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If
    End Sub
End Class