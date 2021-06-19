using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MukemmelSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int sayilar = 2; sayilar <= 1000; sayilar++)
            {
                MukemmelMi(sayilar);
            }
            Console.ReadKey();
        }

        public static void MukemmelMi(int sayi)
        {
            int toplamBolen = 0;
            for(int bolen = 1; bolen < sayi; bolen++)
            {
                if (sayi % bolen == 0)
                    toplamBolen += bolen;
            }

            if (toplamBolen == sayi)
                Console.WriteLine(sayi + " sayısı mükemmel sayıdır.");
        }
    }
}
