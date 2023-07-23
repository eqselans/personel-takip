using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PersonelTakipSistemi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-2K70O5J\\SQLEXPRESS;Initial Catalog=PersonelTakip;Integrated Security=True");
        private void Giris_Load(object sender, EventArgs e)
        {
            Giris giris = new Giris();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNick.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Lütfen tüm kutucukları giriniz", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM TblKayit WHERE KullaniciAdi=@nickname AND Sifre=@password",sqlConnection);

                sqlCommand.Parameters.AddWithValue("@nickname",txtNick.Text);
                sqlCommand.Parameters.AddWithValue("@password",txtPass.Text);
                int count = (int)sqlCommand.ExecuteScalar();

                if (count>0)
                {
                    MessageBox.Show("Giriş Başarılı\nSisteme yönlendiriliyorsunuz","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    mainForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }    
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();

            this.Hide();
        }
    }
}
