Public Class Guess_The_Number
        Dim thenumber As Integer
        Dim chosencolor As Color
        Dim flashnumb As Integer
        Dim controlpicked As Integer
        Dim controlnumb As New Random
        Dim chosencontrol As Control
        Dim flashgen As New Random
        Dim guessednumb As Integer
        Dim randnumb As New Random

    Private Sub Guess_The_Number_app_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        winman.setupwindow(Me, "Guees the Number", My.Resources.guess_the_number_Icon)
        thenumber = randnumb.Next(1, 101)
        look.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        guessednumb = Val(txtGuessedNumber.Text)
        If guessednumb < thenumber Then
            higherorlower.Text = "Higher"
            higherorlower.ForeColor = Color.Blue
        End If
        If guessednumb > thenumber Then
            higherorlower.Text = "Lower"
            higherorlower.ForeColor = Color.Red
        End If
        If guessednumb = thenumber Then
            higherorlower.Text = "Correct"
            higherorlower.ForeColor = Color.Green
            selector.Start()
        End If
    End Sub

        Private Sub flasher_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flasher.Tick
            flashnumb = flashgen.Next(1, 10)
            If flashnumb = 1 Then
                chosencolor = Color.Red
            End If
            If flashnumb = 2 Then
                chosencolor = Color.Green
            End If
            If flashnumb = 3 Then
                chosencolor = Color.Pink
            End If
            If flashnumb = 4 Then
                chosencolor = Color.Orange
            End If
            If flashnumb = 5 Then
                chosencolor = Color.Aqua
            End If
            If flashnumb = 6 Then
                chosencolor = Color.Gold
            End If
            If flashnumb = 7 Then
                chosencolor = Color.YellowGreen
            End If
            If flashnumb = 8 Then
                chosencolor = Color.Yellow
            End If
            If flashnumb = 9 Then
                chosencolor = Color.Black
            End If
            chosencontrol.BackColor = chosencolor
        End Sub

        Private Sub selector_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selector.Tick
            controlpicked = controlnumb.Next(1, 10)
            If controlpicked = 1 Then
                chosencontrol = Label1
            End If
            If controlpicked = 2 Then
                chosencontrol = program
            End If
            If controlpicked = 3 Then
                chosencontrol = txtGuessedNumber
            End If
            If controlpicked = 4 Then
                chosencontrol = Button1
            End If
            If controlpicked = 5 Then
                chosencontrol = Button2
            End If
            If controlpicked = 6 Then
            'chosencontrol = programtopbar
        End If
            If controlpicked = 7 Then
                chosencontrol = Label2
            End If
            If controlpicked = 8 Then
                chosencontrol = Label3
            End If
            If controlpicked = 9 Then
                chosencontrol = higherorlower
            End If
            flasher.Start()
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            Me.Close()
        Dim openguess As New Guess_The_Number
            openguess.Show()
        End Sub


    Private Sub btnveryeasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveryeasy.Click
        thenumber = randnumb.Next(1, 10)
        Label1.Text = "I am thinking of a number between 1-10"
        Panel1.Hide()
    End Sub

    Private Sub btneasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneasy.Click
        thenumber = randnumb.Next(1, 101)
        Label1.Text = "I am thinking of a number between 1-100"
        Panel1.Hide()
    End Sub

    Private Sub btnmedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmedium.Click
        thenumber = randnumb.Next(1, 1001)
        Label1.Text = "I am thinking of a number between 1-1,000"
        Panel1.Hide()
    End Sub

    Private Sub btnhard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhard.Click
        thenumber = randnumb.Next(1, 10001)
        Label1.Text = "I am thinking of a number between 1-10,000"
        Panel1.Hide()
    End Sub

    Private Sub btnveryhard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnveryhard.Click
        thenumber = randnumb.Next(1, 100001)
        Label1.Text = "I am thinking of a number between 1-100,000"
        Panel1.Hide()
    End Sub

    Private Sub btnimpossible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimpossible.Click
        thenumber = randnumb.Next(1, 1000001)
        Label1.Text = "I am thinking of a number between 1-1,000,000"
        Panel1.Hide()
    End Sub
End Class