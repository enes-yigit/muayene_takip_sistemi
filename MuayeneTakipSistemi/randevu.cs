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
    public partial class randevu : Form
    {
        public randevu()
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
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand check = new NpgsqlCommand("SELECT * FROM randevu WHERE hasta_tc = @pTc AND randevu_tarih = @pTarih", baglanti);
            check.Parameters.AddWithValue("@pTc", int.Parse(txtTcKimlik.Text));
            check.Parameters.AddWithValue("@pTarih", DateTime.Parse(dateTimePicker1.Text));
            NpgsqlDataReader reader = check.ExecuteReader();

            // Aynı Tarihte Randevu Alınmaması İçin Yazılan Şahane check Kodu
            
            if (reader.HasRows)
            {
                MessageBox.Show("Aynı tarihte aynı kişi için randevu alınamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Close();
                baglanti.Open();
                NpgsqlCommand randevuKayit = new NpgsqlCommand("insert into randevu (hasta_tc, randevu_ad, randevu_soyad, randevu_doktor, randevu_sikayet, randevu_tarih, randevu_durum)" +
        " values (@pTc, @pAd, @pSoyad, @pDoktor, @pSikayet, @pTarih, @pRandevuDurum)", baglanti);

                randevuKayit.Parameters.AddWithValue("@pTc", int.Parse(txtTcKimlik.Text));
                randevuKayit.Parameters.AddWithValue("@pAd", txtAd.Text);
                randevuKayit.Parameters.AddWithValue("@pSoyad", txtSoyad.Text);
                randevuKayit.Parameters.AddWithValue("@pDoktor", txtDoktor.Text);
                randevuKayit.Parameters.AddWithValue("@pSikayet", txtSikayet.Text);
                randevuKayit.Parameters.AddWithValue("pRandevuDurum", "Bekliyor");
                randevuKayit.Parameters.AddWithValue("@pTarih", DateTime.Parse(dateTimePicker1.Text));
                randevuKayit.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Randevunuz Oluşturulmuştur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }

        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtTcKimlik.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDoktor.Text = "Opr. Dr. Enes Yigit";

            //txtMedeniDurum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //txtTelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //txtAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }
        private void randevu_Load(object sender, EventArgs e)
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
