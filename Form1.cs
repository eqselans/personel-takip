using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipSistemi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-2K70O5J\\SQLEXPRESS;Initial Catalog=PersonelTakip;Integrated Security=True");
        private void MainForm_Load(object sender, EventArgs e)
        {

            // TODO: Bu kod satırı 'personelTakipDataSet.TblPerson' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblPersonTableAdapter.Fill(this.personelTakipDataSet.TblPerson);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tblPersonTableAdapter.Fill(this.personelTakipDataSet.TblPerson);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            sqlConnection.Open();

            bool medeniHal = radioButton1.Checked;


            SqlCommand sqlCommand = new SqlCommand("sp_InsertPerson", sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@p1", txtIsim.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtSoyisim.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtYas.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txtKimlik.Text);
            sqlCommand.Parameters.AddWithValue("@p5", txtSube.Text);
            sqlCommand.Parameters.AddWithValue("@p6", txtMaas.Text);
            sqlCommand.Parameters.AddWithValue("@p7", medeniHal);
            sqlCommand.Parameters.AddWithValue("@p8", txtPoz.Text);
            sqlCommand.Parameters.AddWithValue("@p9", dtGirisTarih.Value);
            sqlCommand.Parameters.AddWithValue("@p10", txtIs.Text);
            sqlCommand.Parameters.AddWithValue("@p11", txtTel.Text);
            sqlCommand.Parameters.AddWithValue("@p12", dtDogumTarih.Value);
            sqlCommand.Parameters.AddWithValue("@p13", txtCinsiyet.Text);
            sqlCommand.Parameters.AddWithValue("@p14", txtDep.Text);
            sqlCommand.Parameters.AddWithValue("@p15", txtMail.Text);
            sqlCommand.Parameters.AddWithValue("@p16", txtAdres.Text);
            sqlCommand.Parameters.AddWithValue("@p17", txtSgk.Text);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Personel Kaydetme Başarılı", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            sqlConnection.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();

            txtIsim.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtSoyisim.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtYas.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtKimlik.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtSube.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();

            txtMaas.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            if ((bool)dataGridView1.Rows[index].Cells[7].Value)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true; 
            }

            txtPoz.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();

            dtGirisTarih.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();

            txtIs.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();
            txtTel.Text = dataGridView1.Rows[index].Cells[11].Value.ToString();

            dtDogumTarih.Text = dataGridView1.Rows[index].Cells[12].Value.ToString();


            txtCinsiyet.Text = dataGridView1.Rows[index].Cells[13].Value.ToString();
            txtDep.Text = dataGridView1.Rows[index].Cells[14].Value.ToString();
            txtMail.Text = dataGridView1.Rows[index].Cells[15].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[index].Cells[16].Value.ToString();
            txtSgk.Text = dataGridView1.Rows[index].Cells[17].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("PersonelGuncelle", sqlConnection);

            bool medeniHal = radioButton1.Checked;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id",txtId.Text);
            sqlCommand.Parameters.AddWithValue("@p1", txtIsim.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtSoyisim.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtYas.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txtKimlik.Text);
            sqlCommand.Parameters.AddWithValue("@p5", txtSube.Text);
            sqlCommand.Parameters.AddWithValue("@p6", txtMaas.Text);
            sqlCommand.Parameters.AddWithValue("@p7", medeniHal);
            sqlCommand.Parameters.AddWithValue("@p8", txtPoz.Text);
            sqlCommand.Parameters.AddWithValue("@p9", dtGirisTarih.Value);
            sqlCommand.Parameters.AddWithValue("@p10", txtIs.Text);
            sqlCommand.Parameters.AddWithValue("@p11", txtTel.Text);
            sqlCommand.Parameters.AddWithValue("@p12", dtDogumTarih.Value);
            sqlCommand.Parameters.AddWithValue("@p13", txtCinsiyet.Text);
            sqlCommand.Parameters.AddWithValue("@p14", txtDep.Text);
            sqlCommand.Parameters.AddWithValue("@p15", txtMail.Text);
            sqlCommand.Parameters.AddWithValue("@p16", txtAdres.Text);
            sqlCommand.Parameters.AddWithValue("@p17", txtSgk.Text);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Personel Güncelleme İşleme Başarılı","Bilgilendirme",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            sqlConnection.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("delete from TblPerson where ID=@p1",sqlConnection);

            sqlCommand.Parameters.AddWithValue("@p1", txtId.Text);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Personel Kaydı Silindi","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);

            sqlConnection.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtId.Text = "";

            txtIsim.Text = "";
            txtSoyisim.Text = "";
            txtYas.Text = "";
            txtKimlik.Text = "";
            txtSube.Text = "";


            dtDogumTarih.Value = dtDogumTarih.MinDate;
            dtGirisTarih.Value= dtGirisTarih.MinDate;
            txtMaas.Text = "";
            radioButton1.Checked = false;

            radioButton2.Checked = false;
            txtPoz.Text = "";

            txtIs.Text = "";
            txtTel.Text = "";

            txtCinsiyet.Text = "";
            txtDep.Text = "";
            txtMail.Text = "";
            txtAdres.Text ="";
            txtSgk.Text = "";
        }



       
    }   
}
