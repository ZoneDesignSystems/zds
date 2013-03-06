namespace ZoneDesignSystems.arCADia
{
    partial class frmMainC
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainC));
      this.tabMenu = new System.Windows.Forms.TabControl();
      this.tabContiguity = new System.Windows.Forms.TabPage();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.label3 = new System.Windows.Forms.Label();
      this.btnLoadFlows = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbFieldPopulation = new System.Windows.Forms.ComboBox();
      this.txtBoxInfo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cmbFieldId = new System.Windows.Forms.ComboBox();
      this.cmbSelectProjection = new System.Windows.Forms.ComboBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.chkLBoxContiguities = new System.Windows.Forms.CheckedListBox();
      this.btnLoad = new System.Windows.Forms.Button();
      this.tabMap = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.picMap = new System.Windows.Forms.PictureBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.txtStatusInfoContiguities = new System.Windows.Forms.TextBox();
      this.tabData = new System.Windows.Forms.TabPage();
      this.tabWeights = new System.Windows.Forms.TabPage();
      this.mnuMain = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statStrip = new System.Windows.Forms.StatusStrip();
      this.btnClearSystem = new System.Windows.Forms.ToolStripDropDownButton();
      this.mnuItemClearStatusInfo = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemClearSystem = new System.Windows.Forms.ToolStripMenuItem();
      this.pBar = new System.Windows.Forms.ToolStripProgressBar();
      this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
      this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
      this.openFD = new System.Windows.Forms.OpenFileDialog();
      this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
      this.tabMenu.SuspendLayout();
      this.tabContiguity.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabMap.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
      this.tabPage2.SuspendLayout();
      this.statStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabMenu
      // 
      this.tabMenu.Controls.Add(this.tabContiguity);
      this.tabMenu.Controls.Add(this.tabData);
      this.tabMenu.Controls.Add(this.tabWeights);
      this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabMenu.Location = new System.Drawing.Point(0, 0);
      this.tabMenu.Name = "tabMenu";
      this.tabMenu.SelectedIndex = 0;
      this.tabMenu.Size = new System.Drawing.Size(891, 509);
      this.tabMenu.TabIndex = 1;
      // 
      // tabContiguity
      // 
      this.tabContiguity.Controls.Add(this.splitContainer1);
      this.tabContiguity.Location = new System.Drawing.Point(4, 22);
      this.tabContiguity.Name = "tabContiguity";
      this.tabContiguity.Padding = new System.Windows.Forms.Padding(3);
      this.tabContiguity.Size = new System.Drawing.Size(883, 483);
      this.tabContiguity.TabIndex = 0;
      this.tabContiguity.Text = "Contiguities";
      this.tabContiguity.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(3, 3);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.label3);
      this.splitContainer1.Panel1.Controls.Add(this.btnLoadFlows);
      this.splitContainer1.Panel1.Controls.Add(this.label4);
      this.splitContainer1.Panel1.Controls.Add(this.cmbFieldPopulation);
      this.splitContainer1.Panel1.Controls.Add(this.txtBoxInfo);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      this.splitContainer1.Panel1.Controls.Add(this.txtFileName);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Controls.Add(this.cmbFieldId);
      this.splitContainer1.Panel1.Controls.Add(this.cmbSelectProjection);
      this.splitContainer1.Panel1.Controls.Add(this.btnSave);
      this.splitContainer1.Panel1.Controls.Add(this.chkLBoxContiguities);
      this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tabMap);
      this.splitContainer1.Size = new System.Drawing.Size(877, 477);
      this.splitContainer1.SplitterDistance = 279;
      this.splitContainer1.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 332);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(173, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "Load matrix file of migration flows ...";
      // 
      // btnLoadFlows
      // 
      this.btnLoadFlows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnLoadFlows.Enabled = false;
      this.btnLoadFlows.Location = new System.Drawing.Point(200, 327);
      this.btnLoadFlows.Name = "btnLoadFlows";
      this.btnLoadFlows.Size = new System.Drawing.Size(75, 23);
      this.btnLoadFlows.TabIndex = 13;
      this.btnLoadFlows.Text = "Load";
      this.btnLoadFlows.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 302);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(85, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "Population Field:";
      // 
      // cmbFieldPopulation
      // 
      this.cmbFieldPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbFieldPopulation.Enabled = false;
      this.cmbFieldPopulation.FormattingEnabled = true;
      this.cmbFieldPopulation.Location = new System.Drawing.Point(96, 299);
      this.cmbFieldPopulation.Name = "cmbFieldPopulation";
      this.cmbFieldPopulation.Size = new System.Drawing.Size(180, 21);
      this.cmbFieldPopulation.TabIndex = 11;
      this.cmbFieldPopulation.Text = ". . .";
      // 
      // txtBoxInfo
      // 
      this.txtBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBoxInfo.Enabled = false;
      this.txtBoxInfo.Location = new System.Drawing.Point(5, 171);
      this.txtBoxInfo.Multiline = true;
      this.txtBoxInfo.Name = "txtBoxInfo";
      this.txtBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtBoxInfo.Size = new System.Drawing.Size(271, 95);
      this.txtBoxInfo.TabIndex = 8;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 381);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "File Name:";
      // 
      // txtFileName
      // 
      this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFileName.Enabled = false;
      this.txtFileName.Location = new System.Drawing.Point(84, 378);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.Size = new System.Drawing.Size(192, 20);
      this.txtFileName.TabIndex = 6;
      this.txtFileName.Text = ". . .";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 275);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(75, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Identifier Field:";
      // 
      // cmbFieldId
      // 
      this.cmbFieldId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbFieldId.Enabled = false;
      this.cmbFieldId.FormattingEnabled = true;
      this.cmbFieldId.Location = new System.Drawing.Point(96, 272);
      this.cmbFieldId.Name = "cmbFieldId";
      this.cmbFieldId.Size = new System.Drawing.Size(180, 21);
      this.cmbFieldId.TabIndex = 4;
      this.cmbFieldId.Text = ". . .";
      // 
      // cmbSelectProjection
      // 
      this.cmbSelectProjection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbSelectProjection.Enabled = false;
      this.cmbSelectProjection.FormattingEnabled = true;
      this.cmbSelectProjection.Items.AddRange(new object[] {
            "Cartesian Coordinates (XY)",
            "Geographical Coordinates (Lat/Lon)"});
      this.cmbSelectProjection.Location = new System.Drawing.Point(96, 17);
      this.cmbSelectProjection.Name = "cmbSelectProjection";
      this.cmbSelectProjection.Size = new System.Drawing.Size(180, 21);
      this.cmbSelectProjection.TabIndex = 3;
      this.cmbSelectProjection.Text = "Cartesian Coordinates (XY)";
      this.cmbSelectProjection.SelectedIndexChanged += new System.EventHandler(this.cmbSelectProjection_SelectedIndexChanged);
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnSave.Enabled = false;
      this.btnSave.Location = new System.Drawing.Point(5, 417);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(84, 23);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Build";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // chkLBoxContiguities
      // 
      this.chkLBoxContiguities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.chkLBoxContiguities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.chkLBoxContiguities.CheckOnClick = true;
      this.chkLBoxContiguities.Enabled = false;
      this.chkLBoxContiguities.FormattingEnabled = true;
      this.chkLBoxContiguities.Items.AddRange(new object[] {
            "Contiguities (AreaId, AreaId)",
            "Contiguities (Matrix)",
            "Contiguities (for A2Z application)",
            "Centroids (AreaId, X, Y)",
            "Centroids (AreaId, X, Y, Area, Perimeter)",
            "Distances (AreaId, AreaId, Dist)",
            "Distances (Matrix)",
            "Migration Flows (OriginId,DestinationId,Flow)",
            "Populations (AreaId, Pop)"});
      this.chkLBoxContiguities.Location = new System.Drawing.Point(5, 45);
      this.chkLBoxContiguities.Name = "chkLBoxContiguities";
      this.chkLBoxContiguities.Size = new System.Drawing.Size(271, 122);
      this.chkLBoxContiguities.TabIndex = 1;
      this.chkLBoxContiguities.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkLBoxContiguities_ItemCheck);
      // 
      // btnLoad
      // 
      this.btnLoad.Location = new System.Drawing.Point(5, 16);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(84, 23);
      this.btnLoad.TabIndex = 0;
      this.btnLoad.Text = "Load SHP";
      this.btnLoad.UseVisualStyleBackColor = true;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // tabMap
      // 
      this.tabMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabMap.Controls.Add(this.tabPage1);
      this.tabMap.Controls.Add(this.tabPage2);
      this.tabMap.Location = new System.Drawing.Point(4, 4);
      this.tabMap.Name = "tabMap";
      this.tabMap.SelectedIndex = 0;
      this.tabMap.Size = new System.Drawing.Size(590, 455);
      this.tabMap.TabIndex = 1;
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
      this.tabPage1.Controls.Add(this.picMap);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(582, 429);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Map";
      // 
      // picMap
      // 
      this.picMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.picMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.picMap.Location = new System.Drawing.Point(6, 6);
      this.picMap.Name = "picMap";
      this.picMap.Size = new System.Drawing.Size(570, 417);
      this.picMap.TabIndex = 0;
      this.picMap.TabStop = false;
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.Color.NavajoWhite;
      this.tabPage2.Controls.Add(this.txtStatusInfoContiguities);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(582, 429);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Status Info";
      // 
      // txtStatusInfoContiguities
      // 
      this.txtStatusInfoContiguities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtStatusInfoContiguities.Enabled = false;
      this.txtStatusInfoContiguities.Location = new System.Drawing.Point(7, 7);
      this.txtStatusInfoContiguities.Multiline = true;
      this.txtStatusInfoContiguities.Name = "txtStatusInfoContiguities";
      this.txtStatusInfoContiguities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtStatusInfoContiguities.Size = new System.Drawing.Size(569, 396);
      this.txtStatusInfoContiguities.TabIndex = 0;
      // 
      // tabData
      // 
      this.tabData.Location = new System.Drawing.Point(4, 22);
      this.tabData.Name = "tabData";
      this.tabData.Padding = new System.Windows.Forms.Padding(3);
      this.tabData.Size = new System.Drawing.Size(883, 483);
      this.tabData.TabIndex = 1;
      this.tabData.Text = "Data";
      this.tabData.UseVisualStyleBackColor = true;
      // 
      // tabWeights
      // 
      this.tabWeights.Location = new System.Drawing.Point(4, 22);
      this.tabWeights.Name = "tabWeights";
      this.tabWeights.Padding = new System.Windows.Forms.Padding(3);
      this.tabWeights.Size = new System.Drawing.Size(883, 483);
      this.tabWeights.TabIndex = 2;
      this.tabWeights.Text = "Weights";
      this.tabWeights.UseVisualStyleBackColor = true;
      // 
      // mnuMain
      // 
      this.mnuMain.Location = new System.Drawing.Point(0, 0);
      this.mnuMain.Name = "mnuMain";
      this.mnuMain.Size = new System.Drawing.Size(891, 24);
      this.mnuMain.TabIndex = 2;
      this.mnuMain.Text = "menuStrip1";
      this.mnuMain.Visible = false;
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadShapefileToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // loadShapefileToolStripMenuItem
      // 
      this.loadShapefileToolStripMenuItem.Name = "loadShapefileToolStripMenuItem";
      this.loadShapefileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
      this.loadShapefileToolStripMenuItem.Text = "Load Shapefile";
      // 
      // clearToolStripMenuItem
      // 
      this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
      this.clearToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
      this.clearToolStripMenuItem.Text = "Clear";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      // 
      // statStrip
      // 
      this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClearSystem,
            this.pBar,
            this.lblStatus});
      this.statStrip.Location = new System.Drawing.Point(0, 487);
      this.statStrip.Name = "statStrip";
      this.statStrip.Size = new System.Drawing.Size(891, 22);
      this.statStrip.TabIndex = 3;
      // 
      // btnClearSystem
      // 
      this.btnClearSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnClearSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemClearStatusInfo,
            this.mnuItemClearSystem});
      this.btnClearSystem.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSystem.Image")));
      this.btnClearSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnClearSystem.Name = "btnClearSystem";
      this.btnClearSystem.Size = new System.Drawing.Size(29, 20);
      this.btnClearSystem.Text = "toolStripDropDownButton1";
      this.btnClearSystem.ToolTipText = "Clear System";
      // 
      // mnuItemClearStatusInfo
      // 
      this.mnuItemClearStatusInfo.Name = "mnuItemClearStatusInfo";
      this.mnuItemClearStatusInfo.Size = new System.Drawing.Size(160, 22);
      this.mnuItemClearStatusInfo.Text = "Clear Status Info";
      // 
      // mnuItemClearSystem
      // 
      this.mnuItemClearSystem.Name = "mnuItemClearSystem";
      this.mnuItemClearSystem.Size = new System.Drawing.Size(160, 22);
      this.mnuItemClearSystem.Text = "Clear System";
      // 
      // pBar
      // 
      this.pBar.Name = "pBar";
      this.pBar.Size = new System.Drawing.Size(150, 16);
      this.pBar.Visible = false;
      // 
      // lblStatus
      // 
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(92, 17);
      this.lblStatus.Text = "System Ready !!!";
      // 
      // toolStripProgressBar1
      // 
      this.toolStripProgressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.toolStripProgressBar1.ForeColor = System.Drawing.Color.Yellow;
      this.toolStripProgressBar1.Name = "toolStripProgressBar1";
      this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
      this.toolStripProgressBar1.Value = 10;
      // 
      // txtStatus
      // 
      this.txtStatus.Name = "txtStatus";
      this.txtStatus.Size = new System.Drawing.Size(92, 17);
      this.txtStatus.Text = "System Ready !!!";
      // 
      // BottomToolStripPanel
      // 
      this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
      this.BottomToolStripPanel.Name = "BottomToolStripPanel";
      this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.BottomToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
      this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
      // 
      // TopToolStripPanel
      // 
      this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
      this.TopToolStripPanel.Name = "TopToolStripPanel";
      this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
      this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
      // 
      // RightToolStripPanel
      // 
      this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
      this.RightToolStripPanel.Name = "RightToolStripPanel";
      this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.RightToolStripPanel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
      this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
      // 
      // LeftToolStripPanel
      // 
      this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
      this.LeftToolStripPanel.Name = "LeftToolStripPanel";
      this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.LeftToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
      this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
      // 
      // ContentPanel
      // 
      this.ContentPanel.Size = new System.Drawing.Size(885, 456);
      // 
      // openFD
      // 
      this.openFD.FileName = "openFileDialog1";
      this.openFD.InitialDirectory = "c:";
      this.openFD.Title = "Insert Shapefile ...";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(891, 509);
      this.Controls.Add(this.statStrip);
      this.Controls.Add(this.tabMenu);
      this.Controls.Add(this.mnuMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.mnuMain;
      this.Name = "frmMain";
      this.Text = "Contiguities & Data Builder";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
      this.tabMenu.ResumeLayout(false);
      this.tabContiguity.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabMap.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.statStrip.ResumeLayout(false);
      this.statStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabWeights;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.StatusStrip statStrip;
        private System.Windows.Forms.TabPage tabContiguity;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox chkLBoxContiguities;
        private System.Windows.Forms.ComboBox cmbSelectProjection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFieldId;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripProgressBar pBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripDropDownButton btnClearSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemClearSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemClearStatusInfo;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
        private System.Windows.Forms.TextBox txtBoxInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFieldPopulation;
        private System.Windows.Forms.TabControl tabMap;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtStatusInfoContiguities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadFlows;
    }
}

