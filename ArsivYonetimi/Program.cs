using MySql.Data.MySqlClient;

namespace ArsivYonetimi
{
    internal static class Program
    {
        public static MySqlConnection dbcon = new MySqlConnection("Server=172.21.54.148;Port=3306;Database=NYP23-5;User=NYP23-5;Password=Uludag9512357.;");
        public static string kullaniciAdi;

        [STAThread]
        static void Main()
        {
            DialogResult sonuc;
            ApplicationConfiguration.Initialize();
            dbcon.Open();
            using (Form girisFormu = new LoginForm())
            {
                sonuc = girisFormu.ShowDialog();
            }

            if (sonuc == DialogResult.OK)
                Application.Run(new Dashboard());
        }
    }
}