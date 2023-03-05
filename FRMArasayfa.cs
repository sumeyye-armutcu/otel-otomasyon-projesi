using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAKLI_BAHCE_RESORT_V1
{
    public partial class FRMArasayfa : Form
    {
        public FRMArasayfa()
        {
            InitializeComponent();
        }

        private void BTNAnasayfOdalar_Click(object sender, EventArgs e)
        {
            FRMOdalar fr = new FRMOdalar();
            fr.Show();
        }

        private void BTNMusteriler_Click(object sender, EventArgs e)
        {
            FRMMusteriler fr = new FRMMusteriler();
            fr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBLTarih.Text = DateTime.Now.ToLongDateString();
            LBLSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void FRMArasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void BTNCİKİS_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }
    }
}
