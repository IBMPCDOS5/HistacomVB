<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class webchat_2000
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(webchat_2000))
        Me.count = New System.Windows.Forms.Timer(Me.components)
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.Chat = New System.Windows.Forms.Timer(Me.components)
        Me.waitingdownload = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.topleftcorner = New System.Windows.Forms.Panel()
        Me.typechat = New System.Windows.Forms.TextBox()
        Me.bottomleftcorner = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.history = New System.Windows.Forms.TextBox()
        Me.bottomrightcorner = New System.Windows.Forms.Panel()
        Me.toprightcorner = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtscreenname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.program = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.program.SuspendLayout()
        Me.SuspendLayout()
        '
        'count
        '
        Me.count.Interval = 1000
        '
        'pullside
        '
        Me.pullside.Interval = 1
        '
        'pullbottom
        '
        Me.pullbottom.Interval = 1
        '
        'pullbs
        '
        Me.pullbs.Interval = 1
        '
        'look
        '
        '
        'Chat
        '
        Me.Chat.Interval = 1000
        '
        'waitingdownload
        '
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.PowderBlue
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(599, 51)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(195, 329)
        Me.ListBox1.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(596, 422)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(195, 51)
        Me.Panel1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Time Distorter 0.3"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(109, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Download"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(634, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Users Logged In"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.PaleGreen
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(514, 444)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Speak"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'topleftcorner
        '
        Me.topleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95topleftcorner
        Me.topleftcorner.Location = New System.Drawing.Point(0, 0)
        Me.topleftcorner.Name = "topleftcorner"
        Me.topleftcorner.Size = New System.Drawing.Size(4, 4)
        Me.topleftcorner.TabIndex = 1
        '
        'typechat
        '
        Me.typechat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.typechat.BackColor = System.Drawing.Color.Honeydew
        Me.typechat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.typechat.Location = New System.Drawing.Point(22, 444)
        Me.typechat.Multiline = True
        Me.typechat.Name = "typechat"
        Me.typechat.Size = New System.Drawing.Size(487, 23)
        Me.typechat.TabIndex = 9
        '
        'bottomleftcorner
        '
        Me.bottomleftcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bottomleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomleftcorner
        Me.bottomleftcorner.Location = New System.Drawing.Point(0, 487)
        Me.bottomleftcorner.Name = "bottomleftcorner"
        Me.bottomleftcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomleftcorner.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(642, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "File Sharing"
        '
        'history
        '
        Me.history.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.history.BackColor = System.Drawing.Color.LightGreen
        Me.history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.history.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.history.Location = New System.Drawing.Point(22, 52)
        Me.history.Multiline = True
        Me.history.Name = "history"
        Me.history.ReadOnly = True
        Me.history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.history.Size = New System.Drawing.Size(563, 386)
        Me.history.TabIndex = 8
        '
        'bottomrightcorner
        '
        Me.bottomrightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottomrightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomrightcorner
        Me.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.bottomrightcorner.Location = New System.Drawing.Point(812, 487)
        Me.bottomrightcorner.Name = "bottomrightcorner"
        Me.bottomrightcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomrightcorner.TabIndex = 4
        '
        'toprightcorner
        '
        Me.toprightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95toprightcorner
        Me.toprightcorner.Location = New System.Drawing.Point(812, 0)
        Me.toprightcorner.Name = "toprightcorner"
        Me.toprightcorner.Size = New System.Drawing.Size(4, 4)
        Me.toprightcorner.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(437, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "To Speak Just type a message in the bottom textbox then press the speak button"
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.Lime
        Me.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.login.Controls.Add(Me.PictureBox1)
        Me.login.Controls.Add(Me.TextBox2)
        Me.login.Controls.Add(Me.TextBox1)
        Me.login.Controls.Add(Me.Label4)
        Me.login.Controls.Add(Me.Button1)
        Me.login.Controls.Add(Me.txtscreenname)
        Me.login.Controls.Add(Me.Label2)
        Me.login.Location = New System.Drawing.Point(92, 114)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(497, 255)
        Me.login.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please Type in a Screen Name"
        '
        'txtscreenname
        '
        Me.txtscreenname.Location = New System.Drawing.Point(328, 184)
        Me.txtscreenname.Name = "txtscreenname"
        Me.txtscreenname.Size = New System.Drawing.Size(151, 20)
        Me.txtscreenname.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Location = New System.Drawing.Point(328, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Chat Room Rules"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Honeydew
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(26, 64)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 178)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.SpringGreen
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(331, 51)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(151, 108)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "A screen name is a tempary name which is displayed in place of your real name. To" &
    " keep your identity safe please don't enter your real name in this chatroom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Histacom.My.Resources.Resources.webchat_2000_title
        Me.PictureBox1.Location = New System.Drawing.Point(193, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.Azure
        Me.program.Controls.Add(Me.login)
        Me.program.Controls.Add(Me.Label7)
        Me.program.Controls.Add(Me.toprightcorner)
        Me.program.Controls.Add(Me.bottomrightcorner)
        Me.program.Controls.Add(Me.history)
        Me.program.Controls.Add(Me.Label6)
        Me.program.Controls.Add(Me.bottomleftcorner)
        Me.program.Controls.Add(Me.typechat)
        Me.program.Controls.Add(Me.topleftcorner)
        Me.program.Controls.Add(Me.Button2)
        Me.program.Controls.Add(Me.Label1)
        Me.program.Controls.Add(Me.Panel1)
        Me.program.Controls.Add(Me.ListBox1)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(816, 491)
        Me.program.TabIndex = 21
        '
        'webchat_2000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 491)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "webchat_2000"
        Me.Text = "webchat_2000"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.login.ResumeLayout(False)
        Me.login.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.program.ResumeLayout(False)
        Me.program.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents count As System.Windows.Forms.Timer
    Friend WithEvents pullside As System.Windows.Forms.Timer
    Friend WithEvents pullbottom As System.Windows.Forms.Timer
    Friend WithEvents pullbs As System.Windows.Forms.Timer
    Friend WithEvents look As System.Windows.Forms.Timer
    Friend WithEvents Chat As System.Windows.Forms.Timer
    Friend WithEvents waitingdownload As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents topleftcorner As Panel
    Friend WithEvents typechat As TextBox
    Friend WithEvents bottomleftcorner As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents history As TextBox
    Friend WithEvents bottomrightcorner As Panel
    Friend WithEvents toprightcorner As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents login As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtscreenname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents program As Panel
End Class
