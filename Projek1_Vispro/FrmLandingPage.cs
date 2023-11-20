using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek1_Vispro
{
    public partial class FrmLandingPage : Form
    {
        public FrmLandingPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLoginAdmin form1 = new FormLoginAdmin();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLoginUser form1 = new FormLoginUser();
            form1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regist1 form1 = new Regist1();
            form1.Show();
            this.Hide();
        }
    }
}
