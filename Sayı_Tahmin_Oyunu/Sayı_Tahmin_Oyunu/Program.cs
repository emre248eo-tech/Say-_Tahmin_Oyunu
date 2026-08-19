using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int pc_sayi = random.Next(1, 100);

            Console.WriteLine("sayı tahmin oyunu");
            Console.WriteLine("bir sayı tahmin et");
            Console.WriteLine("****************************");
            do
            {


                int bizim_sayi = int.Parse(Console.ReadLine());



                if (bizim_sayi < pc_sayi)
                {
                    Console.WriteLine("rastgele sayı daha büyük");
                }
                else if (bizim_sayi > pc_sayi)
                {
                    Console.WriteLine("rastgele sayı daha küçük");

                }
                else if (bizim_sayi == pc_sayi)
                {
                    Console.WriteLine("doğru sayı!");
                    break;
                }


            } while (true);

        }
    }
}
