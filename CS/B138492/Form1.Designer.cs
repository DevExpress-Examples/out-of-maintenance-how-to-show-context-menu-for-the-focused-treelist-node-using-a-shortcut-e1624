namespace B138492 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiDeleteNode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddNode = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddChild = new DevExpress.XtraBars.BarButtonItem();
            this.treeListMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiShowTreeListMenu = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeList1.CustomizationFormBounds = new System.Drawing.Rectangle(1382, 895, 208, 168);
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 23);
            this.treeList1.MenuManager = this.barManager;
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            null,
            null}, 0);
            this.treeList1.AppendNode(new object[] {
            null,
            null}, 0);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(494, 324);
            this.treeList1.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Description";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 1;
            this.treeListColumn1.Width = 1372;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "#";
            this.treeListColumn2.FieldName = "treeListColumn2";
            this.treeListColumn2.MinWidth = 38;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 111;
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiDeleteNode,
            this.bbiAddNode,
            this.bbiAddChild,
            this.bbiShowTreeListMenu});
            this.barManager.MaxItemId = 4;
            // 
            // bbiDeleteNode
            // 
            this.bbiDeleteNode.Caption = "Delete Node";
            this.bbiDeleteNode.Id = 0;
            this.bbiDeleteNode.Name = "bbiDeleteNode";
            this.bbiDeleteNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnDeleteNodeBarButtonItemClick);
            // 
            // bbiAddNode
            // 
            this.bbiAddNode.Caption = "Add Node";
            this.bbiAddNode.Id = 1;
            this.bbiAddNode.Name = "bbiAddNode";
            this.bbiAddNode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddNodeBarButtonItemClick);
            // 
            // bbiAddChild
            // 
            this.bbiAddChild.Caption = "Add Child";
            this.bbiAddChild.Id = 2;
            this.bbiAddChild.Name = "bbiAddChild";
            this.bbiAddChild.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddChildBarButtonItemClick);
            // 
            // treeListMenu
            // 
            this.treeListMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDeleteNode),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddNode),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddChild)});
            this.treeListMenu.Manager = this.barManager;
            this.treeListMenu.Name = "treeListMenu";
            // 
            // bbiShowTreeListMenu
            // 
            this.bbiShowTreeListMenu.Id = 3;
            this.bbiShowTreeListMenu.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10));
            this.bbiShowTreeListMenu.Name = "bbiShowTreeListMenu";
            this.bbiShowTreeListMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowTreeListMenuClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(494, 23);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(490, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "<color=#A03FA0>Select the node and press the <b>Shift+F10</b> key combination to " +
                "show nodes menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 347);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "DX Sample";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiDeleteNode;
        private DevExpress.XtraBars.BarButtonItem bbiAddNode;
        private DevExpress.XtraBars.PopupMenu treeListMenu;
        private DevExpress.XtraBars.BarButtonItem bbiAddChild;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem bbiShowTreeListMenu;
    }
}

