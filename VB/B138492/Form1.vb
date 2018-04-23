Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraBars
Imports System.Collections
Imports DevExpress.XtraTreeList.ViewInfo

Namespace B138492
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			treeList1.ExpandAll()
		End Sub

		Private Sub OnAddNodeBarButtonItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiAddNode.ItemClick
			Dim treeList As TreeList = TryCast(ActiveControl, TreeList)
			If treeList Is Nothing OrElse treeList.FocusedNode Is Nothing Then
				Return
			End If
			AppendEmptyNode(treeList, treeList.FocusedNode.ParentNode)
		End Sub

		Private Sub OnAddChildBarButtonItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiAddChild.ItemClick
			Dim treeList As TreeList = TryCast(ActiveControl, TreeList)
			If treeList Is Nothing OrElse treeList.FocusedNode Is Nothing Then
				Return
			End If
			AppendEmptyNode(treeList, treeList.FocusedNode)
		End Sub

		Private Sub OnDeleteNodeBarButtonItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiDeleteNode.ItemClick
			Dim treeList As TreeList = TryCast(ActiveControl, TreeList)
			If treeList Is Nothing OrElse treeList.FocusedNode Is Nothing Then
				Return
			End If
			If treeList.Nodes.Count = 1 AndAlso treeList.FocusedNode.ParentNode Is Nothing Then
				Return
			End If
			treeList.DeleteNode(treeList.FocusedNode)
		End Sub

		Private Sub AppendEmptyNode(ByVal treeList As TreeList, ByVal parent As TreeListNode)
			Dim nodeData As New ArrayList()
			For i As Integer = 0 To treeList.Columns.Count - 1
				nodeData.Add(Nothing)
			Next i
			treeList.AppendNode(nodeData.ToArray(), parent)
		End Sub

		Private Sub OnShowTreeListMenuClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiShowTreeListMenu.ItemClick
			Dim treeList As TreeList = TryCast(ActiveControl, TreeList)
			If treeList Is Nothing OrElse treeList.FocusedNode Is Nothing Then
				Return
			End If
			Dim focusedNodeBounds As Rectangle = (CType(treeList.ViewInfo.RowsInfo(treeList.FocusedNode).Cells(0), CellInfo)).Bounds
			Dim menuLocation As New Point(focusedNodeBounds.Left + 3, focusedNodeBounds.Bottom + 1)
			menuLocation = treeList.PointToScreen(menuLocation)
			treeListMenu.ShowPopup(menuLocation)
		End Sub
	End Class
End Namespace