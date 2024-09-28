using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ₺ için Konsol Çıktısını UT8-e ayarlıyoruz.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #endregion

            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler
            // string

            //string name;
            //name = "Haçik";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 300 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + "" + customerSurname);
            //Console.WriteLine("İletişim :" + customerPhone);
            //Console.WriteLine("Email Adresi :" + customerEmail);
            //Console.WriteLine("Adres :" + district + "/" + city);
            //Console.WriteLine("--------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + "" + customerSurname);
            //Console.WriteLine("İletişim :" + customerPhone);
            //Console.WriteLine("Email Adresi :" + customerEmail);
            //Console.WriteLine("Adres :" + district + "/" + city);
            //Console.WriteLine("--------------------------------");

            #endregion

            #region Int Degişkenler

            //int 
            //int number = 24;
            //Console.WriteLine(number)

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger Fiyatı:" + hamburgerPrice);
            Console.WriteLine("----- Kola Fiyatı:" + cokePrice);
            Console.WriteLine("----- Su Fiyatı:" + waterPrice);
            Console.WriteLine("----- Patates Kızartması Fiyatı:" + friesPrice);
            Console.WriteLine("----- Pizza Fiyatı:" + pizzaPrice);
            Console.WriteLine("----- Limonata Fiyatı:" + lemonadePrice);
            Console.WriteLine();
            Console.WriteLine("**** Restorant Menü Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 1;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + " ₺");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + " ₺");
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + " ₺");
            Console.WriteLine("Patates Kızartması Tutarı:" + totalFriesPrice + " ₺");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + " ₺");
            Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + " ₺");

            Console.WriteLine();

            int[] totalPrice = new int[] { totalHamburgerPrice, totalCokePrice, totalWaterPrice, totalFriesPrice, totalPizzaPrice, totalLemonadePrice };
            int totalCount = 0;

            foreach (int price in totalPrice)
            {
                totalCount += price;
            }

            Console.WriteLine("Toplam Ödenecek Tutar:" + totalCount + " ₺");

            #endregion

            Console.Read();
        }
    }
}



// Yazdırma Komutları
