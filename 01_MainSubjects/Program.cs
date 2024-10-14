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
            #region Yazdırma Komutları
            //Console.WriteLine("yusuf renklicaglar");
            //Console.Write("selam");
            //Console.Read();

            //Console.WriteLine("******** YEMEK MENÜLERİ ********");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorba");
            //Console.WriteLine("2-Salata");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("3-İçecekler");
            //Console.WriteLine("4-Soğuk Başlangıçlar");
            //Console.WriteLine();
            //Console.WriteLine("******** YEMEK MENÜLERİ ********");
            //Console.Read();
            #endregion
            #region StringDegiskenler
            //string name;
            //name = "yusuf";
            //Console.WriteLine(name);
            //Console.Read();

            //string costomerName;
            //string costomerSurname;
            //string costomerEmail;
            //string costomerPhone;
            //string district, city;

            //costomerName = "yusuf";
            //costomerSurname = "renklicaglar";
            //costomerEmail = "yusufrenklicaglar@gmail.com";
            //costomerPhone = "+90 0539 891 38 07";
            //district = "meram";
            //city = "konya";

            //Console.WriteLine("************ Rezervasyon Kartı ************");
            //Console.WriteLine("İsim:" + costomerName);
            //Console.WriteLine("SoyAd:" + costomerSurname);
            //Console.WriteLine("Mail:"+costomerEmail);
            //Console.WriteLine("Telefon:" + costomerPhone);
            //Console.WriteLine("Sehir:" + city);
            //Console.WriteLine("ilçe:"+district);
            //Console.WriteLine("----------------------------------------");


            //costomerName = "ali";
            //costomerSurname = "veli";
            //costomerEmail = "asdadsadsa@gmail.com";
            //costomerPhone = "+90 520 222 32 58";
            //district = "fatih";
            //city = "istanbul";

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("İsim:" + costomerName);
            //Console.WriteLine("SoyAd:" + costomerSurname);
            //Console.WriteLine("Mail:" + costomerEmail);
            //Console.WriteLine("Telefon:" + costomerPhone);
            //Console.WriteLine("Sehir:" + city);
            //Console.WriteLine("ilçe:" + district);
            //Console.WriteLine("----------------------------------------");
            //Console.Read();

            #endregion
            #region int degiskenler
            //int number;
            //number = 23;
            //Console.WriteLine(number);
            //Console.Read();
            int hamburgerPrice, lemonadePrice, pizzaPrice, cokePrice, friesPrice,waterPrice;
            hamburgerPrice = 300;
            lemonadePrice = 30;
            pizzaPrice = 250;
            cokePrice = 35;
            waterPrice = 10;
            friesPrice = 50;

            Console.WriteLine("************Restoran Menü Fiyatları**************");
            Console.WriteLine();
            Console.WriteLine("Hamburger fiyatı:" + hamburgerPrice + "TL");
            Console.WriteLine("Limonata Fiyatı:" +  lemonadePrice + "TL");
            Console.WriteLine("pizza fiyatı:" + pizzaPrice + "TL");
            Console.WriteLine("kola fiyatı:" + cokePrice + "TL");
            Console.WriteLine("patates fiyatı:" + friesPrice + "TL");
            Console.WriteLine("su fiyatı:" + waterPrice + "TL");
            Console.WriteLine("************Restoran Menü Fiyatları**************");
           

            int hamburgerCount, lemonadeCount, pizzaCount, cokeCount,friesCount,waterCount;
            waterCount = 3;
            hamburgerCount = 3;
            lemonadeCount = 3;
            pizzaCount = 1;
            cokeCount = 1;
            friesCount = 1;
            int totalprice = (hamburgerCount * hamburgerPrice)+(lemonadeCount*lemonadePrice)+(pizzaPrice*pizzaCount)+(cokeCount*cokePrice)+(friesCount*friesPrice)+(waterCount*waterPrice);
           
            Console.WriteLine("******************FATURA******************");
            Console.WriteLine("Hamburger Adedi:" + hamburgerCount+"="+hamburgerPrice*hamburgerCount+"TL");
            Console.WriteLine("Pizza adeti:" + pizzaCount+"="+pizzaCount*pizzaPrice+"TL");
            Console.WriteLine("Limonata Adedi:" + lemonadeCount + "=" + lemonadeCount * lemonadePrice + "TL");
            Console.WriteLine("Kola adeti:" + cokeCount+ "=" + cokeCount * cokePrice+ "TL");
            Console.WriteLine("Su adeti:" + waterCount + "=" + waterCount * waterPrice + "TL");
            Console.WriteLine("Pizza adeti:" + friesCount + "=" + friesCount * friesPrice + "TL");
            Console.WriteLine("Toplam tutar=" + totalprice);
            Console.WriteLine("******************FATURA******************");
            Console.Read();
            #endregion
        }
    }
}
