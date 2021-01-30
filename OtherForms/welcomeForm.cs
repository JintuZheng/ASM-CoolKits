using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASM_SCAU
{
    public partial class welcomeForm : Y.Skin.YoForm.Shadow.ShadowForm
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            killmyself();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://jintuzheng.blog.csdn.net/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OtherForms.contactForm cf = new OtherForms.contactForm();
            cf.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start(Environment.CurrentDirectory + "/Update.exe");
            System.Diagnostics.Process.Start("http://jintupersonal.com/ASMCOOL/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("解码之后就能知道我暗恋的她。提示：观察是类似哪一种加密方法，用合适的方式解码就能知道答案了：data:image/png;base64,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");
            MessageBox.Show("无聊彩蛋已经复制到剪贴板上，自己粘贴到Word文档上看哦");
        }
    }
}
