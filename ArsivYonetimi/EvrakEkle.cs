using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ArsivYonetimi
{
    public partial class EvrakEkle : Form
    {
        public EvrakEkle()
        {
            InitializeComponent();
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = $"Saat: {DateTime.Now:HH:mm}";
        }

        private void EvrakEkle_Load(object sender, EventArgs e)
        {
            string sorguEvrakTuru = "SELECT * FROM evrak_turleri";
            MySqlCommand komut = new(sorguEvrakTuru, Program.dbcon);
            saat.Start();
            saat_Tick(this, new EventArgs());

            using MySqlDataReader reader = komut.ExecuteReader();
            List<string> resultList = new List<string>();

            while (reader.Read())
            {
                string columnValue = reader["turAdi"].ToString();
                cmbEvrakTuru.Items.Add(columnValue);
            }
        }
    }
}
