
namespace kelime_oyunu
{
    partial class YARISMACI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAdi = new System.Windows.Forms.TextBox();
            this.textSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHarfAl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxTahmin = new System.Windows.Forms.GroupBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.textBoxTahmin = new System.Windows.Forms.TextBox();
            this.groupBoxCevap = new System.Windows.Forms.GroupBox();
            this.labelCevap = new System.Windows.Forms.Label();
            this.textSoru = new System.Windows.Forms.TextBox();
            this.groupBoxsSure = new System.Windows.Forms.GroupBox();
            this.labelKalanSure = new System.Windows.Forms.Label();
            this.labelKalanToplamSure = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSureDurdur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.textPuan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.timerBekleme = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxTahmin.SuspendLayout();
            this.groupBoxCevap.SuspendLayout();
            this.groupBoxsSure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "YARISMACI ADI            :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "YARISMACI SOYADI     :";
            // 
            // textAdi
            // 
            this.textAdi.BackColor = System.Drawing.SystemColors.Info;
            this.textAdi.Location = new System.Drawing.Point(273, 52);
            this.textAdi.Name = "textAdi";
            this.textAdi.Size = new System.Drawing.Size(215, 23);
            this.textAdi.TabIndex = 2;
            this.textAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textSoyadi
            // 
            this.textSoyadi.BackColor = System.Drawing.SystemColors.Info;
            this.textSoyadi.Location = new System.Drawing.Point(273, 98);
            this.textSoyadi.Name = "textSoyadi";
            this.textSoyadi.Size = new System.Drawing.Size(215, 23);
            this.textSoyadi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "SORU                              :";
            // 
            // btnHarfAl
            // 
            this.btnHarfAl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHarfAl.Location = new System.Drawing.Point(3, 51);
            this.btnHarfAl.Name = "btnHarfAl";
            this.btnHarfAl.Size = new System.Drawing.Size(192, 68);
            this.btnHarfAl.TabIndex = 5;
            this.btnHarfAl.Text = "HARF AL";
            this.btnHarfAl.UseVisualStyleBackColor = true;
            this.btnHarfAl.Click += new System.EventHandler(this.btnHarfAl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "PUAN                              :";
            // 
            // groupBoxTahmin
            // 
            this.groupBoxTahmin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxTahmin.Controls.Add(this.btnTahmin);
            this.groupBoxTahmin.Controls.Add(this.textBoxTahmin);
            this.groupBoxTahmin.Location = new System.Drawing.Point(273, 316);
            this.groupBoxTahmin.Name = "groupBoxTahmin";
            this.groupBoxTahmin.Size = new System.Drawing.Size(215, 122);
            this.groupBoxTahmin.TabIndex = 8;
            this.groupBoxTahmin.TabStop = false;
            this.groupBoxTahmin.Text = "TAHMIN";
            // 
            // btnTahmin
            // 
            this.btnTahmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTahmin.Location = new System.Drawing.Point(3, 51);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(209, 68);
            this.btnTahmin.TabIndex = 10;
            this.btnTahmin.Text = "TAHMIN ET";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // textBoxTahmin
            // 
            this.textBoxTahmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTahmin.Location = new System.Drawing.Point(3, 19);
            this.textBoxTahmin.Name = "textBoxTahmin";
            this.textBoxTahmin.Size = new System.Drawing.Size(209, 23);
            this.textBoxTahmin.TabIndex = 10;
            // 
            // groupBoxCevap
            // 
            this.groupBoxCevap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxCevap.Controls.Add(this.labelCevap);
            this.groupBoxCevap.Controls.Add(this.btnHarfAl);
            this.groupBoxCevap.Location = new System.Drawing.Point(569, 316);
            this.groupBoxCevap.Name = "groupBoxCevap";
            this.groupBoxCevap.Size = new System.Drawing.Size(198, 122);
            this.groupBoxCevap.TabIndex = 9;
            this.groupBoxCevap.TabStop = false;
            this.groupBoxCevap.Text = "CEVAP";
            // 
            // labelCevap
            // 
            this.labelCevap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCevap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCevap.Location = new System.Drawing.Point(3, 19);
            this.labelCevap.Name = "labelCevap";
            this.labelCevap.Size = new System.Drawing.Size(192, 32);
            this.labelCevap.TabIndex = 6;
            this.labelCevap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textSoru
            // 
            this.textSoru.BackColor = System.Drawing.SystemColors.Info;
            this.textSoru.Location = new System.Drawing.Point(273, 189);
            this.textSoru.Multiline = true;
            this.textSoru.Name = "textSoru";
            this.textSoru.Size = new System.Drawing.Size(494, 121);
            this.textSoru.TabIndex = 10;
            this.textSoru.TextChanged += new System.EventHandler(this.textSoru_TextChanged);
            // 
            // groupBoxsSure
            // 
            this.groupBoxsSure.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxsSure.Controls.Add(this.labelKalanSure);
            this.groupBoxsSure.Controls.Add(this.labelKalanToplamSure);
            this.groupBoxsSure.Controls.Add(this.label6);
            this.groupBoxsSure.Controls.Add(this.label5);
            this.groupBoxsSure.Controls.Add(this.btnSureDurdur);
            this.groupBoxsSure.Location = new System.Drawing.Point(586, 52);
            this.groupBoxsSure.Name = "groupBoxsSure";
            this.groupBoxsSure.Size = new System.Drawing.Size(181, 131);
            this.groupBoxsSure.TabIndex = 11;
            this.groupBoxsSure.TabStop = false;
            this.groupBoxsSure.Text = "SÜRE";
            // 
            // labelKalanSure
            // 
            this.labelKalanSure.AutoSize = true;
            this.labelKalanSure.Location = new System.Drawing.Point(137, 113);
            this.labelKalanSure.Name = "labelKalanSure";
            this.labelKalanSure.Size = new System.Drawing.Size(19, 15);
            this.labelKalanSure.TabIndex = 14;
            this.labelKalanSure.Text = "20";
            // 
            // labelKalanToplamSure
            // 
            this.labelKalanToplamSure.AutoSize = true;
            this.labelKalanToplamSure.Location = new System.Drawing.Point(137, 19);
            this.labelKalanToplamSure.Name = "labelKalanToplamSure";
            this.labelKalanToplamSure.Size = new System.Drawing.Size(28, 15);
            this.labelKalanToplamSure.TabIndex = 13;
            this.labelKalanToplamSure.Text = "4:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(3, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tahmin İçin Kalan Süre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Toplam Kalan Süre        :";
            // 
            // btnSureDurdur
            // 
            this.btnSureDurdur.Location = new System.Drawing.Point(3, 37);
            this.btnSureDurdur.Name = "btnSureDurdur";
            this.btnSureDurdur.Size = new System.Drawing.Size(172, 73);
            this.btnSureDurdur.TabIndex = 10;
            this.btnSureDurdur.Text = "BUTONA BAS";
            this.btnSureDurdur.UseVisualStyleBackColor = true;
            this.btnSureDurdur.Click += new System.EventHandler(this.btnSureDurdur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Image = global::kelime_oyunu.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(537, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox2.Image = global::kelime_oyunu.Properties.Resources.clock;
            this.pictureBox2.Location = new System.Drawing.Point(537, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // timerZamanlayici
            // 
            this.timerZamanlayici.Interval = 1000;
            this.timerZamanlayici.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textPuan
            // 
            this.textPuan.BackColor = System.Drawing.SystemColors.Info;
            this.textPuan.Location = new System.Drawing.Point(273, 145);
            this.textPuan.Name = "textPuan";
            this.textPuan.Size = new System.Drawing.Size(215, 23);
            this.textPuan.TabIndex = 15;
            this.textPuan.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnKayıt);
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Location = new System.Drawing.Point(27, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnKayıt
            // 
            this.btnKayıt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKayıt.Location = new System.Drawing.Point(3, 90);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(234, 72);
            this.btnKayıt.TabIndex = 18;
            this.btnKayıt.Text = "KAYIT";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBasla.Location = new System.Drawing.Point(3, 19);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(234, 72);
            this.btnBasla.TabIndex = 17;
            this.btnBasla.Text = "BASLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // timerBekleme
            // 
            this.timerBekleme.Interval = 1000;
            this.timerBekleme.Tick += new System.EventHandler(this.timerBekleme_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(491, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 32);
            this.label7.TabIndex = 17;
            // 
            // YARISMACI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textPuan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxsSure);
            this.Controls.Add(this.textSoru);
            this.Controls.Add(this.groupBoxCevap);
            this.Controls.Add(this.groupBoxTahmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSoyadi);
            this.Controls.Add(this.textAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YARISMACI";
            this.Text = "YARISMACI";
            this.Load += new System.EventHandler(this.YARISMACI_Load);
            this.groupBoxTahmin.ResumeLayout(false);
            this.groupBoxTahmin.PerformLayout();
            this.groupBoxCevap.ResumeLayout(false);
            this.groupBoxsSure.ResumeLayout(false);
            this.groupBoxsSure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAdi;
        private System.Windows.Forms.TextBox textSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHarfAl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxTahmin;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox textBoxTahmin;
        private System.Windows.Forms.GroupBox groupBoxCevap;
        private System.Windows.Forms.TextBox textSoru;
        private System.Windows.Forms.GroupBox groupBoxsSure;
        private System.Windows.Forms.Button btnSureDurdur;
        private System.Windows.Forms.Label labelCevap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKalanSure;
        private System.Windows.Forms.Label labelKalanToplamSure;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerZamanlayici;
        private System.Windows.Forms.TextBox textPuan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timerBekleme;
        private System.Windows.Forms.Label label7;
    }
}

