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
        Me.SuspendLayout()
        '
        'pull
        '
        Me.pull.Interval = 10
        '
        'lborder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95rightside
        Me.Name = "lborder"
        Me.Size = New System.Drawing.Size(4, 150)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pull As Timer
End Class
