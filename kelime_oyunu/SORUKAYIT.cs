using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace kelime_oyunu
{
    public partial class SORUKAYIT : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GMH6C0P;Initial Catalog=KelimeOyunu;
                                                    Integrated Security=True;Connect Timeout=30;
                                                    Encrypt=False;TrustServerCertificate=False;
                                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SORUKAYIT()
        {
            InitializeComponent();
        }

        private void textBoxSoruKayıt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCevapKayıt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SORUKAYIT_Load(object sender, EventArgs e)
        {

        }

        private void buttonSoruCevapKayıt_Click(object sender, EventArgs e)
        {
            if (textBoxSoruKayıt.Text == "" || textBoxCevapKayıt.Text == "")
            {
                MessageBox.Show("Lütfen Soruyu ve Cevabını Giriniz.");
            }
            else
            {
                if (textBoxCevapKayıt.Text.Length==4)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into dort_harfli(soru,cevap) " +
                                                    "values ('" + textBoxSoruKayıt.Text + "','" + textBoxCevapKayıt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Soru ve cevap veri tabanına kaydedildi.");
                }
                if (textBoxCevapKayıt.Text.Length == 5)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into bes_harfli(soru,cevap) " +
                                                    "values ('" + textBoxSoruKayıt.Text + "','" + textBoxCevapKayıt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Soru ve cevap veri tabanına kaydedildi.");
                }
                if (textBoxCevapKayıt.Text.Length == 6)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into alti_harfli(soru,cevap) " +
                                                    "values ('" + textBoxSoruKayıt.Text + "','" + textBoxCevapKayıt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Soru ve cevap veri tabanına kaydedildi.");
                }
                if (textBoxCevapKayıt.Text.Length == 7)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into yedi_harfli(soru,cevap) " +
                                                    "values ('" + textBoxSoruKayıt.Text + "','" + textBoxCevapKayıt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Soru ve cevap veri tabanına kaydedildi.");
                }
                if (textBoxCevapKayıt.Text.Length == 8)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into sekiz_harfli(soru,cevap) " +
                                                    "values ('" + textBoxSoruKayıt.Text + "','" + textBoxCevapKayıt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Soru ve cevap veri tabanına kaydedildi.");
                }
                if (textBoxCevapKayıt.Text.Length == 9)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into dokuz_harfli(soru,cevap) " +
                                                    "values ('" + textBoxSoruKayıt.Text + "','" + textBoxCevapKayıt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Soru ve cevap veri tabanına kaydedildi.");
                }
                if (textBoxCevapKayıt.Text.Length == 10)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into on_harfli(soru,cevap) " +
                                                    "values ('" + textBoxSoruKayıt.Text + "','" + textBoxCevapKayıt.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Soru ve cevap veri tabanına kaydedildi.");
                }
                textBoxSoruKayıt.Text = "";
                textBoxCevapKayıt.Text = "";
            }
        }

        private void buttonOyunaBasla_Click(object sender, EventArgs e)
        {
            YARISMACI yarismaci = new YARISMACI();
            yarismaci.Show();
            //this.Hide();
        }
    }
}
