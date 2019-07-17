using System;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         
        #region Açıklama
        /*
* MANTIKSAL OPERATORLER
* Birden fazla durumun ayni anda kontrol edilmesi senaryosunda kullanilan operatorlerdir...
* && (VE) (Kontrol blogu icerisinde yer alan tum kosullarin saglanmasi durumuna isaret eder... Kosullardan biri dahi saglanmazsa blogunuz harekete gecmez...)
* || (VEYA) (Kontrol blogu icerisinde yer alan kosullardan herhangi birinin saglanmasi durumuna isaret eder... Boylece bir kosul bile saglansa blogunuza yazdiginiz kodlar harekete gecer...) Kısayol => ALTGR + Tire
* 
* Yukarıdaki operatorlere "kısa devre operatoru (shortcut operator)" adi verilir.. Kosullari kontrole en soldan baslar, herhangi bir uygunsuzluk durumunda diger kosullara asla bakmaz!.. Asagidaki operatorlerde ise, kosullar uysun ya da uymasin hepsi kontrol edilir...
* 

*/
        #endregion

        #region Örnek 1
        private void BtnGirisKontrolu_Click(object sender, EventArgs e)
        {
            if (txtBirinciDeger.Text == "admin" && txtIkinciDeger.Text == "1234")
            {
                MessageBox.Show("Tebrikler, tum bilgileri dogru girdiniz...");
            }
            else
            {
                //Iki kosuldan herhangi birinin saglanmamasi durumu
                MessageBox.Show("Kullanıcı adınızı ya da şifrenizi yanlış girdiniz!");
            }
        }
        #endregion

        #region Örnek 2
        private void BtnNotKontrolu_Click(object sender, EventArgs e)
        {
            /*Girilen not 0 - 30 araligi ise "FF" 30 - 50 araligi
             * "DD" 50 - 70 "BB" 70 - 100 "AA" aldınız seklinde kullaniciyi uyariniz.. */
            try
            {

            
            int not = int.Parse(txtBirinciDeger.Text);
            
            if (not < 30 && not > 0)
                MessageBox.Show("notunuz: FF");
            else if (not > 30 && not < 50)
                MessageBox.Show("notunuz: DD");
            else if (not < 70 && not > 50)
                MessageBox.Show("notunuz: BB");
            else if (not > 70 && not < 100)
                MessageBox.Show("notunuz: AA");
            else
                MessageBox.Show(" lütfen 0'la 100 arası bir deger giriniz");
            }
            catch (Exception)
            {
                MessageBox.Show(" lütfen 0'la 100 arasında sayısal bir deger giriniz");

            }
            txtBirinciDeger.Focus();
            txtBirinciDeger.Clear();
            

        }
        #endregion

        #region Örnek 3
        private void BtnMarketKontrolu_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!

            string urun = txtBirinciDeger.Text.ToLower();


            switch (urun)
            {
                case "domates":
                case "biber":
                case "patlıcan":
                    MessageBox.Show("sebze reyonu");
                    break;
                case "dişmacunu":
                case "parfüm":
                case "şampuan":
                    MessageBox.Show("kozmetik reyonu");
                    break;

                default:
                    MessageBox.Show("bu ürün bizde yok");
                    break;
            }
            txtBirinciDeger.Focus();
            txtBirinciDeger.Clear();

        }
        #endregion

        #region Örnek 4
        private void BtnSatisIslemi_Click(object sender, EventArgs e)
        {
            //Disaridan siparis alinacak olan kitap miktari girilsin.
            //Sipari sayisi 20'den azsa toplam ucretten %5, 
            //20 - 50 araliginda ise %10,
            //50 -100 araligi ise %15, 
            //100'den fazla ise %25 indirim yapilsin.
            //Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya gostermek...


            try
            {

                int miktar = int.Parse(txtBirinciDeger.Text);
                int birim = 5;

                if (miktar > 0 && miktar < 20)
                {
                    MessageBox.Show((miktar * birim * 0.95).ToString());
                }
                else if (miktar > 20 && miktar < 50)

                    MessageBox.Show("tutar: " + (miktar * birim * 0.90).ToString());
                else if (miktar > 50 && miktar < 100)
                    MessageBox.Show("tutar: " + (miktar * birim * 0.85).ToString());
                else if (miktar > 100)
                    MessageBox.Show("tutar: " + (miktar * birim * 0.75).ToString());
                else
                    MessageBox.Show("lütfen 0 dan büyük deger giriniz");
            }
            catch (Exception)
            {
                MessageBox.Show("lütfen 0 dan büyük sayısal bir deger giriniz");
                
            }
            txtBirinciDeger.Focus();
            txtBirinciDeger.Clear();

        } 
        #endregion
    }
}
