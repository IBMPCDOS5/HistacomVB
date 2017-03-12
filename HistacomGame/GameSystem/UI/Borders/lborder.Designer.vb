<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lborder
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
        Me.pull = New System.Windows.Forms.Timer(Me.components)
        Me.lcorner = New System.Windows.Forms.PictureBox()
        CType(Me.lcorner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pull
        '
        Me.pull.Interval = 10
        '
        'lcorner
        '
        Me.lcorner.BackColor = System.Drawing.Color.Silver
        Me.lcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95topleftcorner
        Me.lcorner.Dock = System.Windows.Forms.DockStyle.Top
        Me.lcorner.Location = New System.Drawing.Point(0, 0)
        Me.lcorner.Name = "lcorner"
        Me.lcorner.Size = New System.Drawing.Size(4, 4)
        Me.lcorner.TabIndex = 2
        Me.lcorner.TabStop = False
        '
        'lborder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95rightside
        Me.Controls.Add(Me.lcorner)
        Me.Name = "lborder"
        Me.Size = New System.Drawing.Size(4, 150)
        CType(Me.lcorner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pull As Timer
    Friend WithEvents lcorner As PictureBox
End Class
