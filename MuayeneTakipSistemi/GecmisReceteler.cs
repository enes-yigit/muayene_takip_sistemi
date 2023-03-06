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
    public partial class GecmisReceteler : Form
    {
        public GecmisReceteler()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DBMS_project; user ID=postgres; password=1234");
        void listele()
        {
            string sorgu = "select * from recete";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void listele2()
        {
            string sorgu = "select * from randevu";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void GecmisReceteler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnasayfaGecis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnGecmisRandevu_Click(object sender, EventArgs e)
        {
            listele2();
        }

        private void btnGecmisRecete_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
