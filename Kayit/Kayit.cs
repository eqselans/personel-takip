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

namespace PersonelTakipSistemi
{
    public partial class Kayit : Form
    {
        ToolTip toolTip = new ToolTip();
        public Kayit()
        {
            InitializeComponent();
            
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-2K70O5J\\SQLEXPRESS;Initial Catalog=PersonelTakip;Integrated Security=True");
        private void Kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtNick.Text == string.Empty || txtPass.Text == string.Empty || txtIsim.Text == string.Empty || txtSoyisim.Text == string.Empty || txtSirket.Text == string.Empty || txtDepart.Text == string.Empty)
            {
                MessageBox.Show("Lütfen tüm kutucukları giriniz", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPass.Text == txtPass2.Text)
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TblKayit WHERE KullaniciAdi=@username", sqlConnection);
                    command.Parameters.AddWithValue("@username",txtNick.Text);
                    int countNick = (int)command.ExecuteScalar();

                    if (countNick>0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor, lütfen farklı bir kullanıcı adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SqlCommand sqlCommand = new SqlCommand("Kayit", sqlConnection);

                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.AddWithValue("@p1", txtNick.Text);
                        sqlCommand.Parameters.AddWithValue("@p2", txtPass.Text);
                        sqlCommand.Parameters.AddWithValue("@p3", txtIsim.Text);
                        sqlCommand.Parameters.AddWithValue("@p4", txtSoyisim.Text);
                        sqlCommand.Parameters.AddWithValue("@p5", txtSirket.Text);
                        sqlCommand.Parameters.AddWithValue("@p6", txtDepart.Text);
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected>0)
                        {
                            MessageBox.Show("Kayıt işlemi başarılı\nGiriş yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Giris giris = new Giris();
                            giris.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt başarısız oldu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        sqlConnection.Close();
                    }
                    
                }

                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
