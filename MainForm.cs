using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MASM_SCAU.LogAnalysis;

namespace MASM_SCAU
{
    public partial class MainForm : Form
    {
        public static MainForm instance;//主线程的实体引用主要给主线程被其他线程委托所使用
        public ChromiumWebBrowser EditorBrowser;//主线程的编辑器
        public ChromiumWebBrowser infoBrowser;//信息窗口的展示
        ASMEditor asmETools = new ASMEditor();//ASM编辑器工具类


        ASMFileManager asmfM = new ASMFileManager();

        public MainForm()
        {
            instance = this;//需要把listview1等的Modify改成public
            InitializeComponent();
            this.MinimumSize = new Size(rHW('W', 1082), rHW('H', 818));
            leftInfoPanel.Width = rHW('W', 179);
            rightInfoPanel.Width = rHW('W', 281);
            splitter_left_middle.MinSize = rHW('W', 179);
            LogPanel.Height = rHW('H', 239);
            splitter_bottom_middle.MinSize = rHW('H', 239);
            splitter_right_middle.MinSize = rHW('W', 281);
            InitBrowser();
            UpdateFileOpenTreeView();//更新文件管理列表UI
            initCompilerWindow(compilerConfigListView);//初始化编译视窗
        }

        //###################    前端控制代码  ####################################
        int rHW(char H_W, int value)
        {
            if (H_W.Equals('H'))
            {
                return Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * value / 1080);
            }
            else
            {
                return Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * value / 1920);
            }
        }
        private void ToptoolsBtns_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Panel p = sender as Panel;
                p.BackColor = Color.FromArgb(224, 224, 224);
            }
            catch
            {
                Control p = sender as Control;
                p.Parent.BackColor = Color.FromArgb(224, 224, 224);
            }

        }
        private void ToptoolsBtns_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Panel p = sender as Panel;
                p.BackColor = Color.FromArgb(243, 243, 243);
            }
            catch
            {
                Control p = sender as Control;
                p.Parent.BackColor = Color.FromArgb(243, 243, 243);
            }
        }
        public void InitBrowser()//初始化所有的Cef控件
        {
            var setting = new CefSettings();
            setting.CefCommandLineArgs.Add("disable-gpu", "1");//禁用GPU渲染，解决部分设备渲染问题
            Cef.Initialize(setting);
            //Cef.Initialize(new CefSettings());
            //string urlPath = Environment.CurrentDirectory + "/canvas/index.html";
            //urlPath = urlPath.Replace("%20", " ");//指定本地路径

            EditorBrowser = new ChromiumWebBrowser();
            EditorBrowser.Dock = DockStyle.Fill;
            EditorBrowser.MenuHandler = new MenuHandler(); //去掉菜单

            //this.EditorBrowser.GotFocus+= new System.EventHandler(losehandler);

            wb_container.Controls.Add(EditorBrowser);
            EditorBrowser.BackColor = Color.White;

            infoBrowser = new ChromiumWebBrowser();
             infoBrowser.Anchor= configTB.Anchor;
            infoBrowser.Location = configTB.Location;
            infoBrowser.Size = configTB.Size;
            infoBrowser.MenuHandler = new MenuHandler();
            tabPage5.Controls.Add(infoBrowser);


        }

        public void getDocuments(string Dname)
        {
            infoBrowser.Load(Environment.CurrentDirectory + "/BOOK/"+Dname+".mhtml");
            infoBrowser.Visible = true;
            configTB.Visible = false;

        }

        public void TreeViewContextControl()//控制右键菜单的可用性
        {
            if (FilesTreeView.SelectedNode == null)
            {
                FilesTreeViewContextMenu.Enabled = false;
            }
            else
            {
                FilesTreeViewContextMenu.Enabled = true;
            }
        }
        public void UpdateFileOpenTreeView()//更新文件列表UI视图
        {
            FilesTreeView.Nodes.Clear();
            foreach (CodeFile cf in asmfM.Opened)
            {
                FilesTreeView.Nodes.Add(cf.FileName);
            }
            //asmETools.code = asmfM.EditingFile.CurrentContent;
            asmETools.setValue(asmfM.EditingFile.CurrentContent, MASM_SCAU.configs.AppMainSettings.Default.EditorTheme, EditorBrowser);
        }

        //自动调整ListView的列宽的方法
        void initCompilerWindow(ListView lt)
        {
            for (int i = 0; i < lt.Columns.Count; i++)
            {
                ws.Add(lt.Columns[i].Width);
            }
        }
        List<int> ws = new List<int>();
        private void compilerConfigListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.NewWidth < ws[e.ColumnIndex])
            {
                e.Cancel = true;
                e.NewWidth = ws[e.ColumnIndex];// 把新宽度恢复到之前的宽度
            }
        }

        public void CompilerLockUI(bool sta)//编译器对前端控件进行锁定，因为频繁启动编译器会有一定概率出现线程资源死锁BUG。我目前没找到解决办法
        {
            pictureBox7.Enabled = sta;
            panel7.Enabled = sta;
            label7.Enabled = sta;
            pictureBox8.Enabled = sta;
            label8.Enabled = sta;
            panel8.Enabled = sta;
            pictureBox9.Enabled = sta;
            label9.Enabled = sta;
            panel9.Enabled = sta;

        }

        public void checkUnsave()//检查没有保存的文件
        {
            for (int i = 0; i < asmfM.Opened.Count; i++)
            {
                asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
                asmETools.setValue(asmfM.SwitchASMFileEditing(i), MASM_SCAU.configs.AppMainSettings.Default.EditorTheme, EditorBrowser);//设置编辑器的内容
                asmfM.CloseASMFileOpened(i);//保存当前正在编辑的文件
                UpdateFileOpenTreeView();
            }
        }


        //###################       主线程代码      ###################################

        private void MainForm_Load(object sender, EventArgs e)
        {
            FixCompiler.checkNeedFix();//检查是否需要修复编译器
        }

        
        //###################  委托代码   ########################################
        //委托1：读取代码到主线程（委托类型：异步线程委托）
        public delegate void CallBack_getCodeFromEditor(string codeContent);
        public void FuncDetail_getCodeFromEditor(string codeContent)
        {
            try
            {
                this.Invoke(new ThreadStart(delegate
            {
                //函数实现在这，获得了代码之后干什么写在这里
                //MessageBox.Show(codeContent);
               
                    asmETools.code = codeContent;

            }
            ));
            }
            catch (Exception _e)//此处有BUG，微软的BUG，不关我事，有线程冲突会导致不能释放窗体对象，目前只能异常处理跳过一下
            {

            }
        }
        //委托2：读取到Textbox
        public delegate void Delegate_Open2Editor(string content);//委托针
        public void Open2Editor(string content)//被委托执行的函数
        {
            //asmfM.SwitchASMFileEditing(asmETools.code,)
            //asmETools.code = content;
            asmETools.setValue(content, MASM_SCAU.configs.AppMainSettings.Default.EditorTheme, EditorBrowser);
        }
        public void Invoke_Open2Editor(Delegate_Open2Editor Delegate_Open2Editor, string content)//委托器
        {
            if (this.InvokeRequired)
            {
                this.Invoke(Delegate_Open2Editor);
            }
            else
            {
                Open2Editor(content);
            }
        }
        //委托3：建立个日志更新委托
        public delegate void LogUpdate();//委托针
        public void LogUpdateWindow()//被委托执行的函数
        {
            compilerConfigListView.Items.Clear();
            List<Logitem> lines = LogAnalysis.getResult();
            //此处有BUG，多线程操作日志分析集合会出现死锁，当用户频繁点击运行按钮的时候会发生，解决办法未定
            Label_Errors.Text = LogAnalysis.getErrorSum().ToString();
            Label_warn.Text = LogAnalysis.getWarnSum().ToString();
            lock (lines)
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    Logitem ilog = lines[i];
                    ListViewItem newOne = compilerConfigListView.Items.Add(ilog.lineNumber);
                    newOne.SubItems.Add(ilog.type);
                    newOne.SubItems.Add(ilog.content);
                    newOne.SubItems.Add(ilog.code);
                }
            }

        }
        public void CBLogInvoke(LogUpdate LogDelegate)//委托器
        {
            if (this.InvokeRequired)
            {
                this.Invoke(LogDelegate);
            }
            else
            {
                LogUpdateWindow();
            }
        }

        //委托4：建立个编译完成委托
        public delegate void ConpilerFinished();//委托针
        public void StatusUnlock()//被委托执行的函数
        {
            //button1.Enabled = true;
            CompilerLockUI(true);
        }
        public void CBbtnStatusInvoke(ConpilerFinished ConpilerFinished)//委托器
        {
            if (this.InvokeRequired)
            {
                this.Invoke(ConpilerFinished);
            }
            else
            {
                StatusUnlock();
            }
        }





        //################ 时钟线程  ############################

        private void AppTimer_Tick(object sender, EventArgs e)//系统时钟线程（10ms）
        {
            asmETools._delegate_getValue_Component(EditorBrowser);//随时把代码的内容更新到主线程（每10ms更新一次）
            TreeViewContextControl();//保持UI的右键菜单正常
            Label_CurrentFile.Text = "正在编辑："+asmfM.EditingFile.FileName;
        }

        //#################  主线程关闭  ###########################
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                DialogResult result = MessageBox.Show("是否退出程序？", "警告：", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.Yes))//假如确认
                {
                checkUnsave();//检查没有保存的文件
                asmETools.DisposeHtmlCache();//清空缓存
                asmfM.SaveHistory();
            }
                else if (result.Equals(DialogResult.No))//不确认
                {
                e.Cancel = true;
                }

        }
        //##################   顶部菜单事件   #########################
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            asmfM.NewASMFile();
            UpdateFileOpenTreeView();
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            string srccode = asmfM.SwitchASMFileEditing(asmfM.Opened.Count - 1);
            asmETools.setValue(srccode, MASM_SCAU.configs.AppMainSettings.Default.EditorTheme, EditorBrowser);
        }
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            asmfM.OpenASMFile();//ASM文件管理器打开文件
            UpdateFileOpenTreeView();//更新打开的文件
        }
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            asmfM.SaveASMFile(asmfM.GetEditingID());//保存当前正在编辑的文件
            UpdateFileOpenTreeView();
        }
        private void 另存为当前代码AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            asmfM.SaveASASMFile(asmfM.GetEditingID());//另存为当前正在编辑的文件 
            UpdateFileOpenTreeView();
        }
        private void 关闭当前代码文件CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            asmfM.CloseASMFileOpened(asmfM.GetEditingID());//保存当前正在编辑的文件
            UpdateFileOpenTreeView();
        }
        private void 关闭当前所有的代码文件LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkUnsave();//检查没有保存的文件
        }

        //#################  文件列表的右键菜单事件和双击事件   ####################################
        private void FilesTreeView_DoubleClick(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            if (FilesTreeView.SelectedNode != null)
              asmETools.setValue(asmfM.SwitchASMFileEditing(FilesTreeView.SelectedNode.Index), MASM_SCAU.configs.AppMainSettings.Default.EditorTheme, EditorBrowser);
        }
        private void 关闭toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            if (FilesTreeView.SelectedNode != null)
            {
                asmfM.CloseASMFileOpened(FilesTreeView.SelectedNode.Index);//关闭选中文件
                UpdateFileOpenTreeView();
            }
        }
        private void 保存ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            if (FilesTreeView.SelectedNode != null)
            {
                asmfM.SaveASMFile(FilesTreeView.SelectedNode.Index);//保存选中的文件
                UpdateFileOpenTreeView();
            }
        }
        private void 另存为ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            if (FilesTreeView.SelectedNode != null)
            {
                asmfM.SaveASASMFile(FilesTreeView.SelectedNode.Index);//另存为选中文件
                UpdateFileOpenTreeView();
            }
        }
        private void 切换到编辑器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            if (FilesTreeView.SelectedNode != null)
                //asmETools.code = asmfM.SwitchASMFileEditing(FilesTreeView.SelectedNode.Index);
                asmETools.setValue(asmfM.SwitchASMFileEditing(FilesTreeView.SelectedNode.Index), MASM_SCAU.configs.AppMainSettings.Default.EditorTheme, EditorBrowser);
        }
        private void 在文件管理器中打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            if (FilesTreeView.SelectedNode != null)
            {
                string path = asmfM.Opened[FilesTreeView.SelectedNode.Index].SourcePath;
                if (File.Exists(path))
                {
                    ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
                    psi.Arguments = "/e,/select," + path;
                    Process.Start(psi);
                }
                else
                {
                    asmfM.SaveASASMFile(FilesTreeView.SelectedNode.Index);//另存为选中文件
                    UpdateFileOpenTreeView();
                }
            }
        }
        private void 查找顶部菜单(object sender,EventArgs e)
        {
            asmETools.API("actions.find", EditorBrowser);
        }
        private void 复制顶部菜单(object sender,EventArgs e)
        {
            asmETools.API("editor.action.clipboardCopyAction", EditorBrowser);
        }
        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        public const int KEYEVENTF_KEYUP = 2;
        private void 粘贴顶部菜单(object sender,EventArgs e)
        {
            keybd_event(Keys.ControlKey, 0, 0, 0);
            keybd_event(Keys.V, 0, 0, 0);
            keybd_event(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);
        }
        private void 打开编辑命令面板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keybd_event(Keys.F1, 0, 0, 0);

        }
        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("actions.find", EditorBrowser);
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keybd_event(Keys.ControlKey, 0, 0, 0);
            keybd_event(Keys.Z, 0, 0, 0);
            keybd_event(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);
        }

        private void 重做ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keybd_event(Keys.ControlKey, 0, 0, 0);
            keybd_event(Keys.Y, 0, 0, 0);
            keybd_event(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);
        }

        private void 删除行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.deleteLines", EditorBrowser);
        }

        private void 下移行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.moveLinesDownAction", EditorBrowser);
        }

        private void 折叠区域ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.fold", EditorBrowser);
        }

        private void 展开区域ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.unfold", EditorBrowser);
        }

        private void 折叠所有代码块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.foldAll", EditorBrowser);
        }

        private void 展开所有代码块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.unfoldAll", EditorBrowser);
        }

        private void 向上移动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.moveLinesUpAction", EditorBrowser);
        }

        private void 在上方插入行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.moveLinesUpAction", EditorBrowser);
        }

        private void 在下方插入行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.insertLineAfter", EditorBrowser);
        }

        private void 向下复制行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.copyLinesDownAction", EditorBrowser);
        }

        private void 选择当前行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            keybd_event(Keys.Shift, 0, 0, 0);
            keybd_event(Keys.Alt, 0, 0, 0);
            keybd_event(Keys.Right, 0, 0, 0);*///无效操作,还没写完，先不管了
        }

        private void 添加代码行注释ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.addCommentLine", EditorBrowser);
        }

        private void 转到代码文件头ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keybd_event(Keys.PageUp, 0, 0, 0);
        }

        private void 转到代码文件尾ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keybd_event(Keys.PageDown, 0, 0, 0);
        }

        private void 转到行首ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keybd_event(Keys.Home, 0, 0, 0);
        }

        private void 转到行尾ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keybd_event(Keys.End, 0, 0, 0);
        }

        private void 到上一个查找匹配项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.moveSelectionToNextFindMatch", EditorBrowser);
        }

        private void 到下一个查早匹配项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.addSelectionToNextFindMatch", EditorBrowser);
        }

        private void 选择当前选择的所有匹配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmETools.API("editor.action.selectHighlights", EditorBrowser);
        }
        //########################   编译和调试线程    #########################
        private void RunEvent(object sender,EventArgs e)
        {
            compilerConfigListView.Items.Clear();
            CompilerLockUI(false);//防止编译器多次启动
            ASMCompiler.Run(asmETools.code,isDebug:false);//把当前编辑器的代码传入编译器进行编译,以非Debug模式启动
        }

        private void DebugEvent(object sender,EventArgs e)
        {
            CompilerLockUI(false);
            ASMCompiler.Run(asmETools.code, isDebug:true);//把当前编辑器的代码传入编译器进行编译,以Debug模式启动
        }

        private void LSTEvent(object sender,EventArgs e)
        {
            infoBrowser.Visible = false;
            configTB.Visible = true;
            configTB.Text=ASMCompiler.GetLST();
        }

        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start(Environment.CurrentDirectory+"/Update.exe");
            System.Diagnostics.Process.Start("http://jintupersonal.com/ASMCOOL/");
        }

        private void 编译ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompilerLockUI(false);//防止编译器多次启动
            ASMCompiler.Run(asmETools.code, isDebug: false);//把当前编辑器的代码传入编译器进行编译,以非Debug模式启动
        }

        private void 查看编译LST文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoBrowser.Visible = false;
            configTB.Visible = true;
            configTB.Text = ASMCompiler.GetLST();
        }

        private void debug当前代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CompilerLockUI(false);
            ASMCompiler.Run(asmETools.code, isDebug: true);//把当前编辑器的代码传入编译器进行编译,以Debug模式启动
        }

        private void DocumentView_DoubleClick(object sender, EventArgs e)
        {
            if (DocumentView.SelectedNode != null)
            {
                try
                {
                    getDocuments(DocumentView.SelectedNode.Text);
                }
                catch (Exception _e)
                {

                }
            }
        }

        private void 展开隐藏工具盒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelToolBox.Visible = !panelToolBox.Visible;
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keybd_event(Keys.ControlKey, 0, 0, 0);
            keybd_event(Keys.A, 0, 0, 0);
            keybd_event(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);
        }
        private void 炸天的代码比对功能BetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherForms.DiffForm df = new OtherForms.DiffForm();
            df.Show();
        }

        private void 关于我ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcomeForm wf = new welcomeForm();
            wf.Show();
        }

        private void 汇编在线文档库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.csdn.net/rizero/category_9774552.html");
        }

        private void 我的博客ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://jintuzheng.blog.csdn.net/");
        }

        private void 联系我ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherForms.contactForm cf = new OtherForms.contactForm();
            cf.Show();
        }

        private void Editor_Click(object sender, EventArgs e)
        {

        }

        private void TopPanel_Click(object sender, EventArgs e)
        {
            if (MASM_SCAU.configs.AppMainSettings.Default.FirstOpen)
            {
                welcomeForm wf = new welcomeForm();
                wf.Show();
                MASM_SCAU.configs.AppMainSettings.Default.FirstOpen = false;
                MASM_SCAU.configs.AppMainSettings.Default.Save();
            }

        }

      /*此处用于解决CefSharp的屏蔽鼠标无响应BUG补丁*/

        private Point LocationOnClient(Control c)
        {
            Point retval = new Point(0, 0);
            do
            {
                retval.Offset(c.Location);
                c = c.Parent;
            }
            while (c != null);
            return retval;
        }
        private void UItimer_ToolMenuStrip_Tick(object sender, EventArgs e)
        {

            Point ep = LocationOnClient(EditorBrowser);   
            if (Cursor.Position.X > (ep.X + 100) && Cursor.Position.Y > (ep.Y + 100)){
                CursorP.Top = this.PointToClient(Control.MousePosition).Y - 3;
                CursorP.Left = this.PointToClient(Control.MousePosition).X - 3;
                CursorP.Visible = isMenuOpened;
            }
        }
        bool isMenuOpened = false;
        private void menuStripTop_MenuDeactivate(object sender, EventArgs e)
        {
            //Console.WriteLine("Leave");
            isMenuOpened = false;
            //Console.WriteLine();
        }

        private void menuStripTop_MenuActivate(object sender, EventArgs e)
        {
            //Console.WriteLine("Start");
            isMenuOpened = true;
        }

        private void FilesTreeViewContextMenu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            isMenuOpened = false;
        }

        private void FilesTreeViewContextMenu_Opened(object sender, EventArgs e)
        {
            isMenuOpened = true;
        }

        private void 打开最近文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmfM.TmpSaveASMFileOpened(asmETools.code);//把编辑器内容缓存到后台
            asmfM.LoadHistory();
            UpdateFileOpenTreeView();
        }

        private void 清空最近文件MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asmfM.ClearHistory();
        }

        private void 编译出现问题修复编译器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FixCompiler.GoFix();
        }


        int Bugslines = 0;
        private void logTimerViewFixBugs_Tick(object sender, EventArgs e)
        {

            //修复编译日志重复检测的问题
            if(Bugslines != compilerConfigListView.Items.Count)
            {
                //Console.WriteLine("Here");
                List<ListViewItem> temp = new List<ListViewItem>();
                for (int i = 0; i < compilerConfigListView.Items.Count; i++)
                {
                    bool isSame = false;
                    for (int j = 0; j < temp.Count; j++)
                    {
                        if (temp[j].SubItems[0].Text.Equals(compilerConfigListView.Items[i].SubItems[0].Text))
                        {
                            isSame = true;
                            break;
                        }
                    }
                    if (isSame == false)
                    {
                        temp.Add(compilerConfigListView.Items[i]);
                    }
                }
                HashSet<ListViewItem> hs = new HashSet<ListViewItem>(temp);
                temp = new List<ListViewItem>(hs);
                compilerConfigListView.Items.Clear();
                for (int j = 0; j < temp.Count; j++)
                {
                    compilerConfigListView.Items.Add(temp[j]);
                }
                Bugslines = compilerConfigListView.Items.Count;
            }
                
                
        }


        /*快捷编辑和的拖动功能
        Point pt;
        bool Pdrag = false;
        private void panelToolBox_MouseMove(object sender, MouseEventArgs e)
        {

            Point od = panelToolBox.Location;
            if (e.Button == MouseButtons.Left)
            {
                int px = Cursor.Position.X - pt.X;
                int py = Cursor.Position.Y - pt.Y;
                panelToolBox.Location = new Point(panelToolBox.Location.X + px, panelToolBox.Location.Y + py);
                pt = Cursor.Position;
            }
            if (Pdrag)
                panelToolBox.Cursor = Cursors.SizeAll;
            else
                panelToolBox.Cursor = Cursors.Default;
        }

        private void panelToolBox_MouseDown(object sender, MouseEventArgs e)
        {
            pt = Cursor.Position;
            Pdrag = true;
        }

        private void panelToolBox_MouseUp(object sender, MouseEventArgs e)
        {
            Pdrag = false;
        }
        */

    }
}
