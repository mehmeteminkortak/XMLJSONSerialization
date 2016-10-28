namespace XMLJSON
{
    partial class Form1
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
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nMaas = new System.Windows.Forms.NumericUpDown();
            this.nKilo = new System.Windows.Forms.NumericUpDown();
            this.nBoy = new System.Windows.Forms.NumericUpDown();
            this.cbKadinMi = new System.Windows.Forms.CheckBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXmlDisaAktar = new System.Windows.Forms.Button();
            this.btnXmlIceAktar = new System.Windows.Forms.Button();
            this.btnJsonAktar = new System.Windows.Forms.Button();
            this.btnJsonAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBoy)).BeginInit();
            this.SuspendLayout();
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.Color.Maroon;
            this.pbResim.Location = new System.Drawing.Point(158, 12);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(127, 125);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 57;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(117, 234);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 35);
            this.btnGuncelle.TabIndex = 50;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(291, 12);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(190, 20);
            this.txtArama.TabIndex = 48;
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.Location = new System.Drawing.Point(291, 48);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(190, 303);
            this.lstKisiler.TabIndex = 49;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(11, 234);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 35);
            this.btnKaydet.TabIndex = 47;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nMaas
            // 
            this.nMaas.Location = new System.Drawing.Point(51, 158);
            this.nMaas.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.nMaas.Minimum = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.nMaas.Name = "nMaas";
            this.nMaas.Size = new System.Drawing.Size(100, 20);
            this.nMaas.TabIndex = 44;
            this.nMaas.Value = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            // 
            // nKilo
            // 
            this.nKilo.Location = new System.Drawing.Point(51, 117);
            this.nKilo.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nKilo.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nKilo.Name = "nKilo";
            this.nKilo.Size = new System.Drawing.Size(100, 20);
            this.nKilo.TabIndex = 43;
            this.nKilo.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // nBoy
            // 
            this.nBoy.Location = new System.Drawing.Point(51, 91);
            this.nBoy.Maximum = new decimal(new int[] {
            220,
            0,
            0,
            0});
            this.nBoy.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nBoy.Name = "nBoy";
            this.nBoy.Size = new System.Drawing.Size(100, 20);
            this.nBoy.TabIndex = 42;
            this.nBoy.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbKadinMi
            // 
            this.cbKadinMi.AutoSize = true;
            this.cbKadinMi.Location = new System.Drawing.Point(168, 161);
            this.cbKadinMi.Name = "cbKadinMi";
            this.cbKadinMi.Size = new System.Drawing.Size(53, 17);
            this.cbKadinMi.TabIndex = 45;
            this.cbKadinMi.Text = "Kadın";
            this.cbKadinMi.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(85, 193);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 46;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(51, 50);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(51, 9);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Maas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Kilo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Boy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ad";
            // 
            // btnXmlDisaAktar
            // 
            this.btnXmlDisaAktar.Location = new System.Drawing.Point(12, 275);
            this.btnXmlDisaAktar.Name = "btnXmlDisaAktar";
            this.btnXmlDisaAktar.Size = new System.Drawing.Size(88, 35);
            this.btnXmlDisaAktar.TabIndex = 58;
            this.btnXmlDisaAktar.Text = "XML Dışa Aktar";
            this.btnXmlDisaAktar.UseVisualStyleBackColor = true;
            this.btnXmlDisaAktar.Click += new System.EventHandler(this.btnXmlDisaAktar_Click);
            // 
            // btnXmlIceAktar
            // 
            this.btnXmlIceAktar.Location = new System.Drawing.Point(117, 275);
            this.btnXmlIceAktar.Name = "btnXmlIceAktar";
            this.btnXmlIceAktar.Size = new System.Drawing.Size(88, 35);
            this.btnXmlIceAktar.TabIndex = 58;
            this.btnXmlIceAktar.Text = "XML İçe Aktar";
            this.btnXmlIceAktar.UseVisualStyleBackColor = true;
            this.btnXmlIceAktar.Click += new System.EventHandler(this.btnXmlIceAktar_Click);
            // 
            // btnJsonAktar
            // 
            this.btnJsonAktar.Location = new System.Drawing.Point(11, 317);
            this.btnJsonAktar.Name = "btnJsonAktar";
            this.btnJsonAktar.Size = new System.Drawing.Size(88, 34);
            this.btnJsonAktar.TabIndex = 59;
            this.btnJsonAktar.Text = "Json Aktar";
            this.btnJsonAktar.UseVisualStyleBackColor = true;
            this.btnJsonAktar.Click += new System.EventHandler(this.btnJsonAktar_Click);
            // 
            // btnJsonAl
            // 
            this.btnJsonAl.Location = new System.Drawing.Point(117, 317);
            this.btnJsonAl.Name = "btnJsonAl";
            this.btnJsonAl.Size = new System.Drawing.Size(88, 34);
            this.btnJsonAl.TabIndex = 59;
            this.btnJsonAl.Text = "JSon Al";
            this.btnJsonAl.UseVisualStyleBackColor = true;
            this.btnJsonAl.Click += new System.EventHandler(this.btnJsonAl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 385);
            this.Controls.Add(this.btnJsonAl);
            this.Controls.Add(this.btnJsonAktar);
            this.Controls.Add(this.btnXmlIceAktar);
            this.Controls.Add(this.btnXmlDisaAktar);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nMaas);
            this.Controls.Add(this.nKilo);
            this.Controls.Add(this.nBoy);
            this.Controls.Add(this.cbKadinMi);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBoy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nMaas;
        private System.Windows.Forms.NumericUpDown nKilo;
        private System.Windows.Forms.NumericUpDown nBoy;
        private System.Windows.Forms.CheckBox cbKadinMi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXmlDisaAktar;
        private System.Windows.Forms.Button btnXmlIceAktar;
        private System.Windows.Forms.Button btnJsonAktar;
        private System.Windows.Forms.Button btnJsonAl;
    }
}

