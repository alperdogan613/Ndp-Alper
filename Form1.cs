/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI:
** ÖĞRENCİ ADI: Ali Alper Doğan
** ÖĞRENCİ NUMARASI: B191200051
** DERSİN ALINDIĞI GRUP: A
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ali_Alper_Doğan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
                                //buton basımından etkilenmemeleri için stok ve kasa değişkenlerini giriyorum.
                                // ) her buton basımında kasa 0 olma durumu )
                                 int kasa = 0;
                                 int formasayac = 0;
                                 int biletsayac = 0;
                                 int formatoplam=10000;
                                 int bilettoplam = 20000;
        

        private void button1_Click_1(object sender, EventArgs e)
        {
                                //değişkenlerimi giriyorum textboxları onlara atıyorum.
                                int forma, bilet;

                                forma = Convert.ToInt32(TxtForma.Text);
            
                                //satılan forma sayımı belirlemek için sayaç kullanıyorum.
            
                                formasayac = formasayac + forma;

                                lbnsatılanformasayısı.Text = formasayac.ToString();

                                formatoplam = formatoplam - forma;
                                // stoğumda kaç formam kaldığını belirlemek için toplam formamdan girilen forma sayısını her buton basımında çıkartıyorum.
                                lbnkalanforma.Text = formatoplam.ToString();
                                 // kasa hesabımı yapıyorum.           
                                kasa = kasa + forma * 54;

                                lbnkasa.Text = kasa.ToString() + " tl";
      
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lbntoplamkâr_Click(object sender, EventArgs e)
        {
            // BU KISIMLARI SİLDİĞİMDE HATA VERİYOR BİR ETKİSİ YOK SİLMEDİM .
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             //forma satışında yaptığım hamleleri bilet satışında da gerçekleştiriyorum burda tek fark bilet kategorisine göre ücreti değiştiğinden if kullandım.
                             int bilet = Convert.ToInt32(TxtBilet.Text);

                              bilettoplam = bilettoplam - bilet;

                             lbnkalanbilet.Text = bilettoplam.ToString();
            
                             biletsayac = biletsayac + bilet;
                             
                             lbnsatılanbiletsayısı.Text = biletsayac.ToString();


                            int kategori;
                            
                            kategori = Convert.ToInt32(cmbkategori.Text);
            // kategorı text boxundan aldığım değer doğrultusunda bir ıf else koşulu kurdum 
            // 1. kategori kale arkası 2. kategori maraton 3. kategori numaralı olmak üzere 3 koşul var.
            if (kategori == 1)
            {
                kasa = kasa + bilet * 10;
                lbnkasa.Text = kasa.ToString() + " tl"; 
            }
           
            if (kategori == 2)
            {
                kasa = kasa + bilet * 20; 
                lbnkasa.Text = kasa.ToString() + " tl"; 
            }
            
            if (kategori == 3)
            {
                kasa = kasa + bilet * 30;
                lbnkasa.Text = kasa.ToString() + " tl";
            }
            
            else
            {
               
            }
           
        }
    }
}
