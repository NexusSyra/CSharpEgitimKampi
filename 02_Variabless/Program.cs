using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variabless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, strawPrice, strawberryPrice, potatoPrice, tamotoPrice, orangePrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tamotoPrice = 6.88;
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + "₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + "₺");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tamotoPrice + "₺");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tamotoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tamotoGram = 3.745; 

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = potatoGram * potatoPrice;
            //double tamotoTotalPrice = tamotoGram * tamotoPrice;

            //Console.WriteLine("Alınan Ürün: Elma -" + "Birm Fiyat:" + applePrice + " - Gramaj:" + appleGram + " -Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal -" + "Birm Fiyat:" + orangePrice + " - Gramaj:" + orangeGram + " -Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek -" + "Birm Fiyat:" + strawberryPrice + " - Gramaj:" + strawberryGram + " -Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates -" + "Birm Fiyat:" + potatoPrice + " - Gramaj:" + potatoGram + " -Toplam Tutar: " + patatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates -" + "Birm Fiyat:" + tamotoPrice + " - Gramaj:" + tamotoGram + " -Toplam Tutar: " + tamotoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tamotoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "₺");

            #endregion

            #region Char Değişkenler

            //ABCDEFG
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char symbol;
            //symbol= 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri string Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Ad:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu Ad :" + passengerName + " ");
            //Console.WriteLine("Yolcu SoyAdı: " + passengerSurname + "");
            //Console.WriteLine("İlçe Bilgisi: " + passengerDistrict+" ");
            //Console.WriteLine("Şehir Blgisi:" + passengerCity + " ");
            //Console.WriteLine("Yolcu Yaşı:" + passengerAge + " ");
            //Console.WriteLine("Yolcu Tc Kimlik No: " + passengerIdentityNumber + "");
            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //ABC12D
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Girin: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Girin: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Girin: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalama Sınav Ortalamanız: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Şeçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Şeçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
