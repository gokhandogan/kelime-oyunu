
namespace kelime_oyunu
{
    partial class SORUKAYIT
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
            this.labelSoruKayıt = new System.Windows.Forms.Label();
            this.labelCevapKayıt = new System.Windows.Forms.Label();
            this.textBoxSoruKayıt = new System.Windows.Forms.TextBox();
            this.textBoxCevapKayıt = new System.Windows.Forms.TextBox();
            this.buttonSoruCevapKayıt = new System.Windows.Forms.Button();
            this.buttonOyunaBasla = new System.Windows.Forms.Button();
            this.labeKelimeOyunu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSoruKayıt
            // 
            this.labelSoruKayıt.AutoSize = true;
            this.labelSoruKayıt.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSoruKayıt.Location = new System.Drawing.Point(67, 107);
            this.labelSoruKayıt.Name = "labelSoruKayıt";
            this.labelSoruKayıt.Size = new System.Drawing.Size(111, 32);
            this.labelSoruKayıt.TabIndex = 0;
            this.labelSoruKayıt.Text = "SORU    :";
            // 
            // labelCevapKayıt
            // 
            this.labelCevapKayıt.AutoSize = true;
            this.labelCevapKayıt.BackColor = System.Drawing.Color.IndianRed;
            this.labelCevapKayıt.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCevapKayıt.Location = new System.Drawing.Point(67, 212);
            this.labelCevapKayıt.Name = "labelCevapKayıt";
            this.labelCevapKayıt.Size = new System.Drawing.Size(112, 32);
            this.labelCevapKayıt.TabIndex = 1;
            this.labelCevapKayıt.Text = "CEVAP   :";
            // 
            // textBoxSoruKayıt
            // 
            this.textBoxSoruKayıt.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSoruKayıt.Location = new System.Drawing.Point(202, 116);
            this.textBoxSoruKayıt.Multiline = true;
            this.textBoxSoruKayıt.Name = "textBoxSoruKayıt";
            this.textBoxSoruKayıt.Size = new System.Drawing.Size(348, 88);
            this.textBoxSoruKayıt.TabIndex = 2;
            this.textBoxSoruKayıt.TextChanged += new System.EventHandler(this.textBoxSoruKayıt_TextChanged);
            // 
            // textBoxCevapKayıt
            // 
            this.textBoxCevapKayıt.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxCevapKayıt.Location = new System.Drawing.Point(202, 221);
            this.textBoxCevapKayıt.Name = "textBoxCevapKayıt";
            this.textBoxCevapKayıt.Size = new System.Drawing.Size(348, 23);
            this.textBoxCevapKayıt.TabIndex = 3;
            this.textBoxCevapKayıt.TextChanged += new System.EventHandler(this.textBoxCevapKayıt_TextChanged);
            // 
            // buttonSoruCevapKayıt
            // 
            this.buttonSoruCevapKayıt.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSoruCevapKayıt.Location = new System.Drawing.Point(3, 19);
            this.buttonSoruCevapKayıt.Name = "buttonSoruCevapKayıt";
            this.buttonSoruCevapKayıt.Size = new System.Drawing.Size(176, 117);
            this.buttonSoruCevapKayıt.TabIndex = 4;
            this.buttonSoruCevapKayıt.Text = "KAYIT";
            this.buttonSoruCevapKayıt.UseVisualStyleBackColor = true;
            this.buttonSoruCevapKayıt.Click += new System.EventHandler(this.buttonSoruCevapKayıt_Click);
            // 
            // buttonOyunaBasla
            // 
            this.buttonOyunaBasla.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOyunaBasla.Location = new System.Drawing.Point(179, 19);
            this.buttonOyunaBasla.Name = "buttonOyunaBasla";
            this.buttonOyunaBasla.Size = new System.Drawing.Size(166, 117);
            this.buttonOyunaBasla.TabIndex = 5;
            this.buttonOyunaBasla.Text = "OYUNA BASLA";
            this.buttonOyunaBasla.UseVisualStyleBackColor = true;
            this.buttonOyunaBasla.Click += new System.EventHandler(this.buttonOyunaBasla_Click);
            // 
            // labeKelimeOyunu
            // 
            this.labeKelimeOyunu.AutoSize = true;
            this.labeKelimeOyunu.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeKelimeOyunu.Location = new System.Drawing.Point(324, 39);
            this.labeKelimeOyunu.Name = "labeKelimeOyunu";
            this.labeKelimeOyunu.Size = new System.Drawing.Size(185, 32);
            this.labeKelimeOyunu.TabIndex = 6;
            this.labeKelimeOyunu.Text = "KELİME OYUNU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSoruCevapKayıt);
            this.groupBox1.Controls.Add(this.buttonOyunaBasla);
            this.groupBox1.Location = new System.Drawing.Point(202, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // SORUKAYIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labeKelimeOyunu);
            this.Controls.Add(this.textBoxCevapKayıt);
            this.Controls.Add(this.textBoxSoruKayıt);
            this.Controls.Add(this.labelCevapKayıt);
            this.Controls.Add(this.labelSoruKayıt);
            this.Name = "SORUKAYIT";
            this.Text = "SORUKAYIT";
            this.Load += new System.EventHandler(this.SORUKAYIT_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoruKayıt;
        private System.Windows.Forms.Label labelCevapKayıt;
        private System.Windows.Forms.TextBox textBoxSoruKayıt;
        private System.Windows.Forms.TextBox textBoxCevapKayıt;
        private System.Windows.Forms.Button buttonSoruCevapKayıt;
        private System.Windows.Forms.Button buttonOyunaBasla;
        private System.Windows.Forms.Label labeKelimeOyunu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}