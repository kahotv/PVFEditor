
namespace PVFEditor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFilePatch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExportPatchFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuEditImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditPSkill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPSY = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPEqu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAboutMain = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReadScript = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tvAll = new System.Windows.Forms.TreeView();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.tvSearch = new System.Windows.Forms.TreeView();
            this.tpEditing = new System.Windows.Forms.TabPage();
            this.tvEditing = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbScript = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panelxxx = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pg = new System.Windows.Forms.PropertyGrid();
            this.panel_search = new System.Windows.Forms.Panel();
            this.cbSearchPath = new System.Windows.Forms.CheckBox();
            this.tbSearchTxt = new System.Windows.Forms.TextBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel_control = new System.Windows.Forms.Panel();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnReadSource = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnExportScript = new System.Windows.Forms.Button();
            this.cmsTreeViewEditing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuFileItem.SuspendLayout();
            this.menuEditItem.SuspendLayout();
            this.menuAboutItem.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.tpEditing.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScript)).BeginInit();
            this.panelxxx.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.cmsTreeViewEditing.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 29);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuTool,
            this.menuHelp,
            this.menuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDown = this.menuFileItem;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(44, 21);
            this.menuFile.Text = "文件";
            // 
            // menuFileItem
            // 
            this.menuFileItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileClose,
            this.toolStripSeparator1,
            this.menuFilePatch,
            this.menuFileExportPatchFile});
            this.menuFileItem.Name = "menuFileOpen";
            this.menuFileItem.OwnerItem = this.menuFile;
            this.menuFileItem.Size = new System.Drawing.Size(149, 98);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(148, 22);
            this.menuFileOpen.Text = "打开";
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(148, 22);
            this.menuFileClose.Text = "关闭";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuFilePatch
            // 
            this.menuFilePatch.Name = "menuFilePatch";
            this.menuFilePatch.Size = new System.Drawing.Size(148, 22);
            this.menuFilePatch.Text = "打补丁";
            // 
            // menuFileExportPatchFile
            // 
            this.menuFileExportPatchFile.Name = "menuFileExportPatchFile";
            this.menuFileExportPatchFile.Size = new System.Drawing.Size(148, 22);
            this.menuFileExportPatchFile.Text = "导出补丁文件";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDown = this.menuEditItem;
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(44, 21);
            this.menuEdit.Text = "编辑";
            // 
            // menuEditItem
            // 
            this.menuEditItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditImport,
            this.toolStripSeparator2,
            this.menuEditPSkill,
            this.menuEditPSY,
            this.menuEditPEqu});
            this.menuEditItem.Name = "menuEditItem";
            this.menuEditItem.OwnerItem = this.menuEdit;
            this.menuEditItem.Size = new System.Drawing.Size(149, 98);
            // 
            // menuEditImport
            // 
            this.menuEditImport.Name = "menuEditImport";
            this.menuEditImport.Size = new System.Drawing.Size(148, 22);
            this.menuEditImport.Text = "合并目录";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // menuEditPSkill
            // 
            this.menuEditPSkill.Name = "menuEditPSkill";
            this.menuEditPSkill.Size = new System.Drawing.Size(148, 22);
            this.menuEditPSkill.Text = "增强所有技能";
            // 
            // menuEditPSY
            // 
            this.menuEditPSY.Name = "menuEditPSY";
            this.menuEditPSY.Size = new System.Drawing.Size(148, 22);
            this.menuEditPSY.Text = "增强圣耀武器";
            // 
            // menuEditPEqu
            // 
            this.menuEditPEqu.Name = "menuEditPEqu";
            this.menuEditPEqu.Size = new System.Drawing.Size(148, 22);
            this.menuEditPEqu.Text = "处理所有装备";
            // 
            // menuTool
            // 
            this.menuTool.Name = "menuTool";
            this.menuTool.Size = new System.Drawing.Size(44, 21);
            this.menuTool.Text = "工具";
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 21);
            this.menuHelp.Text = "帮助";
            // 
            // menuAbout
            // 
            this.menuAbout.DropDown = this.menuAboutItem;
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(44, 21);
            this.menuAbout.Text = "关于";
            // 
            // menuAboutItem
            // 
            this.menuAboutItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAboutMain});
            this.menuAboutItem.Name = "contextMenuStrip1";
            this.menuAboutItem.OwnerItem = this.menuAbout;
            this.menuAboutItem.Size = new System.Drawing.Size(137, 26);
            // 
            // menuAboutMain
            // 
            this.menuAboutMain.Name = "menuAboutMain";
            this.menuAboutMain.Size = new System.Drawing.Size(136, 22);
            this.menuAboutMain.Text = "土豆炖牛肉";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbFilePath);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 33);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReadScript);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(837, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 33);
            this.panel3.TabIndex = 1;
            // 
            // btnReadScript
            // 
            this.btnReadScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadScript.Enabled = false;
            this.btnReadScript.Location = new System.Drawing.Point(0, 0);
            this.btnReadScript.Name = "btnReadScript";
            this.btnReadScript.Size = new System.Drawing.Size(251, 33);
            this.btnReadScript.TabIndex = 0;
            this.btnReadScript.Text = "读取/展开";
            this.btnReadScript.UseVisualStyleBackColor = true;
            this.btnReadScript.Click += new System.EventHandler(this.btnReadScript_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFilePath.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFilePath.Location = new System.Drawing.Point(0, 0);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(1088, 33);
            this.tbFilePath.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 62);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panelxxx);
            this.splitContainer1.Size = new System.Drawing.Size(1088, 654);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpSearch);
            this.tabControl1.Controls.Add(this.tpEditing);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(279, 654);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvAll);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(271, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "全部";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tvAll
            // 
            this.tvAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvAll.Indent = 10;
            this.tvAll.Location = new System.Drawing.Point(3, 3);
            this.tvAll.Name = "tvAll";
            this.tvAll.Size = new System.Drawing.Size(265, 618);
            this.tvAll.TabIndex = 0;
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.tvSearch);
            this.tpSearch.Location = new System.Drawing.Point(4, 26);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(271, 624);
            this.tpSearch.TabIndex = 1;
            this.tpSearch.Tag = "搜索";
            this.tpSearch.Text = "搜索";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // tvSearch
            // 
            this.tvSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSearch.Location = new System.Drawing.Point(3, 3);
            this.tvSearch.Name = "tvSearch";
            this.tvSearch.Size = new System.Drawing.Size(265, 618);
            this.tvSearch.TabIndex = 1;
            // 
            // tpEditing
            // 
            this.tpEditing.Controls.Add(this.tvEditing);
            this.tpEditing.Location = new System.Drawing.Point(4, 26);
            this.tpEditing.Name = "tpEditing";
            this.tpEditing.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditing.Size = new System.Drawing.Size(271, 624);
            this.tpEditing.TabIndex = 2;
            this.tpEditing.Tag = "改动";
            this.tpEditing.Text = "改动";
            this.tpEditing.UseVisualStyleBackColor = true;
            // 
            // tvEditing
            // 
            this.tvEditing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvEditing.Location = new System.Drawing.Point(3, 3);
            this.tvEditing.Name = "tvEditing";
            this.tvEditing.Size = new System.Drawing.Size(265, 618);
            this.tvEditing.TabIndex = 2;
            this.tvEditing.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvEditing_NodeMouseClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbScript);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(554, 654);
            this.panel4.TabIndex = 1;
            // 
            // tbScript
            // 
            this.tbScript.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbScript.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.tbScript.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.tbScript.BackBrush = null;
            this.tbScript.CharHeight = 14;
            this.tbScript.CharUnicodeWidth = 16;
            this.tbScript.CharWidth = 8;
            this.tbScript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbScript.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbScript.IsReplaceMode = false;
            this.tbScript.Location = new System.Drawing.Point(0, 0);
            this.tbScript.Name = "tbScript";
            this.tbScript.Paddings = new System.Windows.Forms.Padding(0);
            this.tbScript.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbScript.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbScript.ServiceColors")));
            this.tbScript.Size = new System.Drawing.Size(554, 654);
            this.tbScript.TabIndex = 0;
            this.tbScript.Zoom = 100;
            // 
            // panelxxx
            // 
            this.panelxxx.Controls.Add(this.panel5);
            this.panelxxx.Controls.Add(this.panel_search);
            this.panelxxx.Controls.Add(this.panel_control);
            this.panelxxx.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelxxx.Location = new System.Drawing.Point(554, 0);
            this.panelxxx.Name = "panelxxx";
            this.panelxxx.Size = new System.Drawing.Size(251, 654);
            this.panelxxx.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 246);
            this.panel5.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态";
            // 
            // pg
            // 
            this.pg.CommandsVisibleIfAvailable = false;
            this.pg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg.HelpVisible = false;
            this.pg.Location = new System.Drawing.Point(3, 19);
            this.pg.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pg.Name = "pg";
            this.pg.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.pg.Size = new System.Drawing.Size(245, 224);
            this.pg.TabIndex = 0;
            // 
            // panel_search
            // 
            this.panel_search.Controls.Add(this.cbSearchPath);
            this.panel_search.Controls.Add(this.tbSearchTxt);
            this.panel_search.Controls.Add(this.cbSearchType);
            this.panel_search.Controls.Add(this.label3);
            this.panel_search.Controls.Add(this.label2);
            this.panel_search.Controls.Add(this.btnSearch);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_search.Location = new System.Drawing.Point(0, 246);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(251, 264);
            this.panel_search.TabIndex = 31;
            // 
            // cbSearchPath
            // 
            this.cbSearchPath.AutoSize = true;
            this.cbSearchPath.Location = new System.Drawing.Point(153, 115);
            this.cbSearchPath.Name = "cbSearchPath";
            this.cbSearchPath.Size = new System.Drawing.Size(75, 21);
            this.cbSearchPath.TabIndex = 33;
            this.cbSearchPath.Text = "搜索路径";
            this.cbSearchPath.UseVisualStyleBackColor = true;
            // 
            // tbSearchTxt
            // 
            this.tbSearchTxt.Location = new System.Drawing.Point(27, 37);
            this.tbSearchTxt.Name = "tbSearchTxt";
            this.tbSearchTxt.Size = new System.Drawing.Size(201, 23);
            this.tbSearchTxt.TabIndex = 32;
            this.tbSearchTxt.Text = "哥布林|牛头怪";
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Location = new System.Drawing.Point(26, 113);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(116, 25);
            this.cbSearchType.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "搜索类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "搜索内容";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(26, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 81);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.btnSaveEdit);
            this.panel_control.Controls.Add(this.btnReadSource);
            this.panel_control.Controls.Add(this.btnCancelEdit);
            this.panel_control.Controls.Add(this.btnExportScript);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_control.Location = new System.Drawing.Point(0, 510);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(251, 144);
            this.panel_control.TabIndex = 30;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(27, 82);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 55);
            this.btnSaveEdit.TabIndex = 0;
            this.btnSaveEdit.Text = "保存修改";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnReadSource
            // 
            this.btnReadSource.Location = new System.Drawing.Point(153, 10);
            this.btnReadSource.Name = "btnReadSource";
            this.btnReadSource.Size = new System.Drawing.Size(75, 55);
            this.btnReadSource.TabIndex = 3;
            this.btnReadSource.Text = "读取原文";
            this.btnReadSource.UseVisualStyleBackColor = true;
            this.btnReadSource.Click += new System.EventHandler(this.btnReadSource_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(26, 10);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 55);
            this.btnCancelEdit.TabIndex = 1;
            this.btnCancelEdit.Text = "重新读取";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnExportScript
            // 
            this.btnExportScript.Location = new System.Drawing.Point(153, 82);
            this.btnExportScript.Name = "btnExportScript";
            this.btnExportScript.Size = new System.Drawing.Size(75, 55);
            this.btnExportScript.TabIndex = 2;
            this.btnExportScript.Text = "导出文件";
            this.btnExportScript.UseVisualStyleBackColor = true;
            this.btnExportScript.Click += new System.EventHandler(this.btnExportScript_Click);
            // 
            // cmsTreeViewEditing
            // 
            this.cmsTreeViewEditing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditDelete});
            this.cmsTreeViewEditing.Name = "cmsTreeViewEditing";
            this.cmsTreeViewEditing.Size = new System.Drawing.Size(125, 26);
            // 
            // menuEditDelete
            // 
            this.menuEditDelete.Name = "menuEditDelete";
            this.menuEditDelete.Size = new System.Drawing.Size(124, 22);
            this.menuEditDelete.Text = "删除修改";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 716);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "土豆顿牛肉";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuFileItem.ResumeLayout(false);
            this.menuEditItem.ResumeLayout(false);
            this.menuAboutItem.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.tpEditing.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbScript)).EndInit();
            this.panelxxx.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.panel_control.ResumeLayout(false);
            this.cmsTreeViewEditing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuTool;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ContextMenuStrip menuFileItem;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuFilePatch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReadScript;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView tvAll;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TreeView tvSearch;
        private System.Windows.Forms.TabPage tpEditing;
        private System.Windows.Forms.TreeView tvEditing;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip cmsTreeViewEditing;
        private System.Windows.Forms.ToolStripMenuItem menuEditDelete;
        private System.Windows.Forms.Panel panelxxx;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnReadSource;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnExportScript;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.CheckBox cbSearchPath;
        private System.Windows.Forms.TextBox tbSearchTxt;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PropertyGrid pg;
        private System.Windows.Forms.ContextMenuStrip menuEditItem;
        private FastColoredTextBoxNS.FastColoredTextBox tbScript;
        private System.Windows.Forms.ToolStripMenuItem menuEditPSkill;
        private System.Windows.Forms.ToolStripMenuItem menuEditPSY;
        private System.Windows.Forms.ContextMenuStrip menuAboutItem;
        private System.Windows.Forms.ToolStripMenuItem menuAboutMain;
        private System.Windows.Forms.ToolStripMenuItem menuEditImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuEditPEqu;
        private System.Windows.Forms.ToolStripMenuItem menuFileExportPatchFile;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
    }
}