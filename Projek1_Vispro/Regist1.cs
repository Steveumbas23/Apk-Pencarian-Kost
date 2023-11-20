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
    public partial class Regist1 : Form
    {
        public Regist1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport11.SetParameterValue("InfoKost", textBox1.Text);
            crystalReportViewer1.ReportSource = CrystalReport11;
            crystalReportViewer1.Refresh();
        }

        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            FrmLandingPage Regist1 = new FrmLandingPage();
            Regist1.Show();
            this.Hide();
        }
    }
}
