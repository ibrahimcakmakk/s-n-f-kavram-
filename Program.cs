using System;
using System.Collections;

class Program{

    static void Main(string[] args){

        //söz Dizisi
        //class SinifAdi
        //{
        //  [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
        //  [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdi([Parametre Listesi])
        //  {
        //      Metot Konutları
        //   }
        // }

        //Erişim Berlileyiciler
        // * Public
        // * Private
        // * Internal
        // * Protected
        Calisan calısan1 = new Calisan();
        calısan1.Ad = "Ayşe";
        calısan1.Soyad = "kara";
        calısan1.No = 2345634;
        calısan1.Depertman = "insan Kaynakları";

        calısan1.CalışanBilgiler();

        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Deniz";
        calisan2.Soyad = "Arda";
        calisan2.No = 2345345;
        calisan2.Depertman = "satın alma";

        calisan2.CalışanBilgiler();
    
    }   
}

class Calisan{

    public string Ad;
    public string Soyad;
    public int No;
    public string Depertman;

    public void CalışanBilgiler(){
        Console.WriteLine("çalışanın Adı:{0}" ,Ad);
    }
}
