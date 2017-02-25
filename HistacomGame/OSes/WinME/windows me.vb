Public Class windows_me
    Dim count As Integer
    Dim txtcount As Integer
    Dim usersave As String

    Private Sub windows95_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles desktopicons.Click
        startmenu.Hide()
    End Sub

    Private Sub windows95_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        desktopicons.Show()
        If My.Resources.Windows_ME_Shutdown.CanRead Then
            Dim bStr(My.Resources.Windows_ME_Shutdown.Length) As Byte
            My.Resources.Windows_ME_Shutdown.Read(bStr, 0, My.Resources.Windows_ME_Shutdown.Length)
            My.Computer.Audio.Play(bStr, AudioPlayMode.Background)
        End If
        startmenu.Hide()
        program.Hide()
        Timer4.Start()
        Timer1.Start()
        exampleprogramtopbar.Show()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        System.Windows.Forms.Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled
        Me.desktopicons.BackgroundImage = My.Resources.windows_me_background_color
        Dim w, h As Integer
        w = Me.desktopicons.Width
        h = Me.desktopicons.Height
        Dim bmp As Bitmap = New Bitmap(w, h)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Me.desktopicons.BackgroundImage, 0, 0, bmp.Width, bmp.Height)
        End Using
        Me.BackgroundImage = bmp
        Me.desktopicons.BackgroundImage = bmp
        desktopicons.AutoArrange = False
        desktopicons.AllowDrop = True
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click
        Dim opennotepad As New notepad
        opennotepad.Show()
        startmenu.Hide()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Dim windowshelpopen As New formwindowshelp
        windowshelpopen.Show()
        startmenu.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        program.Hide()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Dim opencalc As New formcalculator
        opencalc.Show()
        startmenu.Hide()
    End Sub


    Private Sub desktopicons_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles desktopicons.DoubleClick
        Dim objDrawingPoint As Drawing.Point
        Dim objListViewItem As ListViewItem

        objDrawingPoint = desktopicons.PointToClient(Cursor.Position)

        If Not IsNothing(objDrawingPoint) Then
            With objDrawingPoint
                objListViewItem = desktopicons.GetItemAt(.X, .Y)
            End With

            If Not IsNothing(objListViewItem) Then
                If objListViewItem.Text = "Internet Explorer" Then
                    Dim IE As New Internet_Explorer_52001
                    IE.Show()
                End If
                If objListViewItem.Text = "Guess The Number 2 Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Guess The Number 2"
                    openinstall.installimage.Image = My.Resources.Guess_the_Number__install_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Start Runner 2000 Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Start Runner 2000"
                    openinstall.installimage.Image = My.Resources.start_run__install___white_with_programname_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Error Blaster 2000 Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Error Blaster 2000"
                    openinstall.installimage.Image = My.Resources.error_blast__big_
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Survive The Day Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Survive The Day"
                    openinstall.installimage.Image = My.Resources.survive_the_day_install_banner
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Skindows 95 Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Skindows 95"
                    openinstall.installimage.Image = My.Resources.skindows_95
                    openinstall.Show()
                End If
                If objListViewItem.Text = "Web Chat Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Web Chat"
                    openinstall.installimage.Image = My.Resources.chat_big
                    openinstall.Show()
                End If
                If objListViewItem.Text = "hwcv.exe" Then
                    Dim openhwcv As New hwcv
                    openhwcv.Show()
                End If
                If objListViewItem.Text = "Time Distorter Setup" Then

                    Dim openinstall As New Installer
                    openinstall.installname.Text = "Time Distorter"
                    openinstall.installimage.Image = My.Resources.time_distorter__install_Black_
                    openinstall.Show()
                End If
            End If
        End If
    End Sub

    Private Sub Desktop_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles desktopicons.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            rightclickbackproperties.Show()
            rightclickbackproperties.BringToFront()
            rightclickbackproperties.Location = MousePosition
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
        End If
        If e.Button = Windows.Forms.MouseButtons.Middle Then
        End If

    End Sub

    Private Sub minimizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizebutton.Click

    End Sub

    Private Sub maximizebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximizebutton.Click

    End Sub

    Private Sub startbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton.Click
        startmenu.Show()
        startmenu.BringToFront()
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem1.Click
        Dim oform As New formDisplayproperties
        oform.Show()
        startmenu.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        desktopicons.BackColor = Me.BackColor
        taskbartime.Text = TimeOfDay
    End Sub

    Private Sub PhoneDialerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhoneDialerToolStripMenuItem.Click
        Dim openphonedialer As New phone_dialer
        openphonedialer.Show()
        startmenu.Hide()
    End Sub

    Private Sub AddressBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressBookToolStripMenuItem.Click
        Dim openaddressbook As New Address_Book
        openaddressbook.Show()
        startmenu.Hide()
    End Sub

    Private Sub VolumeControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim openvolumecontrol As New volume_control
        openvolumecontrol.Show()
        startmenu.Hide()
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        Dim openrun As New run
        openrun.Show()
        startmenu.Hide()
    End Sub

    Private Sub PaintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaintToolStripMenuItem.Click
        Dim openpaint As New paint
        openpaint.Show()
        startmenu.Hide()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

    End Sub

    Private Sub FolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderToolStripMenuItem.Click
        desktopicons.Items.Add("New Folder")
    End Sub

    Private Sub desktopicons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles desktopicons.MouseDown
        startmenu.Hide()

    End Sub

    Private Sub GuessTheNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuessTheNumberToolStripMenuItem.Click
        Dim openguessnumber As New Guess_The_Number
        openguessnumber.Show()
        startmenu.Hide()
    End Sub

    Private Sub StartRunnerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartRunnerToolStripMenuItem.Click
        Dim openstartrunner As New startrunner
        openstartrunner.Show()
        startmenu.Hide()
    End Sub

    Private Sub ErrorBlasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrorBlasterToolStripMenuItem.Click
        Dim openerror As New errorblaster
        openerror.Show()
        startmenu.Hide()
    End Sub

    Private Sub SkindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkindowsToolStripMenuItem.Click
        Dim openskin As New Skindows_95
        openskin.Show()
        startmenu.Hide()
    End Sub

    Private Sub WebChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebChatToolStripMenuItem.Click
        Dim openchat As New Webchat1998
        openchat.Show()
        startmenu.Hide()
    End Sub

    Private Sub TimeDistorterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SurviveTheDayToolStripMenuItem.Click
        Dim opensurvivetheday As New Survive_The_Day
        opensurvivetheday.Show()
        startmenu.Hide()
    End Sub

    Private Sub taskbartime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taskbartime.Click
        Dim showmess As New createmsg
        showmess.infomessage.Text = "Your save code is: 2iu35giu"
        showmess.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        startmenu.Hide()
        desktopicons.Hide()
        taskbar.Hide()
        startbutton.Hide()

        Dim bStr(My.Resources.Windows_ME_Shutdown.Length) As Byte
        My.Resources.Windows_ME_Shutdown.Read(bStr, 0, My.Resources.Windows_ME_Shutdown.Length)
        My.Computer.Audio.Play(bStr, AudioPlayMode.WaitToComplete)
        Me.Close()
    End Sub

    Private Sub Form_IsClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        
    End Sub

    Private Sub WindowsExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem.Click
        Dim openinternet As New Internet_Explorer_52001
        openinternet.Show()
        startmenu.Hide()
    End Sub

    Private Sub desktopicons_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles desktopicons.ItemDrag
        Dim lvi As ListViewItem = CType(e.Item, ListViewItem)
        desktopicons.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem", lvi), DragDropEffects.Move)
    End Sub
    Private Sub desktopicons_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles desktopicons.DragEnter
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem") Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub
    Private Sub desktopicons_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles desktopicons.DragOver
        Dim lvi As ListViewItem = CType(e.Data.GetData("System.Windows.Forms.ListViewItem"), ListViewItem)
        Dim Offset As Size = Size.Subtract(Cursor.Size, New Size(Cursor.HotSpot.X, Cursor.HotSpot.Y))
        lvi.Position = Point.Subtract(desktopicons.PointToClient(New Point(e.X, e.Y)), Offset)
        e.Effect = DragDropEffects.Move
    End Sub
End Class