namespace Aplikasi_Dana_Siswa
{
    partial class laporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laporan));
            this.dgvDaftarAkun = new System.Windows.Forms.DataGridView();
            this.btnCetak = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnDanaKeluar = new System.Windows.Forms.Button();
            this.btnDanaMasuk = new System.Windows.Forms.Button();
            this.btnDaftarAkun = new System.Windows.Forms.Button();
            this.btnDaftarSiswa = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTgl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoAkun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarAkun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDaftarAkun
            // 
            this.dgvDaftarAkun.BackgroundColor = System.Drawing.Color.White;
            this.dgvDaftarAkun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDaftarAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftarAkun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colTgl,
            this.colNoAkun,
            this.colKelas,
            this.colTujuan,
            this.colTipe,
            this.colJumlah});
            this.dgvDaftarAkun.Location = new System.Drawing.Point(22, 242);
            this.dgvDaftarAkun.Name = "dgvDaftarAkun";
            this.dgvDaftarAkun.Size = new System.Drawing.Size(881, 365);
            this.dgvDaftarAkun.TabIndex = 81;
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Location = new System.Drawing.Point(44, 172);
            this.btnCetak.Margin = new System.Windows.Forms.Padding(2);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(104, 36);
            this.btnCetak.TabIndex = 80;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tanggal :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(846, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 76;
            this.label1.Text = "Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(753, 45);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 44);
            this.btnLogout.TabIndex = 75;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.Gray;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(586, 10);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(112, 47);
            this.btnLaporan.TabIndex = 74;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = false;
            // 
            // btnDanaKeluar
            // 
            this.btnDanaKeluar.BackColor = System.Drawing.Color.Gray;
            this.btnDanaKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanaKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanaKeluar.ForeColor = System.Drawing.Color.White;
            this.btnDanaKeluar.Location = new System.Drawing.Point(469, 10);
            this.btnDanaKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDanaKeluar.Name = "btnDanaKeluar";
            this.btnDanaKeluar.Size = new System.Drawing.Size(112, 47);
            this.btnDanaKeluar.TabIndex = 73;
            this.btnDanaKeluar.Text = "Dana Keluar";
            this.btnDanaKeluar.UseVisualStyleBackColor = false;
            // 
            // btnDanaMasuk
            // 
            this.btnDanaMasuk.BackColor = System.Drawing.Color.Gray;
            this.btnDanaMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanaMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanaMasuk.ForeColor = System.Drawing.Color.White;
            this.btnDanaMasuk.Location = new System.Drawing.Point(351, 10);
            this.btnDanaMasuk.Margin = new System.Windows.Forms.Padding(2);
            this.btnDanaMasuk.Name = "btnDanaMasuk";
            this.btnDanaMasuk.Size = new System.Drawing.Size(113, 47);
            this.btnDanaMasuk.TabIndex = 72;
            this.btnDanaMasuk.Text = " Dana Masuk";
            this.btnDanaMasuk.UseVisualStyleBackColor = false;
            // 
            // btnDaftarAkun
            // 
            this.btnDaftarAkun.BackColor = System.Drawing.Color.Gray;
            this.btnDaftarAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftarAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarAkun.ForeColor = System.Drawing.Color.White;
            this.btnDaftarAkun.Location = new System.Drawing.Point(233, 10);
            this.btnDaftarAkun.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaftarAkun.Name = "btnDaftarAkun";
            this.btnDaftarAkun.Size = new System.Drawing.Size(112, 47);
            this.btnDaftarAkun.TabIndex = 71;
            this.btnDaftarAkun.Text = "Daftar Akun";
            this.btnDaftarAkun.UseVisualStyleBackColor = false;
            // 
            // btnDaftarSiswa
            // 
            this.btnDaftarSiswa.BackColor = System.Drawing.Color.Gray;
            this.btnDaftarSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftarSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarSiswa.ForeColor = System.Drawing.Color.White;
            this.btnDaftarSiswa.Location = new System.Drawing.Point(116, 10);
            this.btnDaftarSiswa.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaftarSiswa.Name = "btnDaftarSiswa";
            this.btnDaftarSiswa.Size = new System.Drawing.Size(112, 47);
            this.btnDaftarSiswa.TabIndex = 70;
            this.btnDaftarSiswa.Text = "Daftar Siswa";
            this.btnDaftarSiswa.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Gray;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(9, 10);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(103, 47);
            this.btnDashboard.TabIndex = 69;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "s.d";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(546, 132);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker2.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 83;
            this.label4.Text = "Tanggal :";
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            // 
            // colTgl
            // 
            this.colTgl.DataPropertyName = "tgl";
            this.colTgl.HeaderText = "Tanggal";
            this.colTgl.Name = "colTgl";
            // 
            // colNoAkun
            // 
            this.colNoAkun.DataPropertyName = "no_akun";
            this.colNoAkun.HeaderText = "No Akun";
            this.colNoAkun.Name = "colNoAkun";
            // 
            // colKelas
            // 
            this.colKelas.DataPropertyName = "kelas";
            this.colKelas.HeaderText = "Kelas";
            this.colKelas.Name = "colKelas";
            // 
            // colTujuan
            // 
            this.colTujuan.DataPropertyName = "tujuan";
            this.colTujuan.HeaderText = "Tujuan";
            this.colTujuan.Name = "colTujuan";
            // 
            // colTipe
            // 
            this.colTipe.DataPropertyName = "tipe";
            this.colTipe.HeaderText = "Tipe";
            this.colTipe.Name = "colTipe";
            // 
            // colJumlah
            // 
            this.colJumlah.DataPropertyName = "jumlah";
            this.colJumlah.HeaderText = "Jumlah";
            this.colJumlah.Name = "colJumlah";
            // 
            // laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 624);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDaftarAkun);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnDanaKeluar);
            this.Controls.Add(this.btnDanaMasuk);
            this.Controls.Add(this.btnDaftarAkun);
            this.Controls.Add(this.btnDaftarSiswa);
            this.Controls.Add(this.btnDashboard);
            this.Name = "laporan";
            this.Text = "laporan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarAkun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDaftarAkun;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnDanaKeluar;
        private System.Windows.Forms.Button btnDanaMasuk;
        private System.Windows.Forms.Button btnDaftarAkun;
        private System.Windows.Forms.Button btnDaftarSiswa;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTgl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoAkun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJumlah;
    }
}