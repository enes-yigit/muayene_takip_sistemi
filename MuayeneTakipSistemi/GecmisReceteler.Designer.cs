namespace MuayeneTakipSistemi
{
    partial class GecmisReceteler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAnasayfaGecis = new System.Windows.Forms.Button();
            this.btnGecmisRecete = new System.Windows.Forms.Button();
            this.btnGecmisRandevu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(-3, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 33);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAnasayfaGecis
            // 
            this.btnAnasayfaGecis.BackColor = System.Drawing.SystemColors.Info;
            this.btnAnasayfaGecis.Location = new System.Drawing.Point(113, 421);
            this.btnAnasayfaGecis.Name = "btnAnasayfaGecis";
            this.btnAnasayfaGecis.Size = new System.Drawing.Size(134, 31);
            this.btnAnasayfaGecis.TabIndex = 72;
            this.btnAnasayfaGecis.Text = "Anasayfa";
            this.btnAnasayfaGecis.UseVisualStyleBackColor = false;
            this.btnAnasayfaGecis.Click += new System.EventHandler(this.btnAnasayfaGecis_Click);
            // 
            // btnGecmisRecete
            // 
            this.btnGecmisRecete.BackColor = System.Drawing.Color.Honeydew;
            this.btnGecmisRecete.Location = new System.Drawing.Point(656, 421);
            this.btnGecmisRecete.Name = "btnGecmisRecete";
            this.btnGecmisRecete.Size = new System.Drawing.Size(144, 31);
            this.btnGecmisRecete.TabIndex = 73;
            this.btnGecmisRecete.Text = "Geçmiş Reçeteler";
            this.btnGecmisRecete.UseVisualStyleBackColor = false;
            this.btnGecmisRecete.Click += new System.EventHandler(this.btnGecmisRecete_Click);
            // 
            // btnGecmisRandevu
            // 
            this.btnGecmisRandevu.BackColor = System.Drawing.Color.Honeydew;
            this.btnGecmisRandevu.Location = new System.Drawing.Point(519, 421);
            this.btnGecmisRandevu.Name = "btnGecmisRandevu";
            this.btnGecmisRandevu.Size = new System.Drawing.Size(141, 31);
            this.btnGecmisRandevu.TabIndex = 74;
            this.btnGecmisRandevu.Text = "Geçmiş Randevular";
            this.btnGecmisRandevu.UseVisualStyleBackColor = false;
            this.btnGecmisRandevu.Click += new System.EventHandler(this.btnGecmisRandevu_Click);
            // 
            // GecmisReceteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGecmisRandevu);
            this.Controls.Add(this.btnGecmisRecete);
            this.Controls.Add(this.btnAnasayfaGecis);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GecmisReceteler";
            this.Text = "GecmisKayitlar";
            this.Load += new System.EventHandler(this.GecmisReceteler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAnasayfaGecis;
        private System.Windows.Forms.Button btnGecmisRecete;
        private System.Windows.Forms.Button btnGecmisRandevu;
    }
}