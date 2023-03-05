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
    public partial class FRMYeniMusteriEkle : Form
    {
        public FRMYeniMusteriEkle()
        {
            InitializeComponent();
            
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7C01CUF;Initial Catalog=SaklıBahceResort;Integrated Security=True");
        
        
        

        private void FRMYeniMusteriEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101 ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BTN101.Text = "101 \n" + oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN101.Text != "101")
            {
                BTN101.BackColor = Color.FromArgb(139, 0, 0);
                BTN101.Text = "101";
                BTN101.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102 ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BTN102.Text = "102 \n" + oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN102.Text != "102")
            {
                BTN102.BackColor = Color.FromArgb(139, 0, 0);
                BTN102.Text = "102";
                BTN102.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103 ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BTN103.Text = "103 \n" + oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN103.Text != "103")
            {
                BTN103.BackColor = Color.FromArgb(139, 0, 0);
                BTN103.Text = "103";
                BTN103.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda201 ", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BTN201.Text = "201 \n" + oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN201.Text != "201")
            {
                BTN201.BackColor = Color.FromArgb(139, 0, 0);
                BTN201.Text = "201";
                BTN201.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda202 ", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BTN202.Text = "202 \n" + oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN202.Text != "202")
            {
                BTN202.BackColor = Color.FromArgb(139, 0, 0);
                BTN202.Text = "202";
                BTN202.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda203 ", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BTN203.Text = "203 \n" + oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN203.Text != "203")
            {
                BTN203.BackColor = Color.FromArgb(139, 0, 0);
                BTN203.Text = "203";
                BTN203.Enabled = false;

            }

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda301 ", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BTN301.Text = "301 \n" + oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN301.Text != "301")
            {
                BTN301.BackColor = Color.FromArgb(139, 0, 0);
                
                BTN301.Text = "301";
                BTN301.Enabled = false;
                
            } 
        } 

        private void LBLTelNo_Click(object sender, EventArgs e)
        {

        }

        private void LBLEPosta_Click(object sender, EventArgs e)
        {

        }

        private void TXTAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLGirisTarihi_Click(object sender, EventArgs e)
        {

        }

        private void DTPCKRGirisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTNAileOdaları_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aile odaları (Orman Manzaralı) : Max 2 Yetiskin + 3 Çocuk \n -Günlük Fiyat 400TL");
        }

        private void BTN101_Click(object sender, EventArgs e)
        {
            TXTOda.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + TXTAd.Text + "','" + TXTSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTN102_Click(object sender, EventArgs e)
        {
            TXTOda.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + TXTAd.Text + "','" + TXTSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTN103_Click(object sender, EventArgs e)
        {
            TXTOda.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + TXTAd.Text + "','" + TXTSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTN201_Click(object sender, EventArgs e)
        {
            TXTOda.Text = "201";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda201 (Adi,Soyadi) values ('" + TXTAd.Text + "','" + TXTSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTN202_Click(object sender, EventArgs e)
        {
            TXTOda.Text = "202";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda202 (Adi,Soyadi) values ('" + TXTAd.Text + "','" + TXTSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTN203_Click(object sender, EventArgs e)
        {
            TXTOda.Text = "203";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda203 (Adi,Soyadi) values ('" + TXTAd.Text + "','" + TXTSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTN301_Click(object sender, EventArgs e)
        {
            TXTOda.Text = "301";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda301 (Adi,Soyadi) values ('" + TXTAd.Text + "','" + TXTSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BTNBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beyaz odalar boştur.");
        }

        private void BTNDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı odalar doludur. ");
        }

        private void BTNTekKisilikOdalar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tek Kisilik Odalar: Max 1 Yetişkin \n -Günlük Fiyat 200TL" );
        }

        private void BTNKralDairesi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kral Dairesi(Oda içi Havuz + Deniz Manzaralı) : Max 2 Yetişkin \n -Günlük Fiyat 1000TL");
        }

        private void DTPCKRCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret=0;
            DateTime KucukTarih = Convert.ToDateTime(DTPCKRGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DTPCKRCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            TXTKalinacakGun.Text = Sonuc.TotalDays.ToString();

            
                if (TXTOda.Text == "101")
                {
                    Ucret = Convert.ToInt32(TXTKalinacakGun.Text) * 400;

                }
                else if (TXTOda.Text == "102")
                {
                    Ucret = Convert.ToInt32(TXTKalinacakGun.Text) * 400;
                }
                else if (TXTOda.Text == "103")
                {
                    Ucret = Convert.ToInt32(TXTKalinacakGun.Text) * 400;
                }
                else if (TXTOda.Text == "201")
                {
                    Ucret = Convert.ToInt32(TXTKalinacakGun.Text) * 200;
                }
                else if (TXTOda.Text == "202")
                {
                    Ucret = Convert.ToInt32(TXTKalinacakGun.Text) * 200;
                }
                else if (TXTOda.Text == "203")
                {
                    Ucret = Convert.ToInt32(TXTKalinacakGun.Text) * 200;
                }
                else if (TXTOda.Text == "301")
                {
                    Ucret = Convert.ToInt32(TXTKalinacakGun.Text) * 1000;
                }

                TXTFiyat.Text = Ucret.ToString();
            


        }

        private void TXTFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            Regex regexmail = new Regex(@"^([a-zA-Z0-9]+)(@(gmail|hotmail).com)$");
            Regex regextel = new Regex(@"\((5[0-9]{2})\)\s([0-9]{3})-([0-9]{4})");
            Regex regextc = new Regex(@"^([1-9]{1})([0-9]{10})$");
            Regex regexisim = new Regex(@"^([a-zA-Z]{2,})$");
            Regex regexsoyisim = new Regex(@"^([a-zA-Z]{2,})$");
            

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
            else if(!isValidtc)
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
            
            else if (Sonuc.TotalDays<=0)
            {
                MessageBox.Show("Giriş tarihi ve Çıkış tarihlerini kontrol ediniz.");
            }
            else
            {
                
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,TC,Telefon,Mail,OdaNo,GirisTarihi,CikisTarihi,Ucret) values('" + TXTAd.Text.ToString() + "','" + TXTSoyad.Text.ToString() + "','" + CMBBXCinsiyet.Text.ToString() + "','" + TXTTCNo.Text.ToString() + "','" + MSKDTXTTelefonNo.Text.ToString() + "','" + TXTEPosta.Text.ToString() + "','" + TXTOda.Text.ToString() + "','" + DTPCKRGirisTarihi.Value.ToString("yyyy.MM.dd") + "','" + DTPCKRCikisTarihi.Value.ToString("yyyy.MM.dd") + "','" + TXTFiyat.Text.ToString() + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Müşteri kaydı tamamlandı.");

                    TXTAd.Clear();
                    TXTSoyad.Clear();
                    CMBBXCinsiyet.Text = "";
                    TXTTCNo.Clear();
                    MSKDTXTTelefonNo.Clear();
                    TXTEPosta.Clear();
                    TXTOda.Clear();
                    DTPCKRGirisTarihi.Text = "";
                    DTPCKRCikisTarihi.Text = "";
                    TXTKalinacakGun.Clear();
                    TXTFiyat.Clear();

                
            }

           
           
        }
    }
}



//Data Source=DESKTOP-7C01CUF;Initial Catalog=SaklıBahceResort;Integrated Security=True
