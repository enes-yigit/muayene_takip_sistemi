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
    public partial class hastalarim : Form
    {

        public hastalarim()
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
            dataGridView1.DataSource = ds.Tables[0];
        }


 


        private void txtHastaKayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand hastaKayit = new NpgsqlCommand("insert into hasta (hasta_tc, hasta_ad, hasta_soyad, hasta_dogum_yeri, hasta_dogum_tarihi, hasta_medeni_durum, hasta_adres, hasta_telefon)" +
                " values (@pTc, @pAd, @pSoyad, @pDogumYeri, @pDogumTarihi, @pMedeniDurum, @pAdres ,@pTelefon)", baglanti);
            hastaKayit.Parameters.AddWithValue("@pTc", int.Parse(txtTcKimlik.Text));
            hastaKayit.Parameters.AddWithValue("@pAd", txtAd.Text);
            hastaKayit.Parameters.AddWithValue("@pSoyad", txtSoyad.Text);
            hastaKayit.Parameters.AddWithValue("@pDogumYeri", txtDogumYeri.Text);
            hastaKayit.Parameters.AddWithValue("@pDogumTarihi", DateTime.Parse(txtDogumTarihi.Text));
            hastaKayit.Parameters.AddWithValue("@pMedeniDurum", txtMedeniDurum.Text);
            hastaKayit.Parameters.AddWithValue("@pAdres", txtAdres.Text);
            hastaKayit.Parameters.AddWithValue("@pTelefon", int.Parse(txtTelefon.Text));
            hastaKayit.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand hastaSil = new NpgsqlCommand("delete from hasta where hasta_tc=@pTc", baglanti);
            hastaSil.Parameters.AddWithValue("@pTc", int.Parse(txtTcKimlik.Text));
            hastaSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        //private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtTcKimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //    txtDogumYeri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //    txtDogumTarihi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //    txtMedeniDurum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        //    txtTelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        //    txtAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        //}
        private void hastalarim_Load(object sender, EventArgs e)
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
    }
}
