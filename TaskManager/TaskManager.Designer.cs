namespace TaskManager
{
    partial class TaskManager
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuFileRun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuRefreshRate = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuViewRateHigh = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuViewRateNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuViewRateLow = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelProcessCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlProcrsses = new System.Windows.Forms.TabPage();
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilepath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuProcList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpenFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDestroy = new System.Windows.Forms.ToolStripMenuItem();
            this.Perfomance = new System.Windows.Forms.TabControl();
            this.columnOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlProcrsses.SuspendLayout();
            this.contextMenuProcList.SuspendLayout();
            this.Perfomance.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(578, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuFileRun,
            this.toolStripSeparator1,
            this.mainMenuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuFileRun
            // 
            this.mainMenuFileRun.Name = "mainMenuFileRun";
            this.mainMenuFileRun.Size = new System.Drawing.Size(95, 22);
            this.mainMenuFileRun.Text = "Run";
            this.mainMenuFileRun.Click += new System.EventHandler(this.mainMenuFileRun_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(92, 6);
            // 
            // mainMenuFileExit
            // 
            this.mainMenuFileExit.Name = "mainMenuFileExit";
            this.mainMenuFileExit.Size = new System.Drawing.Size(95, 22);
            this.mainMenuFileExit.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuTopmost,
            this.mainMenuHide,
            this.toolStripSeparator2,
            this.mainMenuColumns,
            this.toolStripSeparator3,
            this.mainMenuRefresh,
            this.mainMenuRefreshRate});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mainMenuTopmost
            // 
            this.mainMenuTopmost.CheckOnClick = true;
            this.mainMenuTopmost.Name = "mainMenuTopmost";
            this.mainMenuTopmost.Size = new System.Drawing.Size(190, 22);
            this.mainMenuTopmost.Text = "Topmost";
            this.mainMenuTopmost.CheckedChanged += new System.EventHandler(this.mainMenuTopmost_CheckedChanged);
            // 
            // mainMenuHide
            // 
            this.mainMenuHide.CheckOnClick = true;
            this.mainMenuHide.Name = "mainMenuHide";
            this.mainMenuHide.Size = new System.Drawing.Size(190, 22);
            this.mainMenuHide.Text = "Hide when minimized";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // mainMenuColumns
            // 
            this.mainMenuColumns.Name = "mainMenuColumns";
            this.mainMenuColumns.Size = new System.Drawing.Size(190, 22);
            this.mainMenuColumns.Text = "Select columns";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // mainMenuRefresh
            // 
            this.mainMenuRefresh.Name = "mainMenuRefresh";
            this.mainMenuRefresh.Size = new System.Drawing.Size(190, 22);
            this.mainMenuRefresh.Text = "Refresh";
            // 
            // mainMenuRefreshRate
            // 
            this.mainMenuRefreshRate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuViewRateHigh,
            this.mainMenuViewRateNormal,
            this.mainMenuViewRateLow});
            this.mainMenuRefreshRate.Name = "mainMenuRefreshRate";
            this.mainMenuRefreshRate.Size = new System.Drawing.Size(190, 22);
            this.mainMenuRefreshRate.Text = "Refresh rate";
            // 
            // mainMenuViewRateHigh
            // 
            this.mainMenuViewRateHigh.Name = "mainMenuViewRateHigh";
            this.mainMenuViewRateHigh.Size = new System.Drawing.Size(114, 22);
            this.mainMenuViewRateHigh.Text = "High";
            // 
            // mainMenuViewRateNormal
            // 
            this.mainMenuViewRateNormal.Name = "mainMenuViewRateNormal";
            this.mainMenuViewRateNormal.Size = new System.Drawing.Size(114, 22);
            this.mainMenuViewRateNormal.Text = "Normal";
            // 
            // mainMenuViewRateLow
            // 
            this.mainMenuViewRateLow.Name = "mainMenuViewRateLow";
            this.mainMenuViewRateLow.Size = new System.Drawing.Size(114, 22);
            this.mainMenuViewRateLow.Text = "Low";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelProcessCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(578, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelProcessCount
            // 
            this.toolStripStatusLabelProcessCount.Name = "toolStripStatusLabelProcessCount";
            this.toolStripStatusLabelProcessCount.Size = new System.Drawing.Size(152, 17);
            this.toolStripStatusLabelProcessCount.Text = "toolStripStatusLabelProcess";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(570, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Perfomance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlProcrsses
            // 
            this.tabControlProcrsses.Controls.Add(this.listViewProcesses);
            this.tabControlProcrsses.Location = new System.Drawing.Point(4, 22);
            this.tabControlProcrsses.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlProcrsses.Name = "tabControlProcrsses";
            this.tabControlProcrsses.Padding = new System.Windows.Forms.Padding(2);
            this.tabControlProcrsses.Size = new System.Drawing.Size(570, 320);
            this.tabControlProcrsses.TabIndex = 0;
            this.tabControlProcrsses.Text = "Processes";
            this.tabControlProcrsses.UseVisualStyleBackColor = true;
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.AllowColumnReorder = true;
            this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPID,
            this.columnOwner,
            this.columnFilepath});
            this.listViewProcesses.ContextMenuStrip = this.contextMenuProcList;
            this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProcesses.FullRowSelect = true;
            this.listViewProcesses.GridLines = true;
            this.listViewProcesses.HideSelection = false;
            this.listViewProcesses.Location = new System.Drawing.Point(2, 2);
            this.listViewProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.listViewProcesses.MultiSelect = false;
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(566, 316);
            this.listViewProcesses.TabIndex = 1;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.View = System.Windows.Forms.View.Details;
            this.listViewProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProcesses_ColumnClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnPID
            // 
            this.columnPID.Text = "PID";
            // 
            // columnFilepath
            // 
            this.columnFilepath.Text = "Path";
            this.columnFilepath.Width = 87;
            // 
            // contextMenuProcList
            // 
            this.contextMenuProcList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenFileLocation,
            this.toolStripSeparator4,
            this.toolStripMenuItemDestroy});
            this.contextMenuProcList.Name = "contextMenuStrip1";
            this.contextMenuProcList.Size = new System.Drawing.Size(169, 54);
            this.contextMenuProcList.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuProcList_Opening);
            // 
            // toolStripMenuItemOpenFileLocation
            // 
            this.toolStripMenuItemOpenFileLocation.Name = "toolStripMenuItemOpenFileLocation";
            this.toolStripMenuItemOpenFileLocation.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemOpenFileLocation.Text = "Open file location";
            this.toolStripMenuItemOpenFileLocation.Click += new System.EventHandler(this.toolStripMenuItemOpenFileLocation_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // toolStripMenuItemDestroy
            // 
            this.toolStripMenuItemDestroy.Name = "toolStripMenuItemDestroy";
            this.toolStripMenuItemDestroy.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemDestroy.Text = "Destroy";
            this.toolStripMenuItemDestroy.Click += new System.EventHandler(this.destroyToolStripMenuItem_Click);
            // 
            // Perfomance
            // 
            this.Perfomance.Controls.Add(this.tabControlProcrsses);
            this.Perfomance.Controls.Add(this.tabPage2);
            this.Perfomance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Perfomance.Location = new System.Drawing.Point(0, 24);
            this.Perfomance.Margin = new System.Windows.Forms.Padding(2);
            this.Perfomance.Name = "Perfomance";
            this.Perfomance.SelectedIndex = 0;
            this.Perfomance.Size = new System.Drawing.Size(578, 346);
            this.Perfomance.TabIndex = 2;
            // 
            // columnOwner
            // 
            this.columnOwner.Text = "Owner";
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 392);
            this.Controls.Add(this.Perfomance);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlProcrsses.ResumeLayout(false);
            this.contextMenuProcList.ResumeLayout(false);
            this.Perfomance.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFileRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuTopmost;
        private System.Windows.Forms.ToolStripMenuItem mainMenuHide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mainMenuColumns;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mainMenuRefresh;
        private System.Windows.Forms.ToolStripMenuItem mainMenuRefreshRate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuViewRateHigh;
        private System.Windows.Forms.ToolStripMenuItem mainMenuViewRateNormal;
        private System.Windows.Forms.ToolStripMenuItem mainMenuViewRateLow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProcessCount;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabControlProcrsses;
        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPID;
        private System.Windows.Forms.TabControl Perfomance;
		private System.Windows.Forms.ContextMenuStrip contextMenuProcList;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFileLocation;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDestroy;
        private System.Windows.Forms.ColumnHeader columnFilepath;
        private System.Windows.Forms.ColumnHeader columnOwner;
    }
}

