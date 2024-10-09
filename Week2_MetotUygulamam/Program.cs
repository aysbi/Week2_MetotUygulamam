using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------1.uygulama-------------------------------");

        SarkiSozu();

        Console.WriteLine("--------------------------2.uygulama-------------------------------");

        Console.WriteLine($"Rastgele sayinin 2ye bolumunden kalan sonuc {TamSayi()}");

        Console.WriteLine("---------------------------3.uygulama------------------------------");

        Console.Write("Carpim islemi icin 1. sayiyi giriniz: ");
        int Sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Carpim islemi icin 2. sayiyi giriniz: ");
        int Sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Carpim isleminin sonucu = {Carpim(Sayi1, Sayi2)}");

        Console.WriteLine("----------------------------4.uygulama-----------------------------");

        Console.Write("Isminizi yaziniz: ");
        string Isim = Console.ReadLine();

        Console.Write("soyisminizi yaziniz: ");
        string Soyisim = Console.ReadLine();

        IsimSoyisim(Isim, Soyisim);
    }

    static void SarkiSozu()
    {
        Console.WriteLine("çikita muz muz muz çikita muz");
    }

    static int TamSayi()
    {
        Random rastgele = new Random();
        int rastgeleSayi = rastgele.Next(1, 100);
        Console.WriteLine("Rastgele gelen sayi: " + rastgeleSayi);
        int sonuc = rastgeleSayi % 2;
        return sonuc;
    }

    static int Carpim(int Sayi1, int Sayi2)
    {
        int sonuc = Sayi1 * Sayi2;
        return sonuc;
    }

    static void IsimSoyisim(string isim, string soyisim)
    {

        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");

    }
}