<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.thing = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btncl = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.count = New System.Windows.Forms.Timer(Me.components)
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btndiv = New System.Windows.Forms.Button()
        Me.btnmul = New System.Windows.Forms.Button()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btnplus = New System.Windows.Forms.Button()
        Me.btnequal = New System.Windows.Forms.Button()
        Me.CDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'thing
        '
        Me.thing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.thing.Location = New System.Drawing.Point(12, 48)
        Me.thing.Name = "thing"
        Me.thing.Size = New System.Drawing.Size(30, 30)
        Me.thing.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(55, 48)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 30)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Backspace"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCE
        '
        Me.btnCE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCE.Location = New System.Drawing.Point(136, 48)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(75, 30)
        Me.btnCE.TabIndex = 1
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = True
        '
        'btncl
        '
        Me.btncl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncl.Location = New System.Drawing.Point(217, 48)
        Me.btncl.Name = "btncl"
        Me.btncl.Size = New System.Drawing.Size(75, 30)
        Me.btncl.TabIndex = 1
        Me.btncl.Text = "C"
        Me.btncl.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.ForeColor = System.Drawing.Color.Blue
        Me.btn7.Location = New System.Drawing.Point(55, 84)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 51)
        Me.btn7.TabIndex = 1
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.ForeColor = System.Drawing.Color.Blue
        Me.btn8.Location = New System.Drawing.Point(136, 84)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 51)
        Me.btn8.TabIndex = 1
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.ForeColor = System.Drawing.Color.Blue
        Me.btn9.Location = New System.Drawing.Point(217, 84)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(75, 51)
        Me.btn9.TabIndex = 1
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'count
        '
        Me.count.Interval = 2000
        '
        'btn4
        '
        Me.btn4.ForeColor = System.Drawing.Color.Blue
        Me.btn4.Location = New System.Drawing.Point(55, 141)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 51)
        Me.btn4.TabIndex = 1
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.ForeColor = System.Drawing.Color.Blue
        Me.btn5.Location = New System.Drawing.Point(136, 141)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 51)
        Me.btn5.TabIndex = 1
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.ForeColor = System.Drawing.Color.Blue
        Me.btn6.Location = New System.Drawing.Point(217, 141)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 51)
        Me.btn6.TabIndex = 1
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.ForeColor = System.Drawing.Color.Blue
        Me.btn1.Location = New System.Drawing.Point(55, 198)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 51)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.ForeColor = System.Drawing.Color.Blue
        Me.btn2.Location = New System.Drawing.Point(136, 198)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 51)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.ForeColor = System.Drawing.Color.Blue
        Me.btn3.Location = New System.Drawing.Point(217, 198)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 51)
        Me.btn3.TabIndex = 1
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.ForeColor = System.Drawing.Color.Blue
        Me.btn0.Location = New System.Drawing.Point(136, 255)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(75, 51)
        Me.btn0.TabIndex = 1
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btndiv
        '
        Me.btndiv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndiv.Location = New System.Drawing.Point(298, 48)
        Me.btndiv.Name = "btndiv"
        Me.btndiv.Size = New System.Drawing.Size(75, 56)
        Me.btndiv.TabIndex = 1
        Me.btndiv.Text = "/"
        Me.btndiv.UseVisualStyleBackColor = True
        '
        'btnmul
        '
        Me.btnmul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnmul.Location = New System.Drawing.Point(298, 110)
        Me.btnmul.Name = "btnmul"
        Me.btnmul.Size = New System.Drawing.Size(75, 56)
        Me.btnmul.TabIndex = 1
        Me.btnmul.Text = "*"
        Me.btnmul.UseVisualStyleBackColor = True
        '
        'btnsub
        '
        Me.btnsub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsub.Location = New System.Drawing.Point(298, 172)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(75, 56)
        Me.btnsub.TabIndex = 1
        Me.btnsub.Text = "-"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'btnplus
        '
        Me.btnplus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnplus.Location = New System.Drawing.Point(298, 234)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(75, 56)
        Me.btnplus.TabIndex = 1
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = True
        '
        'btnequal
        '
        Me.btnequal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnequal.Location = New System.Drawing.Point(217, 255)
        Me.btnequal.Name = "btnequal"
        Me.btnequal.Size = New System.Drawing.Size(75, 51)
        Me.btnequal.TabIndex = 1
        Me.btnequal.Text = "="
        Me.btnequal.UseVisualStyleBackColor = True
        '
        'CDisplay
        '
        Me.CDisplay.Location = New System.Drawing.Point(12, 22)
        Me.CDisplay.Name = "CDisplay"
        Me.CDisplay.Size = New System.Drawing.Size(392, 20)
        Me.CDisplay.TabIndex = 2
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(416, 323)
        Me.Controls.Add(Me.CDisplay)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.btnmul)
        Me.Controls.Add(Me.btndiv)
        Me.Controls.Add(Me.btncl)
        Me.Controls.Add(Me.btnCE)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btnequal)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.thing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents thing As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCE As Button
    Friend WithEvents btncl As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents count As Timer
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnmul As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents btnplus As Button
    Friend WithEvents btnequal As Button
    Friend WithEvents CDisplay As TextBox
End Class
