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
    public partial class FRMAdminGiris : Form
    {
        public FRMAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7C01CUF;Initial Catalog=SaklýBahceResort;Integrated Security=True");

        private void FRMKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void BTNGirisYap_Click(object sender, EventArgs e)
        {
            

            if(TXTKullaniciAdi.Text =="admin" && TXTSifre.Text =="12345")
            {
                FRMArasayfa fr1 = new FRMArasayfa();
                fr1.Show();
                this.Hide();
                

            }
            else if(TXTKullaniciAdi.Text == "admin" && TXTSifre.Text != "12345")
            {
                MessageBox.Show("Þifre yanlýþ, tekrar deneyiniz.");
            }
            else if(TXTKullaniciAdi.Text != "admin" && TXTSifre.Text == "12345")
            {
                MessageBox.Show("Kullanýcý adý yanlýþ, tekrar deneyiniz.");
            }
            else
            {
                MessageBox.Show("Tekrar deneyiniz.");
            }
           
        }
    }
}