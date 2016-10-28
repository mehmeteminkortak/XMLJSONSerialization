using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kisi> kisiler = new List<Kisi>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                kisiler.Add(new Kisi()
                {
                    Ad = txtAd.Text,
                    Boy = Convert.ToInt32(nBoy.Value),
                    DogumTarihi = dtpDogumTarihi.Value,
                    KadinMi = cbKadinMi.Checked,
                    Kilo = Convert.ToInt32(nKilo.Value),
                    Maas = nMaas.Value,
                    Soyad = txtSoyad.Text,
                    Fotograf = string.IsNullOrEmpty(pbResim.ImageLocation) ? null : File.ReadAllBytes(pbResim.ImageLocation)
                });
                ListeyiDoldur(kisiler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Temizle();
            }
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is CheckBox)
                    (item as CheckBox).Checked = false;
                else if (item is NumericUpDown)
                    (item as NumericUpDown).Value = (item as NumericUpDown).Minimum;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is PictureBox)
                    (item as PictureBox).ImageLocation = string.Empty;
            }
        }

        private void ListeyiDoldur(List<Kisi> kisiler)
        {
            lstKisiler.Items.Clear();
            kisiler.ForEach(item => lstKisiler.Items.Add(item));
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir resim dosyası seçiniz";
            dosyaAc.Filter = "JPG Formatı *.jpg | *.jpg; *.png";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "";
            dosyaAc.Multiselect = false;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
                pbResim.ImageLocation = dosyaAc.FileName;
            else
                pbResim.ImageLocation = string.Empty;
        }
        public Kisi SeciliKisi { get; set; }
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null)
            {
                SeciliKisi = null;
                return;
            }
            SeciliKisi = lstKisiler.SelectedItem as Kisi;
            txtAd.Text = SeciliKisi.Ad;
            txtSoyad.Text = SeciliKisi.Soyad;
            nMaas.Value = SeciliKisi.Maas;
            nBoy.Value = SeciliKisi.Boy;
            nKilo.Value = SeciliKisi.Kilo;
            dtpDogumTarihi.Value = SeciliKisi.DogumTarihi;
            cbKadinMi.Checked = SeciliKisi.KadinMi;

            if (SeciliKisi.Fotograf == null)
                pbResim.ImageLocation = string.Empty;
            else
            {
                MemoryStream hamResim = new MemoryStream(SeciliKisi.Fotograf);
                pbResim.Image = Image.FromStream(hamResim);
            }
        }

        private void btnXmlDisaAktar_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Kişi listesini XML olarak kaydet";
            dosyaKaydet.Filter = "XML Formatı | *.xml";
            dosyaKaydet.FileName = "";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter writer = new StreamWriter(dosyaKaydet.FileName);
                serializer.Serialize(writer, kisiler);
                writer.Close();
                writer.Dispose();
                MessageBox.Show("XML dosyası oluşturuldu");
            }
        }
        private void btnXmlIceAktar_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir XML Dosyası seçin";
            dosyaAc.Filter = "XML | *.xml";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "";
            dosyaAc.Multiselect = false;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextReader reader = new StreamReader(dosyaAc.FileName);
                var okunan = serializer.Deserialize(reader) as List<Kisi>;
                if (okunan.Count > 0)
                    kisiler.AddRange(okunan);
                reader.Close();
                reader.Dispose();
                ListeyiDoldur(kisiler);
                MessageBox.Show("XML data içeriye aktarıldı");
            }
        }

        private void btnJsonAktar_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyası kaydedin";
            dosyaKaydet.Filter = "(*.json) | *.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "";
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(dosyaKaydet.FileName, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(dosya);
                writer.Write(JsonConvert.SerializeObject(kisiler));
                writer.Close();
                MessageBox.Show("Json dosyası oluşturuldu");
            }
        }

        private void btnJsonAl_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir Json dosyası seçin";
            dosyaAc.Filter = "(*.Json) | *.Json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "";
            dosyaAc.Multiselect = false;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.OpenRead(dosyaAc.FileName);
                StreamReader reader = new StreamReader(dosya);
                string dosyaIcerigi = reader.ReadToEnd();
                reader.Close();
                //var okunan = JsonConvert.DeserializeObject(dosyaIcerigi) as List<Kisi>;
                kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);
                ListeyiDoldur(kisiler);
            }
        }
    }
}
