<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class titlebar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lcorner = New System.Windows.Forms.PictureBox()
        Me.rcorner = New System.Windows.Forms.PictureBox()
        Me.appName = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.PictureBox()
        Me.btnmax = New System.Windows.Forms.PictureBox()
        Me.btnmin = New System.Windows.Forms.PictureBox()
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.appIcon = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.lcorner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcorner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95top
        Me.Panel1.Controls.Add(Me.lcorner)
        Me.Panel1.Controls.Add(Me.rcorner)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 4)
        Me.Panel1.TabIndex = 0
        '
        'lcorner
        '
        Me.lcorner.BackColor = System.Drawing.Color.Silver
        Me.lcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95topleftcorner
        Me.lcorner.Dock = System.Windows.Forms.DockStyle.Left
        Me.lcorner.Location = New System.Drawing.Point(0, 0)
        Me.lcorner.Name = "lcorner"
        Me.lcorner.Size = New System.Drawing.Size(4, 4)
        Me.lcorner.TabIndex = 1
        Me.lcorner.TabStop = False
        '
        'rcorner
        '
        Me.rcorner.BackColor = System.Drawing.Color.Silver
        Me.rcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95toprightcorner
        Me.rcorner.Dock = System.Windows.Forms.DockStyle.Right
        Me.rcorner.Location = New System.Drawing.Point(564, 0)
        Me.rcorner.Name = "rcorner"
        Me.rcorner.Size = New System.Drawing.Size(4, 4)
        Me.rcorner.TabIndex = 2
        Me.rcorner.TabStop = False
        '
        'appName
        '
        Me.appName.AutoSize = True
        Me.appName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.appName.ForeColor = System.Drawing.Color.White
        Me.appName.Location = New System.Drawing.Point(26, 6)
        Me.appName.Name = "appName"
        Me.appName.Size = New System.Drawing.Size(73, 19)
        Me.appName.TabIndex = 1
        Me.appName.Text = "Windows"
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Image = Global.Histacom.My.Resources.Resources.close
        Me.btnclose.Location = New System.Drawing.Point(548, 7)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(17, 15)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnclose.TabIndex = 3
        Me.btnclose.TabStop = False
        '
        'btnmax
        '
        Me.btnmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmax.BackColor = System.Drawing.Color.Transparent
        Me.btnmax.Image = Global.Histacom.My.Resources.Resources.Maximize
        Me.btnmax.Location = New System.Drawing.Point(530, 7)
        Me.btnmax.Name = "btnmax"
        Me.btnmax.Size = New System.Drawing.Size(17, 15)
        Me.btnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnmax.TabIndex = 3
        Me.btnmax.TabStop = False
        '
        'btnmin
        '
        Me.btnmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmin.BackColor = System.Drawing.Color.Transparent
        Me.btnmin.Image = Global.Histacom.My.Resources.Resources.minimize
        Me.btnmin.Location = New System.Drawing.Point(514, 7)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(17, 15)
        Me.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnmin.TabIndex = 3
        Me.btnmin.TabStop = False
        '
        'look
        '
        Me.look.Enabled = True
        Me.look.Interval = 3000
        '
        'appIcon
        '
        Me.appIcon.BackColor = System.Drawing.Color.Silver
        Me.appIcon.Location = New System.Drawing.Point(3, 7)
        Me.appIcon.Name = "appIcon"
        Me.appIcon.Size = New System.Drawing.Size(17, 16)
        Me.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.appIcon.TabIndex = 4
        Me.appIcon.TabStop = False
        '
        'titlebar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.Controls.Add(Me.appIcon)
        Me.Controls.Add(Me.btnmin)
        Me.Controls.Add(Me.btnmax)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.appName)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "titlebar"
        Me.Size = New System.Drawing.Size(568, 25)
        Me.Panel1.ResumeLayout(False)
        CType(Me.lcorner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcorner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lcorner As PictureBox
    Friend WithEvents rcorner As PictureBox
    Friend WithEvents appName As Label
    Friend WithEvents btnclose As PictureBox
    Friend WithEvents btnmax As PictureBox
    Friend WithEvents btnmin As PictureBox
    Friend WithEvents look As Timer
    Friend WithEvents appIcon As PictureBox
End Class
