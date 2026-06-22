using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Aplikasi_Dana_Siswa
{
    public partial class login : Form
    {
        // koneksi database
        string conDb = @"Data Source=.\SQLEXPRESS;Database=DanaSiswa;Integrated Security=True;TrustServerCertificate=True;";
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // ambil inputan
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // validasi inputan
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Isi Username dan Password terlebih dahulu!","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            // cek database
            try
            {
                using (SqlConnection con = new SqlConnection(conDb))
                {
                    con.Open();
                    string query = "SELECT id_user,username,password,role FROM tbl_user WHERE username = @usn AND password = @pw";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // mengirim data ke query
                        cmd.Parameters.AddWithValue("@usn", username);
                        cmd.Parameters.AddWithValue("@pw",password);

                        // menjalankan perintah
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    // Simpan data session
                                    userSession.IdUser = Convert.ToInt32(reader["id_user"]);
                                    userSession.Username = reader["username"].ToString();
                                    userSession.Password = reader["password"].ToString();
                                    userSession.Role = reader["role"].ToString();

                                    MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (userSession.Role == "Administrator")
                                    {
                                        daftarSiswa keDaftarSiswa = new daftarSiswa();
                                        keDaftarSiswa.Show();
                                        this.Hide();
                                    }else if(userSession.Role == "Bendahara"){
                                        Dashboard keDashboard = new Dashboard();
                                        keDashboard.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Username/Password tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }else
                                {
                                    MessageBox.Show("Role tidak ditemukan!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                        }
                    }   
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erorr :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
