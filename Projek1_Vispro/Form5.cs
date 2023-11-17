using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projek1_Vispro
{
    public partial class Menu_For_Users : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        MySqlCommand command;
        DataTable table;
        MySqlDataReader mdr;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Menu_For_Users()
        {
            alamat = "server=localhost; database=db_infokost; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM tbl_data WHERE CONCAT(`Id`, `Nama`, `Alamat`, `Harga`, 'JenisKost', 'KataKunci') like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, koneksi);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text.ToString();
            searchData(valueToSearch);
        }

        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            Form1 form5 = new Form1();
            form5.Show();
            this.Hide();
        }

        private void BTN_Displays_Click(object sender, EventArgs e)
        {
            koneksi.Open();

            string selectQuery = "SELECT * FROM db_infokost.tbl_data WHERE Id=" + int.Parse(textBoxID.Text);
            command = new MySqlCommand(selectQuery, koneksi);

            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                textBoxNameKost.Text = mdr.GetString("Nama");
                textBoxAlamat.Text = mdr.GetString("Alamat");
                textBoxHarga.Text = mdr.GetInt32("Harga").ToString();
                textBoxJenisKost.Text = mdr.GetString("JenisKost");
                textBoxKataKunci.Text = mdr.GetString("KataKunci");
            }
            else
            {
                MessageBox.Show("No Data For This Id");
            }
            koneksi.Close();
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            try
            {
                Menu_For_Users_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Menu_For_Users_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from tbl_data");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Nama";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Alamat";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Harga";
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[4].HeaderText = "JenisKost";
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[5].HeaderText = "KataKunci";

                searchData("");

                textBox1.Clear();
                textBoxNameKost.Clear();
                textBoxID.Clear();
                textBoxAlamat.Clear();
                textBoxHarga.Clear();
                textBoxJenisKost.Clear();
                textBoxKataKunci.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
