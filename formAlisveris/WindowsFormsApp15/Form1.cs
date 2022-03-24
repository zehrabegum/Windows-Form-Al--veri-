/***********************************************************************************************************************************
 SAKARYA ÜNİVERSİTESİ
 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 NESNEYE DAYALI PROGRAMLAMA DERSİ
 2019-2020 BAHAR DÖNEMİ
 ADI:ZEHRA BEGÜM  SOYADI:AKTOLGA   NUMARASI:B191210062   GRUP:1C GRUBU 1.ÖĞRETİM
/***********************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Urun
        {
            public string Ad, Marka, Model, Ozellik;
            public int StokAdedi, HamFiyat, SecilenAdet;
            static public Random RastGeleSayi = new Random();
        }
        class Buzdolabi : Urun
        {
            public double IcHacim;
            public string EnerjiSinifi;
            public double sonuc = 0;
            public Buzdolabi(int fiyat,double Hacim)
            {
                HamFiyat = fiyat;
                IcHacim = Hacim;
                StokAdedi = RastGeleSayi.Next(1, 100);
            }
            public Buzdolabi(string ad,string marka,string model,string ozellik,string enerjisınıfı)
            {
                Ad = ad;
                Marka = marka;
                Model = model;
                Ozellik = ozellik;
                EnerjiSinifi = enerjisınıfı;
            }
            public double KdvUygula()
            {
                sonuc = HamFiyat * 1.05 ;
                return sonuc;
            }
        }
        class LedTv : Urun
        {
            public int EkranBoyutu, EkranCozunurlugu;
            public double sonuc = 0;
            public LedTv(int fiyat,int ekranboyutu, int ekrancozunurlugu)
            {
                HamFiyat = fiyat;
                EkranBoyutu = ekranboyutu;
                EkranCozunurlugu = ekrancozunurlugu;
                StokAdedi = RastGeleSayi.Next(1, 100);
            }
            public LedTv(string ad, string marka, string model, string ozellik)
            {
                Ad = ad;
                Marka = marka;
                Model = model;
                Ozellik = ozellik;
            }
            public double KdvUygula()
            {
                sonuc = HamFiyat * 1.18 ;
                return sonuc;
            }
        }
        class CepTel : Urun
        {
            public int DahiliHafıza, RamKapasitesi, PilGucu;
            public double sonuc = 0;
            public CepTel(int fiyat,int dahilihafıza,int ramkapasitesi,int pilgucu)
            {
                HamFiyat = fiyat;
                DahiliHafıza = dahilihafıza;
                RamKapasitesi = ramkapasitesi;
                PilGucu = pilgucu;
                StokAdedi = RastGeleSayi.Next(1, 100);
            }
            public CepTel(string ad, string marka, string model, string ozellik)
            {
                Ad = ad;
                Marka = marka;
                Model = model;
                Ozellik = ozellik;
            }
            public double KdvUygula()
            {
                sonuc = HamFiyat * 1.20 ;
                return sonuc;
            }
        }
        class Laptop : Urun
        {
            public int EkranBoyutu, EkranCozunurluk, DahiliHafiza, RamKapasitesi, PilGucu;
            public double sonuc = 0;
            public Laptop(int fiyat,int ekranboyutu,int ekrancozunurluk,int dahilihafıza,int ramkapasitesi,int pilgucu)
            {
                HamFiyat = fiyat;
                EkranBoyutu = ekranboyutu;
                EkranCozunurluk = ekrancozunurluk;
                DahiliHafiza = dahilihafıza;
                RamKapasitesi = ramkapasitesi;
                PilGucu = pilgucu;
                StokAdedi = RastGeleSayi.Next(1, 100);
            }
            public Laptop(string ad, string marka, string model, string ozellik)
            {
                Ad = ad;
                Marka = marka;
                Model = model;
                Ozellik = ozellik;
            }
            public double KdvUygula()
            {
                sonuc = HamFiyat * 1.15 ;
                return sonuc;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LedTv televizyon = new LedTv(4000, 59,80);
            label5.Text = Convert.ToString(televizyon.StokAdedi);
            label4.Text = Convert.ToString(televizyon.HamFiyat);
            Buzdolabi buzdolabı = new Buzdolabi(3500, 40.5);
            label9.Text = Convert.ToString(buzdolabı.HamFiyat);
            label10.Text = Convert.ToString(buzdolabı.StokAdedi);
            Laptop bilgisayar = new Laptop(6000,4,67,89,89,5);
            label15.Text = Convert.ToString(bilgisayar.StokAdedi);
            label14.Text = Convert.ToString(bilgisayar.HamFiyat);
            CepTel telefon = new CepTel(2500,6,8,19);
            label20.Text = Convert.ToString(telefon.StokAdedi);
            label19.Text = Convert.ToString(telefon.HamFiyat);
        }
        class Sepet
        {
            public LedTv televizyon = new LedTv(4000, 59, 80);
            public Buzdolabi buzdolabı = new Buzdolabi(3500, 40.5);
            public Laptop bilgisayar = new Laptop(6000, 4, 67, 89, 89, 5);
            public CepTel telefon = new CepTel(2500,6, 8, 19);
            public void SepeteUrunEkle(Urun u1)
            {
                televizyon.KdvUygula();
                buzdolabı.KdvUygula();
                bilgisayar.KdvUygula();
                telefon.KdvUygula();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            int liste = listBox1.Items.Count;
            int liste2 = listBox2.Items.Count;
            int liste3 = listBox3.Items.Count;
            //BUTONA İKİNCİ KERE BASILDIĞINDA ÜRÜN VARSA EKLEMEMEYİ SAĞLAR.
            if(liste<4)
            {
                listBox1.Items.Add(Convert.ToString(numericUpDown1.Text));
                listBox1.Items.Add(Convert.ToString(numericUpDown2.Text));
                listBox1.Items.Add(Convert.ToString(numericUpDown3.Text));
                listBox1.Items.Add(Convert.ToString(numericUpDown4.Text));
            }
            if(liste2<4)
            {
                listBox2.Items.Add("Led Tv");
                listBox2.Items.Add("Buzdolabı");
                listBox2.Items.Add("Bilgisayar");
                listBox2.Items.Add("Cep Telefonu");
            }
            if(liste3<4)
            {
                double adet = Convert.ToDouble(numericUpDown1.Text);
                listBox3.Items.Add(Convert.ToString(sepet.televizyon.KdvUygula() * adet));
                double adet1 = Convert.ToDouble(numericUpDown2.Text);
                listBox3.Items.Add(Convert.ToString(sepet.buzdolabı.KdvUygula() * adet1));
                double adet2 = Convert.ToDouble(numericUpDown3.Text);
                listBox3.Items.Add(Convert.ToString(sepet.bilgisayar.KdvUygula() * adet2));
                double adet3 = Convert.ToDouble(numericUpDown4.Text);
                listBox3.Items.Add(Convert.ToString(sepet.telefon.KdvUygula() * adet3));
                double sonuc = 0;
                sonuc = (Convert.ToDouble(sepet.televizyon.KdvUygula() * adet)) + (Convert.ToDouble(sepet.buzdolabı.KdvUygula() * adet1)) + (Convert.ToDouble(sepet.bilgisayar.KdvUygula() * adet2)) + (Convert.ToDouble(sepet.telefon.KdvUygula() * adet3));
                label25.Text = Convert.ToString(sonuc) + " " + "TL";
            }
            int deger =Convert.ToInt32( label5.Text);
            int deger1 = Convert.ToInt32(label10.Text);
            int deger2 = Convert.ToInt32(label15.Text);
            int deger3 = Convert.ToInt32(label20.Text);
            //SEÇİLEN ÜRÜN SAYISINI STOKTAN DÜŞER.
            if(liste<4)
            {
                if (Convert.ToInt32(numericUpDown1.Text) > 0)
                {
                    int sayi = Convert.ToInt32(numericUpDown1.Text);
                    deger -= sayi;
                    label5.Text = Convert.ToString(deger);
                }
                if (Convert.ToInt32(numericUpDown2.Text) > 0)
                {
                    int sayi1 = Convert.ToInt32(numericUpDown2.Text);               
                    deger1 -= sayi1;
                    label10.Text = Convert.ToString(deger1);
                }
                if (Convert.ToInt32(numericUpDown3.Text) > 0)
                {
                    int sayi2 = Convert.ToInt32(numericUpDown3.Text);              
                    deger2 -= sayi2;
                    label15.Text = Convert.ToString(deger2);
                }
                if (Convert.ToInt32(numericUpDown4.Text) > 0)
                {
                    int sayi3 = Convert.ToInt32(numericUpDown4.Text);
                    deger3 -= sayi3;                                
                    label20.Text = Convert.ToString(deger3);
                }
            }          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label25.Text = " ";
            int deger = Convert.ToInt32(label5.Text);
            int deger1 = Convert.ToInt32(label10.Text);
            int deger2 = Convert.ToInt32(label15.Text);
            int deger3 = Convert.ToInt32(label20.Text);
            //SEÇİLEN ÜRÜN SAYISINI BUTONA BASINCA TEKRAR STOĞA EKLER.
            if (Convert.ToInt32(numericUpDown1.Text) > 0)
            {
                int sayi = Convert.ToInt32(numericUpDown1.Text);
                {
                    deger += sayi;
                }
                label5.Text = Convert.ToString(deger);
            }
            if (Convert.ToInt32(numericUpDown2.Text) > 0)
            {
                int sayi1 = Convert.ToInt32(numericUpDown2.Text);
                {
                    deger1 += sayi1;
                }
                label10.Text = Convert.ToString(deger1);
            }
            if (Convert.ToInt32(numericUpDown3.Text) > 0)
            {
                int sayi2 = Convert.ToInt32(numericUpDown3.Text);
                {
                    deger2 += sayi2;
                }
                label15.Text = Convert.ToString(deger2);
            }
            if (Convert.ToInt32(numericUpDown4.Text) > 0)
            {
                int sayi3 = Convert.ToInt32(numericUpDown4.Text);
                {
                    deger3 += sayi3;
                }
                label20.Text = Convert.ToString(deger3);
            }
            int deger4 = 0;
            numericUpDown1.Text =Convert.ToString(deger4);
            numericUpDown2.Text = Convert.ToString(deger4);
            numericUpDown3.Text = Convert.ToString(deger4);
            numericUpDown4.Text = Convert.ToString(deger4);
        }
    }
}
