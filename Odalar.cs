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

namespace SAKLI_BAHCE_RESORT_V1
{
    public partial class FRMOdalar : Form
    {
        public FRMOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7C01CUF;Initial Catalog=SaklıBahceResort;Integrated Security=True");

        private void FRMOdalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101 ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BTN101_2.Text="101 \n"+ oku1["Adi"].ToString()+ " "+ oku1["Soyadi"].ToString();
            }
            baglanti.Close();

            if(BTN101_2.Text != "101")
            {
                BTN101_2.BackColor = Color.FromArgb(139, 0, 0); 
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102 ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BTN102_2.Text = "102 \n" + oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN102_2.Text != "102")
            {
                BTN102_2.BackColor = Color.FromArgb(139, 0, 0);
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103 ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BTN103_2.Text = "103 \n" + oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN103_2.Text != "103")
            {
                BTN103_2.BackColor = Color.FromArgb(139, 0, 0);
            }

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda201 ", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BTN201_2.Text = "201 \n" + oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN201_2.Text != "201")
            {
                BTN201_2.BackColor = Color.FromArgb(139, 0, 0);
            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda202 ", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BTN202_2.Text = "202 \n" + oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN202_2.Text != "202")
            {
                BTN202_2.BackColor = Color.FromArgb(139, 0, 0);
            }

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda203 ", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BTN203_2.Text = "203 \n" + oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN203_2.Text != "203")
            {
                BTN203_2.BackColor = Color.FromArgb(139, 0, 0);
            }

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda301 ", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BTN301_2.Text = "301 \n" + oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BTN301_2.Text != "301")
            {
                BTN301_2.BackColor = Color.FromArgb(139, 0, 0);
            }

        }

        private void BTNBosOda2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beyaz odalar boştur.");
        }

        private void BTNDoluOda2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı odalar doludur.");
        }
    }
}
