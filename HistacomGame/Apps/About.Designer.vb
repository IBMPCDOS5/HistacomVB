<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.allctrls = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.allctrls.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Histacom.My.Resources.Resources.win9xlogo
        Me.PictureBox1.Location = New System.Drawing.Point(76, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 36)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'allctrls
        '
        Me.allctrls.BackColor = System.Drawing.Color.Silver
        Me.allctrls.Controls.Add(Me.Label2)
        Me.allctrls.Controls.Add(Me.Label1)
        Me.allctrls.Controls.Add(Me.PictureBox1)
        Me.allctrls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.allctrls.Location = New System.Drawing.Point(0, 0)
        Me.allctrls.Name = "allctrls"
        Me.allctrls.Size = New System.Drawing.Size(195, 146)
        Me.allctrls.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Windows 95"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "produced on Histacom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NO COPYRIGHT - THIS IS NOT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE FULL VERSION OF WINDOWS"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 146)
        Me.Controls.Add(Me.allctrls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "About"
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.allctrls.ResumeLayout(False)
        Me.allctrls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents allctrls As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
