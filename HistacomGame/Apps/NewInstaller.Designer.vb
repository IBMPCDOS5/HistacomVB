<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewInstaller
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
        Me.program = New System.Windows.Forms.Panel()
        Me.pnlnav = New System.Windows.Forms.Panel()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.lblins = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.pnlLic = New System.Windows.Forms.Panel()
        Me.lbllincense = New System.Windows.Forms.Label()
        Me.txtlicense = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sideimg = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.download = New System.Windows.Forms.Timer(Me.components)
        Me.program.SuspendLayout()
        Me.pnlnav.SuspendLayout()
        Me.pnlmain.SuspendLayout()
        Me.pnlLic.SuspendLayout()
        CType(Me.sideimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'program
        '
        Me.program.Controls.Add(Me.pnlnav)
        Me.program.Controls.Add(Me.pnlmain)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(702, 460)
        Me.program.TabIndex = 0
        '
        'pnlnav
        '
        Me.pnlnav.Controls.Add(Me.btnCan)
        Me.pnlnav.Controls.Add(Me.lblins)
        Me.pnlnav.Controls.Add(Me.btnPrev)
        Me.pnlnav.Controls.Add(Me.btnNext)
        Me.pnlnav.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlnav.Location = New System.Drawing.Point(0, 406)
        Me.pnlnav.Name = "pnlnav"
        Me.pnlnav.Size = New System.Drawing.Size(702, 54)
        Me.pnlnav.TabIndex = 3
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(615, 19)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 23)
        Me.btnCan.TabIndex = 0
        Me.btnCan.Text = "Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'lblins
        '
        Me.lblins.AutoSize = True
        Me.lblins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblins.Location = New System.Drawing.Point(224, 22)
        Me.lblins.Name = "lblins"
        Me.lblins.Size = New System.Drawing.Size(208, 20)
        Me.lblins.TabIndex = 4
        Me.lblins.Text = "Simply click Next to continue"
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(438, 19)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 0
        Me.btnPrev.Text = "< Prev"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(519, 19)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'pnlmain
        '
        Me.pnlmain.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlmain.Controls.Add(Me.Progress)
        Me.pnlmain.Controls.Add(Me.pnlLic)
        Me.pnlmain.Controls.Add(Me.Label3)
        Me.pnlmain.Controls.Add(Me.sideimg)
        Me.pnlmain.Controls.Add(Me.Label1)
        Me.pnlmain.Controls.Add(Me.Label2)
        Me.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlmain.Location = New System.Drawing.Point(0, 0)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(702, 460)
        Me.pnlmain.TabIndex = 4
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(132, 202)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(535, 36)
        Me.Progress.TabIndex = 8
        Me.Progress.Visible = False
        '
        'pnlLic
        '
        Me.pnlLic.Controls.Add(Me.lbllincense)
        Me.pnlLic.Controls.Add(Me.txtlicense)
        Me.pnlLic.Location = New System.Drawing.Point(337, 181)
        Me.pnlLic.Name = "pnlLic"
        Me.pnlLic.Size = New System.Drawing.Size(318, 219)
        Me.pnlLic.TabIndex = 7
        '
        'lbllincense
        '
        Me.lbllincense.AutoSize = True
        Me.lbllincense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbllincense.Location = New System.Drawing.Point(16, 8)
        Me.lbllincense.Name = "lbllincense"
        Me.lbllincense.Size = New System.Drawing.Size(226, 20)
        Me.lbllincense.TabIndex = 6
        Me.lbllincense.Text = "You must agree to this license:"
        '
        'txtlicense
        '
        Me.txtlicense.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtlicense.Enabled = False
        Me.txtlicense.Location = New System.Drawing.Point(7, 47)
        Me.txtlicense.Multiline = True
        Me.txtlicense.Name = "txtlicense"
        Me.txtlicense.Size = New System.Drawing.Size(308, 149)
        Me.txtlicense.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label3.Location = New System.Drawing.Point(124, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(500, 92)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "You are currently installing:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " A program"
        '
        'sideimg
        '
        Me.sideimg.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideimg.Location = New System.Drawing.Point(0, 0)
        Me.sideimg.Name = "sideimg"
        Me.sideimg.Size = New System.Drawing.Size(118, 460)
        Me.sideimg.TabIndex = 0
        Me.sideimg.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to the new 12padams installer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(124, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(554, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "This Application will allow to install your programs quicker, easier and... quick" &
    "er"
        '
        'download
        '
        '
        'NewInstaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 460)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewInstaller"
        Me.Text = "NewInstaller"
        Me.TopMost = True
        Me.program.ResumeLayout(False)
        Me.pnlnav.ResumeLayout(False)
        Me.pnlnav.PerformLayout()
        Me.pnlmain.ResumeLayout(False)
        Me.pnlmain.PerformLayout()
        Me.pnlLic.ResumeLayout(False)
        Me.pnlLic.PerformLayout()
        CType(Me.sideimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents program As Panel
    Friend WithEvents sideimg As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlnav As Panel
    Friend WithEvents pnlmain As Panel
    Friend WithEvents btnCan As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblins As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlLic As Panel
    Friend WithEvents lbllincense As Label
    Friend WithEvents txtlicense As TextBox
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents download As Timer
End Class
