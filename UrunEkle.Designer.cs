
namespace veritabaniProje
{
    partial class UrunEkle
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
            this.labelÜrünAd = new System.Windows.Forms.Label();
            this.cmbBxUrun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAdet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBirim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBxTedarikci = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.txtBoxUrnAdAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSatisGecmisi = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.lblBisCesit = new System.Windows.Forms.Label();
            this.txtbxBisCesit = new System.Windows.Forms.TextBox();
            this.lblBisGramaj = new System.Windows.Forms.Label();
            this.txtBxBisGramaj = new System.Windows.Forms.TextBox();
            this.txtbxMarka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtBxPaketAgirlik = new System.Windows.Forms.TextBox();
            this.lblPaketAgirlik = new System.Windows.Forms.Label();
            this.lblUretimYeri = new System.Windows.Forms.Label();
            this.txtBoxUretimYeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLitre = new System.Windows.Forms.Label();
            this.txtBxLitre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(588, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelÜrünAd
            // 
            this.labelÜrünAd.AutoSize = true;
            this.labelÜrünAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelÜrünAd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelÜrünAd.Location = new System.Drawing.Point(39, 40);
            this.labelÜrünAd.Name = "labelÜrünAd";
            this.labelÜrünAd.Size = new System.Drawing.Size(89, 18);
            this.labelÜrünAd.TabIndex = 1;
            this.labelÜrünAd.Text = "Ürün Çeşidi:";
            this.labelÜrünAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelÜrünAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbBxUrun
            // 
            this.cmbBxUrun.FormattingEnabled = true;
            this.cmbBxUrun.Items.AddRange(new object[] {
            "Bisküvi"});
            this.cmbBxUrun.Location = new System.Drawing.Point(125, 40);
            this.cmbBxUrun.Name = "cmbBxUrun";
            this.cmbBxUrun.Size = new System.Drawing.Size(121, 24);
            this.cmbBxUrun.TabIndex = 2;
            this.cmbBxUrun.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tedarikçi :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(50, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adet:";
            // 
            // txtBoxAdet
            // 
            this.txtBoxAdet.Location = new System.Drawing.Point(125, 196);
            this.txtBoxAdet.Name = "txtBoxAdet";
            this.txtBoxAdet.Size = new System.Drawing.Size(121, 22);
            this.txtBoxAdet.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birim Fiyat:";
            // 
            // txtBoxBirim
            // 
            this.txtBoxBirim.Location = new System.Drawing.Point(125, 237);
            this.txtBoxBirim.Name = "txtBoxBirim";
            this.txtBoxBirim.Size = new System.Drawing.Size(121, 22);
            this.txtBoxBirim.TabIndex = 10;
            this.txtBoxBirim.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(197, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBxTedarikci
            // 
            this.cmbBxTedarikci.DisplayMember = "int";
            this.cmbBxTedarikci.FormattingEnabled = true;
            this.cmbBxTedarikci.Location = new System.Drawing.Point(125, 152);
            this.cmbBxTedarikci.Name = "cmbBxTedarikci";
            this.cmbBxTedarikci.Size = new System.Drawing.Size(121, 24);
            this.cmbBxTedarikci.TabIndex = 13;
            this.cmbBxTedarikci.SelectedIndexChanged += new System.EventHandler(this.cmbBxTedarikci_SelectedIndexChanged);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Thistle;
            this.btnListele.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnListele.Location = new System.Drawing.Point(17, 284);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(130, 56);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Ürünleri Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.BackColor = System.Drawing.Color.Thistle;
            this.btnUrunAra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUrunAra.Location = new System.Drawing.Point(426, 382);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(130, 56);
            this.btnUrunAra.TabIndex = 15;
            this.btnUrunAra.Text = "Ürün Ara";
            this.btnUrunAra.UseVisualStyleBackColor = false;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // txtBoxUrnAdAra
            // 
            this.txtBoxUrnAdAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxUrnAdAra.Location = new System.Drawing.Point(426, 331);
            this.txtBoxUrnAdAra.Name = "txtBoxUrnAdAra";
            this.txtBoxUrnAdAra.Size = new System.Drawing.Size(130, 24);
            this.txtBoxUrnAdAra.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(355, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün No:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSatisGecmisi
            // 
            this.btnSatisGecmisi.BackColor = System.Drawing.Color.Thistle;
            this.btnSatisGecmisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSatisGecmisi.Location = new System.Drawing.Point(967, 382);
            this.btnSatisGecmisi.Name = "btnSatisGecmisi";
            this.btnSatisGecmisi.Size = new System.Drawing.Size(147, 56);
            this.btnSatisGecmisi.TabIndex = 18;
            this.btnSatisGecmisi.Text = "SATIŞ GEÇMİŞİNİ GÖRÜNTÜLE";
            this.btnSatisGecmisi.UseVisualStyleBackColor = false;
            this.btnSatisGecmisi.Click += new System.EventHandler(this.btnSatisGecmisi_Click);
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.Thistle;
            this.btnSec.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSec.Location = new System.Drawing.Point(125, 83);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(121, 33);
            this.btnSec.TabIndex = 19;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // lblBisCesit
            // 
            this.lblBisCesit.AutoSize = true;
            this.lblBisCesit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBisCesit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBisCesit.Location = new System.Drawing.Point(331, 162);
            this.lblBisCesit.Name = "lblBisCesit";
            this.lblBisCesit.Size = new System.Drawing.Size(46, 18);
            this.lblBisCesit.TabIndex = 20;
            this.lblBisCesit.Text = "Çeşit:";
            this.lblBisCesit.Visible = false;
            // 
            // txtbxBisCesit
            // 
            this.txtbxBisCesit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxBisCesit.Location = new System.Drawing.Point(380, 159);
            this.txtbxBisCesit.Name = "txtbxBisCesit";
            this.txtbxBisCesit.Size = new System.Drawing.Size(100, 24);
            this.txtbxBisCesit.TabIndex = 21;
            this.txtbxBisCesit.Visible = false;
            // 
            // lblBisGramaj
            // 
            this.lblBisGramaj.AutoSize = true;
            this.lblBisGramaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBisGramaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBisGramaj.Location = new System.Drawing.Point(316, 192);
            this.lblBisGramaj.Name = "lblBisGramaj";
            this.lblBisGramaj.Size = new System.Drawing.Size(61, 18);
            this.lblBisGramaj.TabIndex = 22;
            this.lblBisGramaj.Text = "Gramaj:";
            this.lblBisGramaj.Visible = false;
            // 
            // txtBxBisGramaj
            // 
            this.txtBxBisGramaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxBisGramaj.Location = new System.Drawing.Point(380, 189);
            this.txtBxBisGramaj.Name = "txtBxBisGramaj";
            this.txtBxBisGramaj.Size = new System.Drawing.Size(100, 24);
            this.txtBxBisGramaj.TabIndex = 23;
            this.txtBxBisGramaj.Visible = false;
            // 
            // txtbxMarka
            // 
            this.txtbxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxMarka.Location = new System.Drawing.Point(380, 189);
            this.txtbxMarka.Name = "txtbxMarka";
            this.txtbxMarka.Size = new System.Drawing.Size(100, 24);
            this.txtbxMarka.TabIndex = 25;
            this.txtbxMarka.Visible = false;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarka.Location = new System.Drawing.Point(316, 192);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(54, 18);
            this.lblMarka.TabIndex = 26;
            this.lblMarka.Text = "Marka:";
            this.lblMarka.Visible = false;
            // 
            // txtBxPaketAgirlik
            // 
            this.txtBxPaketAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxPaketAgirlik.Location = new System.Drawing.Point(380, 191);
            this.txtBxPaketAgirlik.Name = "txtBxPaketAgirlik";
            this.txtBxPaketAgirlik.Size = new System.Drawing.Size(100, 24);
            this.txtBxPaketAgirlik.TabIndex = 27;
            this.txtBxPaketAgirlik.Visible = false;
            // 
            // lblPaketAgirlik
            // 
            this.lblPaketAgirlik.AutoSize = true;
            this.lblPaketAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaketAgirlik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaketAgirlik.Location = new System.Drawing.Point(280, 192);
            this.lblPaketAgirlik.Name = "lblPaketAgirlik";
            this.lblPaketAgirlik.Size = new System.Drawing.Size(96, 18);
            this.lblPaketAgirlik.TabIndex = 28;
            this.lblPaketAgirlik.Text = "Paket Ağırlığı:";
            this.lblPaketAgirlik.Visible = false;
            // 
            // lblUretimYeri
            // 
            this.lblUretimYeri.AutoSize = true;
            this.lblUretimYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUretimYeri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUretimYeri.Location = new System.Drawing.Point(292, 225);
            this.lblUretimYeri.Name = "lblUretimYeri";
            this.lblUretimYeri.Size = new System.Drawing.Size(85, 18);
            this.lblUretimYeri.TabIndex = 29;
            this.lblUretimYeri.Text = "Üretim Yeri:";
            this.lblUretimYeri.Visible = false;
            // 
            // txtBoxUretimYeri
            // 
            this.txtBoxUretimYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxUretimYeri.Location = new System.Drawing.Point(380, 222);
            this.txtBoxUretimYeri.Name = "txtBoxUretimYeri";
            this.txtBoxUretimYeri.Size = new System.Drawing.Size(100, 24);
            this.txtBoxUretimYeri.TabIndex = 30;
            this.txtBoxUretimYeri.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(309, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Gramaj:";
            this.label5.Visible = false;
            // 
            // lblLitre
            // 
            this.lblLitre.AutoSize = true;
            this.lblLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLitre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLitre.Location = new System.Drawing.Point(327, 164);
            this.lblLitre.Name = "lblLitre";
            this.lblLitre.Size = new System.Drawing.Size(40, 18);
            this.lblLitre.TabIndex = 32;
            this.lblLitre.Text = "Litre:";
            this.lblLitre.Visible = false;
            // 
            // txtBxLitre
            // 
            this.txtBxLitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxLitre.Location = new System.Drawing.Point(380, 157);
            this.txtBxLitre.Name = "txtBxLitre";
            this.txtBxLitre.Size = new System.Drawing.Size(100, 24);
            this.txtBxLitre.TabIndex = 33;
            this.txtBxLitre.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(769, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 56);
            this.button2.TabIndex = 34;
            this.button2.Text = "MENÜ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(133, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "ÜRÜN EKLE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(435, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "ÜRÜN ARA";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1210, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBxLitre);
            this.Controls.Add(this.lblLitre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxUretimYeri);
            this.Controls.Add(this.lblUretimYeri);
            this.Controls.Add(this.lblPaketAgirlik);
            this.Controls.Add(this.txtBxPaketAgirlik);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtbxMarka);
            this.Controls.Add(this.txtBxBisGramaj);
            this.Controls.Add(this.lblBisGramaj);
            this.Controls.Add(this.txtbxBisCesit);
            this.Controls.Add(this.lblBisCesit);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnSatisGecmisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxUrnAdAra);
            this.Controls.Add(this.btnUrunAra);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbBxTedarikci);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxBirim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxUrun);
            this.Controls.Add(this.labelÜrünAd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelÜrünAd;
        private System.Windows.Forms.ComboBox cmbBxUrun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxBirim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBxTedarikci;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.TextBox txtBoxUrnAdAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSatisGecmisi;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label lblBisCesit;
        private System.Windows.Forms.TextBox txtbxBisCesit;
        private System.Windows.Forms.Label lblBisGramaj;
        private System.Windows.Forms.TextBox txtBxBisGramaj;
        private System.Windows.Forms.TextBox txtbxMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtBxPaketAgirlik;
        private System.Windows.Forms.Label lblPaketAgirlik;
        private System.Windows.Forms.Label lblUretimYeri;
        private System.Windows.Forms.TextBox txtBoxUretimYeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLitre;
        private System.Windows.Forms.TextBox txtBxLitre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}