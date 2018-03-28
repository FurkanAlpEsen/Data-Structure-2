namespace Ödev2Beta1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZeminList = new System.Windows.Forms.ListBox();
            this.İlkKatList = new System.Windows.Forms.ListBox();
            this.İkinciKatList = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnSureYaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZeminList
            // 
            this.ZeminList.FormattingEnabled = true;
            this.ZeminList.Location = new System.Drawing.Point(12, 77);
            this.ZeminList.Name = "ZeminList";
            this.ZeminList.Size = new System.Drawing.Size(186, 238);
            this.ZeminList.TabIndex = 0;
            // 
            // İlkKatList
            // 
            this.İlkKatList.FormattingEnabled = true;
            this.İlkKatList.Location = new System.Drawing.Point(218, 77);
            this.İlkKatList.Name = "İlkKatList";
            this.İlkKatList.Size = new System.Drawing.Size(201, 238);
            this.İlkKatList.TabIndex = 1;
            // 
            // İkinciKatList
            // 
            this.İkinciKatList.FormattingEnabled = true;
            this.İkinciKatList.Location = new System.Drawing.Point(437, 77);
            this.İkinciKatList.Name = "İkinciKatList";
            this.İkinciKatList.Size = new System.Drawing.Size(196, 238);
            this.İkinciKatList.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(40, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Araç Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(251, 25);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 4;
            this.btnCikar.Text = "Araç Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnSureYaz
            // 
            this.btnSureYaz.Location = new System.Drawing.Point(437, 25);
            this.btnSureYaz.Name = "btnSureYaz";
            this.btnSureYaz.Size = new System.Drawing.Size(178, 23);
            this.btnSureYaz.TabIndex = 5;
            this.btnSureYaz.Text = "Süre Başına Çıkan Araç Sayısı";
            this.btnSureYaz.UseVisualStyleBackColor = true;
            this.btnSureYaz.Click += new System.EventHandler(this.btnSureYaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zemin Katta Bulunan Araçlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "1. Katta Bulunan Araçlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "2. Katta Bulunan Araçlar";
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(221, 348);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(198, 23);
            this.btnSifirla.TabIndex = 9;
            this.btnSifirla.Text = "Otoparkı Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 385);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSureYaz);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.İkinciKatList);
            this.Controls.Add(this.İlkKatList);
            this.Controls.Add(this.ZeminList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ZeminList;
        private System.Windows.Forms.ListBox İlkKatList;
        private System.Windows.Forms.ListBox İkinciKatList;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnSureYaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSifirla;
    }
}

