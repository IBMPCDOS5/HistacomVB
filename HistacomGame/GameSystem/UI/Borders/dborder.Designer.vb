<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dborder
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
        Me.lcorner = New System.Windows.Forms.PictureBox()
        Me.rcorner = New System.Windows.Forms.PictureBox()
        CType(Me.lcorner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcorner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lcorner
        '
        Me.lcorner.BackColor = System.Drawing.Color.Silver
        Me.lcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomleftcorner
        Me.lcorner.Dock = System.Windows.Forms.DockStyle.Left
        Me.lcorner.Location = New System.Drawing.Point(0, 0)
        Me.lcorner.Name = "lcorner"
        Me.lcorner.Size = New System.Drawing.Size(4, 4)
        Me.lcorner.TabIndex = 0
        Me.lcorner.TabStop = False
        '
        'rcorner
        '
        Me.rcorner.BackColor = System.Drawing.Color.Silver
        Me.rcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomrightcorner
        Me.rcorner.Dock = System.Windows.Forms.DockStyle.Right
        Me.rcorner.Location = New System.Drawing.Point(146, 0)
        Me.rcorner.Name = "rcorner"
        Me.rcorner.Size = New System.Drawing.Size(4, 4)
        Me.rcorner.TabIndex = 1
        Me.rcorner.TabStop = False
        '
        'dborder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottom
        Me.Controls.Add(Me.rcorner)
        Me.Controls.Add(Me.lcorner)
        Me.Name = "dborder"
        Me.Size = New System.Drawing.Size(150, 4)
        CType(Me.lcorner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcorner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lcorner As PictureBox
    Friend WithEvents rcorner As PictureBox
End Class
