using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SAKLI_BAHCE_RESORT_V1
{
    public partial class FRMAnasayfa : Form
    {
        public FRMAnasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BTNAnasayfaAdminGiris_Click(object sender, EventArgs e)
        {
            FRMAdminGiris fr = new FRMAdminGiris();
            fr.Show();
            
            
        }

        private void BTNAnasayfaMusteriEkle_Click(object sender, EventArgs e)
        {
            FRMYeniMusteriEkle fr = new FRMYeniMusteriEkle();
            fr.Show();
            
        }

       
    

        private void BTNHakımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saklı Bahçe Resort - ANKARA \n İletişim: 0553 146 4224");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBLTarih.Text = DateTime.Now.ToLongDateString();
            LBLSaat.Text = DateTime .Now.ToLongTimeString();
        }

        private void LBLTarih_Click(object sender, EventArgs e)
        {

        }

        private void LBLSaat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LNKLBLHavaDurumu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void BTNHavaDurumu_Click(object sender, EventArgs e)
        {
            var parameter = new ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://havadurumu15gunluk.xyz/havadurumu30gunluk/90/ankara-hava-durumu-30-gunluk.html" };
            Process.Start(parameter);
        }
    }
}

