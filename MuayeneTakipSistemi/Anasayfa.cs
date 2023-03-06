using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuayeneTakipSistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432;" +
            "Database=DBMS_project; user ID=postgres; password=1234");

        void listele()
        {
            string sorgu = "select * from hasta";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void btnReceteGörüntüle_Click(object sender, EventArgs e)
        {
            recete recete=new recete();
            recete.Show();
            this.Hide();
        }


        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            hastalarim hastalarim = new hastalarim();
            hastalarim.Show();
            this.Hide();
        }

        private void btnRandevuKayıt_Click(object sender, EventArgs e)
        {
            randevu randevu = new randevu();
            randevu.Show();
            this.Hide();
        }

        private void btnMuayeneGecis_Click(object sender, EventArgs e)
        {
            muayene muayene = new muayene();
            muayene.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GecmisReceteler gecmisReceteler = new GecmisReceteler();
            gecmisReceteler.Show();
            this.Hide();
        }
    }
}
