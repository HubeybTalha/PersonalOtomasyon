using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PersonelOtomasyon
{
    public partial class MainForm : Form
    {
        private List<string[]> veriler = new List<string[]>();
        private bool kaydedildi = true;
        private string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.txt");

        public MainForm()
        {
            InitializeComponent();
            YukleVeriler();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.Azure;
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            dataGridView1.ReadOnly = true; // Başta düzenleme kapalı
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!kaydedildi)
            {
                var sonuc = MessageBox.Show("Kaydetmeden çıkmak üzeresiniz. Kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
                if (sonuc == DialogResult.Yes)
                    KaydetVeriler();
                else if (sonuc == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            veriler.Add(new string[] { "", "", "", "", "" });
            GosterVeriler();
            kaydedildi = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KaydetVeriler();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            MessageBox.Show("Düzenleme aktif! Gerekli değişiklikleri yapıp KAYDET'e basın.");
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Silmek istediğiniz kişi numarasını girin:", "Kişi Sil");
            if (int.TryParse(input, out int numara))
            {
                if (numara >= 1 && numara <= veriler.Count)
                {
                    veriler.RemoveAt(numara - 1);
                    GosterVeriler();
                    kaydedildi = false;
                }
                else MessageBox.Show("Geçersiz numara.");
            }
        }

        private void GosterVeriler()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < veriler.Count; i++)
            {
                var veri = veriler[i];
                dataGridView1.Rows.Add(i + 1, veri[0], veri[1], veri[2], veri[3], veri[4]);
            }
        }

        private void YukleVeriler()
        {
            if (File.Exists(dataPath))
            {
                var satirlar = File.ReadAllLines(dataPath);
                foreach (var satir in satirlar)
                {
                    var parcalar = satir.Split(',');
                    if (parcalar.Length == 5)
                        veriler.Add(parcalar);
                }
                GosterVeriler();
            }
        }

        private void KaydetVeriler()
        {
            List<string> satirlar = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    satirlar.Add(string.Join(",", new string[]
                    {
                        row.Cells[1].Value?.ToString() ?? "",
                        row.Cells[2].Value?.ToString() ?? "",
                        row.Cells[3].Value?.ToString() ?? "",
                        row.Cells[4].Value?.ToString() ?? "",
                        row.Cells[5].Value?.ToString() ?? ""
                    }));
                }
            }
            File.WriteAllLines(dataPath, satirlar);
            kaydedildi = true;
            MessageBox.Show("Veriler başarıyla kaydedildi.");
        }

        // Geçici
        private void txtSoyad_TextChanged(object sender, EventArgs e) { }
        private void txtMaas_TextChanged(object sender, EventArgs e) { }
        private void btnGoster_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
