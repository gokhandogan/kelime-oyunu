using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;


namespace kelime_oyunu
{
    public partial class YARISMACI : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GMH6C0P;Initial Catalog=KelimeOyunu;
                                                    Integrated Security=True;Connect Timeout=30;
                                                    Encrypt=False;TrustServerCertificate=False;
                                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public YARISMACI()
        {
            InitializeComponent();
        }

        DateTime tarih;
        DateTime baslangic_saati;
        DateTime bitis_saati;
        string kelime;
        int uzunluk,harfIndex,cezaSayac,baslama,puanSayac,rastgele_soru;
        int sayacBekletme = 2;
        int sayac = 0;
        int numara = 1;
        int kalanDakika = 4;
        int kalanSaniye = 0;
        int kalanSure = 20;
        int btnKontrol = 0;
        string tahmin;
        string[] harfler;
        Random rastgele = new Random();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void YARISMACI_Load(object sender, EventArgs e)
        { 
            timerZamanlayici.Start();        
        }
        void kelimeLabelAktar()
        {
            labelCevap.Text = "";
            for(int i = 0; i < uzunluk; i++)
            {
                labelCevap.Text += "_";
            }
        }
        void diziyeAktar()
        {
            for (int i = 0; i < uzunluk; i++)
            {
                harfler[i] = kelime.Substring(i, 1);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (baslama == 1)
            {
                if (kalanSure > 0 && btnKontrol == 1)
                {
                    kalanSure--;
                    labelKalanSure.Text = Convert.ToString(kalanSure);
                }
                else if (kalanSaniye > 0 && kalanDakika > 0)
                {
                    kalanSaniye--;
                    labelKalanToplamSure.Text = kalanDakika + " : " + kalanSaniye;
                }
                else if (kalanSaniye == 0 && kalanDakika > 0)
                {
                    kalanDakika--;
                    kalanSaniye = 59;
                    labelKalanToplamSure.Text = kalanDakika + " : " + kalanSaniye;
                }
                else if (kalanSaniye > 0 && kalanDakika == 0)
                {
                    kalanSaniye--;                   
                    labelKalanToplamSure.Text = kalanDakika + " : " + kalanSaniye;
                }
                if (kalanSure == 0)
                {
                    for (int i = 0; i < uzunluk; i++)
                    {
                        if (labelCevap.Text.Substring(i, 1) == "_")
                        {
                            cezaSayac++;
                        }
                    }
                    if (Convert.ToInt32(textPuan.Text) - cezaSayac * 100 < 0)
                    {
                        textPuan.Text = "0";
                        cezaSayac = 0;
                        btnKontrol = 0;
                        kalanSure = 20;
                        labelKalanSure.Text = Convert.ToString(kalanSure);
                        bekletme();

                    }
                    else
                    {
                        textPuan.Text = Convert.ToString(Convert.ToInt32(textPuan.Text) - cezaSayac * 100);
                        cezaSayac = 0;
                        btnKontrol = 0;
                        kalanSure = 20;
                        labelKalanSure.Text = Convert.ToString(kalanSure);
                        bekletme();

                    }
                    
                }
            }                       
        }

        void bekletme()
        {
            
            textBoxTahmin.Text = "";
            labelCevap.Text = kelime;
            btnHarfAl.Enabled = false;
            btnSureDurdur.Enabled = false;
            btnTahmin.Enabled = false;
            btnBasla.Enabled = false;
            btnKayıt.Enabled = false;
            timerZamanlayici.Stop();
            timerBekleme.Start();
        }

        private void btnSureDurdur_Click(object sender, EventArgs e)
        {
            if (baslama == 1)
            {
                btnKontrol = 1;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (numara>14)
            {
                baslama = 0;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into table_yarismaci(ad,soyad,puan,tarih,baslamazamani,bitiszamani,kalanzaman) " +
                                                "values ('" + textAdi.Text + "','" + textSoyadi.Text + "','" +
                                                   Convert.ToInt32(textPuan.Text) + "','" + tarih.ToLongDateString() + "'" +
                                                   ",'" + baslangic_saati.ToLongTimeString() + "'" +
                                                   ",'" + bitis_saati.ToLongTimeString() + "','" + (kalanDakika + " : " + kalanSaniye) + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                StreamWriter dosya = File.AppendText(@"C:\Users\17901\Desktop\kelimeOyunu.txt");
                dosya.WriteLine("Adı: " + textAdi.Text + "\t\t" + "Soyadı : " +
                                textSoyadi.Text + "\t\t" + "Puanı : " + textPuan.Text + "\t\t" + "Tarih : " + tarih.ToLongDateString()
                                + "\t\t" + "baslangic_saati : " + baslangic_saati.ToLongTimeString() + "\t\t" + "bitis_saati : " + bitis_saati.ToLongTimeString()
                                + "\t\t" + "Kalan_zaman : " + (kalanDakika + " : " + kalanSaniye));
                dosya.Close();
                textAdi.Text = "";
                textSoyadi.Text = "";
                textPuan.Text = "0";
                kalanDakika = 4;
                kalanSaniye = 0;
                kalanSure = 20;
                btnKontrol = 0;
                labelKalanToplamSure.Text = kalanDakika + " : " + kalanSaniye;
                labelKalanSure.Text = Convert.ToString(kalanSure);
                numara = 1;
                MessageBox.Show("Yarışmacı veri tabanına kaydedildi.");
                
            }
            if (kalanDakika == 0 && kalanSaniye == 0)
            {
                baslama = 0;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into table_yarismaci(ad,soyad,puan,tarih,baslamazamani,bitiszamani,kalanzaman) " +
                                                "values ('"+ textAdi.Text +"','"+ textSoyadi.Text +"','"+ 
                                                   Convert.ToInt32(textPuan.Text) + "','" + tarih.ToLongDateString() + "'" +
                                                   ",'" + baslangic_saati.ToLongTimeString() + "'" +
                                                   ",'" + bitis_saati.ToLongTimeString() + "','" + (kalanDakika + " : " + kalanSaniye) + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                StreamWriter dosya = File.AppendText(@"C:\Users\17901\Desktop\kelimeOyunu.txt");
                dosya.WriteLine("Adı: " + textAdi.Text + "\t\t" + "Soyadı : " +
                                textSoyadi.Text + "\t\t" + "Puanı : " + textPuan.Text + "\t\t" + "Tarih : " + tarih.ToLongDateString()
                                + "\t\t" + "baslangic_saati : " + baslangic_saati.ToLongTimeString() + "\t\t" + "bitis_saati : " + bitis_saati.ToLongTimeString()
                                + "\t\t" + "Kalan_zaman : " + (kalanDakika + " : " + kalanSaniye));
                dosya.Close();
                textAdi.Text = "";
                textSoyadi.Text = "";
                textPuan.Text = "0";
                kalanDakika = 4;
                kalanSaniye = 0;
                kalanSure = 20;
                btnKontrol = 0;
                labelKalanToplamSure.Text = kalanDakika + " : " + kalanSaniye;
                labelKalanSure.Text = Convert.ToString(kalanSure);
                numara = 1;
                MessageBox.Show("Yarışmacı veri tabanına kaydedildi.");
                

            }
        }

        private void textSoru_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerBekleme_Tick(object sender, EventArgs e)
        {
            label7.Text = Convert.ToString(sayacBekletme);
            sayacBekletme--;
            sayac++;
            if(sayac == 3)
            {
                timerZamanlayici.Start();
                numara++;
                soruCek(numara);
                textBoxTahmin.Text = "";
                btnSureDurdur.Enabled = true;
                btnTahmin.Enabled = true;
                btnHarfAl.Enabled = true;
                btnBasla.Enabled = true;
                btnKayıt.Enabled = true;
                sayacBekletme = 2;
                label7.Text = "";
                sayac = 0;
                timerBekleme.Stop();
            }
            
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if(textAdi.Text=="" || textSoyadi.Text == "")
            {
                MessageBox.Show("Lütfen Adınızı ve Soyadınızı Giriniz.");
            }
            else
            {
                tarih = DateTime.Now;
                baslangic_saati = DateTime.Now;
                soruCek(numara);
                baslama = 1;
                

            }
        }
        void soruCek(int numara)
        {
            rastgele_soru = rastgele.Next(1,10);
            if (numara==1 || numara==2)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from dort_harfli where siranu = '" +
                                                    rastgele_soru + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textSoru.Text = read["Soru"].ToString();
                    kelime = read["Cevap"].ToString();
                }
                baglanti.Close();
                uzunluk = kelime.Length;
                harfler = new string[uzunluk];
                kelimeLabelAktar();
                diziyeAktar();
            }
            if (numara == 3 || numara == 4)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from bes_harfli where siranu = '" +
                                                    rastgele_soru + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textSoru.Text = read["Soru"].ToString();
                    kelime = read["Cevap"].ToString();
                }
                baglanti.Close();
                uzunluk = kelime.Length;
                harfler = new string[uzunluk];
                kelimeLabelAktar();
                diziyeAktar();
            }
            if (numara == 5 || numara == 6)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from alti_harfli where siranu = '" +
                                                    rastgele_soru + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textSoru.Text = read["Soru"].ToString();
                    kelime = read["Cevap"].ToString();
                }
                baglanti.Close();
                uzunluk = kelime.Length;
                harfler = new string[uzunluk];
                kelimeLabelAktar();
                diziyeAktar();
            }
            if (numara == 7 || numara == 8)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from yedi_harfli where siranu = '" +
                                                    rastgele_soru + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textSoru.Text = read["Soru"].ToString();
                    kelime = read["Cevap"].ToString();
                }
                baglanti.Close();
                uzunluk = kelime.Length;
                harfler = new string[uzunluk];
                kelimeLabelAktar();
                diziyeAktar();
            }
            if (numara == 9 || numara == 10)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from sekiz_harfli where siranu = '" +
                                                    rastgele_soru + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textSoru.Text = read["Soru"].ToString();
                    kelime = read["Cevap"].ToString();
                }
                baglanti.Close();
                uzunluk = kelime.Length;
                harfler = new string[uzunluk];
                kelimeLabelAktar();
                diziyeAktar();
            }
            if (numara == 11 || numara == 12)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from dokuz_harfli where siranu = '" +
                                                    rastgele_soru + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textSoru.Text = read["Soru"].ToString();
                    kelime = read["Cevap"].ToString();
                }
                baglanti.Close();
                uzunluk = kelime.Length;
                harfler = new string[uzunluk];
                kelimeLabelAktar();
                diziyeAktar();
            }
            if (numara == 13 || numara == 14)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from on_harfli where siranu = '" +
                                                    rastgele_soru + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    textSoru.Text = read["Soru"].ToString();
                    kelime = read["Cevap"].ToString();
                }
                baglanti.Close();
                uzunluk = kelime.Length;
                harfler = new string[uzunluk];
                kelimeLabelAktar();
                diziyeAktar();
            }

            if (numara>14)
            {
                bitis_saati = DateTime.Now;
                timerZamanlayici.Stop();
            }

        }
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (btnKontrol == 1)
            {
                tahmin = textBoxTahmin.Text;
                if (tahmin == kelime)
                {
                    for (int i = 0; i < uzunluk; i++)
                    {
                        if (labelCevap.Text.Substring(i, 1) == "_")
                        {
                            puanSayac++;
                        }

                    }
                    textPuan.Text = Convert.ToString(Convert.ToInt32(textPuan.Text) + puanSayac * 100);
                    puanSayac = 0;
                    btnKontrol = 0;
                    kalanSure = 20;
                    labelKalanSure.Text = Convert.ToString(kalanSure);
                    bekletme();

                }
                else
                {
                    for (int i = 0; i < uzunluk; i++)
                    {
                        if(labelCevap.Text.Substring(i, 1) == "_")
                        {
                            cezaSayac++;
                        }                        
                    }
                    if(Convert.ToInt32(textPuan.Text) - cezaSayac * 100 < 0)
                    {
                        textPuan.Text = "0";
                        cezaSayac = 0;
                        btnKontrol = 0;
                        kalanSure = 20;
                        labelKalanSure.Text = Convert.ToString(kalanSure);
                        bekletme();

                    }
                    else
                    {
                        textPuan.Text = Convert.ToString(Convert.ToInt32(textPuan.Text) - cezaSayac * 100);
                        cezaSayac = 0;
                        btnKontrol = 0;
                        kalanSure = 20;
                        labelKalanSure.Text = Convert.ToString(kalanSure);
                        bekletme();

                    }
                }
                    
            }
            
        }
       
        private void btnHarfAl_Click(object sender, EventArgs e)
        {
            
            
            if (baslama == 1)
            {
                
                
                harfIndex = rastgele.Next(kelime.Length);
                while (labelCevap.Text.Substring(harfIndex, 1) != "_")
                {
                    if (labelCevap.Text.IndexOf("_") == -1)
                    {
                        numara++;
                        soruCek(numara);
                        textBoxTahmin.Text = "";
                        break;
                    }
                    harfIndex = rastgele.Next(kelime.Length);
                }
                labelCevap.Text = labelCevap.Text.Remove(harfIndex, 1);
                labelCevap.Text = labelCevap.Text.Insert(harfIndex, harfler[harfIndex]);
                if (Convert.ToInt32(textPuan.Text) > 0)
                {
                    textPuan.Text = Convert.ToString(Convert.ToInt32(textPuan.Text) - 100);
                }
                if (labelCevap.Text == kelime)
                {
                    bekletme();
                   
                }
            }           
            
        }
    }
}

