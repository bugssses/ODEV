
namespace veritabaniProje
{
    partial class Teslimat
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
            this.btnTeslimatOlustur = new System.Windows.Forms.Button();
            this.cmbxTeslimatNokta = new System.Windows.Forms.ComboBox();
            this.cmbxSevkiyatci = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxUrunNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTeslimatUrunEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUrunGöster = new System.Windows.Forms.Button();
            this.btnTeslimatGöster = new System.Windows.Forms.Button();
            this.btnYeniTeslimat = new System.Windows.Forms.Button();
            this.txtBxTeslimNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTeslimatOlustur
            // 
            this.btnTeslimatOlustur.BackColor = System.Drawing.Color.Thistle;
            this.btnTeslimatOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimatOlustur.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTeslimatOlustur.Location = new System.Drawing.Point(702, 184);
            this.btnTeslimatOlustur.Name = "btnTeslimatOlustur";
            this.btnTeslimatOlustur.Size = new System.Drawing.Size(159, 50);
            this.btnTeslimatOlustur.TabIndex = 0;
            this.btnTeslimatOlustur.Text = "Teslimat Oluştur";
            this.btnTeslimatOlustur.UseVisualStyleBackColor = false;
            this.btnTeslimatOlustur.Click += new System.EventHandler(this.btnTeslimatOlustur_Click);
            // 
            // cmbxTeslimatNokta
            // 
            this.cmbxTeslimatNokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxTeslimatNokta.FormattingEnabled = true;
            this.cmbxTeslimatNokta.Location = new System.Drawing.Point(722, 110);
            this.cmbxTeslimatNokta.Name = "cmbxTeslimatNokta";
            this.cmbxTeslimatNokta.Size = new System.Drawing.Size(121, 26);
            this.cmbxTeslimatNokta.TabIndex = 2;
            this.cmbxTeslimatNokta.SelectedIndexChanged += new System.EventHandler(this.cmbxTeslimatNokta_SelectedIndexChanged);
            // 
            // cmbxSevkiyatci
            // 
            this.cmbxSevkiyatci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbxSevkiyatci.FormattingEnabled = true;
            this.cmbxSevkiyatci.Location = new System.Drawing.Point(722, 140);
            this.cmbxSevkiyatci.Name = "cmbxSevkiyatci";
            this.cmbxSevkiyatci.Size = new System.Drawing.Size(121, 26);
            this.cmbxSevkiyatci.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(566, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teslimat Noktası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(554, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sevkiyat Personeli:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBxUrunNo
            // 
            this.txtBxUrunNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxUrunNo.Location = new System.Drawing.Point(722, 253);
            this.txtBxUrunNo.Name = "txtBxUrunNo";
            this.txtBxUrunNo.Size = new System.Drawing.Size(121, 24);
            this.txtBxUrunNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(518, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eklenecek Ürün Numarası:";
            // 
            // btnTeslimatUrunEkle
            // 
            this.btnTeslimatUrunEkle.BackColor = System.Drawing.Color.Thistle;
            this.btnTeslimatUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimatUrunEkle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTeslimatUrunEkle.Location = new System.Drawing.Point(706, 297);
            this.btnTeslimatUrunEkle.Name = "btnTeslimatUrunEkle";
            this.btnTeslimatUrunEkle.Size = new System.Drawing.Size(153, 54);
            this.btnTeslimatUrunEkle.TabIndex = 9;
            this.btnTeslimatUrunEkle.Text = "Ürünü Teslimata Ekle\r\n\r\n";
            this.btnTeslimatUrunEkle.UseVisualStyleBackColor = false;
            this.btnTeslimatUrunEkle.Click += new System.EventHandler(this.btnTeslimatUrunEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 319);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnUrunGöster
            // 
            this.btnUrunGöster.BackColor = System.Drawing.Color.Thistle;
            this.btnUrunGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGöster.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUrunGöster.Location = new System.Drawing.Point(46, 377);
            this.btnUrunGöster.Name = "btnUrunGöster";
            this.btnUrunGöster.Size = new System.Drawing.Size(141, 67);
            this.btnUrunGöster.TabIndex = 11;
            this.btnUrunGöster.Text = "Ürünleri Listele";
            this.btnUrunGöster.UseVisualStyleBackColor = false;
            this.btnUrunGöster.Click += new System.EventHandler(this.btnUrunGöster_Click);
            // 
            // btnTeslimatGöster
            // 
            this.btnTeslimatGöster.BackColor = System.Drawing.Color.Thistle;
            this.btnTeslimatGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimatGöster.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTeslimatGöster.Location = new System.Drawing.Point(233, 374);
            this.btnTeslimatGöster.Name = "btnTeslimatGöster";
            this.btnTeslimatGöster.Size = new System.Drawing.Size(145, 73);
            this.btnTeslimatGöster.TabIndex = 12;
            this.btnTeslimatGöster.Text = "Teslimatları Göster";
            this.btnTeslimatGöster.UseVisualStyleBackColor = false;
            this.btnTeslimatGöster.Click += new System.EventHandler(this.btnTeslimatGöster_Click);
            // 
            // btnYeniTeslimat
            // 
            this.btnYeniTeslimat.BackColor = System.Drawing.Color.Thistle;
            this.btnYeniTeslimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniTeslimat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnYeniTeslimat.Location = new System.Drawing.Point(709, 401);
            this.btnYeniTeslimat.Name = "btnYeniTeslimat";
            this.btnYeniTeslimat.Size = new System.Drawing.Size(152, 61);
            this.btnYeniTeslimat.TabIndex = 13;
            this.btnYeniTeslimat.Text = "Yeni Teslimat Oluştur\r\n\r\n";
            this.btnYeniTeslimat.UseVisualStyleBackColor = false;
            this.btnYeniTeslimat.Click += new System.EventHandler(this.btnYeniTeslimat_Click);
            // 
            // txtBxTeslimNum
            // 
            this.txtBxTeslimNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxTeslimNum.Location = new System.Drawing.Point(722, 67);
            this.txtBxTeslimNum.Name = "txtBxTeslimNum";
            this.txtBxTeslimNum.Size = new System.Drawing.Size(121, 24);
            this.txtBxTeslimNum.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(553, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Teslimat Numarası:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(437, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 65);
            this.button1.TabIndex = 16;
            this.button1.Text = "MENÜ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Teslimat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(916, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxTeslimNum);
            this.Controls.Add(this.btnYeniTeslimat);
            this.Controls.Add(this.btnTeslimatGöster);
            this.Controls.Add(this.btnUrunGöster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTeslimatUrunEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxUrunNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxSevkiyatci);
            this.Controls.Add(this.cmbxTeslimatNokta);
            this.Controls.Add(this.btnTeslimatOlustur);
            this.Name = "Teslimat";
            this.Text = "Teslimat";
            this.Load += new System.EventHandler(this.Teslimat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeslimatOlustur;
        private System.Windows.Forms.ComboBox cmbxTeslimatNokta;
        private System.Windows.Forms.ComboBox cmbxSevkiyatci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxUrunNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTeslimatUrunEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunGöster;
        private System.Windows.Forms.Button btnTeslimatGöster;
        private System.Windows.Forms.Button btnYeniTeslimat;
        private System.Windows.Forms.TextBox txtBxTeslimNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}