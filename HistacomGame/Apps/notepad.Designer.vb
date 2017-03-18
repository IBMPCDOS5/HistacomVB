<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notepad
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
        Me.maintxt = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutNotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toprightcorner = New System.Windows.Forms.Panel()
        Me.bottomrightcorner = New System.Windows.Forms.Panel()
        Me.bottomleftcorner = New System.Windows.Forms.Panel()
        Me.topleftcorner = New System.Windows.Forms.Panel()
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.look = New System.Windows.Forms.Timer(Me.components)
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCtrlOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCtrlSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintCtrlPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoCtrlZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutCtrlXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.program.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.LightGray
        Me.program.Controls.Add(Me.maintxt)
        Me.program.Controls.Add(Me.MenuStrip1)
        Me.program.Controls.Add(Me.toprightcorner)
        Me.program.Controls.Add(Me.bottomrightcorner)
        Me.program.Controls.Add(Me.bottomleftcorner)
        Me.program.Controls.Add(Me.topleftcorner)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(438, 316)
        Me.program.TabIndex = 5
        '
        'maintxt
        '
        Me.maintxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.maintxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maintxt.Location = New System.Drawing.Point(0, 24)
        Me.maintxt.Multiline = True
        Me.maintxt.Name = "maintxt"
        Me.maintxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.maintxt.Size = New System.Drawing.Size(438, 292)
        Me.maintxt.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(438, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem1
        '
        Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
        Me.SaveAsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem1.Text = "Save As..."
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.TimeDateToolStripMenuItem, Me.WordWrapToolStripMenuItem})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'TimeDateToolStripMenuItem
        '
        Me.TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem"
        Me.TimeDateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TimeDateToolStripMenuItem.Text = "Time/Date"
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.CheckOnClick = True
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutNotepadToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutNotepadToolStripMenuItem
        '
        Me.AboutNotepadToolStripMenuItem.Name = "AboutNotepadToolStripMenuItem"
        Me.AboutNotepadToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AboutNotepadToolStripMenuItem.Text = "About Notepad"
        '
        'toprightcorner
        '
        Me.toprightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95toprightcorner
        Me.toprightcorner.Location = New System.Drawing.Point(434, 0)
        Me.toprightcorner.Name = "toprightcorner"
        Me.toprightcorner.Size = New System.Drawing.Size(4, 4)
        Me.toprightcorner.TabIndex = 6
        '
        'bottomrightcorner
        '
        Me.bottomrightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottomrightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomrightcorner
        Me.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.bottomrightcorner.Location = New System.Drawing.Point(434, 312)
        Me.bottomrightcorner.Name = "bottomrightcorner"
        Me.bottomrightcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomrightcorner.TabIndex = 4
        '
        'bottomleftcorner
        '
        Me.bottomleftcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bottomleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomleftcorner
        Me.bottomleftcorner.Location = New System.Drawing.Point(0, 312)
        Me.bottomleftcorner.Name = "bottomleftcorner"
        Me.bottomleftcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomleftcorner.TabIndex = 2
        '
        'topleftcorner
        '
        Me.topleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95topleftcorner
        Me.topleftcorner.Location = New System.Drawing.Point(0, 0)
        Me.topleftcorner.Name = "topleftcorner"
        Me.topleftcorner.Size = New System.Drawing.Size(4, 4)
        Me.topleftcorner.TabIndex = 1
        '
        'pullbs
        '
        Me.pullbs.Interval = 1
        '
        'pullside
        '
        Me.pullside.Interval = 1
        '
        'pullbottom
        '
        Me.pullbottom.Interval = 1
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NewToolStripMenuItem.Text = "New              Ctrl+N"
        '
        'OpenCtrlOToolStripMenuItem
        '
        Me.OpenCtrlOToolStripMenuItem.Name = "OpenCtrlOToolStripMenuItem"
        Me.OpenCtrlOToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.OpenCtrlOToolStripMenuItem.Text = "Open...         Ctrl+O"
        '
        'SaveCtrlSToolStripMenuItem
        '
        Me.SaveCtrlSToolStripMenuItem.Name = "SaveCtrlSToolStripMenuItem"
        Me.SaveCtrlSToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SaveCtrlSToolStripMenuItem.Text = "Save              Ctrl+S"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup..."
        '
        'PrintCtrlPToolStripMenuItem
        '
        Me.PrintCtrlPToolStripMenuItem.Name = "PrintCtrlPToolStripMenuItem"
        Me.PrintCtrlPToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PrintCtrlPToolStripMenuItem.Text = "Print...          Ctrl+P"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'UndoCtrlZToolStripMenuItem
        '
        Me.UndoCtrlZToolStripMenuItem.Name = "UndoCtrlZToolStripMenuItem"
        Me.UndoCtrlZToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.UndoCtrlZToolStripMenuItem.Text = "Undo               Ctrl+Z"
        '
        'CutCtrlXToolStripMenuItem
        '
        Me.CutCtrlXToolStripMenuItem.Name = "CutCtrlXToolStripMenuItem"
        Me.CutCtrlXToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CutCtrlXToolStripMenuItem.Text = "Cut                  Ctrl+X"
        '
        'notepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(438, 316)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "notepad"
        Me.Text = "notepad2000"
        Me.TopMost = True
        Me.program.ResumeLayout(False)
        Me.program.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents toprightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomrightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomleftcorner As System.Windows.Forms.Panel
    Friend WithEvents topleftcorner As System.Windows.Forms.Panel
    Friend WithEvents pullbs As System.Windows.Forms.Timer
    Friend WithEvents look As System.Windows.Forms.Timer
    Friend WithEvents pullside As System.Windows.Forms.Timer
    Friend WithEvents pullbottom As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenCtrlOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveCtrlSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintCtrlPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoCtrlZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutCtrlXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents maintxt As System.Windows.Forms.TextBox
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutNotepadToolStripMenuItem As ToolStripMenuItem
End Class
