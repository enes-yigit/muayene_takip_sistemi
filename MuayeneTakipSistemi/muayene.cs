using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuayeneTakipSistemi
{
    public partial class muayene : Form
    {
        public muayene()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432;" +
"Database=DBMS_project; user ID=postgres; password=1234");


        public DateTime zaman { get; set; }
        

        void listele()
        {
            string sorgu = "select * from randevu";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }



        private void btnMuayeneOnay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand muayeneOnay = new NpgsqlCommand("UPDATE randevu SET randevu_durum=@pRandevuDurum WHERE hasta_tc=@pTc", baglanti);
            muayeneOnay.Parameters.AddWithValue("@pTc", int.Parse(lblTcKimlik.Text));
            muayeneOnay.Parameters.AddWithValue("@pRandevuDurum", "Muayene Oldu");
            muayeneOnay.ExecuteNonQuery();

            NpgsqlCommand muayeneTeşhis = new NpgsqlCommand("insert into muayene(hasta_tc, muayene_tarih, muayene_sikayet, muayene_teşhis, muayene_recete, muayene_sirano) " +
                "values (@pTc, @pTarih, @pSikayet, @pTeşhis, @pRecete, @pSiraNo)", baglanti);
            muayeneTeşhis.Parameters.AddWithValue("@pTc", int.Parse(lblTcKimlik.Text));
            muayeneTeşhis.Parameters.AddWithValue("@pTarih", DateTime.Now);
            muayeneTeşhis.Parameters.AddWithValue("@pSikayet", lblHastaSikayet.Text);
            muayeneTeşhis.Parameters.AddWithValue("@pTeşhis", txtTeşhis.Text);
            muayeneTeşhis.Parameters.AddWithValue("@pRecete", "recete yok");
            muayeneTeşhis.Parameters.AddWithValue("@pSiraNo", int.Parse(lblSiraNo.Text));
            muayeneTeşhis.ExecuteNonQuery();
            listele();
            baglanti.Close();
        }

        private void btnReceteYaz_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            NpgsqlCommand muayeneRecete = new NpgsqlCommand("insert into muayene(hasta_tc, muayene_tarih, muayene_sikayet, muayene_teşhis, muayene_recete, muayene_sirano) " +
               "values (@pTc, @pTarih, @pSikayet, @pTeşhis, @pRecete, @pSiraNo)", baglanti);
            muayeneRecete.Parameters.AddWithValue("@pTc", int.Parse(lblTcKimlik.Text));
            muayeneRecete.Parameters.AddWithValue("@pTarih", DateTime.Now);
            muayeneRecete.Parameters.AddWithValue("@pSikayet", lblHastaSikayet.Text);
            muayeneRecete.Parameters.AddWithValue("@pTeşhis", txtTeşhis.Text);
            muayeneRecete.Parameters.AddWithValue("@pRecete", "recete yazılacak");
            muayeneRecete.Parameters.AddWithValue("@pSiraNo", int.Parse(lblSiraNo.Text));
            muayeneRecete.ExecuteNonQuery();
            listele();
            recete recete = new recete();
            recete.Show();
        }









        private void muayene_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.UtcNow.ToString();
            listele(); 
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblTarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            lblTcKimlik.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lblHastaAd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblHastaSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblDoktor.Text = "Opr. Dr. Enes Yigit";
            lblHastaSikayet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblSiraNo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

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

    }
}
