Public Class startrunner
    Dim beginlocation As System.Drawing.Point
    Dim randnumb As New Random
    Dim taskbarlenght As Integer
    Dim ylocation As Integer
    Dim xlocation As Integer
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Windows2000.startbutton.Location = beginlocation
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Windows2000.startbutton.Location = beginlocation
        Me.Close()
    End Sub

    Private Sub Start_Runner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        beginlocation = Windows2000.startbutton.Location
        taskbarlenght = Windows2000.taskbar.Size.Width
        look.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        xlocation = randnumb.Next(1, taskbarlenght)
        Windows2000.startbutton.Location = New Point(xlocation, Windows2000.startbutton.Location.Y)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Windows2000.startbutton.Location = beginlocation
    End Sub
End Class