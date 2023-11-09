namespace Projek1_Vispro
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_BACK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNameKost = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxJenisKost = new System.Windows.Forms.TextBox();
            this.BTN_Displays = new System.Windows.Forms.Button();
            this.BTN_CLEAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(838, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(639, 52);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(230, 26);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH.Location = new System.Drawing.Point(887, 46);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(97, 39);
            this.BTN_SEARCH.TabIndex = 2;
            this.BTN_SEARCH.Text = "Search";
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projek1_Vispro.Properties.Resources.WhatsApp_Image_2023_10_30_at_18_23_00;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Boarding House Search";
            // 
            // BTN_BACK
            // 
            this.BTN_BACK.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BACK.Location = new System.Drawing.Point(887, 563);
            this.BTN_BACK.Name = "BTN_BACK";
            this.BTN_BACK.Size = new System.Drawing.Size(97, 39);
            this.BTN_BACK.TabIndex = 14;
            this.BTN_BACK.Text = "Back";
            this.BTN_BACK.UseVisualStyleBackColor = false;
            this.BTN_BACK.Click += new System.EventHandler(this.BTN_BACK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id               :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nama Kost :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Alamat       :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Harga        :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Jenis Kost :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(161, 353);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(66, 26);
            this.textBoxID.TabIndex = 20;
            // 
            // textBoxNameKost
            // 
            this.textBoxNameKost.Location = new System.Drawing.Point(161, 394);
            this.textBoxNameKost.Name = "textBoxNameKost";
            this.textBoxNameKost.Size = new System.Drawing.Size(567, 26);
            this.textBoxNameKost.TabIndex = 21;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(161, 437);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(567, 26);
            this.textBoxAlamat.TabIndex = 22;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(161, 476);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(567, 26);
            this.textBoxHarga.TabIndex = 23;
            // 
            // textBoxJenisKost
            // 
            this.textBoxJenisKost.Location = new System.Drawing.Point(161, 525);
            this.textBoxJenisKost.Name = "textBoxJenisKost";
            this.textBoxJenisKost.Size = new System.Drawing.Size(66, 26);
            this.textBoxJenisKost.TabIndex = 24;
            // 
            // BTN_Displays
            // 
            this.BTN_Displays.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Displays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Displays.Location = new System.Drawing.Point(654, 563);
            this.BTN_Displays.Name = "BTN_Displays";
            this.BTN_Displays.Size = new System.Drawing.Size(97, 39);
            this.BTN_Displays.TabIndex = 25;
            this.BTN_Displays.Text = "Displays";
            this.BTN_Displays.UseVisualStyleBackColor = false;
            this.BTN_Displays.Click += new System.EventHandler(this.BTN_Displays_Click);
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLEAR.Location = new System.Drawing.Point(772, 563);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(97, 39);
            this.BTN_CLEAR.TabIndex = 26;
            this.BTN_CLEAR.Text = "Clear";
            this.BTN_CLEAR.UseVisualStyleBackColor = false;
            this.BTN_CLEAR.Click += new System.EventHandler(this.BTN_CLEAR_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 614);
            this.Controls.Add(this.BTN_CLEAR);
            this.Controls.Add(this.BTN_Displays);
            this.Controls.Add(this.textBoxJenisKost);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNameKost);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_BACK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_BACK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNameKost;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxJenisKost;
        private System.Windows.Forms.Button BTN_Displays;
        private System.Windows.Forms.Button BTN_CLEAR;
    }
}