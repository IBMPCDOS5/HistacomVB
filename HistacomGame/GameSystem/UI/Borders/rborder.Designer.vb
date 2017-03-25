<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rborder
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
        Me.updat = New System.Windows.Forms.Timer(Me.components)
        Me.rcorner = New System.Windows.Forms.PictureBox()
        CType(Me.rcorner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pull
        '
        Me.pull.Interval = 10
        '
        'updat
        '
        Me.updat.Enabled = True
        Me.updat.Interval = 5000
        '
        'rcorner
        '
        Me.rcorner.BackColor = System.Drawing.Color.Silver
        Me.rcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95toprightcorner
        Me.rcorner.Dock = System.Windows.Forms.DockStyle.Top
        Me.rcorner.Location = New System.Drawing.Point(0, 0)
        Me.rcorner.Name = "rcorner"
        Me.rcorner.Size = New System.Drawing.Size(4, 4)
        Me.rcorner.TabIndex = 3
        Me.rcorner.TabStop = False
        '
        'rborder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95rightside
        Me.Controls.Add(Me.rcorner)
        Me.Name = "rborder"
        Me.Size = New System.Drawing.Size(4, 150)
        CType(Me.rcorner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pull As Timer
    Friend WithEvents updat As Timer
    Friend WithEvents rcorner As PictureBox
End Class
