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
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1.SetParameterValue("My Parameter", textBox1.Text);
            crystalReportViewer1.ReportSource = CrystalReport1;
            crystalReportViewer1.Refresh();
        }
    }
}
