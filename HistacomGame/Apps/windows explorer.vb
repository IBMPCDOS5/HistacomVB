Public Class windows_explorer

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        ListView1.Items.Clear()
        Dim childamount As TreeNodeCollection
        childamount = TreeView1.SelectedNode.Nodes
        lblamountofobjects.Text = (childamount.Count & " objects(s)")
        For Each TreeNode In TreeView1.SelectedNode.Nodes
            If TreeNode.tag = "file" Then
                TreeNode.forecolor = TreeView1.BackColor
            End If
            ListView1.Items.Add(TreeNode.text)
        Next

    End Sub

    Private Sub windows_explorer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        winman.setupwindow(Me, "Windows Explorer", My.Resources.windows_95_settings_computer_example)
        lblamountofobjects.Text = "0 objects"
        look.Start()
    End Sub
End Class