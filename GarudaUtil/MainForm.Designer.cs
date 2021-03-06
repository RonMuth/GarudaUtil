﻿namespace GarudaUtil
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._treeView = new System.Windows.Forms.TreeView();
            this._imgListTree = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._tabControl = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._tsbOpenFile = new System.Windows.Forms.ToolStripButton();
            this._tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._tsbNewQuery = new System.Windows.Forms.ToolStripButton();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._tsslCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this._tsslConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this._cmsTreeTableMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tsmiSelectTop1000 = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptTableAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiTableScriptCreate = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiTableScriptInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this._tsbConnect = new System.Windows.Forms.ToolStripButton();
            this._tsbRefreshTree = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this._statusStrip.SuspendLayout();
            this._cmsTreeTableMenu.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(860, 405);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._treeView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _treeView
            // 
            this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeView.ImageIndex = 0;
            this._treeView.ImageList = this._imgListTree;
            this._treeView.Location = new System.Drawing.Point(3, 3);
            this._treeView.Name = "_treeView";
            this._treeView.SelectedImageIndex = 0;
            this._treeView.ShowRootLines = false;
            this._treeView.Size = new System.Drawing.Size(279, 399);
            this._treeView.TabIndex = 1;
            this._treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._treeView_NodeMouseDoubleClick);
            // 
            // _imgListTree
            // 
            this._imgListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgListTree.ImageStream")));
            this._imgListTree.TransparentColor = System.Drawing.Color.Transparent;
            this._imgListTree.Images.SetKeyName(0, "Cloud Storage Filled-50.png");
            this._imgListTree.Images.SetKeyName(1, "Database-50.png");
            this._imgListTree.Images.SetKeyName(2, "Insert Table Filled-50.png");
            this._imgListTree.Images.SetKeyName(3, "Origami-50.png");
            this._imgListTree.Images.SetKeyName(4, "List-52.png");
            this._imgListTree.Images.SetKeyName(5, "Training Filled-50.png");
            this._imgListTree.Images.SetKeyName(6, "Folder-32.png");
            this._imgListTree.Images.SetKeyName(7, "Key 2-32.png");
            this._imgListTree.Images.SetKeyName(8, "Active Directory-32.png");
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this._tabControl, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(571, 405);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // _tabControl
            // 
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this._tabControl.HotTrack = true;
            this._tabControl.ItemSize = new System.Drawing.Size(100, 18);
            this._tabControl.Location = new System.Drawing.Point(3, 3);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(565, 399);
            this._tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this._tabControl.TabIndex = 0;
            this._tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this._tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this._tabControl_MouseDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsbOpenFile,
            this._tsbSave,
            this.toolStripSeparator1,
            this._tsbNewQuery});
            this.toolStrip1.Location = new System.Drawing.Point(61, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(159, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _tsbOpenFile
            // 
            this._tsbOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._tsbOpenFile.Image = global::GarudaUtil.Properties.Resources.Open_Folder_Filled_32__2_;
            this._tsbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbOpenFile.Name = "_tsbOpenFile";
            this._tsbOpenFile.Size = new System.Drawing.Size(23, 22);
            this._tsbOpenFile.Text = "Open File...";
            this._tsbOpenFile.ToolTipText = "Open File... (Ctrl+O)";
            this._tsbOpenFile.Click += new System.EventHandler(this._tsbOpenFile_Click);
            // 
            // _tsbSave
            // 
            this._tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._tsbSave.Image = global::GarudaUtil.Properties.Resources.Save_32;
            this._tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbSave.Name = "_tsbSave";
            this._tsbSave.Size = new System.Drawing.Size(23, 22);
            this._tsbSave.Text = "Save";
            this._tsbSave.ToolTipText = "Save (Ctrl+S)";
            this._tsbSave.Click += new System.EventHandler(this._tsbSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _tsbNewQuery
            // 
            this._tsbNewQuery.Image = global::GarudaUtil.Properties.Resources.Create_New_Filled_50;
            this._tsbNewQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbNewQuery.Name = "_tsbNewQuery";
            this._tsbNewQuery.Size = new System.Drawing.Size(95, 22);
            this._tsbNewQuery.Text = "New Query...";
            this._tsbNewQuery.ToolTipText = "New Query... (Ctrl+N)";
            this._tsbNewQuery.Click += new System.EventHandler(this._tsbNewQuery_Click);
            // 
            // _statusStrip
            // 
            this._statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsslCurrent,
            this._tsslConnection});
            this._statusStrip.Location = new System.Drawing.Point(0, 0);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(860, 22);
            this._statusStrip.TabIndex = 1;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _tsslCurrent
            // 
            this._tsslCurrent.AutoSize = false;
            this._tsslCurrent.Name = "_tsslCurrent";
            this._tsslCurrent.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this._tsslCurrent.Size = new System.Drawing.Size(100, 17);
            this._tsslCurrent.Text = "Ready";
            this._tsslCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _tsslConnection
            // 
            this._tsslConnection.AutoSize = false;
            this._tsslConnection.AutoToolTip = true;
            this._tsslConnection.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this._tsslConnection.Name = "_tsslConnection";
            this._tsslConnection.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this._tsslConnection.Size = new System.Drawing.Size(350, 17);
            this._tsslConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _cmsTreeTableMenu
            // 
            this._cmsTreeTableMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiSelectTop1000,
            this.scriptTableAsToolStripMenuItem});
            this._cmsTreeTableMenu.Name = "_cmsTreeMenu";
            this._cmsTreeTableMenu.Size = new System.Drawing.Size(187, 48);
            // 
            // _tsmiSelectTop1000
            // 
            this._tsmiSelectTop1000.Name = "_tsmiSelectTop1000";
            this._tsmiSelectTop1000.Size = new System.Drawing.Size(186, 22);
            this._tsmiSelectTop1000.Text = "Select Top 1000 Rows";
            this._tsmiSelectTop1000.Click += new System.EventHandler(this._tsmiSelectTop1000_Click);
            // 
            // scriptTableAsToolStripMenuItem
            // 
            this.scriptTableAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiTableScriptCreate,
            this._tsmiTableScriptInsert});
            this.scriptTableAsToolStripMenuItem.Name = "scriptTableAsToolStripMenuItem";
            this.scriptTableAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.scriptTableAsToolStripMenuItem.Text = "Script Table as";
            // 
            // _tsmiTableScriptCreate
            // 
            this._tsmiTableScriptCreate.Name = "_tsmiTableScriptCreate";
            this._tsmiTableScriptCreate.Size = new System.Drawing.Size(117, 22);
            this._tsmiTableScriptCreate.Text = "CREATE";
            this._tsmiTableScriptCreate.Click += new System.EventHandler(this._tsmiTableScriptCreate_Click);
            // 
            // _tsmiTableScriptInsert
            // 
            this._tsmiTableScriptInsert.Name = "_tsmiTableScriptInsert";
            this._tsmiTableScriptInsert.Size = new System.Drawing.Size(117, 22);
            this._tsmiTableScriptInsert.Text = "UPSERT ";
            this._tsmiTableScriptInsert.Click += new System.EventHandler(this._tsmiTableScriptInsert_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this._statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(860, 405);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(860, 452);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsbConnect,
            this._tsbRefreshTree});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(58, 25);
            this.toolStrip2.TabIndex = 1;
            // 
            // _tsbConnect
            // 
            this._tsbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._tsbConnect.Image = global::GarudaUtil.Properties.Resources.Connected_64;
            this._tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbConnect.Name = "_tsbConnect";
            this._tsbConnect.Size = new System.Drawing.Size(23, 22);
            this._tsbConnect.Text = "Connect...";
            this._tsbConnect.Click += new System.EventHandler(this._tsbConnect_Click);
            // 
            // _tsbRefreshTree
            // 
            this._tsbRefreshTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._tsbRefreshTree.Image = global::GarudaUtil.Properties.Resources.Refresh_32;
            this._tsbRefreshTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._tsbRefreshTree.Name = "_tsbRefreshTree";
            this._tsbRefreshTree.Size = new System.Drawing.Size(23, 22);
            this._tsbRefreshTree.Text = "Refresh";
            this._tsbRefreshTree.Click += new System.EventHandler(this._tsbRefreshTree_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 452);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Garuda Query";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this._cmsTreeTableMenu.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView _treeView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _tsslCurrent;
        private System.Windows.Forms.ToolStripStatusLabel _tsslConnection;
        private System.Windows.Forms.ImageList _imgListTree;
        private System.Windows.Forms.ContextMenuStrip _cmsTreeTableMenu;
        private System.Windows.Forms.ToolStripMenuItem _tsmiSelectTop1000;
        private System.Windows.Forms.ToolStripButton _tsbNewQuery;
        private System.Windows.Forms.ToolStripButton _tsbOpenFile;
        private System.Windows.Forms.ToolStripButton _tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton _tsbConnect;
        private System.Windows.Forms.ToolStripButton _tsbRefreshTree;
        private System.Windows.Forms.ToolStripMenuItem scriptTableAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _tsmiTableScriptInsert;
        private System.Windows.Forms.ToolStripMenuItem _tsmiTableScriptCreate;
    }
}

