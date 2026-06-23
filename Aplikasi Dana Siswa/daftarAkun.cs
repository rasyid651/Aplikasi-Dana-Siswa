using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Dana_Siswa
{
    public partial class daftarAkun : Form
    {
        string conDb = @"Data Source=.\SQLEXPRESS;Database=DanaSiswa;Integrated Security=True;TrustServerCertificate=True;";
        private bool isModeEdit = false;

        public daftarAkun()
        {
            InitializeComponent();
        }

        private void daftarAkun_Load(object sender, EventArgs e)
        {
            TampilkanDataAkun();
        }

        private void TampilkanDataAkun()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = @"SELECT id_user, username, password, role FROM tbl_user ORDER BY id_user";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // eksekusi disimpan di adapter
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dts = new System.Data.DataTable();
                            // isi data ke table sementara
                            adapter.Fill(dts);
                            dgvDaftarAkun.DataSource = dts;

                            if (dgvDaftarAkun.Columns["id_user"] != null)
                                dgvDaftarAkun.Columns["id_user"].Visible = false;

                            TampilkanNoUrut();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data akun gagal ditampilkan :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilkanNoUrut()
        {
            int no = 1;
            foreach (DataGridViewRow row in dgvDaftarAkun.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["colNo"].Value = no++;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // validasi input 
            if (string.IsNullOrEmpty(txtNakun.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Nama akun atau Kata sandi tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = "";

                    if (isModeEdit)
                    {
                        // query Update
                        query = "UPDATE tbl_user SET username = @usn, password = @pw, role = @role WHERE id_user = @id_user";
                    }
                    else
                    {
                        // query Add
                        query = "INSERT INTO tbl_user (username,password,role) VALUES (@usn,@pw,@role)";

                    }

                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        // mengirim data ke query
                        cmd.Parameters.AddWithValue("@usn", txtNakun.Text);
                        cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@role", txtRole.Text);

                        if (isModeEdit)
                        {
                            cmd.Parameters.AddWithValue("@id_user", txtNakun.Tag);
                        }

                        int hasil = cmd.ExecuteNonQuery();

                        string pesan = isModeEdit
                            ? "Data berhasil ditambahkan!"
                            : "Data behasil diupdate!";

                        MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNakun.Clear();
                        txtPassword.Clear();
                        txtRole.Clear();
                        txtNakun.Tag = null;
                        isModeEdit = false;
                        btnSimpan.Text = "Update";
                        TampilkanDataAkun();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal dsimpan" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // validasi data
            if (dgvDaftarAkun.CurrentRow == null)
            {
                MessageBox.Show("Pilih baris terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                DataTable dt = (DataTable)dgvDaftarAkun.DataSource;
                int rowIndex = dgvDaftarAkun.CurrentRow.Index;

                if (rowIndex >= 0 && rowIndex < dt.Rows.Count)
                {
                    DataRow row = dt.Rows[rowIndex];

                    // ambil data akun
                    int idUser = Convert.ToInt32(row["id_user"]);
                    string nakun = row["username"].ToString();
                    string pw = row["password"].ToString();
                    string role = row["role"].ToString();

                    // isi textbox dari label
                    txtNakun.Text = nakun;
                    txtPassword.Text = pw;
                    txtRole.Text = role;

                    // simpan id di tag
                    txtNakun.Tag = idUser;

                    // set mode edit
                    isModeEdit = true;
                    btnSimpan.Text = "Update";
                    txtNakun.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal diupdate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // validasi data
            if (dgvDaftarAkun.CurrentRow == null)
            {
                MessageBox.Show("Pilih baris terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // ambil data yang ingin dihapus
            int idUser = Convert.ToInt32(dgvDaftarAkun.CurrentRow.Cells["id_user"].Value.ToString());
            string username = dgvDaftarAkun.CurrentRow.Cells["usernama"].Value.ToString();

            // Dialog hapus
            DialogResult konfirmasi = MessageBox.Show("Ingin menghapus data?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // jika hapus
            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    using(SqlConnection con = new SqlConnection(conDb))
                    {
                        con.Open();
                        string query = @"DELETE FROM tbl_user WHERE id_user = @id_user";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id_user", idUser);
                            cmd.ExecuteNonQuery(); // jalankan perintah
                        }

                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // refresh Data
                        TampilkanDataAkun();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Data gagal dihapus : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDaftarSiswa_Click(object sender, EventArgs e)
        {
            daftarSiswa keDaftarSiswa = new daftarSiswa();
            keDaftarSiswa.Show();
            this.Hide();
        }
    }
}
