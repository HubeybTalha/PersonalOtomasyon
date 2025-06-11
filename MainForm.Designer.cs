namespace PersonelOtomasyon
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // btnKaydet
            this.btnKaydet.Location = new System.Drawing.Point(50, 400);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // btnDuzenle
            this.btnDuzenle.Location = new System.Drawing.Point(150, 400);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 23);
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);

            // btnKisiSil
            this.btnKisiSil.Location = new System.Drawing.Point(270, 400);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(100, 23);
            this.btnKisiSil.Text = "KİŞİ SİL";
            this.btnKisiSil.UseVisualStyleBackColor = true;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);

            // btnKisiEkle
            this.btnKisiEkle.Location = new System.Drawing.Point(390, 400);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(100, 23);
            this.btnKisiEkle.Text = "KİŞİ EKLE";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);

            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.no, this.tc, this.ad, this.soyad, this.gorev, this.maas });
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 350);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.Azure;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // no
            this.no.HeaderText = "NO";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 50;

            // tc
            this.tc.HeaderText = "TC";
            this.tc.Name = "tc";
            this.tc.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            // ad
            this.ad.HeaderText = "AD";
            this.ad.Name = "ad";

            // soyad
            this.soyad.HeaderText = "SOYAD";
            this.soyad.Name = "soyad";

            // gorev
            this.gorev.HeaderText = "GÖREV";
            this.gorev.Name = "gorev";

            // maas
            this.maas.HeaderText = "MAAŞ";
            this.maas.Name = "maas";

            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnKisiSil);
            this.Controls.Add(this.btnKisiEkle);
            this.Name = "MainForm";
            this.Text = "AV ASAF İŞYERİ";
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorev;
        private System.Windows.Forms.DataGridViewTextBoxColumn maas;
    }
}
