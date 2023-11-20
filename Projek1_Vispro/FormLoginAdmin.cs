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
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "12345")
            {
                FrmMenuForAdmin form2 = new FrmMenuForAdmin();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password entered incorrectly");
            }
        }
    }
}
