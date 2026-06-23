using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplikasi_Dana_Siswa
{
    public partial class daftarSiswa : Form
    {
        string conDb = @"Data Source=.\SQLEXPRESS;Database=DanaSiswa;Integrated Security=True;TrustServerCertificate=True;";
        // var untuk user login
        public string roleUser = "";
        // untuk tamba/edit
        private bool isEditMode = false;
        public daftarSiswa()
        {
            InitializeComponent();
        }

        private void daftarSiswa_Load(object sender, EventArgs e)
        {
            TampilkanDataUser();
        }

        private void TampilkanDataUser()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = @"SELECT id_siswa, nama_siswa, kelas, nomor_induk FROM tbl_siswa ORDER BY id_siswa";

                    // buat sqlCommand
                    using (SqlCommand cmd = new SqlCommand(query,con))
                    {
                        // eksekusi disimpan di adapter 
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dts = new System.Data.DataTable();
                            // isi data dari database
                            adapter.Fill(dts);
                            dgvDaftarSiswa.DataSource = dts;

                            if (dgvDaftarSiswa.Columns["id_siswa"] != null)
                                dgvDaftarSiswa.Columns["id_siswa"].Visible = false;

                            TambahNoUrut();
                        }
                    }
                } 
            }catch (Exception ex)
            {
                MessageBox.Show("Data user gagal ditampilkan :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TambahNoUrut()
        {
            int no = 1;
            foreach (DataGridViewRow row in dgvDaftarSiswa.Rows)
            {
                if (!row.IsNewRow) // menskip baris kosong
                {
                    row.Cells["colNo"].Value = no++;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // validasi input
            if (string.IsNullOrEmpty(txtNamaSiswa.Text) || string.IsNullOrEmpty(txtKelas.Text))
            {
                MessageBox.Show("Form Nama siswa atau Kelas tidak boleh kosong!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = "";

                    if (isEditMode)
                    {
                        // query edit data
                        query = "UPDATE tbl_siswa SET nama_siswa = @nasis, kelas = @kelas, nomor_induk = @noduk WHERE id_siswa = @id_siswa";
                    }
                    else
                    {
                        // tambah
                        query = "INSERT INTO tbl_siswa (nama_siswa,kelas,nomor_induk) VALUES (@nasis,@kelas,@noduk)";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // mengirim data ke query
                        cmd.Parameters.AddWithValue("@nasis", txtNamaSiswa.Text);
                        cmd.Parameters.AddWithValue("@kelas", txtKelas.Text);
                        cmd.Parameters.AddWithValue("@noduk", txtNoInduk.Text);

                        if (isEditMode)
                        {
                            // patokan id pertamannya
                            cmd.Parameters.AddWithValue("@id_siswa", txtNamaSiswa.Tag);
                        }

                        int hasil = cmd.ExecuteNonQuery();

                        if (hasil > 0)
                        {
                            string pesan = isEditMode
                                ? "Data Siswa Berhasil diupdate!"
                                : "Data Siswa Berhasil ditambahkan!";

                            MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtNamaSiswa.Clear();
                            txtKelas.Clear();
                            txtNoInduk.Clear();
                            txtNamaSiswa.Tag = null;
                            isEditMode = false;

                            btnSimpan.Text = "Simpan";
                            TampilkanDataUser();
                        }
                    }
                    
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan : " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // validasi data
            if (dgvDaftarSiswa.CurrentRow == null)
            {
                MessageBox.Show("Pilih baris terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataTable dt = (DataTable)dgvDaftarSiswa.DataSource;
                int rowIndex = dgvDaftarSiswa.CurrentRow.Index;

                if (rowIndex >= 0 && rowIndex < dt.Rows.Count)
                {
                    DataRow row = dt.Rows[rowIndex];

                    // ambil data siswa
                    int idSiswa = Convert.ToInt32(row["id_siswa"]);
                    string namaSiswa = row["nama_siswa"].ToString();
                    string kelas = row["kelas"].ToString();
                    string noInduk = row["nomor_induk"].ToString();

                    // isi txtBox dari tabel
                    txtNamaSiswa.Text = namaSiswa;
                    txtKelas.Text = kelas;
                    txtNoInduk.Text = noInduk;

                    // simpan id di tag
                    txtNamaSiswa.Tag = idSiswa;

                    // set mode edit
                    isEditMode = true;
                    btnSimpan.Text = "Update";
                    txtNamaSiswa.Focus();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Data gagal diupdate : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // validasi data
            if (dgvDaftarSiswa.CurrentCell == null)
            {
                MessageBox.Show("Plih baris terlebih dahulu!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            // ambil data yang ingin dihapus
            int IdSiswa = Convert.ToInt32(dgvDaftarSiswa.CurrentRow.Cells["id_siswa"].Value);
            string namaSiswa = dgvDaftarSiswa.CurrentRow.Cells["colSiswa"].Value.ToString();

            // konfirmasi hapus 
            DialogResult konfirmasi = MessageBox.Show("Yakin ingin menghapus data?",
                "Konfirmasi hapus",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            // jika hapus
            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conDb))
                    {
                        con.Open();
                        string query = "DELETE FROM tbl_siswa WHERE id_siswa = @id_siswa";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id_siswa", IdSiswa);
                            cmd.ExecuteNonQuery(); // mengirim perintah query

                        }

                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // refresh data
                        TampilkanDataUser();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Data gagal dihapus :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilkanDataUser();
        }

        private void btnDaftarAkun_Click(object sender, EventArgs e)
        {
            daftarAkun keDaftarAkun = new daftarAkun();
            keDaftarAkun.Show();
            this.Hide();
        }
    }
}
