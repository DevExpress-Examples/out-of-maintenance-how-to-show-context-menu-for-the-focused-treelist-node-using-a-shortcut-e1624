Imports Microsoft.VisualBasic
Imports System
Namespace B138492
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.bbiDeleteNode = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiAddNode = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiAddChild = New DevExpress.XtraBars.BarButtonItem()
			Me.treeListMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.bbiShowTreeListMenu = New DevExpress.XtraBars.BarButtonItem()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeListMenu, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2})
			Me.treeList1.CustomizationFormBounds = New System.Drawing.Rectangle(1382, 895, 208, 168)
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 23)
			Me.treeList1.MenuManager = Me.barManager
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { Nothing, Nothing}, -1)
			Me.treeList1.AppendNode(New Object() { Nothing, Nothing}, 0)
			Me.treeList1.AppendNode(New Object() { Nothing, Nothing}, 0)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.Size = New System.Drawing.Size(494, 324)
			Me.treeList1.TabIndex = 0
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Description"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 1
			Me.treeListColumn1.Width = 1372
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "#"
			Me.treeListColumn2.FieldName = "treeListColumn2"
			Me.treeListColumn2.MinWidth = 38
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 0
			Me.treeListColumn2.Width = 111
			' 
			' barManager
			' 
			Me.barManager.DockControls.Add(Me.barDockControlTop)
			Me.barManager.DockControls.Add(Me.barDockControlBottom)
			Me.barManager.DockControls.Add(Me.barDockControlLeft)
			Me.barManager.DockControls.Add(Me.barDockControlRight)
			Me.barManager.Form = Me
			Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bbiDeleteNode, Me.bbiAddNode, Me.bbiAddChild, Me.bbiShowTreeListMenu})
			Me.barManager.MaxItemId = 4
			' 
			' bbiDeleteNode
			' 
			Me.bbiDeleteNode.Caption = "Delete Node"
			Me.bbiDeleteNode.Id = 0
			Me.bbiDeleteNode.Name = "bbiDeleteNode"
'			Me.bbiDeleteNode.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnDeleteNodeBarButtonItemClick);
			' 
			' bbiAddNode
			' 
			Me.bbiAddNode.Caption = "Add Node"
			Me.bbiAddNode.Id = 1
			Me.bbiAddNode.Name = "bbiAddNode"
'			Me.bbiAddNode.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnAddNodeBarButtonItemClick);
			' 
			' bbiAddChild
			' 
			Me.bbiAddChild.Caption = "Add Child"
			Me.bbiAddChild.Id = 2
			Me.bbiAddChild.Name = "bbiAddChild"
'			Me.bbiAddChild.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnAddChildBarButtonItemClick);
			' 
			' treeListMenu
			' 
			Me.treeListMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bbiDeleteNode), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAddNode), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAddChild)})
			Me.treeListMenu.Manager = Me.barManager
			Me.treeListMenu.Name = "treeListMenu"
			' 
			' bbiShowTreeListMenu
			' 
			Me.bbiShowTreeListMenu.Id = 3
			Me.bbiShowTreeListMenu.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F10))
			Me.bbiShowTreeListMenu.Name = "bbiShowTreeListMenu"
'			Me.bbiShowTreeListMenu.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.OnShowTreeListMenuClick);
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(494, 23)
			Me.panelControl1.TabIndex = 4
			' 
			' labelControl1
			' 
			Me.labelControl1.AllowHtmlString = True
			Me.labelControl1.Appearance.Options.UseTextOptions = True
			Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelControl1.Location = New System.Drawing.Point(2, 2)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(490, 19)
			Me.labelControl1.TabIndex = 5
			Me.labelControl1.Text = "<color=#A03FA0>Select the node and press the <b>Shift+F10</b> key combination to " & "show nodes menu"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(494, 347)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "DX Sample"
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeListMenu, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private barManager As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents bbiDeleteNode As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbiAddNode As DevExpress.XtraBars.BarButtonItem
		Private treeListMenu As DevExpress.XtraBars.PopupMenu
		Private WithEvents bbiAddChild As DevExpress.XtraBars.BarButtonItem
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents bbiShowTreeListMenu As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

