<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Title_Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Title_Screen))
        Me.buttonnewgame = New System.Windows.Forms.PictureBox()
        Me.buttonloadgame = New System.Windows.Forms.PictureBox()
        Me.buttonexit = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        CType(Me.buttonnewgame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonloadgame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonexit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonnewgame
        '
        Me.buttonnewgame.BackColor = System.Drawing.Color.Transparent
        Me.buttonnewgame.Image = Global.Histacom.My.Resources.Resources.new_game
        Me.buttonnewgame.Location = New System.Drawing.Point(33, 119)
        Me.buttonnewgame.Name = "buttonnewgame"
        Me.buttonnewgame.Size = New System.Drawing.Size(156, 113)
        Me.buttonnewgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonnewgame.TabIndex = 0
        Me.buttonnewgame.TabStop = False
        '
        'buttonloadgame
        '
        Me.buttonloadgame.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.buttonloadgame.BackColor = System.Drawing.Color.Transparent
        Me.buttonloadgame.Image = Global.Histacom.My.Resources.Resources.load_game
        Me.buttonloadgame.Location = New System.Drawing.Point(310, 119)
        Me.buttonloadgame.Name = "buttonloadgame"
        Me.buttonloadgame.Size = New System.Drawing.Size(156, 113)
        Me.buttonloadgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonloadgame.TabIndex = 1
        Me.buttonloadgame.TabStop = False
        '
        'buttonexit
        '
        Me.buttonexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonexit.BackColor = System.Drawing.Color.Transparent
        Me.buttonexit.Image = Global.Histacom.My.Resources.Resources.exitimg
        Me.buttonexit.Location = New System.Drawing.Point(602, 119)
        Me.buttonexit.Name = "buttonexit"
        Me.buttonexit.Size = New System.Drawing.Size(156, 113)
        Me.buttonexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonexit.TabIndex = 2
        Me.buttonexit.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(52, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(720, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Histacom 2.0 origanally By 12padams now by Alex (aka SonicMad)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(266, 485)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Alpha 1 (Everything is basically messed up, right now)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 535)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EXTRA INFO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(42, 312)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.Size = New System.Drawing.Size(716, 20)
        Me.txtNew.TabIndex = 5
        Me.txtNew.Visible = False
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblNew.Location = New System.Drawing.Point(138, 284)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(561, 25)
        Me.lblNew.TabIndex = 6
        Me.lblNew.Text = "Give your game a profile name (You do need to remember this):"
        Me.lblNew.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(281, 338)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(185, 23)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "Go!"
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'Title_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Histacom.My.Resources.Resources.Histacom_1_8_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 560)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonexit)
        Me.Controls.Add(Me.buttonloadgame)
        Me.Controls.Add(Me.buttonnewgame)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Title_Screen"
        Me.Text = "Histacom 1.8.5"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.buttonnewgame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonloadgame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonexit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonnewgame As System.Windows.Forms.PictureBox
    Friend WithEvents buttonloadgame As System.Windows.Forms.PictureBox
    Friend WithEvents buttonexit As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNew As TextBox
    Friend WithEvents lblNew As Label
    Friend WithEvents btnNew As Button
End Class
