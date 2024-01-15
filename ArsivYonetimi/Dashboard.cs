using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArsivYonetimi
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblGreet.Text = $"Merhaba, {Program.kullaniciAdi}.";
            saat.Start();
            saat_Tick(this, new EventArgs());
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = $"Saat: {DateTime.Now:HH:mm}";
        }

        private void pnlEvrakEkle_Click(object sender, EventArgs e)
        {
            using EvrakEkle form = new EvrakEkle();
            form.ShowDialog();
        }

        private void pnlEvrakListele_Click(object sender, EventArgs e)
        {
            using EvrakListele form = new EvrakListele();
            form.ShowDialog();
        }

        private void pnlErisimGecmisi_Click(object sender, EventArgs e)
        {
            using ErisimGecmisi form = new ErisimGecmisi();
            form.ShowDialog();
        }
    }
}
