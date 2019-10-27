using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dışarıdan girilen 2 sayının (toplam,fark,çarpım,bölüm ve mod) işlemlerini yapıp kullanıcıya gösteriniz.

            Console.WriteLine("Lütfen 1. Sayıyı Giriniz : ");
            double s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı Giriniz : ");
            double s2 = Convert.ToInt32(Console.ReadLine());


            double toplam  = s1 + s2;
            double fark    = s1 - s2;
            double bolum   = s1 / s2;
            double carpim  = s1 * s2;
            double mod     = s1 % s2;

            Console.WriteLine("Toplama İşleminin Sonucu  : " + toplam);
            Console.WriteLine("Çıkartma İşleminin Sonucu : " + fark);
            Console.WriteLine("Çarpma İşleminin Sonucu   : " + carpim);
            Console.WriteLine("Bölme İşleminin Sonucu    : " + bolum);
            Console.WriteLine("Mod İşleminin Sonucu      : " + mod);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(
                  "Toplama İşleminin Sonucu  : "   + toplam 
                + "\nÇıkartma İşleminin Sonucu : " + fark 
                + "\nÇarpma İşleminin Sonucu   : " + carpim 
                + "\nBölme İşleminin Sonucu    : " + bolum 
                + "\nMod İşleminin Sonucu      : " + mod);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine( 
                "Toplama İşleminin Sonucu  :{0}" +
                "\nÇıkartma İşleminin Sonucu :{1}" +
                "\nÇarpma İşleminin Sonucu   :{2}" +
                "\nBölme İşleminin Sonucu    :{3}" +
                "\nMod İşleminin Sonucu      :{4}", toplam,fark, carpim, bolum, mod);


            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine( @"
Toplama İşleminin Sonucu  :{0}
Çıkartma İşleminin Sonucu :{1}
Çarpma İşleminin Sonucu   :{2}
Bölme İşleminin Sonucu    :{3} 
Mod İşleminin Sonucu      :{4}", toplam, fark, carpim, bolum, mod);
            int a1 = 123;
            int b1 = 213;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Toplama İşlemi sonucu : " + a1 + b1);   // => 123213
            Console.WriteLine("Toplama İşlemi sonucu : " + (a1 + b1)); // => 336 
            Console.ReadKey();
        }
    }
}
