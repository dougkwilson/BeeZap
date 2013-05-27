using Beeline.BeeZap.Infrastructure;

namespace Beeline.BeeZap
{
	partial class MainView
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			this.secondarySplitContainer = new System.Windows.Forms.SplitContainer();
			this.topTabControl = new System.Windows.Forms.TabControl();
			this.filterTabPage = new System.Windows.Forms.TabPage();
			this.pathGroupBox = new System.Windows.Forms.GroupBox();
			this.patternTextBox = new BeeTextBox();
			this.patternLabel = new System.Windows.Forms.Label();
			this.browseButton = new System.Windows.Forms.Button();
			this.pathTextBox = new BeeTextBox();
			this.pathLabel = new System.Windows.Forms.Label();
			this.subdirectoriesRadioButton = new System.Windows.Forms.RadioButton();
			this.currentDirectoryRadioButton = new System.Windows.Forms.RadioButton();
			this.contentFilterGroupBox = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.maxLineExcludeTextBox = new BeeTextBox();
			this.minLineExcludeTextBox = new BeeTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.maxLineIncludeTextBox = new BeeTextBox();
			this.minLineIncludeTextBox = new BeeTextBox();
			this.contentIncludeExpressionLabel = new System.Windows.Forms.Label();
			this.fileContentIncludeTextBox = new BeeTextBox();
			this.contentExcludeExpressionLabel = new System.Windows.Forms.Label();
			this.fileContentExcludeTextBox = new BeeTextBox();
			this.filtersGroupBox = new System.Windows.Forms.GroupBox();
			this.fullNameExcludeTextBox = new System.Windows.Forms.ComboBox();
			this.fullNameIncludeTextBox = new BeeTextBox();
			this.filenameExcludeExpressionLabel = new System.Windows.Forms.Label();
			this.filenameIncludeExpressionLabel = new System.Windows.Forms.Label();
			this.replaceTabPage = new System.Windows.Forms.TabPage();
			this.searchReplaceSplitContainer = new System.Windows.Forms.SplitContainer();
			this.searchGroupBox = new System.Windows.Forms.GroupBox();
			this.explicitCaptureCheckBox = new System.Windows.Forms.CheckBox();
			this.singlelineCheckBox = new System.Windows.Forms.CheckBox();
			this.multilineCheckBox = new System.Windows.Forms.CheckBox();
			this.ignoreCaseCheckBox = new System.Windows.Forms.CheckBox();
			this.regularExpressionCheckBox = new System.Windows.Forms.CheckBox();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.replaceGroupBox = new System.Windows.Forms.GroupBox();
			this.literalReplacementCheckBox = new System.Windows.Forms.CheckBox();
			this.replaceTextBox = new System.Windows.Forms.TextBox();
			this.iconList = new System.Windows.Forms.ImageList(this.components);
			this.bottomTabControl = new System.Windows.Forms.TabControl();
			this.logTabPage = new System.Windows.Forms.TabPage();
			this.logTextBox = new System.Windows.Forms.TextBox();
			this.toolStripButtons = new System.Windows.Forms.ToolStrip();
			this.viewFilesButton = new System.Windows.Forms.ToolStripButton();
			this.viewMatchesButton = new System.Windows.Forms.ToolStripButton();
			this.executeButton = new System.Windows.Forms.ToolStripButton();
			this.stopButton = new System.Windows.Forms.ToolStripButton();
			this.undoButton = new System.Windows.Forms.ToolStripButton();
			this.deleteBackupsButton = new System.Windows.Forms.ToolStripButton();
			this.clearLogButton = new System.Windows.Forms.ToolStripButton();
			this.undoCountToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.formToolTips = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.secondarySplitContainer)).BeginInit();
			this.secondarySplitContainer.Panel1.SuspendLayout();
			this.secondarySplitContainer.Panel2.SuspendLayout();
			this.secondarySplitContainer.SuspendLayout();
			this.topTabControl.SuspendLayout();
			this.filterTabPage.SuspendLayout();
			this.pathGroupBox.SuspendLayout();
			this.contentFilterGroupBox.SuspendLayout();
			this.filtersGroupBox.SuspendLayout();
			this.replaceTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchReplaceSplitContainer)).BeginInit();
			this.searchReplaceSplitContainer.Panel1.SuspendLayout();
			this.searchReplaceSplitContainer.Panel2.SuspendLayout();
			this.searchReplaceSplitContainer.SuspendLayout();
			this.searchGroupBox.SuspendLayout();
			this.replaceGroupBox.SuspendLayout();
			this.bottomTabControl.SuspendLayout();
			this.logTabPage.SuspendLayout();
			this.toolStripButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// secondarySplitContainer
			// 
			this.secondarySplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.secondarySplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.secondarySplitContainer.Location = new System.Drawing.Point(12, 58);
			this.secondarySplitContainer.Name = "secondarySplitContainer";
			this.secondarySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// secondarySplitContainer.Panel1
			// 
			this.secondarySplitContainer.Panel1.Controls.Add(this.topTabControl);
			// 
			// secondarySplitContainer.Panel2
			// 
			this.secondarySplitContainer.Panel2.Controls.Add(this.bottomTabControl);
			this.secondarySplitContainer.Size = new System.Drawing.Size(835, 571);
			this.secondarySplitContainer.SplitterDistance = 324;
			this.secondarySplitContainer.TabIndex = 1;
			// 
			// topTabControl
			// 
			this.topTabControl.Controls.Add(this.filterTabPage);
			this.topTabControl.Controls.Add(this.replaceTabPage);
			this.topTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.topTabControl.ImageList = this.iconList;
			this.topTabControl.Location = new System.Drawing.Point(0, 0);
			this.topTabControl.Name = "topTabControl";
			this.topTabControl.SelectedIndex = 0;
			this.topTabControl.Size = new System.Drawing.Size(835, 324);
			this.topTabControl.TabIndex = 0;
			// 
			// filterTabPage
			// 
			this.filterTabPage.Controls.Add(this.pathGroupBox);
			this.filterTabPage.Controls.Add(this.contentFilterGroupBox);
			this.filterTabPage.Controls.Add(this.filtersGroupBox);
			this.filterTabPage.ImageIndex = 0;
			this.filterTabPage.Location = new System.Drawing.Point(4, 31);
			this.filterTabPage.Name = "filterTabPage";
			this.filterTabPage.Size = new System.Drawing.Size(827, 289);
			this.filterTabPage.TabIndex = 2;
			this.filterTabPage.Text = "File Selection";
			this.filterTabPage.UseVisualStyleBackColor = true;
			// 
			// pathGroupBox
			// 
			this.pathGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pathGroupBox.Controls.Add(this.patternTextBox);
			this.pathGroupBox.Controls.Add(this.patternLabel);
			this.pathGroupBox.Controls.Add(this.browseButton);
			this.pathGroupBox.Controls.Add(this.pathTextBox);
			this.pathGroupBox.Controls.Add(this.pathLabel);
			this.pathGroupBox.Controls.Add(this.subdirectoriesRadioButton);
			this.pathGroupBox.Controls.Add(this.currentDirectoryRadioButton);
			this.pathGroupBox.Location = new System.Drawing.Point(3, 3);
			this.pathGroupBox.Name = "pathGroupBox";
			this.pathGroupBox.Size = new System.Drawing.Size(821, 74);
			this.pathGroupBox.TabIndex = 15;
			this.pathGroupBox.TabStop = false;
			this.pathGroupBox.Text = "Starting Path";
			// 
			// patternTextBox
			// 
			this.patternTextBox.Location = new System.Drawing.Point(57, 44);
			this.patternTextBox.Name = "patternTextBox";
			this.patternTextBox.Size = new System.Drawing.Size(100, 20);
			this.patternTextBox.TabIndex = 2;
			this.patternTextBox.Text = "*.*";
			// 
			// patternLabel
			// 
			this.patternLabel.AutoSize = true;
			this.patternLabel.Location = new System.Drawing.Point(7, 47);
			this.patternLabel.Name = "patternLabel";
			this.patternLabel.Size = new System.Drawing.Size(41, 13);
			this.patternLabel.TabIndex = 15;
			this.patternLabel.Text = "Pattern";
			// 
			// browseButton
			// 
			this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.browseButton.Location = new System.Drawing.Point(740, 15);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(75, 23);
			this.browseButton.TabIndex = 1;
			this.browseButton.Text = "Browse ...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// pathTextBox
			// 
			this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pathTextBox.Location = new System.Drawing.Point(58, 17);
			this.pathTextBox.Name = "pathTextBox";
			this.pathTextBox.Size = new System.Drawing.Size(676, 20);
			this.pathTextBox.TabIndex = 0;
			// 
			// pathLabel
			// 
			this.pathLabel.AutoSize = true;
			this.pathLabel.Location = new System.Drawing.Point(7, 20);
			this.pathLabel.Name = "pathLabel";
			this.pathLabel.Size = new System.Drawing.Size(29, 13);
			this.pathLabel.TabIndex = 12;
			this.pathLabel.Text = "Path";
			// 
			// subdirectoriesRadioButton
			// 
			this.subdirectoriesRadioButton.AutoSize = true;
			this.subdirectoriesRadioButton.Checked = true;
			this.subdirectoriesRadioButton.Location = new System.Drawing.Point(185, 45);
			this.subdirectoriesRadioButton.Name = "subdirectoriesRadioButton";
			this.subdirectoriesRadioButton.Size = new System.Drawing.Size(195, 17);
			this.subdirectoriesRadioButton.TabIndex = 3;
			this.subdirectoriesRadioButton.TabStop = true;
			this.subdirectoriesRadioButton.Text = "This Directory and All Subdirectories";
			this.subdirectoriesRadioButton.UseVisualStyleBackColor = true;
			// 
			// currentDirectoryRadioButton
			// 
			this.currentDirectoryRadioButton.AutoSize = true;
			this.currentDirectoryRadioButton.Location = new System.Drawing.Point(386, 45);
			this.currentDirectoryRadioButton.Name = "currentDirectoryRadioButton";
			this.currentDirectoryRadioButton.Size = new System.Drawing.Size(114, 17);
			this.currentDirectoryRadioButton.TabIndex = 4;
			this.currentDirectoryRadioButton.Text = "This Directory Only";
			this.currentDirectoryRadioButton.UseVisualStyleBackColor = true;
			// 
			// contentFilterGroupBox
			// 
			this.contentFilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contentFilterGroupBox.Controls.Add(this.label3);
			this.contentFilterGroupBox.Controls.Add(this.label4);
			this.contentFilterGroupBox.Controls.Add(this.maxLineExcludeTextBox);
			this.contentFilterGroupBox.Controls.Add(this.minLineExcludeTextBox);
			this.contentFilterGroupBox.Controls.Add(this.label2);
			this.contentFilterGroupBox.Controls.Add(this.label1);
			this.contentFilterGroupBox.Controls.Add(this.maxLineIncludeTextBox);
			this.contentFilterGroupBox.Controls.Add(this.minLineIncludeTextBox);
			this.contentFilterGroupBox.Controls.Add(this.contentIncludeExpressionLabel);
			this.contentFilterGroupBox.Controls.Add(this.fileContentIncludeTextBox);
			this.contentFilterGroupBox.Controls.Add(this.contentExcludeExpressionLabel);
			this.contentFilterGroupBox.Controls.Add(this.fileContentExcludeTextBox);
			this.contentFilterGroupBox.Location = new System.Drawing.Point(3, 160);
			this.contentFilterGroupBox.Name = "contentFilterGroupBox";
			this.contentFilterGroupBox.Size = new System.Drawing.Size(821, 127);
			this.contentFilterGroupBox.TabIndex = 13;
			this.contentFilterGroupBox.TabStop = false;
			this.contentFilterGroupBox.Text = "Content Regular Expressions";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "And";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(54, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Between Lines";
			// 
			// maxLineExcludeTextBox
			// 
			this.maxLineExcludeTextBox.Location = new System.Drawing.Point(229, 97);
			this.maxLineExcludeTextBox.Name = "maxLineExcludeTextBox";
			this.maxLineExcludeTextBox.Size = new System.Drawing.Size(54, 20);
			this.maxLineExcludeTextBox.TabIndex = 24;
			this.maxLineExcludeTextBox.Text = "EOF";
			// 
			// minLineExcludeTextBox
			// 
			this.minLineExcludeTextBox.Location = new System.Drawing.Point(137, 97);
			this.minLineExcludeTextBox.Name = "minLineExcludeTextBox";
			this.minLineExcludeTextBox.Size = new System.Drawing.Size(54, 20);
			this.minLineExcludeTextBox.TabIndex = 23;
			this.minLineExcludeTextBox.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(198, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 22;
			this.label2.Text = "And";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Between Lines";
			// 
			// maxLineIncludeTextBox
			// 
			this.maxLineIncludeTextBox.Location = new System.Drawing.Point(230, 45);
			this.maxLineIncludeTextBox.Name = "maxLineIncludeTextBox";
			this.maxLineIncludeTextBox.Size = new System.Drawing.Size(54, 20);
			this.maxLineIncludeTextBox.TabIndex = 20;
			this.maxLineIncludeTextBox.Text = "EOF";
			// 
			// minLineIncludeTextBox
			// 
			this.minLineIncludeTextBox.Location = new System.Drawing.Point(138, 45);
			this.minLineIncludeTextBox.Name = "minLineIncludeTextBox";
			this.minLineIncludeTextBox.Size = new System.Drawing.Size(54, 20);
			this.minLineIncludeTextBox.TabIndex = 19;
			this.minLineIncludeTextBox.Text = "0";
			// 
			// contentIncludeExpressionLabel
			// 
			this.contentIncludeExpressionLabel.AutoSize = true;
			this.contentIncludeExpressionLabel.Location = new System.Drawing.Point(7, 22);
			this.contentIncludeExpressionLabel.Name = "contentIncludeExpressionLabel";
			this.contentIncludeExpressionLabel.Size = new System.Drawing.Size(42, 13);
			this.contentIncludeExpressionLabel.TabIndex = 18;
			this.contentIncludeExpressionLabel.Text = "Include";
			// 
			// fileContentIncludeTextBox
			// 
			this.fileContentIncludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileContentIncludeTextBox.Location = new System.Drawing.Point(58, 19);
			this.fileContentIncludeTextBox.Name = "fileContentIncludeTextBox";
			this.fileContentIncludeTextBox.Size = new System.Drawing.Size(757, 20);
			this.fileContentIncludeTextBox.TabIndex = 7;
			// 
			// contentExcludeExpressionLabel
			// 
			this.contentExcludeExpressionLabel.AutoSize = true;
			this.contentExcludeExpressionLabel.Location = new System.Drawing.Point(6, 74);
			this.contentExcludeExpressionLabel.Name = "contentExcludeExpressionLabel";
			this.contentExcludeExpressionLabel.Size = new System.Drawing.Size(45, 13);
			this.contentExcludeExpressionLabel.TabIndex = 16;
			this.contentExcludeExpressionLabel.Text = "Exclude";
			// 
			// fileContentExcludeTextBox
			// 
			this.fileContentExcludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileContentExcludeTextBox.Location = new System.Drawing.Point(57, 71);
			this.fileContentExcludeTextBox.Name = "fileContentExcludeTextBox";
			this.fileContentExcludeTextBox.Size = new System.Drawing.Size(757, 20);
			this.fileContentExcludeTextBox.TabIndex = 8;
			// 
			// filtersGroupBox
			// 
			this.filtersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filtersGroupBox.Controls.Add(this.fullNameExcludeTextBox);
			this.filtersGroupBox.Controls.Add(this.fullNameIncludeTextBox);
			this.filtersGroupBox.Controls.Add(this.filenameExcludeExpressionLabel);
			this.filtersGroupBox.Controls.Add(this.filenameIncludeExpressionLabel);
			this.filtersGroupBox.Location = new System.Drawing.Point(3, 83);
			this.filtersGroupBox.Name = "filtersGroupBox";
			this.filtersGroupBox.Size = new System.Drawing.Size(821, 71);
			this.filtersGroupBox.TabIndex = 10;
			this.filtersGroupBox.TabStop = false;
			this.filtersGroupBox.Text = "Filename Regular Expressions";
			// 
			// fullNameExcludeTextBox
			// 
			this.fullNameExcludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameExcludeTextBox.Items.AddRange(new object[] {
            "(back ?up|preview|paused)",
            "\\\\(Admin|Analytics|App_Browsers|App_Code|App_Data|App_Themes|Bin|Content|Framewor" +
                "k|Includes|Scripts|Views)\\\\",
            "(\\\\(Admin|Analytics|App_Browsers|App_Code|App_Data|App_Themes|Bin|Content|Framewo" +
                "rk|Includes|Scripts|Views)\\\\|back ?up|preview|paused)"});
			this.fullNameExcludeTextBox.Location = new System.Drawing.Point(58, 44);
			this.fullNameExcludeTextBox.Name = "fullNameExcludeTextBox";
			this.fullNameExcludeTextBox.Size = new System.Drawing.Size(757, 21);
			this.fullNameExcludeTextBox.TabIndex = 6;
			// 
			// fullNameIncludeTextBox
			// 
			this.fullNameIncludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameIncludeTextBox.Location = new System.Drawing.Point(58, 18);
			this.fullNameIncludeTextBox.Name = "fullNameIncludeTextBox";
			this.fullNameIncludeTextBox.Size = new System.Drawing.Size(757, 20);
			this.fullNameIncludeTextBox.TabIndex = 5;
			this.fullNameIncludeTextBox.Text = "\\.aspx?";
			// 
			// filenameExcludeExpressionLabel
			// 
			this.filenameExcludeExpressionLabel.AutoSize = true;
			this.filenameExcludeExpressionLabel.Location = new System.Drawing.Point(7, 47);
			this.filenameExcludeExpressionLabel.Name = "filenameExcludeExpressionLabel";
			this.filenameExcludeExpressionLabel.Size = new System.Drawing.Size(45, 13);
			this.filenameExcludeExpressionLabel.TabIndex = 4;
			this.filenameExcludeExpressionLabel.Text = "Exclude";
			// 
			// filenameIncludeExpressionLabel
			// 
			this.filenameIncludeExpressionLabel.AutoSize = true;
			this.filenameIncludeExpressionLabel.Location = new System.Drawing.Point(7, 21);
			this.filenameIncludeExpressionLabel.Name = "filenameIncludeExpressionLabel";
			this.filenameIncludeExpressionLabel.Size = new System.Drawing.Size(42, 13);
			this.filenameIncludeExpressionLabel.TabIndex = 3;
			this.filenameIncludeExpressionLabel.Text = "Include";
			// 
			// replaceTabPage
			// 
			this.replaceTabPage.Controls.Add(this.searchReplaceSplitContainer);
			this.replaceTabPage.ImageIndex = 1;
			this.replaceTabPage.Location = new System.Drawing.Point(4, 31);
			this.replaceTabPage.Name = "replaceTabPage";
			this.replaceTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.replaceTabPage.Size = new System.Drawing.Size(827, 289);
			this.replaceTabPage.TabIndex = 0;
			this.replaceTabPage.Text = "Find && Replace";
			this.replaceTabPage.UseVisualStyleBackColor = true;
			// 
			// searchReplaceSplitContainer
			// 
			this.searchReplaceSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchReplaceSplitContainer.Location = new System.Drawing.Point(3, 3);
			this.searchReplaceSplitContainer.Name = "searchReplaceSplitContainer";
			this.searchReplaceSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// searchReplaceSplitContainer.Panel1
			// 
			this.searchReplaceSplitContainer.Panel1.Controls.Add(this.searchGroupBox);
			// 
			// searchReplaceSplitContainer.Panel2
			// 
			this.searchReplaceSplitContainer.Panel2.Controls.Add(this.replaceGroupBox);
			this.searchReplaceSplitContainer.Size = new System.Drawing.Size(821, 283);
			this.searchReplaceSplitContainer.SplitterDistance = 145;
			this.searchReplaceSplitContainer.TabIndex = 12;
			// 
			// searchGroupBox
			// 
			this.searchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchGroupBox.Controls.Add(this.explicitCaptureCheckBox);
			this.searchGroupBox.Controls.Add(this.singlelineCheckBox);
			this.searchGroupBox.Controls.Add(this.multilineCheckBox);
			this.searchGroupBox.Controls.Add(this.ignoreCaseCheckBox);
			this.searchGroupBox.Controls.Add(this.regularExpressionCheckBox);
			this.searchGroupBox.Controls.Add(this.searchTextBox);
			this.searchGroupBox.Location = new System.Drawing.Point(0, 0);
			this.searchGroupBox.Name = "searchGroupBox";
			this.searchGroupBox.Size = new System.Drawing.Size(818, 143);
			this.searchGroupBox.TabIndex = 8;
			this.searchGroupBox.TabStop = false;
			this.searchGroupBox.Text = "Text to Find";
			// 
			// explicitCaptureCheckBox
			// 
			this.explicitCaptureCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.explicitCaptureCheckBox.AutoSize = true;
			this.explicitCaptureCheckBox.Location = new System.Drawing.Point(136, 120);
			this.explicitCaptureCheckBox.Name = "explicitCaptureCheckBox";
			this.explicitCaptureCheckBox.Size = new System.Drawing.Size(99, 17);
			this.explicitCaptureCheckBox.TabIndex = 5;
			this.explicitCaptureCheckBox.Text = "Explicit Capture";
			this.formToolTips.SetToolTip(this.explicitCaptureCheckBox, resources.GetString("explicitCaptureCheckBox.ToolTip"));
			this.explicitCaptureCheckBox.UseVisualStyleBackColor = true;
			// 
			// singlelineCheckBox
			// 
			this.singlelineCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.singlelineCheckBox.AutoSize = true;
			this.singlelineCheckBox.Location = new System.Drawing.Point(330, 120);
			this.singlelineCheckBox.Name = "singlelineCheckBox";
			this.singlelineCheckBox.Size = new System.Drawing.Size(71, 17);
			this.singlelineCheckBox.TabIndex = 4;
			this.singlelineCheckBox.Text = "Singleline";
			this.formToolTips.SetToolTip(this.singlelineCheckBox, "Changes the meaning of the dot (.) so it matches every character (instead of ever" +
        "y character except \\n).\r\n");
			this.singlelineCheckBox.UseVisualStyleBackColor = true;
			// 
			// multilineCheckBox
			// 
			this.multilineCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.multilineCheckBox.AutoSize = true;
			this.multilineCheckBox.Location = new System.Drawing.Point(407, 120);
			this.multilineCheckBox.Name = "multilineCheckBox";
			this.multilineCheckBox.Size = new System.Drawing.Size(64, 17);
			this.multilineCheckBox.TabIndex = 3;
			this.multilineCheckBox.Text = "Multiline";
			this.formToolTips.SetToolTip(this.multilineCheckBox, "Changes the meaning of ^ and $ so they match at the beginning and end, respective" +
        "ly, of any line, and not just the beginning and end of the entire string.");
			this.multilineCheckBox.UseVisualStyleBackColor = true;
			// 
			// ignoreCaseCheckBox
			// 
			this.ignoreCaseCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ignoreCaseCheckBox.AutoSize = true;
			this.ignoreCaseCheckBox.Location = new System.Drawing.Point(241, 120);
			this.ignoreCaseCheckBox.Name = "ignoreCaseCheckBox";
			this.ignoreCaseCheckBox.Size = new System.Drawing.Size(83, 17);
			this.ignoreCaseCheckBox.TabIndex = 2;
			this.ignoreCaseCheckBox.Text = "Ignore Case";
			this.ignoreCaseCheckBox.UseVisualStyleBackColor = true;
			// 
			// regularExpressionCheckBox
			// 
			this.regularExpressionCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.regularExpressionCheckBox.AutoSize = true;
			this.regularExpressionCheckBox.Location = new System.Drawing.Point(13, 120);
			this.regularExpressionCheckBox.Name = "regularExpressionCheckBox";
			this.regularExpressionCheckBox.Size = new System.Drawing.Size(117, 17);
			this.regularExpressionCheckBox.TabIndex = 1;
			this.regularExpressionCheckBox.Text = "Regular Expression";
			this.regularExpressionCheckBox.UseVisualStyleBackColor = true;
			this.regularExpressionCheckBox.CheckedChanged += new System.EventHandler(this.RegularExpressionCheckBoxCheckedChanged);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchTextBox.Location = new System.Drawing.Point(13, 19);
			this.searchTextBox.Multiline = true;
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(789, 95);
			this.searchTextBox.TabIndex = 0;
			this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
			// 
			// replaceGroupBox
			// 
			this.replaceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.replaceGroupBox.Controls.Add(this.literalReplacementCheckBox);
			this.replaceGroupBox.Controls.Add(this.replaceTextBox);
			this.replaceGroupBox.Location = new System.Drawing.Point(0, 0);
			this.replaceGroupBox.Name = "replaceGroupBox";
			this.replaceGroupBox.Size = new System.Drawing.Size(818, 131);
			this.replaceGroupBox.TabIndex = 9;
			this.replaceGroupBox.TabStop = false;
			this.replaceGroupBox.Text = "Replace With";
			// 
			// literalReplacementCheckBox
			// 
			this.literalReplacementCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.literalReplacementCheckBox.AutoSize = true;
			this.literalReplacementCheckBox.Location = new System.Drawing.Point(13, 108);
			this.literalReplacementCheckBox.Name = "literalReplacementCheckBox";
			this.literalReplacementCheckBox.Size = new System.Drawing.Size(120, 17);
			this.literalReplacementCheckBox.TabIndex = 1;
			this.literalReplacementCheckBox.Text = "Literal Replacement";
			this.literalReplacementCheckBox.UseVisualStyleBackColor = true;
			// 
			// replaceTextBox
			// 
			this.replaceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.replaceTextBox.Location = new System.Drawing.Point(13, 19);
			this.replaceTextBox.Multiline = true;
			this.replaceTextBox.Name = "replaceTextBox";
			this.replaceTextBox.Size = new System.Drawing.Size(789, 83);
			this.replaceTextBox.TabIndex = 0;
			this.replaceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.replaceTextBox_KeyDown);
			// 
			// iconList
			// 
			this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
			this.iconList.TransparentColor = System.Drawing.Color.Transparent;
			this.iconList.Images.SetKeyName(0, "funnel.ico");
			this.iconList.Images.SetKeyName(1, "replace2.ico");
			this.iconList.Images.SetKeyName(2, "message.ico");
			// 
			// bottomTabControl
			// 
			this.bottomTabControl.Controls.Add(this.logTabPage);
			this.bottomTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottomTabControl.ImageList = this.iconList;
			this.bottomTabControl.Location = new System.Drawing.Point(0, 0);
			this.bottomTabControl.Name = "bottomTabControl";
			this.bottomTabControl.SelectedIndex = 0;
			this.bottomTabControl.Size = new System.Drawing.Size(835, 243);
			this.bottomTabControl.TabIndex = 0;
			// 
			// logTabPage
			// 
			this.logTabPage.Controls.Add(this.logTextBox);
			this.logTabPage.ImageIndex = 2;
			this.logTabPage.Location = new System.Drawing.Point(4, 31);
			this.logTabPage.Name = "logTabPage";
			this.logTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.logTabPage.Size = new System.Drawing.Size(827, 208);
			this.logTabPage.TabIndex = 0;
			this.logTabPage.Text = "Log";
			this.logTabPage.UseVisualStyleBackColor = true;
			// 
			// logTextBox
			// 
			this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logTextBox.HideSelection = false;
			this.logTextBox.Location = new System.Drawing.Point(3, 3);
			this.logTextBox.MaxLength = 65535;
			this.logTextBox.Multiline = true;
			this.logTextBox.Name = "logTextBox";
			this.logTextBox.ReadOnly = true;
			this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.logTextBox.Size = new System.Drawing.Size(821, 202);
			this.logTextBox.TabIndex = 0;
			this.logTextBox.WordWrap = false;
			this.logTextBox.DoubleClick += new System.EventHandler(this.LogTextBoxDoubleClick);
			// 
			// toolStripButtons
			// 
			this.toolStripButtons.ImageScalingSize = new System.Drawing.Size(48, 48);
			this.toolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFilesButton,
            this.viewMatchesButton,
            this.executeButton,
            this.stopButton,
            this.undoButton,
            this.deleteBackupsButton,
            this.clearLogButton,
            this.undoCountToolStripLabel});
			this.toolStripButtons.Location = new System.Drawing.Point(0, 0);
			this.toolStripButtons.Name = "toolStripButtons";
			this.toolStripButtons.Size = new System.Drawing.Size(859, 55);
			this.toolStripButtons.TabIndex = 2;
			this.toolStripButtons.Text = "toolStrip1";
			// 
			// viewFilesButton
			// 
			this.viewFilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.viewFilesButton.Image = ((System.Drawing.Image)(resources.GetObject("viewFilesButton.Image")));
			this.viewFilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.viewFilesButton.Name = "viewFilesButton";
			this.viewFilesButton.Size = new System.Drawing.Size(52, 52);
			this.viewFilesButton.ToolTipText = "Preview files that will be included in the Find/Replace.";
			this.viewFilesButton.Click += new System.EventHandler(this.ViewFilesButtonClick);
			// 
			// viewMatchesButton
			// 
			this.viewMatchesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.viewMatchesButton.Image = ((System.Drawing.Image)(resources.GetObject("viewMatchesButton.Image")));
			this.viewMatchesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.viewMatchesButton.Name = "viewMatchesButton";
			this.viewMatchesButton.Size = new System.Drawing.Size(52, 52);
			this.viewMatchesButton.ToolTipText = "Preview files that will be modified by the Find/Replace.";
			this.viewMatchesButton.Click += new System.EventHandler(this.ViewMatchesButtonClick);
			// 
			// executeButton
			// 
			this.executeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.executeButton.Image = ((System.Drawing.Image)(resources.GetObject("executeButton.Image")));
			this.executeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.executeButton.Name = "executeButton";
			this.executeButton.Size = new System.Drawing.Size(52, 52);
			this.executeButton.ToolTipText = "Peform the Find/Replace, creating backups for modified files.";
			this.executeButton.Click += new System.EventHandler(this.ExecuteButtonClick);
			// 
			// stopButton
			// 
			this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.stopButton.Enabled = false;
			this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
			this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(52, 52);
			this.stopButton.ToolTipText = "Stop the currently running task.";
			this.stopButton.Click += new System.EventHandler(this.StopButtonClick);
			// 
			// undoButton
			// 
			this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
			this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.undoButton.Name = "undoButton";
			this.undoButton.Size = new System.Drawing.Size(52, 52);
			this.undoButton.ToolTipText = "Restore all the backups, undoing all changes made.";
			this.undoButton.Click += new System.EventHandler(this.UndoButtonClick);
			// 
			// deleteBackupsButton
			// 
			this.deleteBackupsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteBackupsButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteBackupsButton.Image")));
			this.deleteBackupsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteBackupsButton.Name = "deleteBackupsButton";
			this.deleteBackupsButton.Size = new System.Drawing.Size(52, 52);
			this.deleteBackupsButton.ToolTipText = "Delete all the backup files.";
			this.deleteBackupsButton.Click += new System.EventHandler(this.DeleteBackupsButtonClick);
			// 
			// clearLogButton
			// 
			this.clearLogButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.clearLogButton.Image = ((System.Drawing.Image)(resources.GetObject("clearLogButton.Image")));
			this.clearLogButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.clearLogButton.Name = "clearLogButton";
			this.clearLogButton.Size = new System.Drawing.Size(52, 52);
			this.clearLogButton.Text = "deleteLog";
			this.clearLogButton.ToolTipText = "Clear the log screen.";
			this.clearLogButton.Click += new System.EventHandler(this.ClearLogButtonClick);
			// 
			// undoCountToolStripLabel
			// 
			this.undoCountToolStripLabel.Name = "undoCountToolStripLabel";
			this.undoCountToolStripLabel.Size = new System.Drawing.Size(13, 52);
			this.undoCountToolStripLabel.Text = "0";
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 641);
			this.Controls.Add(this.toolStripButtons);
			this.Controls.Add(this.secondarySplitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(549, 668);
			this.Name = "MainView";
			this.Text = "BeeZap";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.secondarySplitContainer.Panel1.ResumeLayout(false);
			this.secondarySplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.secondarySplitContainer)).EndInit();
			this.secondarySplitContainer.ResumeLayout(false);
			this.topTabControl.ResumeLayout(false);
			this.filterTabPage.ResumeLayout(false);
			this.pathGroupBox.ResumeLayout(false);
			this.pathGroupBox.PerformLayout();
			this.contentFilterGroupBox.ResumeLayout(false);
			this.contentFilterGroupBox.PerformLayout();
			this.filtersGroupBox.ResumeLayout(false);
			this.filtersGroupBox.PerformLayout();
			this.replaceTabPage.ResumeLayout(false);
			this.searchReplaceSplitContainer.Panel1.ResumeLayout(false);
			this.searchReplaceSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.searchReplaceSplitContainer)).EndInit();
			this.searchReplaceSplitContainer.ResumeLayout(false);
			this.searchGroupBox.ResumeLayout(false);
			this.searchGroupBox.PerformLayout();
			this.replaceGroupBox.ResumeLayout(false);
			this.replaceGroupBox.PerformLayout();
			this.bottomTabControl.ResumeLayout(false);
			this.logTabPage.ResumeLayout(false);
			this.logTabPage.PerformLayout();
			this.toolStripButtons.ResumeLayout(false);
			this.toolStripButtons.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer secondarySplitContainer;
		private System.Windows.Forms.TabControl topTabControl;
		private System.Windows.Forms.TabPage filterTabPage;
		private System.Windows.Forms.GroupBox pathGroupBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.TextBox pathTextBox;
		private System.Windows.Forms.Label pathLabel;
		private System.Windows.Forms.RadioButton subdirectoriesRadioButton;
		private System.Windows.Forms.RadioButton currentDirectoryRadioButton;
		private System.Windows.Forms.GroupBox contentFilterGroupBox;
		private System.Windows.Forms.Label contentIncludeExpressionLabel;
		private System.Windows.Forms.TextBox fileContentIncludeTextBox;
		private System.Windows.Forms.Label contentExcludeExpressionLabel;
		private System.Windows.Forms.TextBox fileContentExcludeTextBox;
		private System.Windows.Forms.GroupBox filtersGroupBox;
		private System.Windows.Forms.ComboBox fullNameExcludeTextBox;
		private System.Windows.Forms.TextBox fullNameIncludeTextBox;
		private System.Windows.Forms.Label filenameExcludeExpressionLabel;
		private System.Windows.Forms.Label filenameIncludeExpressionLabel;
		private System.Windows.Forms.TabPage replaceTabPage;
		private System.Windows.Forms.SplitContainer searchReplaceSplitContainer;
		private System.Windows.Forms.GroupBox searchGroupBox;
		private System.Windows.Forms.CheckBox explicitCaptureCheckBox;
		private System.Windows.Forms.CheckBox singlelineCheckBox;
		private System.Windows.Forms.CheckBox multilineCheckBox;
		private System.Windows.Forms.CheckBox ignoreCaseCheckBox;
		private System.Windows.Forms.CheckBox regularExpressionCheckBox;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.GroupBox replaceGroupBox;
		private System.Windows.Forms.CheckBox literalReplacementCheckBox;
		private System.Windows.Forms.TextBox replaceTextBox;
		private System.Windows.Forms.TextBox patternTextBox;
		private System.Windows.Forms.Label patternLabel;
		private System.Windows.Forms.ToolStrip toolStripButtons;
		private System.Windows.Forms.ToolStripButton viewFilesButton;
		private System.Windows.Forms.ToolStripButton viewMatchesButton;
		private System.Windows.Forms.ToolStripButton executeButton;
		private System.Windows.Forms.ToolStripButton undoButton;
		private System.Windows.Forms.ToolStripButton deleteBackupsButton;
		private System.Windows.Forms.ImageList iconList;
		private System.Windows.Forms.TabControl bottomTabControl;
		private System.Windows.Forms.TabPage logTabPage;
		private System.Windows.Forms.TextBox logTextBox;
		private System.Windows.Forms.ToolStripButton clearLogButton;
		private System.Windows.Forms.ToolStripButton stopButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox maxLineExcludeTextBox;
		private System.Windows.Forms.TextBox minLineExcludeTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox maxLineIncludeTextBox;
		private System.Windows.Forms.TextBox minLineIncludeTextBox;
		private System.Windows.Forms.ToolTip formToolTips;
		private System.Windows.Forms.ToolStripLabel undoCountToolStripLabel;
	}
}

