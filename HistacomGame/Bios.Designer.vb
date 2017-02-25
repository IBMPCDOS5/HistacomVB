<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bios
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
        Me.Sunimage = New System.Windows.Forms.PictureBox()
        Me.Americanimage = New System.Windows.Forms.PictureBox()
        Me.biostxt1 = New System.Windows.Forms.Label()
        Me.biostxt2 = New System.Windows.Forms.Label()
        Me.biostxt3 = New System.Windows.Forms.Label()
        Me.biostxt4 = New System.Windows.Forms.Label()
        Me.biostxt5 = New System.Windows.Forms.Label()
        Me.biostxt6 = New System.Windows.Forms.Label()
        Me.biostxt7 = New System.Windows.Forms.Label()
        Me.biostxt9 = New System.Windows.Forms.Label()
        Me.biostxt8 = New System.Windows.Forms.Label()
        Me.biostxt10 = New System.Windows.Forms.Label()
        Me.biostxt11 = New System.Windows.Forms.Label()
        Me.biostxt12 = New System.Windows.Forms.Label()
        Me.biostxt13 = New System.Windows.Forms.Label()
        Me.biostxt15 = New System.Windows.Forms.Label()
        Me.biostxt14 = New System.Windows.Forms.Label()
        Me.biostxt16 = New System.Windows.Forms.Label()
        Me.Biosload = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Sunimage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Americanimage,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Sunimage
        '
        Me.Sunimage.Image = Global.Histacom.My.Resources.Resources.biosmakerimage
        Me.Sunimage.Location = New System.Drawing.Point(407, 2)
        Me.Sunimage.Name = "Sunimage"
        Me.Sunimage.Size = New System.Drawing.Size(348, 126)
        Me.Sunimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Sunimage.TabIndex = 1
        Me.Sunimage.TabStop = false
        '
        'Americanimage
        '
        Me.Americanimage.Image = Global.Histacom.My.Resources.Resources.biosimage
        Me.Americanimage.Location = New System.Drawing.Point(3, 2)
        Me.Americanimage.Name = "Americanimage"
        Me.Americanimage.Size = New System.Drawing.Size(356, 126)
        Me.Americanimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Americanimage.TabIndex = 0
        Me.Americanimage.TabStop = false
        '
        'biostxt1
        '
        Me.biostxt1.AutoSize = true
        Me.biostxt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt1.ForeColor = System.Drawing.Color.Silver
        Me.biostxt1.Location = New System.Drawing.Point(0, 131)
        Me.biostxt1.Name = "biostxt1"
        Me.biostxt1.Size = New System.Drawing.Size(533, 29)
        Me.biostxt1.TabIndex = 2
        Me.biostxt1.Text = "AMIBIOS(C) 1995 American Megatrends, Inc."
        Me.biostxt1.Visible = false
        '
        'biostxt2
        '
        Me.biostxt2.AutoSize = true
        Me.biostxt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt2.ForeColor = System.Drawing.Color.Silver
        Me.biostxt2.Location = New System.Drawing.Point(0, 160)
        Me.biostxt2.Name = "biostxt2"
        Me.biostxt2.Size = New System.Drawing.Size(562, 29)
        Me.biostxt2.TabIndex = 3
        Me.biostxt2.Text = "BIOS Date:   02/25/95   16:04:09    Ver: 00.00.15"
        Me.biostxt2.Visible = false
        '
        'biostxt3
        '
        Me.biostxt3.AutoSize = true
        Me.biostxt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt3.ForeColor = System.Drawing.Color.Silver
        Me.biostxt3.Location = New System.Drawing.Point(0, 189)
        Me.biostxt3.Name = "biostxt3"
        Me.biostxt3.Size = New System.Drawing.Size(381, 29)
        Me.biostxt3.TabIndex = 4
        Me.biostxt3.Text = "Sun BIOS Revision: 07.01.38.03"
        Me.biostxt3.Visible = false
        '
        'biostxt4
        '
        Me.biostxt4.AutoSize = true
        Me.biostxt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt4.ForeColor = System.Drawing.Color.Silver
        Me.biostxt4.Location = New System.Drawing.Point(1, 218)
        Me.biostxt4.Name = "biostxt4"
        Me.biostxt4.Size = New System.Drawing.Size(731, 29)
        Me.biostxt4.TabIndex = 5
        Me.biostxt4.Text = "Sun Fire X4170 Server       CPU Power (TOP Limit) = 95 Watts"
        Me.biostxt4.Visible = false
        '
        'biostxt5
        '
        Me.biostxt5.AutoSize = true
        Me.biostxt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt5.ForeColor = System.Drawing.Color.Silver
        Me.biostxt5.Location = New System.Drawing.Point(1, 247)
        Me.biostxt5.Name = "biostxt5"
        Me.biostxt5.Size = New System.Drawing.Size(426, 29)
        Me.biostxt5.TabIndex = 6
        Me.biostxt5.Text = "Product Serial Number:0000000000"
        Me.biostxt5.Visible = false
        '
        'biostxt6
        '
        Me.biostxt6.AutoSize = true
        Me.biostxt6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt6.ForeColor = System.Drawing.Color.Silver
        Me.biostxt6.Location = New System.Drawing.Point(1, 276)
        Me.biostxt6.Name = "biostxt6"
        Me.biostxt6.Size = New System.Drawing.Size(720, 29)
        Me.biostxt6.TabIndex = 7
        Me.biostxt6.Text = "CPU : Intel(R) Xeon(R)   CPU                      X5570   L 2.93GHz"
        Me.biostxt6.Visible = false
        '
        'biostxt7
        '
        Me.biostxt7.AutoSize = true
        Me.biostxt7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt7.ForeColor = System.Drawing.Color.Silver
        Me.biostxt7.Location = New System.Drawing.Point(1, 305)
        Me.biostxt7.Name = "biostxt7"
        Me.biostxt7.Size = New System.Drawing.Size(382, 29)
        Me.biostxt7.TabIndex = 8
        Me.biostxt7.Text = " Speed : 2.93 GHz      Count : 16"
        Me.biostxt7.Visible = false
        '
        'biostxt9
        '
        Me.biostxt9.AutoSize = true
        Me.biostxt9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt9.ForeColor = System.Drawing.Color.Silver
        Me.biostxt9.Location = New System.Drawing.Point(1, 388)
        Me.biostxt9.Name = "biostxt9"
        Me.biostxt9.Size = New System.Drawing.Size(929, 29)
        Me.biostxt9.TabIndex = 9
        Me.biostxt9.Text = "Press F12 if you want to boot from the network (CTRL+N on Remote Keyboard)"
        Me.biostxt9.Visible = false
        '
        'biostxt8
        '
        Me.biostxt8.AutoSize = true
        Me.biostxt8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt8.ForeColor = System.Drawing.Color.Silver
        Me.biostxt8.Location = New System.Drawing.Point(1, 363)
        Me.biostxt8.Name = "biostxt8"
        Me.biostxt8.Size = New System.Drawing.Size(642, 29)
        Me.biostxt8.TabIndex = 10
        Me.biostxt8.Text = "Press F2 to run Setup (CTRL+E on Remote Keyboard)"
        Me.biostxt8.Visible = false
        '
        'biostxt10
        '
        Me.biostxt10.AutoSize = true
        Me.biostxt10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt10.ForeColor = System.Drawing.Color.Silver
        Me.biostxt10.Location = New System.Drawing.Point(1, 417)
        Me.biostxt10.Name = "biostxt10"
        Me.biostxt10.Size = New System.Drawing.Size(686, 29)
        Me.biostxt10.TabIndex = 11
        Me.biostxt10.Text = "Press F8 for BBS POPUP (CTRL+P on Remote Keyboard)"
        Me.biostxt10.Visible = false
        '
        'biostxt11
        '
        Me.biostxt11.AutoSize = true
        Me.biostxt11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt11.ForeColor = System.Drawing.Color.Silver
        Me.biostxt11.Location = New System.Drawing.Point(-2, 446)
        Me.biostxt11.Name = "biostxt11"
        Me.biostxt11.Size = New System.Drawing.Size(426, 29)
        Me.biostxt11.TabIndex = 12
        Me.biostxt11.Text = "QPI Operational Speed at : 6.4GT/s"
        Me.biostxt11.Visible = false
        '
        'biostxt12
        '
        Me.biostxt12.AutoSize = true
        Me.biostxt12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt12.ForeColor = System.Drawing.Color.Silver
        Me.biostxt12.Location = New System.Drawing.Point(1, 475)
        Me.biostxt12.Name = "biostxt12"
        Me.biostxt12.Size = New System.Drawing.Size(377, 29)
        Me.biostxt12.TabIndex = 13
        Me.biostxt12.Text = "BNC Fireware Revision: 2.0.2.9"
        Me.biostxt12.Visible = false
        '
        'biostxt13
        '
        Me.biostxt13.AutoSize = true
        Me.biostxt13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt13.ForeColor = System.Drawing.Color.Silver
        Me.biostxt13.Location = New System.Drawing.Point(1, 504)
        Me.biostxt13.Name = "biostxt13"
        Me.biostxt13.Size = New System.Drawing.Size(347, 29)
        Me.biostxt13.TabIndex = 14
        Me.biostxt13.Text = "Initializing USB Controllers .."
        Me.biostxt13.Visible = false
        '
        'biostxt15
        '
        Me.biostxt15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.biostxt15.AutoSize = true
        Me.biostxt15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt15.ForeColor = System.Drawing.Color.Silver
        Me.biostxt15.Location = New System.Drawing.Point(0, 615)
        Me.biostxt15.Name = "biostxt15"
        Me.biostxt15.Size = New System.Drawing.Size(765, 29)
        Me.biostxt15.TabIndex = 15
        Me.biostxt15.Text = "64-3047-009999-00101111-022509-TYLSBURG-3AB0N838-Y2KC"
        '
        'biostxt14
        '
        Me.biostxt14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.biostxt14.AutoSize = true
        Me.biostxt14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt14.ForeColor = System.Drawing.Color.Silver
        Me.biostxt14.Location = New System.Drawing.Point(-2, 586)
        Me.biostxt14.Name = "biostxt14"
        Me.biostxt14.Size = New System.Drawing.Size(365, 29)
        Me.biostxt14.TabIndex = 16
        Me.biostxt14.Text = "(C) American Megatrends. Inc."
        '
        'biostxt16
        '
        Me.biostxt16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.biostxt16.AutoSize = true
        Me.biostxt16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.biostxt16.ForeColor = System.Drawing.Color.Silver
        Me.biostxt16.Location = New System.Drawing.Point(817, 615)
        Me.biostxt16.Name = "biostxt16"
        Me.biostxt16.Size = New System.Drawing.Size(72, 29)
        Me.biostxt16.TabIndex = 17
        Me.biostxt16.Text = "6B38"
        '
        'Biosload
        '
        Me.Biosload.Enabled = true
        Me.Biosload.Interval = 500
        '
        'Bios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(887, 641)
        Me.Controls.Add(Me.biostxt16)
        Me.Controls.Add(Me.biostxt14)
        Me.Controls.Add(Me.biostxt15)
        Me.Controls.Add(Me.biostxt13)
        Me.Controls.Add(Me.biostxt12)
        Me.Controls.Add(Me.biostxt11)
        Me.Controls.Add(Me.biostxt10)
        Me.Controls.Add(Me.biostxt8)
        Me.Controls.Add(Me.biostxt9)
        Me.Controls.Add(Me.biostxt7)
        Me.Controls.Add(Me.biostxt6)
        Me.Controls.Add(Me.biostxt5)
        Me.Controls.Add(Me.biostxt4)
        Me.Controls.Add(Me.biostxt3)
        Me.Controls.Add(Me.biostxt2)
        Me.Controls.Add(Me.biostxt1)
        Me.Controls.Add(Me.Sunimage)
        Me.Controls.Add(Me.Americanimage)
        Me.Name = "Bios"
        Me.Text = "Bios"
        Me.TopMost = true
        CType(Me.Sunimage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Americanimage,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Americanimage As PictureBox
    Friend WithEvents Sunimage As PictureBox
    Friend WithEvents biostxt1 As Label
    Friend WithEvents biostxt2 As Label
    Friend WithEvents biostxt3 As Label
    Friend WithEvents biostxt4 As Label
    Friend WithEvents biostxt5 As Label
    Friend WithEvents biostxt6 As Label
    Friend WithEvents biostxt7 As Label
    Friend WithEvents biostxt9 As Label
    Friend WithEvents biostxt8 As Label
    Friend WithEvents biostxt10 As Label
    Friend WithEvents biostxt11 As Label
    Friend WithEvents biostxt12 As Label
    Friend WithEvents biostxt13 As Label
    Friend WithEvents biostxt15 As Label
    Friend WithEvents biostxt14 As Label
    Friend WithEvents biostxt16 As Label
    Friend WithEvents Biosload As Timer
End Class
