<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guess_The_Number
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnimpossible = New System.Windows.Forms.Button()
        Me.btnveryhard = New System.Windows.Forms.Button()
        Me.btnhard = New System.Windows.Forms.Button()
        Me.btnmedium = New System.Windows.Forms.Button()
        Me.btneasy = New System.Windows.Forms.Button()
        Me.btnveryeasy = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.higherorlower = New System.Windows.Forms.Label()
        Me.txtGuessedNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flasher = New System.Windows.Forms.Timer(Me.components)
        Me.selector = New System.Windows.Forms.Timer(Me.components)
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.program = New System.Windows.Forms.Panel()
        Me.toprightcorner = New System.Windows.Forms.Panel()
        Me.bottomrightcorner = New System.Windows.Forms.Panel()
        Me.bottomleftcorner = New System.Windows.Forms.Panel()
        Me.topleftcorner = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.program.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnimpossible)
        Me.Panel1.Controls.Add(Me.btnveryhard)
        Me.Panel1.Controls.Add(Me.btnhard)
        Me.Panel1.Controls.Add(Me.btnmedium)
        Me.Panel1.Controls.Add(Me.btneasy)
        Me.Panel1.Controls.Add(Me.btnveryeasy)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(6, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 171)
        Me.Panel1.TabIndex = 13
        '
        'btnimpossible
        '
        Me.btnimpossible.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnimpossible.Location = New System.Drawing.Point(311, 132)
        Me.btnimpossible.Name = "btnimpossible"
        Me.btnimpossible.Size = New System.Drawing.Size(74, 32)
        Me.btnimpossible.TabIndex = 6
        Me.btnimpossible.Text = "Impossible"
        Me.btnimpossible.UseVisualStyleBackColor = True
        '
        'btnveryhard
        '
        Me.btnveryhard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnveryhard.Location = New System.Drawing.Point(160, 132)
        Me.btnveryhard.Name = "btnveryhard"
        Me.btnveryhard.Size = New System.Drawing.Size(74, 32)
        Me.btnveryhard.TabIndex = 5
        Me.btnveryhard.Text = "Very Hard"
        Me.btnveryhard.UseVisualStyleBackColor = True
        '
        'btnhard
        '
        Me.btnhard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnhard.Location = New System.Drawing.Point(10, 132)
        Me.btnhard.Name = "btnhard"
        Me.btnhard.Size = New System.Drawing.Size(74, 32)
        Me.btnhard.TabIndex = 4
        Me.btnhard.Text = "Hard"
        Me.btnhard.UseVisualStyleBackColor = True
        '
        'btnmedium
        '
        Me.btnmedium.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmedium.Location = New System.Drawing.Point(316, 59)
        Me.btnmedium.Name = "btnmedium"
        Me.btnmedium.Size = New System.Drawing.Size(74, 32)
        Me.btnmedium.TabIndex = 3
        Me.btnmedium.Text = "Medium"
        Me.btnmedium.UseVisualStyleBackColor = True
        '
        'btneasy
        '
        Me.btneasy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btneasy.Location = New System.Drawing.Point(160, 66)
        Me.btneasy.Name = "btneasy"
        Me.btneasy.Size = New System.Drawing.Size(74, 32)
        Me.btneasy.TabIndex = 2
        Me.btneasy.Text = "Easy"
        Me.btneasy.UseVisualStyleBackColor = True
        '
        'btnveryeasy
        '
        Me.btnveryeasy.Location = New System.Drawing.Point(11, 65)
        Me.btnveryeasy.Name = "btnveryeasy"
        Me.btnveryeasy.Size = New System.Drawing.Size(74, 32)
        Me.btnveryeasy.TabIndex = 1
        Me.btnveryeasy.Text = "Very Easy"
        Me.btnveryeasy.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Please Choose A Difficulty level"
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(402, 27)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Restart"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "then press check"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(168, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'higherorlower
        '
        Me.higherorlower.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.higherorlower.AutoSize = True
        Me.higherorlower.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.higherorlower.Location = New System.Drawing.Point(84, 53)
        Me.higherorlower.Name = "higherorlower"
        Me.higherorlower.Size = New System.Drawing.Size(78, 18)
        Me.higherorlower.TabIndex = 9
        Me.higherorlower.Text = "Unknown"
        '
        'txtGuessedNumber
        '
        Me.txtGuessedNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGuessedNumber.Location = New System.Drawing.Point(126, 25)
        Me.txtGuessedNumber.Name = "txtGuessedNumber"
        Me.txtGuessedNumber.Size = New System.Drawing.Size(173, 20)
        Me.txtGuessedNumber.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Type your guess here:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "I am thinking of a number between 1-100"
        '
        'flasher
        '
        '
        'selector
        '
        Me.selector.Interval = 1000
        '
        'pullbs
        '
        Me.pullbs.Interval = 1
        '
        'pullbottom
        '
        Me.pullbottom.Interval = 1
        '
        'pullside
        '
        Me.pullside.Interval = 1
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.Silver
        Me.program.Controls.Add(Me.Panel1)
        Me.program.Controls.Add(Me.Button2)
        Me.program.Controls.Add(Me.toprightcorner)
        Me.program.Controls.Add(Me.bottomrightcorner)
        Me.program.Controls.Add(Me.Label3)
        Me.program.Controls.Add(Me.bottomleftcorner)
        Me.program.Controls.Add(Me.Button1)
        Me.program.Controls.Add(Me.higherorlower)
        Me.program.Controls.Add(Me.topleftcorner)
        Me.program.Controls.Add(Me.txtGuessedNumber)
        Me.program.Controls.Add(Me.Label2)
        Me.program.Controls.Add(Me.Label1)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(402, 184)
        Me.program.TabIndex = 14
        '
        'toprightcorner
        '
        Me.toprightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95toprightcorner
        Me.toprightcorner.Location = New System.Drawing.Point(398, 0)
        Me.toprightcorner.Name = "toprightcorner"
        Me.toprightcorner.Size = New System.Drawing.Size(4, 4)
        Me.toprightcorner.TabIndex = 6
        '
        'bottomrightcorner
        '
        Me.bottomrightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottomrightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomrightcorner
        Me.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.bottomrightcorner.Location = New System.Drawing.Point(398, 180)
        Me.bottomrightcorner.Name = "bottomrightcorner"
        Me.bottomrightcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomrightcorner.TabIndex = 4
        '
        'bottomleftcorner
        '
        Me.bottomleftcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bottomleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomleftcorner
        Me.bottomleftcorner.Location = New System.Drawing.Point(0, 180)
        Me.bottomleftcorner.Name = "bottomleftcorner"
        Me.bottomleftcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomleftcorner.TabIndex = 2
        '
        'topleftcorner
        '
        Me.topleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95topleftcorner
        Me.topleftcorner.Location = New System.Drawing.Point(0, 0)
        Me.topleftcorner.Name = "topleftcorner"
        Me.topleftcorner.Size = New System.Drawing.Size(4, 4)
        Me.topleftcorner.TabIndex = 1
        '
        'Guess_The_Number
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 184)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Guess_The_Number"
        Me.Text = "Guess_The_Number_98"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.program.ResumeLayout(False)
        Me.program.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents higherorlower As System.Windows.Forms.Label
    Friend WithEvents txtGuessedNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnimpossible As System.Windows.Forms.Button
    Friend WithEvents btnveryhard As System.Windows.Forms.Button
    Friend WithEvents btnhard As System.Windows.Forms.Button
    Friend WithEvents btnmedium As System.Windows.Forms.Button
    Friend WithEvents btneasy As System.Windows.Forms.Button
    Friend WithEvents btnveryeasy As System.Windows.Forms.Button
    Friend WithEvents flasher As System.Windows.Forms.Timer
    Friend WithEvents selector As System.Windows.Forms.Timer
    Friend WithEvents look As System.Windows.Forms.Timer
    Friend WithEvents pullbs As System.Windows.Forms.Timer
    Friend WithEvents pullbottom As System.Windows.Forms.Timer
    Friend WithEvents pullside As System.Windows.Forms.Timer
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents toprightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomrightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomleftcorner As System.Windows.Forms.Panel
    Friend WithEvents topleftcorner As System.Windows.Forms.Panel
End Class
