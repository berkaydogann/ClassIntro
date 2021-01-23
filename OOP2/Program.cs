using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMüsteri musteri1 = new GercekMüsteri();
            musteri1.MusteriNo = "123456";
            musteri1.MusteriAdi = "Berkay";
            musteri1.MusteriSoyadi = "Aydoğan";
            musteri1.TcNo = "123456879852";
            musteri1.Id = 1;
            

            TüzelMüsteri musteri2 = new TüzelMüsteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "52-131";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1335135";


            Musteri musteri3 = new GercekMüsteri();
            Musteri musteri4 = new TüzelMüsteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            //Gerçek Müşteri- Tüzel Müşteri
        }
    }
}
