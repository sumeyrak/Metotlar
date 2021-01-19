using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=??? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar2 =??? 999

            //int, decimal, float, double, bool = değer tip
            //array, class, interface = referans tip

            //Stack                 heap
            //102-sayilar1      102-[10,20,30]
            //102-sayilar2      102-[100 (999),200,300]
       
        }
    }
}
