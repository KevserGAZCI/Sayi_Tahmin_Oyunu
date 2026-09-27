using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayi_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int RastgeleSayi = rnd.Next(1,100);
            int TutulanSayi = 0, TahminHakki = 5;

            while (TahminHakki>0)
            {
                Console.WriteLine("1 ile 100 arasında bir sayı giriniz: ");
                TutulanSayi = Convert.ToInt32(Console.ReadLine());
                TahminHakki--;

                if (RastgeleSayi==TutulanSayi)
                {
                    Console.WriteLine("Sayıyı {0}. hakkınızda doğru tahmin ettiniz.", TahminHakki);
                    break;

                }
                else
                {
                    if (RastgeleSayi>TutulanSayi)
                    {
                        Console.WriteLine("Rastgele sayı daha büyük");
                    }
                    else if (RastgeleSayi<TutulanSayi)
                    {
                        Console.WriteLine("Rastgele sayı daha küçük");
                    }
                    Console.WriteLine("Kalan tahmin hakkınız {0}", TahminHakki);

                }
                if (TahminHakki==0)
                {

                    Console.WriteLine("Rastgele sayıyı tahmin edemediniz.Rastgele sayı {0}", RastgeleSayi);
                }
                Console.ReadLine();


            }
           


        }
    }
}
