using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SAKLI_BAHCE_RESORT_V1
{
    public partial class FRMMusteriler : Form
    {
        public FRMMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7C01CUF;Initial Catalog=SaklıBahceResort;Integrated Security=True");

        private void verilerigoster()
        {

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text=oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void FRMMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void BTNDeneme_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void TXTOda_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLOda_Click(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id=int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TXTAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TXTSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CMBBXCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TXTTCNo.Text= listView1.SelectedItems[0].SubItems[4].Text;
            MSKDTXTTelefonNo.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TXTEPosta.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TXTOda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DTPCKRGirisTarihi.Text= listView1.SelectedItems[0].SubItems[8].Text;
            DTPCKRCikisTarihi.Text=listView1.SelectedItems[0].SubItems[9].Text;
            TXTFiyat.Text=listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void BTNSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Delete from MusteriEkle where Musteriid =(" + id + ")", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

            if (TXTOda.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TXTOda.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TXTOda.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TXTOda.Text == "201")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda201", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TXTOda.Text == "202")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda202", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TXTOda.Text == "203")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda203", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TXTOda.Text == "301")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from Oda301", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
        }

        private void BTNAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where adi like'%"+ TXTAraIsim.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            TXTAraIsim.Clear();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void BTNTemizle_Click(object sender, EventArgs e)
        {
            TXTAd.Clear();
            TXTSoyad.Clear();
            CMBBXCinsiyet.Text = "";
            TXTTCNo.Clear();
            MSKDTXTTelefonNo.Clear();
            TXTEPosta.Clear();
            TXTOda.Clear();
            DTPCKRGirisTarihi.Text = "";
            DTPCKRCikisTarihi.Text = "";
            TXTFiyat.Clear();
        }

        private void BTNGuncelle_Click(object sender, EventArgs e)
        {
            Regex regexmail = new Regex(@"^([a-zA-Z0-9]+)(@(gmail|hotmail).com)$");
            Regex regextel = new Regex(@"\((5[0-9]{2})\)\s([0-9]{3})-([0-9]{4})");
            Regex regextc = new Regex(@"^([1-9]{1})([0-9]{10})");
            Regex regexisim = new Regex(@"([a-zA-Z]{2,})");
            Regex regexsoyisim = new Regex(@"([a-zA-Z]{2,})");


            bool isValidmail = regexmail.IsMatch(TXTEPosta.Text);
            bool isValidtel = regextel.IsMatch(MSKDTXTTelefonNo.Text);
            bool isValidtc = regextc.IsMatch(TXTTCNo.Text);
            bool isValidisim = regexisim.IsMatch(TXTAd.Text);
            bool isValidsoyisim = regexsoyisim.IsMatch(TXTSoyad.Text);


            DateTime KucukTarih = Convert.ToDateTime(DTPCKRGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DTPCKRCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            if (!isValidisim)
            {
                MessageBox.Show("Lütfen adınızı kontrol ediniz");
            }
            else if (!isValidsoyisim)
            {
                MessageBox.Show("Lütfen soyadınızı kontrol ediniz.");
            }
            else if (!isValidtc)
            {
                MessageBox.Show("Lütfen TC numaranızı kontrol ediniz.");
            }
            else if (!isValidtel)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.");
            }
            else if (!isValidmail)
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.");
            }

            else if (Sonuc.TotalDays <= 0)
            {
                MessageBox.Show("Giriş tarihi ve Çıkış tarihlerini kontrol ediniz.");
            }
            else
            {
                if (TXTAd.Text == "" || TXTSoyad.Text == "" || CMBBXCinsiyet.Text == "" || TXTTCNo.Text == "" || MSKDTXTTelefonNo.Text == "" || TXTEPosta.Text == "" || TXTOda.Text == "" || DTPCKRGirisTarihi.Text == "" || DTPCKRCikisTarihi.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.");

                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update MusteriEkle set Adi ='" + TXTAd.Text + "',Soyadi = '" + TXTSoyad.Text + "',Cinsiyet = '" + CMBBXCinsiyet.Text + "',TC= '" + TXTTCNo.Text + "', Telefon= '" + MSKDTXTTelefonNo.Text + "',Mail= '" + TXTEPosta.Text + "', OdaNo = '" + TXTOda.Text + "', GirisTarihi= '" + DTPCKRGirisTarihi.Value.ToString("yyyy.MM.dd") + "', CikisTarihi='" + DTPCKRCikisTarihi.Value.ToString("yyyy.MM.dd") + "', Ucret='" + TXTFiyat.Text + "' where Musteriid= " + id + "", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    verilerigoster();
                }
            }
        
        
        }

        private void TXTTCNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

//Data Source=DESKTOP-7C01CUF;Initial Catalog=SaklıBahceResort;Integrated Security=True
// SqlCommand komut = new SqlCommand("Delete from MusteriEkle where Musteriid =(" + id + ")", baglanti);
