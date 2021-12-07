using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* * Bu proje Samet KAYA tarafından öğrenim/pekiştirme amacıyla geliştirilmiştir. 
 * 
 * !ÖNEMLİ!
 * ÇALIŞTIRMA NOTLARI:
 * 
 * 1- db klasöründeki veri tabanının ismini değiştirmeden C kök dizininize olduğu gibi kopyalayıp yapıştırın.
 * 2- uygulamayı muhakkak yönetici olarak çalıştırın.
 * 
 * UYGULAMANIN MAİN FORMU GİZLENMİŞTİR.
 * ALTTA ÇALIŞAN UYGULAMA SAYISININ YALNIZCA BİR TANE OLDUĞUNA DİKKAT EDİN
 * UYGULAMAYI ÇALIŞTIRDIKTAN SONRA EKRANDA HERHANGİ BİR ŞEY GÖRÜNMEMESİ SİZİ YANILTABİLİR VE BİRKAÇ DEFA AÇABİLİRSİNİZ
 * BU DA KRİTİK HATALARA SEBEBİYET VERECEKTİR.
 * 
 * uygulama çalıştıktan sonra:
 * 3- SHİFT + S kombinasyonu: kaydetme/listeleme formunu açar.
 * 4- SOL CTRL + S kombinasyonu: kaydetme/listeleme forumunu kapatır.
 * 5- SHİFT + T kombinasyonu: uygulama tamamen kapanır.
 * 6- SHİFT + L kombinasyonu: uygulamayı kitler. Uygulama kilitli iken shift + s gibi kombinasyonlar çalışmaz, shift + t kombinasyonu uygulamayı kolayca kapatabilmeniz adına hala çalışır vaziyettedir.
 * 
 * !ÖNEMLİ!
 * DERLEME NOTLARI:
 * windows 10 kullanıyorsanız hedef işlemcinizi özellikle x64 olarak seçmelisiniz,
 * windows 8.1 için x64 ve any tanımlı işlemci hedeflerinde sorunsuz çalışıyor,
 * 32 bit işletim sistemlerinde denemek için hedef işlemcinizi x86 yapmalısınız.
 * */


/*
 * Oledb API kullanılarak access veri tabanı üzerinde işlemler gerçekleştirmek amaçlanmıştır.
 * öğrenim sürecinin sonunda aktif olarak kullanılabilir bir uygulama ortaya koymak adına gerçekçi
 * bir gereksinim oluşturulup, algoritma da bu şekilde hazırlanmıştır.
 * Manuel global hotkey fonksiyonları için projeye dışarıdan sınıf dahil edilmiştir.
 * GH fonksiyonlarının kötü amaçlı kullanılmasının illegal olduğunu ve cezai sonuçları olabileceğini düşünerek hareket ediniz.
 * basit global hotkey kullanımı için faydalı olabileceğini düşündüğüm bağlantı ektedir:
 * https://ourcodeworld.com/articles/read/573/how-to-register-a-single-or-multiple-global-hotkeys-for-a-single-key-in-winforms
 * projede kullanılan GH scripti için attribution şu şekildedir:
 * http://tutplusplus.blogspot.com/2010/10/ultimate-keylogger-lesson-1-global.html
 * Proje öğrenim amaçlı geliştirildiği için: 
 * İçerisinde ölümcül buglar, absürt kod blokları ve hatalar bulunabilir, bunun sorumluluğunu alarak derleyip makineniz üzerinde çalıştırın.
 * Projenin içeriğindeki her türlü script ve dökümanı dilediğiniz gibi kullanabilirsiniz.
 * Proje üzerinde değişiklik yapmadan, olduğu gibi paylaşacaksanız attribution verilmesi gururumu okşar.
 * Manuel olarak GC kullanarak memory temizliği yapmayı bilmediğim için, 2. form ("serbest" adlı form) açılıp kapandıkça
 * uygulamanın bellekte kapladığı yer de artmaktadır. Bunu takip etmek için görev yöneticisinden bellek kullanımı takip etmeniz
 * bile yeterli olacaktır. Dispose fonksiyonları veya manuel GC oluşturabilen arkadaşlar varsa üzerine ekleme yapıp bana yollarsa sevinirim.
 */
namespace mfl
{
    public partial class Form1 : Form
    {
        public static bool opendorcontroller = true;
        private bool islock = false;
        private int lastKey;

        public Form1()
        {
           
            InitializeComponent();
 
        }

        GlobalKeyboardHook gHook;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
            gHook.hook();

        }

        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (islock == false)
            {
                if (opendorcontroller)
                {
                   
                    if (lastKey == 160 && e.KeyValue == 83) // sol shift ve S basılırsa
                    {
                        bool isserbestopen = false;
                        FormCollection fc = Application.OpenForms; // açık formları topla

                        foreach (Form frm in fc) // açık formları kontrol et
                        {
                            //iterate through
                            if (frm.Name == "serbest")//açık formlarında içinde serbest bulduysan
                            {
                                isserbestopen = true; // true yap
                                break; //döngüden direkt çık
                            }
                            else
                                isserbestopen = false; //serbest bulunmadıysa false yap
                        }

                        if (!isserbestopen) //serbest bulunmadı ise
                        {
                            serbest isserbest = new serbest();
                            isserbest.Show(); //serbesti aç
                            isserbest.BringToFront(); //serbesti öne getir
                            opendorcontroller = false;
                        }
                    }
                }
            }
            if (lastKey == 160 && e.KeyValue == 84) // sol shift ve T basıldığında
            {
                this.Close(); // terminate
            }
            if (lastKey == 160 && e.KeyValue == 76) // sol shift ve T basıldığında
            {
                islock = !islock;
                if(islock)
                    MessageBox.Show("kilitlendi");
                else
                    MessageBox.Show("kilit açıldı");
            }
            lastKey = e.KeyValue;


        }
    }
}
