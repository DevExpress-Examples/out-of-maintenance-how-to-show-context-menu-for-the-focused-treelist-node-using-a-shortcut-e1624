using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraBars;
using System.Collections;
using DevExpress.XtraTreeList.ViewInfo;

namespace B138492 {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
            treeList1.ExpandAll();
        }

        private void OnAddNodeBarButtonItemClick(object sender, ItemClickEventArgs e) {
            TreeList treeList = ActiveControl as TreeList;
            if (treeList == null || treeList.FocusedNode == null) return;
            AppendEmptyNode(treeList, treeList.FocusedNode.ParentNode);
        }

        private void OnAddChildBarButtonItemClick(object sender, ItemClickEventArgs e) {
            TreeList treeList = ActiveControl as TreeList;
            if (treeList == null || treeList.FocusedNode == null) return;
            AppendEmptyNode(treeList, treeList.FocusedNode);
        }

        private void OnDeleteNodeBarButtonItemClick(object sender, ItemClickEventArgs e) {
            TreeList treeList = ActiveControl as TreeList;
            if (treeList == null || treeList.FocusedNode == null) return;
            if (treeList.Nodes.Count == 1 && treeList.FocusedNode.ParentNode == null) return;
            treeList.DeleteNode(treeList.FocusedNode);
        }

        private void AppendEmptyNode(TreeList treeList, TreeListNode parent) {
            ArrayList nodeData = new ArrayList();
            for (int i = 0; i < treeList.Columns.Count; i++)
                nodeData.Add(null);
            treeList.AppendNode(nodeData.ToArray(), parent);
        }

        private void OnShowTreeListMenuClick(object sender, ItemClickEventArgs e) {
            TreeList treeList = ActiveControl as TreeList;
            if (treeList == null || treeList.FocusedNode == null) return;
            Rectangle focusedNodeBounds = ((CellInfo)treeList.ViewInfo.RowsInfo[treeList.FocusedNode].Cells[0]).Bounds;
            Point menuLocation = new Point(focusedNodeBounds.Left + 3, focusedNodeBounds.Bottom + 1);
            menuLocation = treeList.PointToScreen(menuLocation);
            treeListMenu.ShowPopup(menuLocation);
        }
    }
}