using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metodlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer --> Listele, ekle , sil , güncelle
            //Void 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surname}");
            //}

            //CustomerCard("Haçik", "Ulu");
            //CustomerCard("Mehmet", "Kaya");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine($"Toplam: {result}");
            //}

            //Sum(2, 4, 5);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return $"{name} {surname}";
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke :" + countryName + "-  Başkent: " + capital + "-  Bayrak Rengi: " + flagColor;
            //    return cardInfo;

            //}

            //string x, y, z;
            //Console.WriteLine("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.WriteLine("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.WriteLine("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    return result;
            //}

            //Console.WriteLine("Lütfen ilk sayıyı giriniz: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen üçüncü sayıyı giriniz: ");
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("Toplam: " + Sum(a, b, c));

            //Console.WriteLine($"Toplam : {Sum(1, 2, 3)}"); 
            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3 / 3);
            //    if (result >= 50)
            //    {
            //        return student + " isimli Öğrenci sınavı geçti" + " " + "Öğrenci Ortalama : " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli Öğrenci başarısız oldu" + " " + "Öğrenci Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 25, 10, 17));
            //Console.WriteLine(ExamResult("Ayşe", 60, 75, 85));

            #endregion

            //Console.Read();

        }
    }
}
