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
    public partial class recete : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=DBMS_project; user ID=postgres; password=1234");

        public recete()
        {
            InitializeComponent();
        }
        void listele()
        {
            string receteDurum = "recete yazılacak";
            string sorgu = "select * from muayene where muayene_recete='" + receteDurum + "' ";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void listele2()
        {
            string sorgu2 = "select * from ilac ORDER BY ilac_id ASC ";
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds = new DataSet();
            npgsqlDataAdapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        private void btnReceteOnay_Click(object sender, EventArgs e)
        {
            //Muayene Tablosu Recete Updateleri
            baglanti.Open();
            NpgsqlCommand muayeneReceteli = new NpgsqlCommand("UPDATE muayene SET muayene_teşhis=@pTeshis, muayene_recete=@pRecete WHERE muayene_id=@pMuayeneId", baglanti);
            muayeneReceteli.Parameters.AddWithValue("@pMuayeneId", int.Parse(txtReceteId.Text));
            muayeneReceteli.Parameters.AddWithValue("@pTeshis", txtDoktorTani.Text);
            muayeneReceteli.Parameters.AddWithValue("@pRecete", "recete yazıldı");
            muayeneReceteli.ExecuteNonQuery();
            listele();


            //Randevu Tablosu Updateleri
            NpgsqlCommand muayeneOnay = new NpgsqlCommand("UPDATE randevu SET randevu_durum=@pRandevuDurum WHERE hasta_tc=@pTc", baglanti);
            muayeneOnay.Parameters.AddWithValue("@pTc", int.Parse(txtReceteId.Text));
            muayeneOnay.Parameters.AddWithValue("@pRandevuDurum", "Muayene Oldu");
            muayeneOnay.ExecuteNonQuery();




            //Recete Tablosu Insertleri
            NpgsqlCommand receteOnay = new NpgsqlCommand("insert into recete( recete_ad, recete_tarih, recete_doktor, recete_tanı, recete_ilac1, recete_ilac_adet1, recete_ilac2, recete_ilac_adet2,recete_ilac3, recete_ilac_adet3,recete_ilac4, recete_ilac_adet4,recete_ilac5, recete_ilac_adet5) " +
            "values (@pReceteAd, @pReceteTarih, @pReceteDoktor, @pReceteTanı, @pReceteİlac1, @pReceteAdet1, @pReceteİlac2, @pReceteAdet2, @pReceteİlac3, @pReceteAdet3, @pReceteİlac4, @pReceteAdet4, @pReceteİlac5, @pReceteAdet5)", baglanti);
            //receteOnay.Parameters.AddWithValue("@pReceteNo", int.Parse(txtReceteId.Text));
            receteOnay.Parameters.AddWithValue("@pReceteAd", int.Parse(txtTC.Text));
            receteOnay.Parameters.AddWithValue("@pReceteTarih", DateTime.Now);
            receteOnay.Parameters.AddWithValue("@pReceteDoktor", "Opr. Dr. Enes Yigit");
            receteOnay.Parameters.AddWithValue("@pReceteTanı", txtDoktorTani.Text);
            receteOnay.Parameters.AddWithValue("@pReceteİlac1", txtİlac.Text);
            receteOnay.Parameters.AddWithValue("@pReceteAdet1", int.Parse(comboBox1.Text));
            receteOnay.Parameters.AddWithValue("@pReceteİlac2", txtİlac2.Text);
            receteOnay.Parameters.AddWithValue("@pReceteAdet2", int.Parse(comboBox2.Text));
            receteOnay.Parameters.AddWithValue("@pReceteİlac3", txtİlac3.Text);
            receteOnay.Parameters.AddWithValue("@pReceteAdet3", int.Parse(comboBox3.Text));
            receteOnay.Parameters.AddWithValue("@pReceteİlac4", txtİlac4.Text);
            receteOnay.Parameters.AddWithValue("@pReceteAdet4", int.Parse(comboBox4.Text));
            receteOnay.Parameters.AddWithValue("@pReceteİlac5", txtİlac5.Text);
            receteOnay.Parameters.AddWithValue("@pReceteAdet5", int.Parse(comboBox5.Text)); 
            receteOnay.ExecuteNonQuery();
            baglanti.Close();
        }
        private void recete_Load(object sender, EventArgs e)
        {
            listele();
            listele2();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtReceteId.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtReceteTarihi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTC.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDoktorAd.Text = "Opr. Dr. Enes Yigit";
        }

        private void btnAnasayfaGecis_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
