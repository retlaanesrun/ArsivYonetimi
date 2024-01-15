using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace ArsivYonetimi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullanici.Text.Trim()) || string.IsNullOrEmpty(txtParola.Text.Trim()))
            {
                MessageBox.Show("Kullanýcý adý ve parola boþ býrakýlmamalýdýr!", "Arþiv Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kullaniciAdi = txtKullanici.Text;
            byte[] parolaByte = Encoding.UTF8.GetBytes(txtParola.Text);

            using SHA256 sha256 = SHA256.Create();
            byte[] hashByte = sha256.ComputeHash(parolaByte);
            string parolaHash = BitConverter.ToString(hashByte).Replace("-", string.Empty).ToLower();

            string sorgu = "SELECT * FROM personeller WHERE kullaniciAdi = @kadi";
            MySqlCommand komut = new(sorgu, Program.dbcon);
            komut.Parameters.AddWithValue("@kadi", kullaniciAdi);

            using MySqlDataReader reader = komut.ExecuteReader();
            string parolaHashDb = "";
            if (reader.Read())
            {
                parolaHashDb = reader["sifreHash"].ToString();
            }

            if (parolaHash == parolaHashDb)
            {
                Program.kullaniciAdi = txtKullanici.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                txtParola.Clear();
                lblHata.Visible = true;
            }
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            lblHata.Visible = lblHata.Visible && false;
        }

        private void txtKullanici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGiris_Click(sender, e);
        }
    }
}