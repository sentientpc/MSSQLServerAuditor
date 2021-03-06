﻿using MSSQLServerAuditor.Gui.Base;

namespace MSSQLServerAuditor.Gui
{
	public partial class ConnectionTabControl
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

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionTabControl));
			this.cmsTree = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuUpdateNode = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuUpdateHierarcially = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuNodeSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuScheduleSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSettingsParameters = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExpandHierarchically = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCollapseHierarchically = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRefreshTree = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuConnectionProperties = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCloseConnection = new System.Windows.Forms.ToolStripMenuItem();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblSplitter = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnStop = new System.Windows.Forms.ToolStripSplitButton();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.processWithLabel = new MSSQLServerAuditor.Gui.CustomControls.ToolStripStatusLabelWithProgress();
			this.progressDetailsButton = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblInstancesCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblUserName = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblLastRefreshDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblSpendTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbNextUpdateDateTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.treeImageList = new System.Windows.Forms.ImageList(this.components);
			this.tmSchedulerTimer = new System.Windows.Forms.Timer(this.components);
			this.tcBrowse = new MSSQLServerAuditor.Gui.Base.TabControlEx();
			this.tpXml = new System.Windows.Forms.TabPage();
			this.txtXml = new System.Windows.Forms.TextBox();
			this.treeTemplate = new MSSQLServerAuditor.Gui.Base.PreserveHighlightTreeView();
			this.cmsTree.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.tcBrowse.SuspendLayout();
			this.tpXml.SuspendLayout();
			this.SuspendLayout();
			//
			// cmsTree
			//
			this.cmsTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuUpdateNode,
			this.mnuUpdateHierarcially,
			this.mnuSeparator1,
			this.mnuNodeSettings,
			this.mnuScheduleSettings,
			this.mnuSettingsParameters,
			this.mnuSeparator2,
			this.mnuExpandHierarchically,
			this.mnuCollapseHierarchically,
			this.mnuRefreshTree,
			this.mnuSeparator3,
			this.mnuConnectionProperties,
			this.mnuCloseConnection});
			this.cmsTree.Name = "cmsTree";
			this.cmsTree.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.cmsTree.Size = new System.Drawing.Size(181, 264);
			this.cmsTree.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTree_Opening);
			//
			// mnuUpdateNode
			//
			this.mnuUpdateNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuUpdateNode.Name = "mnuUpdateNode";
			this.mnuUpdateNode.ShowShortcutKeys = false;
			this.mnuUpdateNode.Size = new System.Drawing.Size(180, 22);
			this.mnuUpdateNode.Text = "Update Node";
			this.mnuUpdateNode.Click += new System.EventHandler(this.UpdateMenuItemClick);
			//
			// mnuUpdateHierarcially
			//
			this.mnuUpdateHierarcially.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuUpdateHierarcially.Name = "mnuUpdateHierarcially";
			this.mnuUpdateHierarcially.ShowShortcutKeys = false;
			this.mnuUpdateHierarcially.Size = new System.Drawing.Size(180, 22);
			this.mnuUpdateHierarcially.Text = "Update Hierarchically";
			this.mnuUpdateHierarcially.Click += new System.EventHandler(this.UpdateHierarciallyMenuItemClick);
			//
			// mnuSeparator1
			//
			this.mnuSeparator1.Name = "mnuSeparator1";
			this.mnuSeparator1.Size = new System.Drawing.Size(177, 6);
			//
			// mnuNodeSettings
			//
			this.mnuNodeSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuNodeSettings.Name = "mnuNodeSettings";
			this.mnuNodeSettings.ShowShortcutKeys = false;
			this.mnuNodeSettings.Size = new System.Drawing.Size(180, 22);
			this.mnuNodeSettings.Text = "Settings node";
			this.mnuNodeSettings.Click += new System.EventHandler(this.settingsNodeToolStripMenuItem_Click);
			//
			// mnuScheduleSettings
			//
			this.mnuScheduleSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuScheduleSettings.Name = "mnuScheduleSettings";
			this.mnuScheduleSettings.ShowShortcutKeys = false;
			this.mnuScheduleSettings.Size = new System.Drawing.Size(180, 22);
			this.mnuScheduleSettings.Text = "Settings schedule";
			this.mnuScheduleSettings.Click += new System.EventHandler(this.settingScheduleToolStripMenuItem_Click);
			//
			// mnuSettingsParameters
			//
			this.mnuSettingsParameters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuSettingsParameters.Name = "mnuSettingsParameters";
			this.mnuSettingsParameters.ShowShortcutKeys = false;
			this.mnuSettingsParameters.Size = new System.Drawing.Size(180, 22);
			this.mnuSettingsParameters.Text = "Settings parameters";
			this.mnuSettingsParameters.Click += new System.EventHandler(this.settingsParametersToolStripMenuItem_Click);
			//
			// mnuSeparator2
			//
			this.mnuSeparator2.Name = "mnuSeparator2";
			this.mnuSeparator2.Size = new System.Drawing.Size(177, 6);
			//
			// mnuExpandHierarchically
			//
			this.mnuExpandHierarchically.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuExpandHierarchically.Name = "mnuExpandHierarchically";
			this.mnuExpandHierarchically.ShowShortcutKeys = false;
			this.mnuExpandHierarchically.Size = new System.Drawing.Size(180, 22);
			this.mnuExpandHierarchically.Text = "Expand Hierarcially";
			this.mnuExpandHierarchically.Click += new System.EventHandler(this.expandHierarciallyToolStripMenuItem_Click);
			//
			// mnuCollapseHierarchically
			//
			this.mnuCollapseHierarchically.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuCollapseHierarchically.Name = "mnuCollapseHierarchically";
			this.mnuCollapseHierarchically.ShowShortcutKeys = false;
			this.mnuCollapseHierarchically.Size = new System.Drawing.Size(180, 22);
			this.mnuCollapseHierarchically.Text = "Collapse Hierarcially";
			this.mnuCollapseHierarchically.Click += new System.EventHandler(this.collapseHierarciallyToolStripMenuItem_Click);
			//
			// mnuRefreshTree
			//
			this.mnuRefreshTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuRefreshTree.Name = "mnuRefreshTree";
			this.mnuRefreshTree.ShowShortcutKeys = false;
			this.mnuRefreshTree.Size = new System.Drawing.Size(180, 22);
			this.mnuRefreshTree.Text = "Refresh Tree";
			this.mnuRefreshTree.Click += new System.EventHandler(this.RefreshTreeToolStripMenuItemClick);
			//
			// mnuSeparator3
			//
			this.mnuSeparator3.Name = "mnuSeparator3";
			this.mnuSeparator3.Size = new System.Drawing.Size(177, 6);
			//
			// mnuConnectionProperties
			//
			this.mnuConnectionProperties.Name = "mnuConnectionProperties";
			this.mnuConnectionProperties.ShowShortcutKeys = false;
			this.mnuConnectionProperties.Size = new System.Drawing.Size(180, 22);
			this.mnuConnectionProperties.Text = "Properties";
			this.mnuConnectionProperties.Click += new System.EventHandler(this.mnuConnectionProperties_Click);
			//
			// mnuCloseConnection
			//
			this.mnuCloseConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuCloseConnection.Name = "mnuCloseConnection";
			this.mnuCloseConnection.ShowShortcutKeys = false;
			this.mnuCloseConnection.Size = new System.Drawing.Size(180, 22);
			this.mnuCloseConnection.Text = "Close";
			this.mnuCloseConnection.Click += new System.EventHandler(this.mnuTreeContextCloseConnection_Click);
			//
			// splitter1
			//
			this.splitter1.Location = new System.Drawing.Point(199, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 1123);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			this.splitter1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitter1_MouseClick);
			//
			// statusStrip
			//
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lblSplitter,
			this.btnStop,
			this.toolStripStatusLabel2,
			this.processWithLabel,
			this.progressDetailsButton,
			this.lblInstancesCount,
			this.lblUserName,
			this.lblLastRefreshDate,
			this.lblSpendTime,
			this.lbNextUpdateDateTime});
			this.statusStrip.Location = new System.Drawing.Point(0, 1123);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(1264, 24);
			this.statusStrip.TabIndex = 19;
			this.statusStrip.Text = "statusStrip1";
			//
			// lblSplitter
			//
			this.lblSplitter.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.lblSplitter.Name = "lblSplitter";
			this.lblSplitter.Size = new System.Drawing.Size(1053, 19);
			this.lblSplitter.Spring = true;
			//
			// btnStop
			//
			this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnStop.Image = global::MSSQLServerAuditor.Properties.Resources.stop;
			this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnStop.Margin = new System.Windows.Forms.Padding(2);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(32, 20);
			this.btnStop.Text = "toolStripSplitButton1";
			this.btnStop.Visible = false;
			this.btnStop.ButtonClick += new System.EventHandler(this.BtnStopButtonClick);
			//
			// toolStripStatusLabel2
			//
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 19);
			this.toolStripStatusLabel2.Text = " ";
			//
			// processWithLabel
			//
			this.processWithLabel.AutoSize = false;
			this.processWithLabel.BackColor = System.Drawing.Color.Transparent;
			this.processWithLabel.BarColor = System.Drawing.SystemColors.Highlight;
			this.processWithLabel.Name = "processWithLabel";
			this.processWithLabel.Size = new System.Drawing.Size(102, 19);
			this.processWithLabel.Text = "ConnectionGroup";
			this.processWithLabel.Value = new decimal(new int[] {
			50,
			0,
			0,
			0});
			this.processWithLabel.Click += new System.EventHandler(this.processWithLabel_Click);
			//
			// progressDetailsButton
			//
			this.progressDetailsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.progressDetailsButton.Image = ((System.Drawing.Image)(resources.GetObject("progressDetailsButton.Image")));
			this.progressDetailsButton.IsLink = true;
			this.progressDetailsButton.Name = "progressDetailsButton";
			this.progressDetailsButton.Size = new System.Drawing.Size(16, 19);
			this.progressDetailsButton.Text = "progressInfoButton";
			this.progressDetailsButton.Visible = false;
			this.progressDetailsButton.Click += new System.EventHandler(this.progressDetailsButton_Click);
			//
			// lblInstancesCount
			//
			this.lblInstancesCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.lblInstancesCount.Name = "lblInstancesCount";
			this.lblInstancesCount.Size = new System.Drawing.Size(17, 19);
			this.lblInstancesCount.Text = "0";
			//
			// lblUserName
			//
			this.lblUserName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(55, 19);
			this.lblUserName.Text = "userData";
			//
			// lblLastRefreshDate
			//
			this.lblLastRefreshDate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.lblLastRefreshDate.Name = "lblLastRefreshDate";
			this.lblLastRefreshDate.Size = new System.Drawing.Size(4, 19);
			//
			// lblSpendTime
			//
			this.lblSpendTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.lblSpendTime.Name = "lblSpendTime";
			this.lblSpendTime.Size = new System.Drawing.Size(4, 19);
			//
			// lbNextUpdateDateTime
			//
			this.lbNextUpdateDateTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.lbNextUpdateDateTime.Name = "lbNextUpdateDateTime";
			this.lbNextUpdateDateTime.Size = new System.Drawing.Size(4, 19);
			//
			// treeImageList
			//
			this.treeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.treeImageList.ImageSize = new System.Drawing.Size(16, 16);
			this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
			//
			// tmSchedulerTimer
			//
			this.tmSchedulerTimer.Interval = 1000;
			this.tmSchedulerTimer.Tick += new System.EventHandler(this.tmSchedulerTimer_Tick);
			//
			// tcBrowse
			//
			this.tcBrowse.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tcBrowse.Controls.Add(this.tpXml);
			this.tcBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcBrowse.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tcBrowse.Location = new System.Drawing.Point(202, 0);
			this.tcBrowse.Margin = new System.Windows.Forms.Padding(0);
			this.tcBrowse.Name = "tcBrowse";
			this.tcBrowse.Padding = new System.Drawing.Point(0, 0);
			this.tcBrowse.SelectedIndex = 0;
			this.tcBrowse.ShowSingleTab = true;
			this.tcBrowse.Size = new System.Drawing.Size(1062, 1123);
			this.tcBrowse.TabIndex = 2;
			//
			// tpXml
			//
			this.tpXml.Controls.Add(this.txtXml);
			this.tpXml.Location = new System.Drawing.Point(1, 23);
			this.tpXml.Margin = new System.Windows.Forms.Padding(0);
			this.tpXml.Name = "tpXml";
			this.tpXml.Size = new System.Drawing.Size(1060, 1099);
			this.tpXml.TabIndex = 1;
			this.tpXml.Text = "XML";
			this.tpXml.UseVisualStyleBackColor = true;
			//
			// txtXml
			//
			this.txtXml.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtXml.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtXml.Location = new System.Drawing.Point(0, 0);
			this.txtXml.Margin = new System.Windows.Forms.Padding(0);
			this.txtXml.Multiline = true;
			this.txtXml.Name = "txtXml";
			this.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtXml.Size = new System.Drawing.Size(1060, 1099);
			this.txtXml.TabIndex = 5;
			//
			// treeTemplate
			//
			this.treeTemplate.ActiveScheduleOverlayImage = global::MSSQLServerAuditor.Properties.Resources.active_schedule;
			this.treeTemplate.ContextMenuStrip = this.cmsTree;
			this.treeTemplate.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeTemplate.ImageIndex = 0;
			this.treeTemplate.ImageList = this.treeImageList;
			this.treeTemplate.Location = new System.Drawing.Point(0, 0);
			this.treeTemplate.Name = "treeTemplate";
			this.treeTemplate.SelectedImageIndex = 0;
			this.treeTemplate.ShowNodeToolTips = true;
			this.treeTemplate.Size = new System.Drawing.Size(199, 1123);
			this.treeTemplate.TabIndex = 0;
			this.treeTemplate.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeTemplate_BeforeExpand);
			this.treeTemplate.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeTemplate_AfterExpand);
			this.treeTemplate.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeTemplate_AfterSelect);
			this.treeTemplate.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeTemplate_NodeMouseClick);
			//
			// ConnectionTabControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tcBrowse);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.treeTemplate);
			this.Controls.Add(this.statusStrip);
			this.Name = "ConnectionTabControl";
			this.Size = new System.Drawing.Size(1264, 1147);
			this.cmsTree.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tcBrowse.ResumeLayout(false);
			this.tpXml.ResumeLayout(false);
			this.tpXml.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private PreserveHighlightTreeView treeTemplate;
		private System.Windows.Forms.Splitter splitter1;
		private MSSQLServerAuditor.Gui.Base.TabControlEx tcBrowse;
		private System.Windows.Forms.TabPage tpXml;
		private System.Windows.Forms.TextBox txtXml;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ContextMenuStrip cmsTree;
		private System.Windows.Forms.ToolStripMenuItem mnuUpdateNode;
		private System.Windows.Forms.ToolStripMenuItem mnuRefreshTree;
		private System.Windows.Forms.ToolStripSplitButton btnStop;
		private System.Windows.Forms.ToolStripMenuItem mnuUpdateHierarcially;
		private System.Windows.Forms.ToolStripStatusLabel lblUserName;
		private System.Windows.Forms.ToolStripStatusLabel lblLastRefreshDate;
		private System.Windows.Forms.ToolStripStatusLabel lblInstancesCount;
		private System.Windows.Forms.ToolStripSeparator mnuSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnuExpandHierarchically;
		private System.Windows.Forms.ToolStripMenuItem mnuCollapseHierarchically;
		private System.Windows.Forms.ImageList treeImageList;
		private System.Windows.Forms.ToolStripStatusLabel lblSplitter;
		private System.Windows.Forms.ToolStripSeparator mnuSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mnuCloseConnection;
		private System.Windows.Forms.ToolStripMenuItem mnuNodeSettings;
		private System.Windows.Forms.ToolStripSeparator mnuSeparator1;
		private System.Windows.Forms.ToolStripStatusLabel lblSpendTime;
		private System.Windows.Forms.ToolStripMenuItem mnuScheduleSettings;
		private System.Windows.Forms.Timer tmSchedulerTimer;
		private System.Windows.Forms.ToolStripStatusLabel lbNextUpdateDateTime;
		private System.Windows.Forms.ToolStripStatusLabel progressDetailsButton;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripMenuItem mnuSettingsParameters;
		private CustomControls.ToolStripStatusLabelWithProgress processWithLabel;
		private System.Windows.Forms.ToolStripMenuItem mnuConnectionProperties;
	}
}
