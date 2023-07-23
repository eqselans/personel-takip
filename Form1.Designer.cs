using System.Drawing;
using System.Windows.Forms;
using System;

namespace PersonelTakipSistemi
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupGiris = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.dtGirisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtPoz = new System.Windows.Forms.TextBox();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtSgk = new System.Windows.Forms.TextBox();
            this.txtSube = new System.Windows.Forms.TextBox();
            this.txtIs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupIslem = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupKayıt = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMedeniHalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perPozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perGirisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCalismaDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDogumTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSgkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTakipDataSet = new PersonelTakipSistemi.PersonelTakipDataSet();
            this.tblPersonTableAdapter = new PersonelTakipSistemi.PersonelTakipDataSetTableAdapters.TblPersonTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupGiris.SuspendLayout();
            this.groupIslem.SuspendLayout();
            this.groupKayıt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupGiris
            // 
            this.groupGiris.BackColor = System.Drawing.SystemColors.Control;
            this.groupGiris.Controls.Add(this.txtAdres);
            this.groupGiris.Controls.Add(this.radioButton2);
            this.groupGiris.Controls.Add(this.radioButton1);
            this.groupGiris.Controls.Add(this.dtDogumTarih);
            this.groupGiris.Controls.Add(this.dtGirisTarih);
            this.groupGiris.Controls.Add(this.txtDep);
            this.groupGiris.Controls.Add(this.txtPoz);
            this.groupGiris.Controls.Add(this.txtKimlik);
            this.groupGiris.Controls.Add(this.label13);
            this.groupGiris.Controls.Add(this.label9);
            this.groupGiris.Controls.Add(this.label14);
            this.groupGiris.Controls.Add(this.label5);
            this.groupGiris.Controls.Add(this.txtTel);
            this.groupGiris.Controls.Add(this.txtSgk);
            this.groupGiris.Controls.Add(this.txtSube);
            this.groupGiris.Controls.Add(this.txtIs);
            this.groupGiris.Controls.Add(this.label12);
            this.groupGiris.Controls.Add(this.txtIsim);
            this.groupGiris.Controls.Add(this.label8);
            this.groupGiris.Controls.Add(this.label11);
            this.groupGiris.Controls.Add(this.txtYas);
            this.groupGiris.Controls.Add(this.label7);
            this.groupGiris.Controls.Add(this.txtMail);
            this.groupGiris.Controls.Add(this.label3);
            this.groupGiris.Controls.Add(this.txtMaas);
            this.groupGiris.Controls.Add(this.label17);
            this.groupGiris.Controls.Add(this.label16);
            this.groupGiris.Controls.Add(this.label18);
            this.groupGiris.Controls.Add(this.label10);
            this.groupGiris.Controls.Add(this.label4);
            this.groupGiris.Controls.Add(this.txtCinsiyet);
            this.groupGiris.Controls.Add(this.label6);
            this.groupGiris.Controls.Add(this.label15);
            this.groupGiris.Controls.Add(this.txtSoyisim);
            this.groupGiris.Controls.Add(this.label2);
            this.groupGiris.Controls.Add(this.txtId);
            this.groupGiris.Controls.Add(this.label1);
            this.groupGiris.Location = new System.Drawing.Point(7, 7);
            this.groupGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupGiris.Name = "groupGiris";
            this.groupGiris.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupGiris.Size = new System.Drawing.Size(598, 498);
            this.groupGiris.TabIndex = 0;
            this.groupGiris.TabStop = false;
            this.groupGiris.Text = "Personel İşlemleri";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(19, 409);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(560, 69);
            this.txtAdres.TabIndex = 17;
            this.txtAdres.Text = "";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(440, 381);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 24);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(378, 381);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 24);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dtDogumTarih
            // 
            this.dtDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDogumTarih.Location = new System.Drawing.Point(384, 170);
            this.dtDogumTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDogumTarih.MaxDate = new System.DateTime(2023, 7, 23, 1, 44, 22, 0);
            this.dtDogumTarih.Name = "dtDogumTarih";
            this.dtDogumTarih.Size = new System.Drawing.Size(182, 26);
            this.dtDogumTarih.TabIndex = 10;
            this.dtDogumTarih.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // dtGirisTarih
            // 
            this.dtGirisTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGirisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGirisTarih.Location = new System.Drawing.Point(383, 39);
            this.dtGirisTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGirisTarih.MaxDate = new System.DateTime(2023, 7, 23, 1, 44, 5, 0);
            this.dtGirisTarih.Name = "dtGirisTarih";
            this.dtGirisTarih.Size = new System.Drawing.Size(183, 26);
            this.dtGirisTarih.TabIndex = 7;
            this.dtGirisTarih.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(383, 296);
            this.txtDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(183, 26);
            this.txtDep.TabIndex = 13;
            // 
            // txtPoz
            // 
            this.txtPoz.Location = new System.Drawing.Point(383, 210);
            this.txtPoz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPoz.Name = "txtPoz";
            this.txtPoz.Size = new System.Drawing.Size(183, 26);
            this.txtPoz.TabIndex = 11;
            // 
            // txtKimlik
            // 
            this.txtKimlik.Location = new System.Drawing.Point(383, 86);
            this.txtKimlik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKimlik.MaxLength = 11;
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.Size = new System.Drawing.Size(183, 26);
            this.txtKimlik.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(277, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Departman";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pozisyon";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(277, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Giriş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "TC Kimlik No";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(80, 298);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(168, 26);
            this.txtTel.TabIndex = 5;
            // 
            // txtSgk
            // 
            this.txtSgk.Location = new System.Drawing.Point(383, 336);
            this.txtSgk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSgk.Name = "txtSgk";
            this.txtSgk.Size = new System.Drawing.Size(183, 26);
            this.txtSgk.TabIndex = 14;
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(80, 213);
            this.txtSube.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSube.Name = "txtSube";
            this.txtSube.Size = new System.Drawing.Size(168, 26);
            this.txtSube.TabIndex = 3;
            // 
            // txtIs
            // 
            this.txtIs.Location = new System.Drawing.Point(383, 250);
            this.txtIs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIs.Name = "txtIs";
            this.txtIs.Size = new System.Drawing.Size(183, 26);
            this.txtIs.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Telefon";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(80, 88);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(168, 26);
            this.txtIsim.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Şube";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "SGK No";
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(383, 126);
            this.txtYas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYas.MaxLength = 3;
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(183, 26);
            this.txtYas.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "İş Durumu";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(80, 338);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(168, 26);
            this.txtMail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "İsim";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(80, 253);
            this.txtMaas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(168, 26);
            this.txtMaas.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(277, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Medeni Hâli";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(277, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Doğum Tarihi";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 381);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Adres : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yaş";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(80, 171);
            this.txtCinsiyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(168, 26);
            this.txtCinsiyet.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Maaş";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Cinsiyet";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(80, 128);
            this.txtSoyisim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(168, 26);
            this.txtSoyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(80, 39);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(168, 26);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupIslem
            // 
            this.groupIslem.BackColor = System.Drawing.Color.Transparent;
            this.groupIslem.Controls.Add(this.btnTemizle);
            this.groupIslem.Controls.Add(this.btnSil);
            this.groupIslem.Controls.Add(this.btnGuncelle);
            this.groupIslem.Controls.Add(this.btnKaydet);
            this.groupIslem.Controls.Add(this.btnListele);
            this.groupIslem.Location = new System.Drawing.Point(930, 18);
            this.groupIslem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupIslem.Name = "groupIslem";
            this.groupIslem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupIslem.Size = new System.Drawing.Size(430, 487);
            this.groupIslem.TabIndex = 1;
            this.groupIslem.TabStop = false;
            this.groupIslem.Text = "İşlemler";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(5, 398);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(422, 66);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(5, 305);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(422, 66);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Personel Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(5, 212);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(422, 66);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Personel Bilgi Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(5, 120);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(422, 66);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Personel Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(5, 36);
            this.btnListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(422, 66);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Personel Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupKayıt
            // 
            this.groupKayıt.Controls.Add(this.dataGridView1);
            this.groupKayıt.Location = new System.Drawing.Point(8, 516);
            this.groupKayıt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupKayıt.Name = "groupKayıt";
            this.groupKayıt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupKayıt.Size = new System.Drawing.Size(1352, 226);
            this.groupKayıt.TabIndex = 2;
            this.groupKayıt.TabStop = false;
            this.groupKayıt.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perYasDataGridViewTextBoxColumn,
            this.perTCDataGridViewTextBoxColumn,
            this.perSubeDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perMedeniHalDataGridViewCheckBoxColumn,
            this.perPozisyonDataGridViewTextBoxColumn,
            this.perGirisTarihiDataGridViewTextBoxColumn,
            this.perCalismaDurumuDataGridViewTextBoxColumn,
            this.perTelefonDataGridViewTextBoxColumn,
            this.perDogumTarihDataGridViewTextBoxColumn,
            this.perCinsiyetDataGridViewTextBoxColumn,
            this.perDepartmanDataGridViewTextBoxColumn,
            this.perMailDataGridViewTextBoxColumn,
            this.perAdresDataGridViewTextBoxColumn,
            this.perSgkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1346, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 150;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.perAdDataGridViewTextBoxColumn.Width = 150;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.perSoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // perYasDataGridViewTextBoxColumn
            // 
            this.perYasDataGridViewTextBoxColumn.DataPropertyName = "PerYas";
            this.perYasDataGridViewTextBoxColumn.HeaderText = "PerYas";
            this.perYasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perYasDataGridViewTextBoxColumn.Name = "perYasDataGridViewTextBoxColumn";
            this.perYasDataGridViewTextBoxColumn.ReadOnly = true;
            this.perYasDataGridViewTextBoxColumn.Width = 150;
            // 
            // perTCDataGridViewTextBoxColumn
            // 
            this.perTCDataGridViewTextBoxColumn.DataPropertyName = "PerTC";
            this.perTCDataGridViewTextBoxColumn.HeaderText = "PerTC";
            this.perTCDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perTCDataGridViewTextBoxColumn.Name = "perTCDataGridViewTextBoxColumn";
            this.perTCDataGridViewTextBoxColumn.ReadOnly = true;
            this.perTCDataGridViewTextBoxColumn.Width = 150;
            // 
            // perSubeDataGridViewTextBoxColumn
            // 
            this.perSubeDataGridViewTextBoxColumn.DataPropertyName = "PerSube";
            this.perSubeDataGridViewTextBoxColumn.HeaderText = "PerSube";
            this.perSubeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perSubeDataGridViewTextBoxColumn.Name = "perSubeDataGridViewTextBoxColumn";
            this.perSubeDataGridViewTextBoxColumn.ReadOnly = true;
            this.perSubeDataGridViewTextBoxColumn.Width = 150;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.ReadOnly = true;
            this.perMaasDataGridViewTextBoxColumn.Width = 150;
            // 
            // perMedeniHalDataGridViewCheckBoxColumn
            // 
            this.perMedeniHalDataGridViewCheckBoxColumn.DataPropertyName = "PerMedeniHal";
            this.perMedeniHalDataGridViewCheckBoxColumn.HeaderText = "PerMedeniHal";
            this.perMedeniHalDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.perMedeniHalDataGridViewCheckBoxColumn.Name = "perMedeniHalDataGridViewCheckBoxColumn";
            this.perMedeniHalDataGridViewCheckBoxColumn.ReadOnly = true;
            this.perMedeniHalDataGridViewCheckBoxColumn.Width = 150;
            // 
            // perPozisyonDataGridViewTextBoxColumn
            // 
            this.perPozisyonDataGridViewTextBoxColumn.DataPropertyName = "PerPozisyon";
            this.perPozisyonDataGridViewTextBoxColumn.HeaderText = "PerPozisyon";
            this.perPozisyonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perPozisyonDataGridViewTextBoxColumn.Name = "perPozisyonDataGridViewTextBoxColumn";
            this.perPozisyonDataGridViewTextBoxColumn.ReadOnly = true;
            this.perPozisyonDataGridViewTextBoxColumn.Width = 150;
            // 
            // perGirisTarihiDataGridViewTextBoxColumn
            // 
            this.perGirisTarihiDataGridViewTextBoxColumn.DataPropertyName = "PerGirisTarihi";
            this.perGirisTarihiDataGridViewTextBoxColumn.HeaderText = "PerGirisTarihi";
            this.perGirisTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perGirisTarihiDataGridViewTextBoxColumn.Name = "perGirisTarihiDataGridViewTextBoxColumn";
            this.perGirisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.perGirisTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // perCalismaDurumuDataGridViewTextBoxColumn
            // 
            this.perCalismaDurumuDataGridViewTextBoxColumn.DataPropertyName = "PerCalismaDurumu";
            this.perCalismaDurumuDataGridViewTextBoxColumn.HeaderText = "PerCalismaDurumu";
            this.perCalismaDurumuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perCalismaDurumuDataGridViewTextBoxColumn.Name = "perCalismaDurumuDataGridViewTextBoxColumn";
            this.perCalismaDurumuDataGridViewTextBoxColumn.ReadOnly = true;
            this.perCalismaDurumuDataGridViewTextBoxColumn.Width = 150;
            // 
            // perTelefonDataGridViewTextBoxColumn
            // 
            this.perTelefonDataGridViewTextBoxColumn.DataPropertyName = "PerTelefon";
            this.perTelefonDataGridViewTextBoxColumn.HeaderText = "PerTelefon";
            this.perTelefonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perTelefonDataGridViewTextBoxColumn.Name = "perTelefonDataGridViewTextBoxColumn";
            this.perTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.perTelefonDataGridViewTextBoxColumn.Width = 150;
            // 
            // perDogumTarihDataGridViewTextBoxColumn
            // 
            this.perDogumTarihDataGridViewTextBoxColumn.DataPropertyName = "PerDogumTarih";
            this.perDogumTarihDataGridViewTextBoxColumn.HeaderText = "PerDogumTarih";
            this.perDogumTarihDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perDogumTarihDataGridViewTextBoxColumn.Name = "perDogumTarihDataGridViewTextBoxColumn";
            this.perDogumTarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.perDogumTarihDataGridViewTextBoxColumn.Width = 150;
            // 
            // perCinsiyetDataGridViewTextBoxColumn
            // 
            this.perCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "PerCinsiyet";
            this.perCinsiyetDataGridViewTextBoxColumn.HeaderText = "PerCinsiyet";
            this.perCinsiyetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perCinsiyetDataGridViewTextBoxColumn.Name = "perCinsiyetDataGridViewTextBoxColumn";
            this.perCinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            this.perCinsiyetDataGridViewTextBoxColumn.Width = 150;
            // 
            // perDepartmanDataGridViewTextBoxColumn
            // 
            this.perDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PerDepartman";
            this.perDepartmanDataGridViewTextBoxColumn.HeaderText = "PerDepartman";
            this.perDepartmanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perDepartmanDataGridViewTextBoxColumn.Name = "perDepartmanDataGridViewTextBoxColumn";
            this.perDepartmanDataGridViewTextBoxColumn.ReadOnly = true;
            this.perDepartmanDataGridViewTextBoxColumn.Width = 150;
            // 
            // perMailDataGridViewTextBoxColumn
            // 
            this.perMailDataGridViewTextBoxColumn.DataPropertyName = "PerMail";
            this.perMailDataGridViewTextBoxColumn.HeaderText = "PerMail";
            this.perMailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perMailDataGridViewTextBoxColumn.Name = "perMailDataGridViewTextBoxColumn";
            this.perMailDataGridViewTextBoxColumn.ReadOnly = true;
            this.perMailDataGridViewTextBoxColumn.Width = 150;
            // 
            // perAdresDataGridViewTextBoxColumn
            // 
            this.perAdresDataGridViewTextBoxColumn.DataPropertyName = "PerAdres";
            this.perAdresDataGridViewTextBoxColumn.HeaderText = "PerAdres";
            this.perAdresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perAdresDataGridViewTextBoxColumn.Name = "perAdresDataGridViewTextBoxColumn";
            this.perAdresDataGridViewTextBoxColumn.ReadOnly = true;
            this.perAdresDataGridViewTextBoxColumn.Width = 150;
            // 
            // perSgkDataGridViewTextBoxColumn
            // 
            this.perSgkDataGridViewTextBoxColumn.DataPropertyName = "PerSgk";
            this.perSgkDataGridViewTextBoxColumn.HeaderText = "PerSgk";
            this.perSgkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perSgkDataGridViewTextBoxColumn.Name = "perSgkDataGridViewTextBoxColumn";
            this.perSgkDataGridViewTextBoxColumn.ReadOnly = true;
            this.perSgkDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblPersonBindingSource
            // 
            this.tblPersonBindingSource.DataMember = "TblPerson";
            this.tblPersonBindingSource.DataSource = this.personelTakipDataSet;
            // 
            // personelTakipDataSet
            // 
            this.personelTakipDataSet.DataSetName = "PersonelTakipDataSet";
            this.personelTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonTableAdapter
            // 
            this.tblPersonTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(611, 377);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1371, 752);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupKayıt);
            this.Controls.Add(this.groupIslem);
            this.Controls.Add(this.groupGiris);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Personel Takip Sistemi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupGiris.ResumeLayout(false);
            this.groupGiris.PerformLayout();
            this.groupIslem.ResumeLayout(false);
            this.groupKayıt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupGiris;
        private TextBox txtSoyisim;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private TextBox txtIsim;
        private Label label3;
        private TextBox txtKimlik;
        private Label label5;
        private TextBox txtYas;
        private Label label4;
        private TextBox txtDep;
        private TextBox txtPoz;
        private Label label13;
        private Label label9;
        private TextBox txtTel;
        private TextBox txtSgk;
        private TextBox txtSube;
        private TextBox txtIs;
        private Label label12;
        private Label label8;
        private Label label11;
        private Label label7;
        private TextBox txtMail;
        private TextBox txtMaas;
        private Label label10;
        private Label label6;
        private DateTimePicker dtGirisTarih;
        private Label label14;
        private DateTimePicker dtDogumTarih;
        private Label label16;
        private TextBox txtCinsiyet;
        private Label label15;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label17;
        private RichTextBox txtAdres;
        private Label label18;
        private GroupBox groupIslem;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnKaydet;
        private Button btnListele;
        private GroupBox groupKayıt;
        private DataGridView dataGridView1;
        private PersonelTakipDataSet personelTakipDataSet;
        private BindingSource tblPersonBindingSource;
        private PersonelTakipDataSetTableAdapters.TblPersonTableAdapter tblPersonTableAdapter;
        private DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perYasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perTCDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perSubeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn perMedeniHalDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn perPozisyonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perGirisTarihiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perCalismaDurumuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perTelefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perDogumTarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perCinsiyetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perDepartmanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perMailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perAdresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn perSgkDataGridViewTextBoxColumn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

