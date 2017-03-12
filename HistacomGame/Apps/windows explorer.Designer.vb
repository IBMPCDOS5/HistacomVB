<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class windows_explorer
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
        Me.mainView = New System.Windows.Forms.ListView()
        Me.dirLbl = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateShortcutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShortcutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitmapImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoCtrlZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutCtrlXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCtrlCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteShortcutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellectAllCtrlAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByDriveLetterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BySizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByFreeSpaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineUpIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilesOrFoldersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnTheInternetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeopleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapNetworkDriveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectNetworkDriveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutWindows95ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.program = New System.Windows.Forms.Panel()
        Me.diskView = New System.Windows.Forms.ListView()
        Me.icons = New System.Windows.Forms.ImageList(Me.components)
        Me.btnGo = New System.Windows.Forms.Button()
        Me.toprightcorner = New System.Windows.Forms.Panel()
        Me.bottomrightcorner = New System.Windows.Forms.Panel()
        Me.bottomleftcorner = New System.Windows.Forms.Panel()
        Me.topleftcorner = New System.Windows.Forms.Panel()
        Me.pnlHidden = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlSave = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSave = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.program.SuspendLayout()
        Me.pnlHidden.SuspendLayout()
        Me.pnlSave.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainView
        '
        Me.mainView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainView.Location = New System.Drawing.Point(222, 100)
        Me.mainView.Name = "mainView"
        Me.mainView.Size = New System.Drawing.Size(631, 417)
        Me.mainView.TabIndex = 10
        Me.mainView.UseCompatibleStateImageBehavior = False
        Me.mainView.View = System.Windows.Forms.View.List
        '
        'dirLbl
        '
        Me.dirLbl.FormattingEnabled = True
        Me.dirLbl.Items.AddRange(New Object() {"Desktop", "My Computer", "3 1/2 Floppy (a:)", "(C:)", "(D:)", "Control Panel", "Printers", "Network Neightborhood", "Recycle Bin", "Online Services"})
        Me.dirLbl.Location = New System.Drawing.Point(11, 73)
        Me.dirLbl.Name = "dirLbl"
        Me.dirLbl.Size = New System.Drawing.Size(802, 21)
        Me.dirLbl.TabIndex = 7
        Me.dirLbl.Text = "My Computer"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateShortcutToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.RenameToolStripMenuItem, Me.PropertiesToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CreateShortcutToolStripMenuItem
        '
        Me.CreateShortcutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolderToolStripMenuItem, Me.ShortcutToolStripMenuItem, Me.TextDocumentToolStripMenuItem, Me.BitmapImageToolStripMenuItem})
        Me.CreateShortcutToolStripMenuItem.Name = "CreateShortcutToolStripMenuItem"
        Me.CreateShortcutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CreateShortcutToolStripMenuItem.Text = "New"
        '
        'FolderToolStripMenuItem
        '
        Me.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem"
        Me.FolderToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.FolderToolStripMenuItem.Text = "Folder"
        '
        'ShortcutToolStripMenuItem
        '
        Me.ShortcutToolStripMenuItem.Name = "ShortcutToolStripMenuItem"
        Me.ShortcutToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ShortcutToolStripMenuItem.Text = "Shortcut"
        '
        'TextDocumentToolStripMenuItem
        '
        Me.TextDocumentToolStripMenuItem.Name = "TextDocumentToolStripMenuItem"
        Me.TextDocumentToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.TextDocumentToolStripMenuItem.Text = "Text Document"
        '
        'BitmapImageToolStripMenuItem
        '
        Me.BitmapImageToolStripMenuItem.Name = "BitmapImageToolStripMenuItem"
        Me.BitmapImageToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.BitmapImageToolStripMenuItem.Text = "Bitmap Image"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoCtrlZToolStripMenuItem, Me.CutCtrlXToolStripMenuItem, Me.CopyCtrlCToolStripMenuItem, Me.PasteToolStripMenuItem, Me.PasteShortcutToolStripMenuItem, Me.SellectAllCtrlAToolStripMenuItem, Me.InvertSelectionToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoCtrlZToolStripMenuItem
        '
        Me.UndoCtrlZToolStripMenuItem.Name = "UndoCtrlZToolStripMenuItem"
        Me.UndoCtrlZToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.UndoCtrlZToolStripMenuItem.Text = "Undo                    Ctrl+Z"
        '
        'CutCtrlXToolStripMenuItem
        '
        Me.CutCtrlXToolStripMenuItem.Name = "CutCtrlXToolStripMenuItem"
        Me.CutCtrlXToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CutCtrlXToolStripMenuItem.Text = "Cut                       Ctrl+X"
        '
        'CopyCtrlCToolStripMenuItem
        '
        Me.CopyCtrlCToolStripMenuItem.Name = "CopyCtrlCToolStripMenuItem"
        Me.CopyCtrlCToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CopyCtrlCToolStripMenuItem.Text = "Copy                    Ctrl+C"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.PasteToolStripMenuItem.Text = "Paste                    Ctrl+V"
        '
        'PasteShortcutToolStripMenuItem
        '
        Me.PasteShortcutToolStripMenuItem.Name = "PasteShortcutToolStripMenuItem"
        Me.PasteShortcutToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.PasteShortcutToolStripMenuItem.Text = "Paste Shortcut"
        '
        'SellectAllCtrlAToolStripMenuItem
        '
        Me.SellectAllCtrlAToolStripMenuItem.Name = "SellectAllCtrlAToolStripMenuItem"
        Me.SellectAllCtrlAToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.SellectAllCtrlAToolStripMenuItem.Text = "Sellect All            Ctrl+A"
        '
        'InvertSelectionToolStripMenuItem
        '
        Me.InvertSelectionToolStripMenuItem.Name = "InvertSelectionToolStripMenuItem"
        Me.InvertSelectionToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.InvertSelectionToolStripMenuItem.Text = "Invert Selection"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolbarToolStripMenuItem, Me.StatusBarToolStripMenuItem, Me.LargeIconsToolStripMenuItem, Me.SmallIconsToolStripMenuItem, Me.ListToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem, Me.LineUpIconsToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ToolbarToolStripMenuItem
        '
        Me.ToolbarToolStripMenuItem.Name = "ToolbarToolStripMenuItem"
        Me.ToolbarToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ToolbarToolStripMenuItem.Text = "Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.StatusBarToolStripMenuItem.Text = "Status Bar"
        '
        'LargeIconsToolStripMenuItem
        '
        Me.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem"
        Me.LargeIconsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.LargeIconsToolStripMenuItem.Text = "Large Icons"
        '
        'SmallIconsToolStripMenuItem
        '
        Me.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem"
        Me.SmallIconsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SmallIconsToolStripMenuItem.Text = "Small Icons"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByDriveLetterToolStripMenuItem, Me.ByTypeToolStripMenuItem, Me.BySizeToolStripMenuItem, Me.ByFreeSpaceToolStripMenuItem})
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "Arrange Icons"
        '
        'ByDriveLetterToolStripMenuItem
        '
        Me.ByDriveLetterToolStripMenuItem.Name = "ByDriveLetterToolStripMenuItem"
        Me.ByDriveLetterToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ByDriveLetterToolStripMenuItem.Text = "by Drive Letter"
        '
        'ByTypeToolStripMenuItem
        '
        Me.ByTypeToolStripMenuItem.Name = "ByTypeToolStripMenuItem"
        Me.ByTypeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ByTypeToolStripMenuItem.Text = "by Type"
        '
        'BySizeToolStripMenuItem
        '
        Me.BySizeToolStripMenuItem.Name = "BySizeToolStripMenuItem"
        Me.BySizeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BySizeToolStripMenuItem.Text = "by Size"
        '
        'ByFreeSpaceToolStripMenuItem
        '
        Me.ByFreeSpaceToolStripMenuItem.Name = "ByFreeSpaceToolStripMenuItem"
        Me.ByFreeSpaceToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ByFreeSpaceToolStripMenuItem.Text = "by Free Space"
        '
        'LineUpIconsToolStripMenuItem
        '
        Me.LineUpIconsToolStripMenuItem.Name = "LineUpIconsToolStripMenuItem"
        Me.LineUpIconsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.LineUpIconsToolStripMenuItem.Text = "Line up Icons"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.OptionsToolStripMenuItem.Text = "Options..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem, Me.MapNetworkDriveToolStripMenuItem, Me.DisconnectNetworkDriveToolStripMenuItem, Me.GoToToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesOrFoldersToolStripMenuItem, Me.ComputerToolStripMenuItem, Me.OnTheInternetToolStripMenuItem, Me.PeopleToolStripMenuItem})
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'FilesOrFoldersToolStripMenuItem
        '
        Me.FilesOrFoldersToolStripMenuItem.Name = "FilesOrFoldersToolStripMenuItem"
        Me.FilesOrFoldersToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FilesOrFoldersToolStripMenuItem.Text = "Files or Folders..."
        '
        'ComputerToolStripMenuItem
        '
        Me.ComputerToolStripMenuItem.Name = "ComputerToolStripMenuItem"
        Me.ComputerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ComputerToolStripMenuItem.Text = "Computer..."
        '
        'OnTheInternetToolStripMenuItem
        '
        Me.OnTheInternetToolStripMenuItem.Name = "OnTheInternetToolStripMenuItem"
        Me.OnTheInternetToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OnTheInternetToolStripMenuItem.Text = "On the Internet"
        '
        'PeopleToolStripMenuItem
        '
        Me.PeopleToolStripMenuItem.Name = "PeopleToolStripMenuItem"
        Me.PeopleToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PeopleToolStripMenuItem.Text = "People..."
        '
        'MapNetworkDriveToolStripMenuItem
        '
        Me.MapNetworkDriveToolStripMenuItem.Name = "MapNetworkDriveToolStripMenuItem"
        Me.MapNetworkDriveToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.MapNetworkDriveToolStripMenuItem.Text = "Map Network Drive..."
        '
        'DisconnectNetworkDriveToolStripMenuItem
        '
        Me.DisconnectNetworkDriveToolStripMenuItem.Name = "DisconnectNetworkDriveToolStripMenuItem"
        Me.DisconnectNetworkDriveToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.DisconnectNetworkDriveToolStripMenuItem.Text = "Disconnect Network Drive..."
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.GoToToolStripMenuItem.Text = "Go to..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutWindows95ToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.HelpToolStripMenuItem1.Text = "Help Topics"
        '
        'AboutWindows95ToolStripMenuItem
        '
        Me.AboutWindows95ToolStripMenuItem.Name = "AboutWindows95ToolStripMenuItem"
        Me.AboutWindows95ToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AboutWindows95ToolStripMenuItem.Text = "About Windows 95"
        '
        'program
        '
        Me.program.BackColor = System.Drawing.Color.Silver
        Me.program.Controls.Add(Me.diskView)
        Me.program.Controls.Add(Me.btnGo)
        Me.program.Controls.Add(Me.MenuStrip1)
        Me.program.Controls.Add(Me.toprightcorner)
        Me.program.Controls.Add(Me.dirLbl)
        Me.program.Controls.Add(Me.bottomrightcorner)
        Me.program.Controls.Add(Me.bottomleftcorner)
        Me.program.Controls.Add(Me.topleftcorner)
        Me.program.Controls.Add(Me.mainView)
        Me.program.Controls.Add(Me.pnlHidden)
        Me.program.Controls.Add(Me.pnlSave)
        Me.program.Dock = System.Windows.Forms.DockStyle.Fill
        Me.program.Location = New System.Drawing.Point(0, 0)
        Me.program.Name = "program"
        Me.program.Size = New System.Drawing.Size(874, 552)
        Me.program.TabIndex = 12
        '
        'diskView
        '
        Me.diskView.LargeImageList = Me.icons
        Me.diskView.Location = New System.Drawing.Point(3, 100)
        Me.diskView.Name = "diskView"
        Me.diskView.Size = New System.Drawing.Size(213, 417)
        Me.diskView.SmallImageList = Me.icons
        Me.diskView.StateImageList = Me.icons
        Me.diskView.TabIndex = 13
        Me.diskView.UseCompatibleStateImageBehavior = False
        Me.diskView.View = System.Windows.Forms.View.List
        '
        'icons
        '
        Me.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.icons.ImageSize = New System.Drawing.Size(16, 16)
        Me.icons.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Image = Global.Histacom.My.Resources.Resources.windows95internetexplorergobutton
        Me.btnGo.Location = New System.Drawing.Point(819, 66)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(55, 28)
        Me.btnGo.TabIndex = 12
        Me.btnGo.Text = "Go"
        Me.btnGo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'toprightcorner
        '
        Me.toprightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95toprightcorner
        Me.toprightcorner.Location = New System.Drawing.Point(870, 0)
        Me.toprightcorner.Name = "toprightcorner"
        Me.toprightcorner.Size = New System.Drawing.Size(4, 4)
        Me.toprightcorner.TabIndex = 6
        '
        'bottomrightcorner
        '
        Me.bottomrightcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bottomrightcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomrightcorner
        Me.bottomrightcorner.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.bottomrightcorner.Location = New System.Drawing.Point(870, 548)
        Me.bottomrightcorner.Name = "bottomrightcorner"
        Me.bottomrightcorner.Size = New System.Drawing.Size(4, 4)
        Me.bottomrightcorner.TabIndex = 4
        '
        'bottomleftcorner
        '
        Me.bottomleftcorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bottomleftcorner.BackgroundImage = Global.Histacom.My.Resources.Resources.windows95bottomleftcorner
        Me.bottomleftcorner.Location = New System.Drawing.Point(0, 548)
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
        'pnlHidden
        '
        Me.pnlHidden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHidden.Controls.Add(Me.LinkLabel1)
        Me.pnlHidden.Controls.Add(Me.Label3)
        Me.pnlHidden.Controls.Add(Me.Label2)
        Me.pnlHidden.Location = New System.Drawing.Point(222, 100)
        Me.pnlHidden.Name = "pnlHidden"
        Me.pnlHidden.Size = New System.Drawing.Size(631, 417)
        Me.pnlHidden.TabIndex = 14
        Me.pnlHidden.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(325, 50)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(54, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(330, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "If you want to view the contents of this folder, "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "This directory is hidden"
        '
        'pnlSave
        '
        Me.pnlSave.Controls.Add(Me.Button1)
        Me.pnlSave.Controls.Add(Me.Label1)
        Me.pnlSave.Controls.Add(Me.txtSave)
        Me.pnlSave.Location = New System.Drawing.Point(162, 520)
        Me.pnlSave.Name = "pnlSave"
        Me.pnlSave.Size = New System.Drawing.Size(253, 73)
        Me.pnlSave.TabIndex = 18
        Me.pnlSave.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(166, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "File Name:"
        '
        'txtSave
        '
        Me.txtSave.Location = New System.Drawing.Point(60, 3)
        Me.txtSave.Name = "txtSave"
        Me.txtSave.Size = New System.Drawing.Size(100, 20)
        Me.txtSave.TabIndex = 15
        '
        'windows_explorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 552)
        Me.Controls.Add(Me.program)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "windows_explorer"
        Me.Text = "windows_explorer"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.program.ResumeLayout(False)
        Me.program.PerformLayout()
        Me.pnlHidden.ResumeLayout(False)
        Me.pnlHidden.PerformLayout()
        Me.pnlSave.ResumeLayout(False)
        Me.pnlSave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateShortcutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoCtrlZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutCtrlXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyCtrlCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteShortcutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SellectAllCtrlAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvertSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LargeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDriveLetterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BySizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByFreeSpaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineUpIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilesOrFoldersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnTheInternetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeopleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MapNetworkDriveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectNetworkDriveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutWindows95ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dirLbl As System.Windows.Forms.ComboBox
    Friend WithEvents mainView As System.Windows.Forms.ListView
    Friend WithEvents program As System.Windows.Forms.Panel
    Friend WithEvents toprightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomrightcorner As System.Windows.Forms.Panel
    Friend WithEvents bottomleftcorner As System.Windows.Forms.Panel
    Friend WithEvents topleftcorner As System.Windows.Forms.Panel
    Friend WithEvents FolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShortcutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextDocumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BitmapImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnGo As Button
    Friend WithEvents icons As ImageList
    Friend WithEvents diskView As ListView
    Friend WithEvents pnlHidden As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlSave As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSave As TextBox
End Class
