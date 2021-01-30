using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASM_SCAU.OtherForms
{
    public partial class DiffForm : Y.Skin.YoForm.Shadow.ShadowForm
    {
        public DiffForm()
        {
            InitializeComponent();
            InitBrowser();
        }

        public ChromiumWebBrowser EditorBrowser;//主进程的编辑器

        public void InitBrowser()//初始化所有的Cef控件
        {
            string urlPath = Environment.CurrentDirectory + @"\diff.html";
            urlPath = urlPath.Replace("%20", " ");//指定本地路径
            EditorBrowser = new ChromiumWebBrowser(urlPath);
            EditorBrowser.Dock = DockStyle.Fill;
            EditorBrowser.MenuHandler = new MenuHandler(); //去掉菜单
            panel1.Controls.Add(EditorBrowser);
        }

            private void DiffForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            killmyself();
        }
    }
}
