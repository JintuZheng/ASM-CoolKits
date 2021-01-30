using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASM_SCAU.OtherForms
{
    public partial class contactForm : Y.Skin.YoForm.Shadow.ShadowForm
    {
        public contactForm()
        {
            InitializeComponent();
        }

        private void contactForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            killmyself();
        }
    }
}
