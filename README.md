Örnek:
https://youtu.be/3zai9HsA1UI

OKUMADAN PROJEYİ VEYA BUİLDLERİ KULLANMAYINIZ.

Çözümünüz OleDB'yi tanımıyorsa aşağıdaki NuGet paket yükleyicisini kullanabilirsiniz:

"Install-Package System.Data.OleDb"

Test aşamasından önce sisteminize Microsoft Access Database Engine kurmanız önerilir:

https://www.microsoft.com/en-us/download/details.aspx?id=13255

/*  Bu proje Samet KAYA tarafından öğrenim/pekiştirme amacıyla geliştirilmiştir. 
 * 
 * !ÖNEMLİ!
 * ÇALIŞTIRMA NOTLARI:
 * 
 * 1- mfl/builds/A0.1/database klasöründeki mydb isimli veri tabanının ismini değiştirmeden C kök dizininize olduğu gibi kopyalayıp yapıştırın.
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
 * İçerisinde ölümcül buglar, absürt kod blokları ve hatalar bulunabilir, hatta hiç çalışmayabilir; bunun sorumluluğunu alarak derleyip makineniz üzerinde çalıştırın.
 * Projenin içeriğindeki her türlü script ve dökümanı dilediğiniz gibi kullanabilirsiniz.
 * Proje üzerinde değişiklik yapmadan, olduğu gibi paylaşacaksanız attribution verilmesi gururumu okşar.
 * Manuel olarak GC kullanarak memory temizliği yapmayı bilmediğim için, 2. form ("serbest" adlı form) açılıp kapandıkça
 * uygulamanın bellekte kapladığı yer de artmaktadır. Bunu takip etmek için görev yöneticisinden bellek kullanımı takip etmeniz
 * bile yeterli olacaktır. Dispose fonksiyonları veya manuel GC oluşturabilen arkadaşlar varsa üzerine ekleme yapıp bana yollarsa sevinirim.
 */
