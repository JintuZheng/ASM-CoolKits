namespace MASM_SCAU
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ASCII表");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("DOS软中断");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("DOS功能表");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("DOS表", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("数据传送指令");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("算术指令");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("逻辑指令");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("串操作指令");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("程序转移指令");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("处理器控制指令");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("指令字典", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为当前代码AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭当前代码文件CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭当前所有的代码文件LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开最近文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空最近文件MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.折叠区域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.展开区域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.折叠所有代码块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.展开所有代码块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.向上移动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在上方插入行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在下方插入行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.向下复制行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择当前行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加代码行注释ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到代码文件头ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到代码文件尾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到行首ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到行尾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.到上一个查找匹配项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.到下一个查早匹配项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择当前选择的所有匹配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开编辑命令面板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.炸天的代码比对功能BetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.展开隐藏工具盒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编译ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看编译LST文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debug当前代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编译出现问题修复编译器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运行RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汇编在线文档库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的博客ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系我ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_newFile = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.splitter_right_middle = new System.Windows.Forms.Splitter();
            this.wb_container = new System.Windows.Forms.Panel();
            this.splitter_left_middle = new System.Windows.Forms.Splitter();
            this.panel12 = new System.Windows.Forms.Panel();
            this.leftInfoPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.FilesTreeView = new System.Windows.Forms.TreeView();
            this.FilesTreeViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.切换到编辑器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在文件管理器中打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DocumentView = new System.Windows.Forms.TreeView();
            this.dociconList = new System.Windows.Forms.ImageList(this.components);
            this.rightInfoPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.configTB = new System.Windows.Forms.TextBox();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.compilerConfigListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label_warn = new System.Windows.Forms.Label();
            this.Label_Errors = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.splitter_bottom_middle = new System.Windows.Forms.Splitter();
            this.AppTimer = new System.Windows.Forms.Timer(this.components);
            this.Label_CurrentFile = new System.Windows.Forms.Label();
            this.UItimer_ToolMenuStrip = new System.Windows.Forms.Timer(this.components);
            this.CursorP = new System.Windows.Forms.Panel();
            this.logTimerViewFixBugs = new System.Windows.Forms.Timer(this.components);
            this.menuStripTop.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panelToolBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.btn_newFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.leftInfoPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.FilesTreeViewContextMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.rightInfoPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.LogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.Color.LightGray;
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.选项ToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.运行RToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripTop.Size = new System.Drawing.Size(1064, 30);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            this.menuStripTop.MenuActivate += new System.EventHandler(this.menuStripTop_MenuActivate);
            this.menuStripTop.MenuDeactivate += new System.EventHandler(this.menuStripTop_MenuDeactivate);
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.保存SToolStripMenuItem,
            this.另存为当前代码AToolStripMenuItem,
            this.关闭当前代码文件CToolStripMenuItem,
            this.关闭当前所有的代码文件LToolStripMenuItem,
            this.打开最近文件ToolStripMenuItem,
            this.清空最近文件MToolStripMenuItem});
            this.文件FToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.文件FToolStripMenuItem.Text = "文件(F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.新建NToolStripMenuItem.Text = "新建(N)";
            this.新建NToolStripMenuItem.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.打开OToolStripMenuItem.Text = "打开(O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.保存SToolStripMenuItem.Text = "保存(S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // 另存为当前代码AToolStripMenuItem
            // 
            this.另存为当前代码AToolStripMenuItem.Name = "另存为当前代码AToolStripMenuItem";
            this.另存为当前代码AToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.另存为当前代码AToolStripMenuItem.Text = "另存为当前代码(A)";
            this.另存为当前代码AToolStripMenuItem.Click += new System.EventHandler(this.另存为当前代码AToolStripMenuItem_Click);
            // 
            // 关闭当前代码文件CToolStripMenuItem
            // 
            this.关闭当前代码文件CToolStripMenuItem.Name = "关闭当前代码文件CToolStripMenuItem";
            this.关闭当前代码文件CToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.关闭当前代码文件CToolStripMenuItem.Text = "关闭当前代码文件(C)";
            this.关闭当前代码文件CToolStripMenuItem.Click += new System.EventHandler(this.关闭当前代码文件CToolStripMenuItem_Click);
            // 
            // 关闭当前所有的代码文件LToolStripMenuItem
            // 
            this.关闭当前所有的代码文件LToolStripMenuItem.Name = "关闭当前所有的代码文件LToolStripMenuItem";
            this.关闭当前所有的代码文件LToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.关闭当前所有的代码文件LToolStripMenuItem.Text = "关闭当前所有的代码文件(L)";
            this.关闭当前所有的代码文件LToolStripMenuItem.Click += new System.EventHandler(this.关闭当前所有的代码文件LToolStripMenuItem_Click);
            // 
            // 打开最近文件ToolStripMenuItem
            // 
            this.打开最近文件ToolStripMenuItem.Name = "打开最近文件ToolStripMenuItem";
            this.打开最近文件ToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.打开最近文件ToolStripMenuItem.Text = "打开最近文件(R)";
            this.打开最近文件ToolStripMenuItem.Click += new System.EventHandler(this.打开最近文件ToolStripMenuItem_Click);
            // 
            // 清空最近文件MToolStripMenuItem
            // 
            this.清空最近文件MToolStripMenuItem.Name = "清空最近文件MToolStripMenuItem";
            this.清空最近文件MToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.清空最近文件MToolStripMenuItem.Text = "清空最近文件(M)";
            this.清空最近文件MToolStripMenuItem.Click += new System.EventHandler(this.清空最近文件MToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查找ToolStripMenuItem,
            this.全选ToolStripMenuItem,
            this.撤销ToolStripMenuItem,
            this.重做ToolStripMenuItem,
            this.删除行ToolStripMenuItem,
            this.下移行ToolStripMenuItem,
            this.折叠区域ToolStripMenuItem,
            this.展开区域ToolStripMenuItem,
            this.折叠所有代码块ToolStripMenuItem,
            this.展开所有代码块ToolStripMenuItem,
            this.向上移动ToolStripMenuItem,
            this.在上方插入行ToolStripMenuItem,
            this.在下方插入行ToolStripMenuItem,
            this.向下复制行ToolStripMenuItem,
            this.选择当前行ToolStripMenuItem,
            this.添加代码行注释ToolStripMenuItem,
            this.转到代码文件头ToolStripMenuItem,
            this.转到代码文件尾ToolStripMenuItem,
            this.转到行首ToolStripMenuItem,
            this.转到行尾ToolStripMenuItem,
            this.到上一个查找匹配项ToolStripMenuItem,
            this.到下一个查早匹配项ToolStripMenuItem,
            this.选择当前选择的所有匹配ToolStripMenuItem,
            this.打开编辑命令面板ToolStripMenuItem});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.编辑EToolStripMenuItem.Text = "编辑(E)";
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.查找ToolStripMenuItem.Text = "查找/替换";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 重做ToolStripMenuItem
            // 
            this.重做ToolStripMenuItem.Name = "重做ToolStripMenuItem";
            this.重做ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.重做ToolStripMenuItem.Text = "重做";
            this.重做ToolStripMenuItem.Click += new System.EventHandler(this.重做ToolStripMenuItem_Click);
            // 
            // 删除行ToolStripMenuItem
            // 
            this.删除行ToolStripMenuItem.Name = "删除行ToolStripMenuItem";
            this.删除行ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.删除行ToolStripMenuItem.Text = "删除行";
            this.删除行ToolStripMenuItem.Click += new System.EventHandler(this.删除行ToolStripMenuItem_Click);
            // 
            // 下移行ToolStripMenuItem
            // 
            this.下移行ToolStripMenuItem.Name = "下移行ToolStripMenuItem";
            this.下移行ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.下移行ToolStripMenuItem.Text = "下移行";
            this.下移行ToolStripMenuItem.Click += new System.EventHandler(this.下移行ToolStripMenuItem_Click);
            // 
            // 折叠区域ToolStripMenuItem
            // 
            this.折叠区域ToolStripMenuItem.Name = "折叠区域ToolStripMenuItem";
            this.折叠区域ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.折叠区域ToolStripMenuItem.Text = "折叠区域";
            this.折叠区域ToolStripMenuItem.Click += new System.EventHandler(this.折叠区域ToolStripMenuItem_Click);
            // 
            // 展开区域ToolStripMenuItem
            // 
            this.展开区域ToolStripMenuItem.Name = "展开区域ToolStripMenuItem";
            this.展开区域ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.展开区域ToolStripMenuItem.Text = "展开区域";
            this.展开区域ToolStripMenuItem.Click += new System.EventHandler(this.展开区域ToolStripMenuItem_Click);
            // 
            // 折叠所有代码块ToolStripMenuItem
            // 
            this.折叠所有代码块ToolStripMenuItem.Name = "折叠所有代码块ToolStripMenuItem";
            this.折叠所有代码块ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.折叠所有代码块ToolStripMenuItem.Text = "折叠所有代码块";
            this.折叠所有代码块ToolStripMenuItem.Click += new System.EventHandler(this.折叠所有代码块ToolStripMenuItem_Click);
            // 
            // 展开所有代码块ToolStripMenuItem
            // 
            this.展开所有代码块ToolStripMenuItem.Name = "展开所有代码块ToolStripMenuItem";
            this.展开所有代码块ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.展开所有代码块ToolStripMenuItem.Text = "展开所有代码块";
            this.展开所有代码块ToolStripMenuItem.Click += new System.EventHandler(this.展开所有代码块ToolStripMenuItem_Click);
            // 
            // 向上移动ToolStripMenuItem
            // 
            this.向上移动ToolStripMenuItem.Name = "向上移动ToolStripMenuItem";
            this.向上移动ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.向上移动ToolStripMenuItem.Text = "向上移动";
            this.向上移动ToolStripMenuItem.Click += new System.EventHandler(this.向上移动ToolStripMenuItem_Click);
            // 
            // 在上方插入行ToolStripMenuItem
            // 
            this.在上方插入行ToolStripMenuItem.Name = "在上方插入行ToolStripMenuItem";
            this.在上方插入行ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.在上方插入行ToolStripMenuItem.Text = "在上方插入行";
            this.在上方插入行ToolStripMenuItem.Click += new System.EventHandler(this.在上方插入行ToolStripMenuItem_Click);
            // 
            // 在下方插入行ToolStripMenuItem
            // 
            this.在下方插入行ToolStripMenuItem.Name = "在下方插入行ToolStripMenuItem";
            this.在下方插入行ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.在下方插入行ToolStripMenuItem.Text = "在下方插入行";
            this.在下方插入行ToolStripMenuItem.Click += new System.EventHandler(this.在下方插入行ToolStripMenuItem_Click);
            // 
            // 向下复制行ToolStripMenuItem
            // 
            this.向下复制行ToolStripMenuItem.Name = "向下复制行ToolStripMenuItem";
            this.向下复制行ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.向下复制行ToolStripMenuItem.Text = "向下复制行";
            this.向下复制行ToolStripMenuItem.Click += new System.EventHandler(this.向下复制行ToolStripMenuItem_Click);
            // 
            // 选择当前行ToolStripMenuItem
            // 
            this.选择当前行ToolStripMenuItem.Name = "选择当前行ToolStripMenuItem";
            this.选择当前行ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.选择当前行ToolStripMenuItem.Text = "选择当前行";
            this.选择当前行ToolStripMenuItem.Click += new System.EventHandler(this.选择当前行ToolStripMenuItem_Click);
            // 
            // 添加代码行注释ToolStripMenuItem
            // 
            this.添加代码行注释ToolStripMenuItem.Name = "添加代码行注释ToolStripMenuItem";
            this.添加代码行注释ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.添加代码行注释ToolStripMenuItem.Text = "添加代码行注释";
            this.添加代码行注释ToolStripMenuItem.Click += new System.EventHandler(this.添加代码行注释ToolStripMenuItem_Click);
            // 
            // 转到代码文件头ToolStripMenuItem
            // 
            this.转到代码文件头ToolStripMenuItem.Name = "转到代码文件头ToolStripMenuItem";
            this.转到代码文件头ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.转到代码文件头ToolStripMenuItem.Text = "转到代码文件头";
            this.转到代码文件头ToolStripMenuItem.Click += new System.EventHandler(this.转到代码文件头ToolStripMenuItem_Click);
            // 
            // 转到代码文件尾ToolStripMenuItem
            // 
            this.转到代码文件尾ToolStripMenuItem.Name = "转到代码文件尾ToolStripMenuItem";
            this.转到代码文件尾ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.转到代码文件尾ToolStripMenuItem.Text = "转到代码文件尾";
            this.转到代码文件尾ToolStripMenuItem.Click += new System.EventHandler(this.转到代码文件尾ToolStripMenuItem_Click);
            // 
            // 转到行首ToolStripMenuItem
            // 
            this.转到行首ToolStripMenuItem.Name = "转到行首ToolStripMenuItem";
            this.转到行首ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.转到行首ToolStripMenuItem.Text = "转到行首";
            this.转到行首ToolStripMenuItem.Click += new System.EventHandler(this.转到行首ToolStripMenuItem_Click);
            // 
            // 转到行尾ToolStripMenuItem
            // 
            this.转到行尾ToolStripMenuItem.Name = "转到行尾ToolStripMenuItem";
            this.转到行尾ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.转到行尾ToolStripMenuItem.Text = "转到行尾";
            this.转到行尾ToolStripMenuItem.Click += new System.EventHandler(this.转到行尾ToolStripMenuItem_Click);
            // 
            // 到上一个查找匹配项ToolStripMenuItem
            // 
            this.到上一个查找匹配项ToolStripMenuItem.Name = "到上一个查找匹配项ToolStripMenuItem";
            this.到上一个查找匹配项ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.到上一个查找匹配项ToolStripMenuItem.Text = "到上一个查找匹配项";
            this.到上一个查找匹配项ToolStripMenuItem.Click += new System.EventHandler(this.到上一个查找匹配项ToolStripMenuItem_Click);
            // 
            // 到下一个查早匹配项ToolStripMenuItem
            // 
            this.到下一个查早匹配项ToolStripMenuItem.Name = "到下一个查早匹配项ToolStripMenuItem";
            this.到下一个查早匹配项ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.到下一个查早匹配项ToolStripMenuItem.Text = "到下一个查早匹配项";
            this.到下一个查早匹配项ToolStripMenuItem.Click += new System.EventHandler(this.到下一个查早匹配项ToolStripMenuItem_Click);
            // 
            // 选择当前选择的所有匹配ToolStripMenuItem
            // 
            this.选择当前选择的所有匹配ToolStripMenuItem.Name = "选择当前选择的所有匹配ToolStripMenuItem";
            this.选择当前选择的所有匹配ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.选择当前选择的所有匹配ToolStripMenuItem.Text = "选择当前选择的所有匹配";
            this.选择当前选择的所有匹配ToolStripMenuItem.Click += new System.EventHandler(this.选择当前选择的所有匹配ToolStripMenuItem_Click);
            // 
            // 打开编辑命令面板ToolStripMenuItem
            // 
            this.打开编辑命令面板ToolStripMenuItem.Name = "打开编辑命令面板ToolStripMenuItem";
            this.打开编辑命令面板ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.打开编辑命令面板ToolStripMenuItem.Text = "打开编辑命令面板";
            this.打开编辑命令面板ToolStripMenuItem.Click += new System.EventHandler(this.打开编辑命令面板ToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.炸天的代码比对功能BetaToolStripMenuItem});
            this.工具TToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.工具TToolStripMenuItem.Text = "增强功能(P)";
            // 
            // 炸天的代码比对功能BetaToolStripMenuItem
            // 
            this.炸天的代码比对功能BetaToolStripMenuItem.Name = "炸天的代码比对功能BetaToolStripMenuItem";
            this.炸天的代码比对功能BetaToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.炸天的代码比对功能BetaToolStripMenuItem.Text = "炸天的代码比对功能（Beta）";
            this.炸天的代码比对功能BetaToolStripMenuItem.Click += new System.EventHandler(this.炸天的代码比对功能BetaToolStripMenuItem_Click);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.展开隐藏工具盒ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.选项ToolStripMenuItem.Text = "选项(O)";
            // 
            // 展开隐藏工具盒ToolStripMenuItem
            // 
            this.展开隐藏工具盒ToolStripMenuItem.Name = "展开隐藏工具盒ToolStripMenuItem";
            this.展开隐藏工具盒ToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.展开隐藏工具盒ToolStripMenuItem.Text = "展开/隐藏快捷编辑盒";
            this.展开隐藏工具盒ToolStripMenuItem.Click += new System.EventHandler(this.展开隐藏工具盒ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编译ToolStripMenuItem,
            this.查看编译LST文件ToolStripMenuItem,
            this.debug当前代码ToolStripMenuItem,
            this.编译出现问题修复编译器ToolStripMenuItem});
            this.帮助HToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.帮助HToolStripMenuItem.Text = "编译器(C)";
            // 
            // 编译ToolStripMenuItem
            // 
            this.编译ToolStripMenuItem.Name = "编译ToolStripMenuItem";
            this.编译ToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.编译ToolStripMenuItem.Text = "编译";
            this.编译ToolStripMenuItem.Click += new System.EventHandler(this.编译ToolStripMenuItem_Click);
            // 
            // 查看编译LST文件ToolStripMenuItem
            // 
            this.查看编译LST文件ToolStripMenuItem.Name = "查看编译LST文件ToolStripMenuItem";
            this.查看编译LST文件ToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.查看编译LST文件ToolStripMenuItem.Text = "查看编译LST文件";
            this.查看编译LST文件ToolStripMenuItem.Click += new System.EventHandler(this.查看编译LST文件ToolStripMenuItem_Click);
            // 
            // debug当前代码ToolStripMenuItem
            // 
            this.debug当前代码ToolStripMenuItem.Name = "debug当前代码ToolStripMenuItem";
            this.debug当前代码ToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.debug当前代码ToolStripMenuItem.Text = "Debug当前代码";
            this.debug当前代码ToolStripMenuItem.Click += new System.EventHandler(this.debug当前代码ToolStripMenuItem_Click);
            // 
            // 编译出现问题修复编译器ToolStripMenuItem
            // 
            this.编译出现问题修复编译器ToolStripMenuItem.Name = "编译出现问题修复编译器ToolStripMenuItem";
            this.编译出现问题修复编译器ToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.编译出现问题修复编译器ToolStripMenuItem.Text = "编译出现问题？此处修复编译器";
            this.编译出现问题修复编译器ToolStripMenuItem.Click += new System.EventHandler(this.编译出现问题修复编译器ToolStripMenuItem_Click);
            // 
            // 运行RToolStripMenuItem
            // 
            this.运行RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检查更新ToolStripMenuItem,
            this.关于我ToolStripMenuItem,
            this.汇编在线文档库ToolStripMenuItem,
            this.我的博客ToolStripMenuItem,
            this.联系我ToolStripMenuItem});
            this.运行RToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.运行RToolStripMenuItem.Name = "运行RToolStripMenuItem";
            this.运行RToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.运行RToolStripMenuItem.Text = "帮助(H)";
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.检查更新ToolStripMenuItem.Text = "官网更新";
            this.检查更新ToolStripMenuItem.Click += new System.EventHandler(this.检查更新ToolStripMenuItem_Click);
            // 
            // 关于我ToolStripMenuItem
            // 
            this.关于我ToolStripMenuItem.Name = "关于我ToolStripMenuItem";
            this.关于我ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.关于我ToolStripMenuItem.Text = "开屏页展示";
            this.关于我ToolStripMenuItem.Click += new System.EventHandler(this.关于我ToolStripMenuItem_Click);
            // 
            // 汇编在线文档库ToolStripMenuItem
            // 
            this.汇编在线文档库ToolStripMenuItem.Name = "汇编在线文档库ToolStripMenuItem";
            this.汇编在线文档库ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.汇编在线文档库ToolStripMenuItem.Text = "汇编在线文档库";
            this.汇编在线文档库ToolStripMenuItem.Click += new System.EventHandler(this.汇编在线文档库ToolStripMenuItem_Click);
            // 
            // 我的博客ToolStripMenuItem
            // 
            this.我的博客ToolStripMenuItem.Name = "我的博客ToolStripMenuItem";
            this.我的博客ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.我的博客ToolStripMenuItem.Text = "我的博客";
            this.我的博客ToolStripMenuItem.Click += new System.EventHandler(this.我的博客ToolStripMenuItem_Click);
            // 
            // 联系我ToolStripMenuItem
            // 
            this.联系我ToolStripMenuItem.Name = "联系我ToolStripMenuItem";
            this.联系我ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.联系我ToolStripMenuItem.Text = "联系我";
            this.联系我ToolStripMenuItem.Click += new System.EventHandler(this.联系我ToolStripMenuItem_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TopPanel.Controls.Add(this.panel9);
            this.TopPanel.Controls.Add(this.panelToolBox);
            this.TopPanel.Controls.Add(this.panel6);
            this.TopPanel.Controls.Add(this.panel8);
            this.TopPanel.Controls.Add(this.panel7);
            this.TopPanel.Controls.Add(this.panel5);
            this.TopPanel.Controls.Add(this.panel4);
            this.TopPanel.Controls.Add(this.panel3);
            this.TopPanel.Controls.Add(this.panel2);
            this.TopPanel.Controls.Add(this.btn_newFile);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 30);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1064, 74);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.Click += new System.EventHandler(this.TopPanel_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel9.Controls.Add(this.pictureBox9);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Location = new System.Drawing.Point(709, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(57, 68);
            this.panel9.TabIndex = 6;
            this.panel9.Click += new System.EventHandler(this.DebugEvent);
            this.panel9.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.panel9.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(15, 6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(28, 36);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.DebugEvent);
            this.pictureBox9.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.pictureBox9.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(3, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "DEBUG";
            this.label9.Click += new System.EventHandler(this.DebugEvent);
            this.label9.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.label9.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // panelToolBox
            // 
            this.panelToolBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelToolBox.Controls.Add(this.label13);
            this.panelToolBox.Controls.Add(this.toolStrip1);
            this.panelToolBox.Location = new System.Drawing.Point(780, 6);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(374, 65);
            this.panelToolBox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "快捷编辑盒";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(374, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "复制";
            this.toolStripButton1.Click += new System.EventHandler(this.复制顶部菜单);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "粘贴";
            this.toolStripButton2.Click += new System.EventHandler(this.粘贴顶部菜单);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "保存";
            this.toolStripButton3.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "撤销";
            this.toolStripButton4.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "重做";
            this.toolStripButton5.Click += new System.EventHandler(this.重做ToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "删除行";
            this.toolStripButton6.Click += new System.EventHandler(this.删除行ToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton7.Text = "新增行";
            this.toolStripButton7.Click += new System.EventHandler(this.在下方插入行ToolStripMenuItem_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton8.Text = "展开所有";
            this.toolStripButton8.Click += new System.EventHandler(this.展开所有代码块ToolStripMenuItem_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton9.Text = "折叠所有";
            this.toolStripButton9.Click += new System.EventHandler(this.折叠所有代码块ToolStripMenuItem_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton10.Text = "查找";
            this.toolStripButton10.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton11.Text = "转到行首";
            this.toolStripButton11.Click += new System.EventHandler(this.转到行首ToolStripMenuItem_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton12.Text = "转到行尾";
            this.toolStripButton12.Click += new System.EventHandler(this.转到行尾ToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 24);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(448, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 68);
            this.panel6.TabIndex = 5;
            this.panel6.Click += new System.EventHandler(this.查找顶部菜单);
            this.panel6.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.查找顶部菜单);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(13, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "查找";
            this.label6.Click += new System.EventHandler(this.查找顶部菜单);
            this.label6.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.Controls.Add(this.pictureBox8);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(622, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(57, 68);
            this.panel8.TabIndex = 5;
            this.panel8.Click += new System.EventHandler(this.LSTEvent);
            this.panel8.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(15, 6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.LSTEvent);
            this.pictureBox8.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.pictureBox8.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(14, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "列表";
            this.label8.Click += new System.EventHandler(this.LSTEvent);
            this.label8.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(535, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(57, 68);
            this.panel7.TabIndex = 5;
            this.panel7.Click += new System.EventHandler(this.RunEvent);
            this.panel7.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(15, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.RunEvent);
            this.pictureBox7.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "运行";
            this.label7.Click += new System.EventHandler(this.RunEvent);
            this.label7.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(361, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(57, 68);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.粘贴顶部菜单);
            this.panel5.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.粘贴顶部菜单);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(15, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "粘贴";
            this.label5.Click += new System.EventHandler(this.粘贴顶部菜单);
            this.label5.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(274, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(57, 68);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.复制顶部菜单);
            this.panel4.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.复制顶部菜单);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "复制";
            this.label4.Click += new System.EventHandler(this.复制顶部菜单);
            this.label4.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(187, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 68);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            this.panel3.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "保存";
            this.label3.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            this.label3.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(100, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 68);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "打开";
            this.label2.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            this.label2.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // btn_newFile
            // 
            this.btn_newFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_newFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_newFile.Controls.Add(this.pictureBox1);
            this.btn_newFile.Controls.Add(this.label1);
            this.btn_newFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_newFile.Location = new System.Drawing.Point(13, 4);
            this.btn_newFile.Name = "btn_newFile";
            this.btn_newFile.Size = new System.Drawing.Size(57, 68);
            this.btn_newFile.TabIndex = 2;
            this.btn_newFile.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            this.btn_newFile.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.btn_newFile.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "新建";
            this.label1.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            this.label1.MouseEnter += new System.EventHandler(this.ToptoolsBtns_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.ToptoolsBtns_MouseLeave);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.splitter_right_middle);
            this.panel10.Controls.Add(this.wb_container);
            this.panel10.Controls.Add(this.splitter_left_middle);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.rightInfoPanel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 104);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1064, 667);
            this.panel10.TabIndex = 2;
            // 
            // splitter_right_middle
            // 
            this.splitter_right_middle.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_right_middle.Location = new System.Drawing.Point(780, 0);
            this.splitter_right_middle.Name = "splitter_right_middle";
            this.splitter_right_middle.Size = new System.Drawing.Size(3, 667);
            this.splitter_right_middle.TabIndex = 5;
            this.splitter_right_middle.TabStop = false;
            // 
            // wb_container
            // 
            this.wb_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_container.Location = new System.Drawing.Point(182, 0);
            this.wb_container.Name = "wb_container";
            this.wb_container.Size = new System.Drawing.Size(601, 667);
            this.wb_container.TabIndex = 3;
            // 
            // splitter_left_middle
            // 
            this.splitter_left_middle.BackColor = System.Drawing.Color.LightGray;
            this.splitter_left_middle.Location = new System.Drawing.Point(179, 0);
            this.splitter_left_middle.MinExtra = 100;
            this.splitter_left_middle.MinSize = 0;
            this.splitter_left_middle.Name = "splitter_left_middle";
            this.splitter_left_middle.Size = new System.Drawing.Size(3, 667);
            this.splitter_left_middle.TabIndex = 2;
            this.splitter_left_middle.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.leftInfoPanel);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(179, 667);
            this.panel12.TabIndex = 0;
            // 
            // leftInfoPanel
            // 
            this.leftInfoPanel.Controls.Add(this.tabPage1);
            this.leftInfoPanel.Controls.Add(this.tabPage2);
            this.leftInfoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.leftInfoPanel.Name = "leftInfoPanel";
            this.leftInfoPanel.SelectedIndex = 0;
            this.leftInfoPanel.Size = new System.Drawing.Size(179, 667);
            this.leftInfoPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.FilesTreeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(171, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "打开的文件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(3, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 24);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "加载最近文件";
            this.linkLabel1.Click += new System.EventHandler(this.打开最近文件ToolStripMenuItem_Click);
            // 
            // FilesTreeView
            // 
            this.FilesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesTreeView.BackColor = System.Drawing.Color.White;
            this.FilesTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesTreeView.ContextMenuStrip = this.FilesTreeViewContextMenu;
            this.FilesTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.FilesTreeView.FullRowSelect = true;
            this.FilesTreeView.ImageIndex = 0;
            this.FilesTreeView.ImageList = this.iconList;
            this.FilesTreeView.Location = new System.Drawing.Point(3, 30);
            this.FilesTreeView.Name = "FilesTreeView";
            this.FilesTreeView.SelectedImageIndex = 0;
            this.FilesTreeView.ShowLines = false;
            this.FilesTreeView.Size = new System.Drawing.Size(165, 406);
            this.FilesTreeView.TabIndex = 1;
            this.FilesTreeView.DoubleClick += new System.EventHandler(this.FilesTreeView_DoubleClick);
            // 
            // FilesTreeViewContextMenu
            // 
            this.FilesTreeViewContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FilesTreeViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭toolStripMenuItem1,
            this.保存ToolStripMenuItem1,
            this.另存为ToolStripMenuItem1,
            this.切换到编辑器ToolStripMenuItem,
            this.在文件管理器中打开ToolStripMenuItem});
            this.FilesTreeViewContextMenu.Name = "contextMenuStrip1";
            this.FilesTreeViewContextMenu.Size = new System.Drawing.Size(199, 124);
            this.FilesTreeViewContextMenu.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.FilesTreeViewContextMenu_Closed);
            this.FilesTreeViewContextMenu.Opened += new System.EventHandler(this.FilesTreeViewContextMenu_Opened);
            // 
            // 关闭toolStripMenuItem1
            // 
            this.关闭toolStripMenuItem1.Name = "关闭toolStripMenuItem1";
            this.关闭toolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.关闭toolStripMenuItem1.Text = "关闭选中文件";
            this.关闭toolStripMenuItem1.Click += new System.EventHandler(this.关闭toolStripMenuItem1_Click);
            // 
            // 保存ToolStripMenuItem1
            // 
            this.保存ToolStripMenuItem1.Name = "保存ToolStripMenuItem1";
            this.保存ToolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.保存ToolStripMenuItem1.Text = "保存选中文件";
            this.保存ToolStripMenuItem1.Click += new System.EventHandler(this.保存ToolStripMenuItem1_Click);
            // 
            // 另存为ToolStripMenuItem1
            // 
            this.另存为ToolStripMenuItem1.Name = "另存为ToolStripMenuItem1";
            this.另存为ToolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.另存为ToolStripMenuItem1.Text = "另存为选中文件";
            this.另存为ToolStripMenuItem1.Click += new System.EventHandler(this.另存为ToolStripMenuItem1_Click);
            // 
            // 切换到编辑器ToolStripMenuItem
            // 
            this.切换到编辑器ToolStripMenuItem.Name = "切换到编辑器ToolStripMenuItem";
            this.切换到编辑器ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.切换到编辑器ToolStripMenuItem.Text = "切换到编辑器";
            this.切换到编辑器ToolStripMenuItem.Click += new System.EventHandler(this.切换到编辑器ToolStripMenuItem_Click);
            // 
            // 在文件管理器中打开ToolStripMenuItem
            // 
            this.在文件管理器中打开ToolStripMenuItem.Name = "在文件管理器中打开ToolStripMenuItem";
            this.在文件管理器中打开ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.在文件管理器中打开ToolStripMenuItem.Text = "打开文件所在位置";
            this.在文件管理器中打开ToolStripMenuItem.Click += new System.EventHandler(this.在文件管理器中打开ToolStripMenuItem_Click);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "未标题-1.png");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DocumentView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(171, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "资料库";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DocumentView
            // 
            this.DocumentView.BackColor = System.Drawing.Color.White;
            this.DocumentView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocumentView.ContextMenuStrip = this.FilesTreeViewContextMenu;
            this.DocumentView.Cursor = System.Windows.Forms.Cursors.Default;
            this.DocumentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentView.ImageIndex = 0;
            this.DocumentView.ImageList = this.dociconList;
            this.DocumentView.Location = new System.Drawing.Point(3, 3);
            this.DocumentView.Name = "DocumentView";
            treeNode12.ImageKey = "glitchr.png";
            treeNode12.Name = "节点0";
            treeNode12.SelectedImageKey = "glitchr.png";
            treeNode12.Text = "ASCII表";
            treeNode13.Name = "节点9";
            treeNode13.Text = "DOS软中断";
            treeNode14.Name = "节点10";
            treeNode14.Text = "DOS功能表";
            treeNode15.Name = "节点0";
            treeNode15.Text = "DOS表";
            treeNode16.Name = "节点2";
            treeNode16.Text = "数据传送指令";
            treeNode17.Name = "节点3";
            treeNode17.Text = "算术指令";
            treeNode18.Name = "节点4";
            treeNode18.Text = "逻辑指令";
            treeNode19.Name = "节点6";
            treeNode19.Text = "串操作指令";
            treeNode20.Name = "节点7";
            treeNode20.Text = "程序转移指令";
            treeNode21.Name = "节点8";
            treeNode21.Text = "处理器控制指令";
            treeNode22.Name = "节点1";
            treeNode22.Text = "指令字典";
            this.DocumentView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode15,
            treeNode22});
            this.DocumentView.SelectedImageIndex = 0;
            this.DocumentView.ShowLines = false;
            this.DocumentView.Size = new System.Drawing.Size(165, 628);
            this.DocumentView.TabIndex = 2;
            this.DocumentView.DoubleClick += new System.EventHandler(this.DocumentView_DoubleClick);
            // 
            // dociconList
            // 
            this.dociconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dociconList.ImageStream")));
            this.dociconList.TransparentColor = System.Drawing.Color.Transparent;
            this.dociconList.Images.SetKeyName(0, "glitchr.png");
            // 
            // rightInfoPanel
            // 
            this.rightInfoPanel.BackColor = System.Drawing.Color.White;
            this.rightInfoPanel.Controls.Add(this.tabControl1);
            this.rightInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightInfoPanel.Location = new System.Drawing.Point(783, 0);
            this.rightInfoPanel.Name = "rightInfoPanel";
            this.rightInfoPanel.Size = new System.Drawing.Size(281, 667);
            this.rightInfoPanel.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(281, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.configTB);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(273, 634);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "信息面板";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // configTB
            // 
            this.configTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configTB.BackColor = System.Drawing.Color.White;
            this.configTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configTB.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.configTB.Location = new System.Drawing.Point(3, 0);
            this.configTB.Multiline = true;
            this.configTB.Name = "configTB";
            this.configTB.ReadOnly = true;
            this.configTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.configTB.Size = new System.Drawing.Size(267, 433);
            this.configTB.TabIndex = 0;
            // 
            // LogPanel
            // 
            this.LogPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogPanel.Controls.Add(this.compilerConfigListView);
            this.LogPanel.Controls.Add(this.Label_warn);
            this.LogPanel.Controls.Add(this.Label_Errors);
            this.LogPanel.Controls.Add(this.pictureBox11);
            this.LogPanel.Controls.Add(this.pictureBox10);
            this.LogPanel.Controls.Add(this.label12);
            this.LogPanel.Controls.Add(this.label11);
            this.LogPanel.Controls.Add(this.label10);
            this.LogPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogPanel.Location = new System.Drawing.Point(0, 572);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(1064, 199);
            this.LogPanel.TabIndex = 3;
            // 
            // compilerConfigListView
            // 
            this.compilerConfigListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.compilerConfigListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compilerConfigListView.BackColor = System.Drawing.Color.White;
            this.compilerConfigListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compilerConfigListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.compilerConfigListView.FullRowSelect = true;
            this.compilerConfigListView.GridLines = true;
            this.compilerConfigListView.HideSelection = false;
            this.compilerConfigListView.Location = new System.Drawing.Point(0, 44);
            this.compilerConfigListView.Name = "compilerConfigListView";
            this.compilerConfigListView.Size = new System.Drawing.Size(1064, 155);
            this.compilerConfigListView.TabIndex = 9;
            this.compilerConfigListView.UseCompatibleStateImageBehavior = false;
            this.compilerConfigListView.View = System.Windows.Forms.View.Details;
            this.compilerConfigListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.compilerConfigListView_ColumnWidthChanging);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "行号";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "类型";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "源信息";
            this.columnHeader3.Width = 324;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "错误编号";
            this.columnHeader4.Width = 145;
            // 
            // Label_warn
            // 
            this.Label_warn.AutoSize = true;
            this.Label_warn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_warn.Location = new System.Drawing.Point(368, 15);
            this.Label_warn.Name = "Label_warn";
            this.Label_warn.Size = new System.Drawing.Size(18, 20);
            this.Label_warn.TabIndex = 8;
            this.Label_warn.Text = "0";
            // 
            // Label_Errors
            // 
            this.Label_Errors.AutoSize = true;
            this.Label_Errors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_Errors.Location = new System.Drawing.Point(241, 15);
            this.Label_Errors.Name = "Label_Errors";
            this.Label_Errors.Size = new System.Drawing.Size(18, 20);
            this.Label_Errors.TabIndex = 7;
            this.Label_Errors.Text = "0";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(301, 15);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(21, 20);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 6;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(173, 15);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(21, 20);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(323, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "警告：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(196, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "错误：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(12, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "编译日志";
            // 
            // splitter_bottom_middle
            // 
            this.splitter_bottom_middle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter_bottom_middle.Location = new System.Drawing.Point(0, 569);
            this.splitter_bottom_middle.Name = "splitter_bottom_middle";
            this.splitter_bottom_middle.Size = new System.Drawing.Size(1064, 3);
            this.splitter_bottom_middle.TabIndex = 4;
            this.splitter_bottom_middle.TabStop = false;
            // 
            // AppTimer
            // 
            this.AppTimer.Enabled = true;
            this.AppTimer.Interval = 10;
            this.AppTimer.Tick += new System.EventHandler(this.AppTimer_Tick);
            // 
            // Label_CurrentFile
            // 
            this.Label_CurrentFile.AutoSize = true;
            this.Label_CurrentFile.BackColor = System.Drawing.Color.LightGray;
            this.Label_CurrentFile.Location = new System.Drawing.Point(636, 6);
            this.Label_CurrentFile.Name = "Label_CurrentFile";
            this.Label_CurrentFile.Size = new System.Drawing.Size(212, 20);
            this.Label_CurrentFile.TabIndex = 7;
            this.Label_CurrentFile.Text = "正在编辑：新建ASM文件.asm";
            // 
            // UItimer_ToolMenuStrip
            // 
            this.UItimer_ToolMenuStrip.Enabled = true;
            this.UItimer_ToolMenuStrip.Interval = 10;
            this.UItimer_ToolMenuStrip.Tick += new System.EventHandler(this.UItimer_ToolMenuStrip_Tick);
            // 
            // CursorP
            // 
            this.CursorP.BackColor = System.Drawing.Color.White;
            this.CursorP.Location = new System.Drawing.Point(836, 18);
            this.CursorP.Name = "CursorP";
            this.CursorP.Size = new System.Drawing.Size(5, 5);
            this.CursorP.TabIndex = 8;
            // 
            // logTimerViewFixBugs
            // 
            this.logTimerViewFixBugs.Enabled = true;
            this.logTimerViewFixBugs.Tick += new System.EventHandler(this.logTimerViewFixBugs_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 771);
            this.Controls.Add(this.CursorP);
            this.Controls.Add(this.Label_CurrentFile);
            this.Controls.Add(this.splitter_bottom_middle);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.menuStripTop);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTop;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "ASM CoolKits 专业版 华南农大 Jintu Zheng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.btn_newFile.ResumeLayout(false);
            this.btn_newFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.leftInfoPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.FilesTreeViewContextMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.rightInfoPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行RToolStripMenuItem;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel btn_newFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Splitter splitter_bottom_middle;
        private System.Windows.Forms.Splitter splitter_left_middle;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Label_warn;
        private System.Windows.Forms.Label Label_Errors;
        private System.Windows.Forms.TabControl leftInfoPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel wb_container;
        private System.Windows.Forms.Splitter splitter_right_middle;
        private System.Windows.Forms.Panel rightInfoPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Timer AppTimer;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ContextMenuStrip FilesTreeViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem 关闭toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 切换到编辑器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在文件管理器中打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为当前代码AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭当前代码文件CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭当前所有的代码文件LToolStripMenuItem;
        private System.Windows.Forms.Label Label_CurrentFile;
        public System.Windows.Forms.ListView compilerConfigListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox configTB;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView FilesTreeView;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重做ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 折叠区域ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 展开区域ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 折叠所有代码块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 展开所有代码块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向上移动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在上方插入行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在下方插入行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向下复制行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择当前行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加代码行注释ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到代码文件头ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到代码文件尾ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到行首ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到行尾ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 到上一个查找匹配项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 到下一个查早匹配项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择当前选择的所有匹配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开编辑命令面板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 炸天的代码比对功能BetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编译ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看编译LST文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debug当前代码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 汇编在线文档库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的博客ToolStripMenuItem;
        private System.Windows.Forms.TreeView DocumentView;
        private System.Windows.Forms.ImageList dociconList;
        private System.Windows.Forms.ToolStripMenuItem 联系我ToolStripMenuItem;
        private System.Windows.Forms.Timer UItimer_ToolMenuStrip;
        private System.Windows.Forms.Panel CursorP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 展开隐藏工具盒ToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开最近文件ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem 清空最近文件MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编译出现问题修复编译器ToolStripMenuItem;
        private System.Windows.Forms.Timer logTimerViewFixBugs;
    }
}

