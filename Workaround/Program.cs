using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            refactoring();

            Vatandas vatandas = new Vatandas();

            SelamVer(isim: "Ümit");
            SelamVer(isim: "Engin");
            SelamVer(isim: "Mustafa");
            SelamVer();

            int sonuc = Topla(32);


            // Arrays
            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Devrim";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Devrim";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Engin";
            ogrenciler = new string[4];
            ogrenciler[3] = "Sırrı";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            Console.WriteLine("\n");

            string[] sehirler1 = new[] { "Ankara", "Antalya", "İzmir" };
            string[] sehirler2 = new[] {"Bursa", "Diyarbakır", "Şırnak"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 9;
            sayi2 = sayi1;

            Person person1 = new Person();
            person1.FirstName = "Kadri";
            person1.LastName = "Demirog";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 123;
            Person person2 = new Person();
            person2.FirstName = "Mazlum";

            foreach ( string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine("\n");

            List<string> yeniSehirler1 = new List<string> { "İstanbul 1", "Antalya 1", "Malatya 1" };
            yeniSehirler1.Add(item: "Şırnak");
            foreach( var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 7, int sayi2 = 3)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("\n Toplam : " + sonuc);
            return sonuc;
        }

        private static void refactoring()
        {
            String mesaj = "message";
            double tutar = 100000;  //db'den gelir...
            int sayi = 100;
            bool girisYapmisMi = false;


            string name = "Ümit";
            string surname = "Dengiz";
            int birthday = 1985;
            long tcNo = 12345678910;


            Console.WriteLine("Hi There");

            Console.WriteLine("\n" + tutar * 1.18 + "\n");
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
