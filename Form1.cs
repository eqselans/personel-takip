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
    }
}
