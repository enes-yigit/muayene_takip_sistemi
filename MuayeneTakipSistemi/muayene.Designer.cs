namespace MuayeneTakipSistemi
{
    partial class muayene
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
            this.label14 = new System.Windows.Forms.Label();
            this.lblSikayet = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.lblSayın = new System.Windows.Forms.Label();
            this.lblHastaSoyad = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.lblHastaSikayet = new System.Windows.Forms.Label();
            this.btnAnasayfaGecis = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReceteYaz = new System.Windows.Forms.Button();
            this.txtTeşhis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSiraNo = new System.Windows.Forms.Label();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.btnMuayeneOnay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(452, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(180, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 24);
            this.label14.TabIndex = 60;
            this.label14.Text = ":";
            // 
            // lblSikayet
            // 
            this.lblSikayet.AutoSize = true;
            this.lblSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSikayet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSikayet.Location = new System.Drawing.Point(113, 181);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(61, 20);
            this.lblSikayet.TabIndex = 53;
            this.lblSikayet.Text = "Şikayet";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTarih.Location = new System.Drawing.Point(894, 82);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(150, 21);
            this.lblTarih.TabIndex = 52;
            this.lblTarih.Text = "Muayene Tarihi";
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoktor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDoktor.Location = new System.Drawing.Point(9, 2);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(58, 21);
            this.lblDoktor.TabIndex = 51;
            this.lblDoktor.Text = "Doktor";
            // 
            // lblSayın
            // 
            this.lblSayın.AutoSize = true;
            this.lblSayın.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayın.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSayın.Location = new System.Drawing.Point(9, 55);
            this.lblSayın.Name = "lblSayın";
            this.lblSayın.Size = new System.Drawing.Size(48, 21);
            this.lblSayın.TabIndex = 50;
            this.lblSayın.Text = "Sayın";
            // 
            // lblHastaSoyad
            // 
            this.lblHastaSoyad.AutoSize = true;
            this.lblHastaSoyad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaSoyad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHastaSoyad.Location = new System.Drawing.Point(63, 76);
            this.lblHastaSoyad.Name = "lblHastaSoyad";
            this.lblHastaSoyad.Size = new System.Drawing.Size(53, 21);
            this.lblHastaSoyad.TabIndex = 49;
            this.lblHastaSoyad.Text = "Soyad";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaAd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHastaAd.Location = new System.Drawing.Point(63, 55);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(29, 21);
            this.lblHastaAd.TabIndex = 48;
            this.lblHastaAd.Text = "Ad";
            // 
            // lblHastaSikayet
            // 
            this.lblHastaSikayet.AutoSize = true;
            this.lblHastaSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaSikayet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHastaSikayet.Location = new System.Drawing.Point(221, 181);
            this.lblHastaSikayet.Name = "lblHastaSikayet";
            this.lblHastaSikayet.Size = new System.Drawing.Size(0, 20);
            this.lblHastaSikayet.TabIndex = 69;
            // 
            // btnAnasayfaGecis
            // 
            this.btnAnasayfaGecis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAnasayfaGecis.Location = new System.Drawing.Point(-1, 447);
            this.btnAnasayfaGecis.Name = "btnAnasayfaGecis";
            this.btnAnasayfaGecis.Size = new System.Drawing.Size(447, 31);
            this.btnAnasayfaGecis.TabIndex = 71;
            this.btnAnasayfaGecis.Text = "Anasayfa";
            this.btnAnasayfaGecis.UseVisualStyleBackColor = false;
            this.btnAnasayfaGecis.Click += new System.EventHandler(this.btnAnasayfaGecis_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(-1, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(447, 23);
            this.btnExit.TabIndex = 70;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReceteYaz
            // 
            this.btnReceteYaz.BackColor = System.Drawing.Color.RosyBrown;
            this.btnReceteYaz.Location = new System.Drawing.Point(-1, 315);
            this.btnReceteYaz.Name = "btnReceteYaz";
            this.btnReceteYaz.Size = new System.Drawing.Size(447, 37);
            this.btnReceteYaz.TabIndex = 72;
            this.btnReceteYaz.Text = "REÇETE YAZ";
            this.btnReceteYaz.UseVisualStyleBackColor = false;
            this.btnReceteYaz.Click += new System.EventHandler(this.btnReceteYaz_Click);
            // 
            // txtTeşhis
            // 
            this.txtTeşhis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeşhis.Location = new System.Drawing.Point(202, 223);
            this.txtTeşhis.Name = "txtTeşhis";
            this.txtTeşhis.Size = new System.Drawing.Size(134, 13);
            this.txtTeşhis.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 74;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Doktor Tanısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(691, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 76;
            this.label3.Text = "Randevulu Hastalar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblSiraNo);
            this.panel1.Controls.Add(this.lblTcKimlik);
            this.panel1.Controls.Add(this.lblHastaAd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblHastaSoyad);
            this.panel1.Controls.Add(this.lblSayın);
            this.panel1.Controls.Add(this.lblDoktor);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 111);
            this.panel1.TabIndex = 77;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(833, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 19);
            this.lblTime.TabIndex = 80;
            this.lblTime.Text = "TIME";
            // 
            // lblSiraNo
            // 
            this.lblSiraNo.AutoSize = true;
            this.lblSiraNo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiraNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSiraNo.Location = new System.Drawing.Point(648, 84);
            this.lblSiraNo.Name = "lblSiraNo";
            this.lblSiraNo.Size = new System.Drawing.Size(37, 21);
            this.lblSiraNo.TabIndex = 79;
            this.lblSiraNo.Text = "Sıra";
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTcKimlik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTcKimlik.Location = new System.Drawing.Point(165, 55);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(25, 21);
            this.lblTcKimlik.TabIndex = 77;
            this.lblTcKimlik.Text = "Tc";
            // 
            // btnMuayeneOnay
            // 
            this.btnMuayeneOnay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMuayeneOnay.Location = new System.Drawing.Point(-1, 267);
            this.btnMuayeneOnay.Name = "btnMuayeneOnay";
            this.btnMuayeneOnay.Size = new System.Drawing.Size(447, 42);
            this.btnMuayeneOnay.TabIndex = 78;
            this.btnMuayeneOnay.Text = "MUAYENE ONAY";
            this.btnMuayeneOnay.UseVisualStyleBackColor = false;
            this.btnMuayeneOnay.Click += new System.EventHandler(this.btnMuayeneOnay_Click);
            // 
            // muayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 503);
            this.Controls.Add(this.btnMuayeneOnay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTeşhis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSikayet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblHastaSikayet);
            this.Controls.Add(this.btnReceteYaz);
            this.Controls.Add(this.btnAnasayfaGecis);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "muayene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "muayene";
            this.Load += new System.EventHandler(this.muayene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.Label lblSayın;
        private System.Windows.Forms.Label lblHastaSoyad;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.Label lblHastaSikayet;
        private System.Windows.Forms.Button btnAnasayfaGecis;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReceteYaz;
        private System.Windows.Forms.TextBox txtTeşhis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMuayeneOnay;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.Label lblSiraNo;
        private System.Windows.Forms.Label lblTime;
    }
}