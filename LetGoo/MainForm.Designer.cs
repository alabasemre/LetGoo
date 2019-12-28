namespace LetGoo
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUrunler = new System.Windows.Forms.TabPage();
            this.dgvPazar = new System.Windows.Forms.DataGridView();
            this.pazarClmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pazarClmFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pazarClmSatici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabUrunlerim = new System.Windows.Forms.TabPage();
            this.pnlDgvUrun = new System.Windows.Forms.Panel();
            this.dgvUrunlerim = new System.Windows.Forms.DataGridView();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.tabAyarlar = new System.Windows.Forms.TabPage();
            this.btnKSil = new System.Windows.Forms.Button();
            this.btnKGüncelle = new System.Windows.Forms.Button();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazar)).BeginInit();
            this.tabUrunlerim.SuspendLayout();
            this.pnlDgvUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunlerim)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.tabAyarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUrunler);
            this.tabControl1.Controls.Add(this.tabUrunlerim);
            this.tabControl1.Controls.Add(this.tabAyarlar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 220);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUrunler
            // 
            this.tabUrunler.Controls.Add(this.dgvPazar);
            this.tabUrunler.Location = new System.Drawing.Point(4, 22);
            this.tabUrunler.Name = "tabUrunler";
            this.tabUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrunler.Size = new System.Drawing.Size(440, 194);
            this.tabUrunler.TabIndex = 0;
            this.tabUrunler.Text = "Pazar";
            this.tabUrunler.UseVisualStyleBackColor = true;
            // 
            // dgvPazar
            // 
            this.dgvPazar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPazar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPazar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pazarClmAd,
            this.pazarClmFiyat,
            this.pazarClmSatici});
            this.dgvPazar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPazar.Location = new System.Drawing.Point(3, 3);
            this.dgvPazar.Name = "dgvPazar";
            this.dgvPazar.Size = new System.Drawing.Size(434, 188);
            this.dgvPazar.TabIndex = 0;
            // 
            // pazarClmAd
            // 
            this.pazarClmAd.DataPropertyName = "UrunAd";
            this.pazarClmAd.HeaderText = "Ürün Adı";
            this.pazarClmAd.Name = "pazarClmAd";
            this.pazarClmAd.ReadOnly = true;
            // 
            // pazarClmFiyat
            // 
            this.pazarClmFiyat.DataPropertyName = "Fiyat";
            this.pazarClmFiyat.HeaderText = "Fiyat";
            this.pazarClmFiyat.Name = "pazarClmFiyat";
            this.pazarClmFiyat.ReadOnly = true;
            // 
            // pazarClmSatici
            // 
            this.pazarClmSatici.DataPropertyName = "Satici";
            this.pazarClmSatici.HeaderText = "Satıcı";
            this.pazarClmSatici.Name = "pazarClmSatici";
            this.pazarClmSatici.ReadOnly = true;
            // 
            // tabUrunlerim
            // 
            this.tabUrunlerim.Controls.Add(this.pnlDgvUrun);
            this.tabUrunlerim.Controls.Add(this.pnlControls);
            this.tabUrunlerim.Location = new System.Drawing.Point(4, 22);
            this.tabUrunlerim.Name = "tabUrunlerim";
            this.tabUrunlerim.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrunlerim.Size = new System.Drawing.Size(440, 194);
            this.tabUrunlerim.TabIndex = 1;
            this.tabUrunlerim.Text = "Ürünlerim";
            this.tabUrunlerim.UseVisualStyleBackColor = true;
            // 
            // pnlDgvUrun
            // 
            this.pnlDgvUrun.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDgvUrun.Controls.Add(this.dgvUrunlerim);
            this.pnlDgvUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvUrun.Location = new System.Drawing.Point(3, 3);
            this.pnlDgvUrun.Name = "pnlDgvUrun";
            this.pnlDgvUrun.Size = new System.Drawing.Size(234, 188);
            this.pnlDgvUrun.TabIndex = 0;
            // 
            // dgvUrunlerim
            // 
            this.dgvUrunlerim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunlerim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAd,
            this.clmUrunId,
            this.clmFiyat});
            this.dgvUrunlerim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunlerim.Location = new System.Drawing.Point(0, 0);
            this.dgvUrunlerim.Name = "dgvUrunlerim";
            this.dgvUrunlerim.Size = new System.Drawing.Size(234, 188);
            this.dgvUrunlerim.TabIndex = 0;
            this.dgvUrunlerim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunlerim_CellClick);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.txtFiyat);
            this.pnlControls.Controls.Add(this.txtUrunAdi);
            this.pnlControls.Controls.Add(this.btnEkle);
            this.pnlControls.Controls.Add(this.btnSil);
            this.pnlControls.Controls.Add(this.btnVazgec);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControls.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlControls.Location = new System.Drawing.Point(237, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(200, 188);
            this.pnlControls.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiyat.Location = new System.Drawing.Point(69, 55);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(126, 22);
            this.txtFiyat.TabIndex = 4;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUrunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrunAdi.Location = new System.Drawing.Point(69, 28);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(126, 22);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(109, 95);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(109, 153);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Location = new System.Drawing.Point(109, 124);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 0;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // tabAyarlar
            // 
            this.tabAyarlar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabAyarlar.Controls.Add(this.btnKSil);
            this.tabAyarlar.Controls.Add(this.btnKGüncelle);
            this.tabAyarlar.Controls.Add(this.txtKullaniciSifre);
            this.tabAyarlar.Controls.Add(this.txtKullaniciAdi);
            this.tabAyarlar.Controls.Add(this.label4);
            this.tabAyarlar.Controls.Add(this.label3);
            this.tabAyarlar.Location = new System.Drawing.Point(4, 22);
            this.tabAyarlar.Name = "tabAyarlar";
            this.tabAyarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAyarlar.Size = new System.Drawing.Size(440, 194);
            this.tabAyarlar.TabIndex = 2;
            this.tabAyarlar.Text = "Ayarlar";
            // 
            // btnKSil
            // 
            this.btnKSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKSil.Location = new System.Drawing.Point(274, 96);
            this.btnKSil.Name = "btnKSil";
            this.btnKSil.Size = new System.Drawing.Size(114, 23);
            this.btnKSil.TabIndex = 5;
            this.btnKSil.Text = "Hesabı Sil";
            this.btnKSil.UseVisualStyleBackColor = true;
            this.btnKSil.Click += new System.EventHandler(this.btnKSil_Click);
            // 
            // btnKGüncelle
            // 
            this.btnKGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKGüncelle.Location = new System.Drawing.Point(274, 67);
            this.btnKGüncelle.Name = "btnKGüncelle";
            this.btnKGüncelle.Size = new System.Drawing.Size(114, 23);
            this.btnKGüncelle.TabIndex = 4;
            this.btnKGüncelle.Text = "Güncelle";
            this.btnKGüncelle.UseVisualStyleBackColor = true;
            this.btnKGüncelle.Click += new System.EventHandler(this.btnKGüncelle_Click);
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtKullaniciSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciSifre.Location = new System.Drawing.Point(117, 97);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(128, 20);
            this.txtKullaniciSifre.TabIndex = 3;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(117, 70);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(128, 20);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(78, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // clmAd
            // 
            this.clmAd.DataPropertyName = "UrunAd";
            this.clmAd.HeaderText = "Ürün Adı";
            this.clmAd.Name = "clmAd";
            this.clmAd.ReadOnly = true;
            // 
            // clmUrunId
            // 
            this.clmUrunId.DataPropertyName = "UrunId";
            this.clmUrunId.HeaderText = "Ürün ID";
            this.clmUrunId.Name = "clmUrunId";
            this.clmUrunId.Visible = false;
            // 
            // clmFiyat
            // 
            this.clmFiyat.DataPropertyName = "Fiyat";
            this.clmFiyat.HeaderText = "Fiyat";
            this.clmFiyat.Name = "clmFiyat";
            this.clmFiyat.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 220);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazar)).EndInit();
            this.tabUrunlerim.ResumeLayout(false);
            this.pnlDgvUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunlerim)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.tabAyarlar.ResumeLayout(false);
            this.tabAyarlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUrunler;
        private System.Windows.Forms.DataGridView dgvPazar;
        private System.Windows.Forms.TabPage tabUrunlerim;
        private System.Windows.Forms.TabPage tabAyarlar;
        private System.Windows.Forms.Panel pnlDgvUrun;
        private System.Windows.Forms.DataGridView dgvUrunlerim;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKSil;
        private System.Windows.Forms.Button btnKGüncelle;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pazarClmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pazarClmFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn pazarClmSatici;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFiyat;
    }
}