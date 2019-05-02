using System;

namespace algoritma1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3, buyuk, kucuk;
            Console.Write("bir sayi girin");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("bir sayi girin");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("bir sayi girin");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3 )
            {
                buyuk = sayi1;
            }
            else if (sayi2 > sayi3)
            {
                buyuk = sayi2;
            }
            else
            {
                buyuk = sayi3;
            }

            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                kucuk = sayi1;
            }
            else if (sayi2 < sayi3)
            {
                kucuk = sayi2;
            }
            else
            {
                kucuk = sayi3;
            }

            Console.WriteLine("girilen 3 sayıdan küçük ile büyüğün toplamı = {0}",kucuk + buyuk);
            Console.ReadLine();



            Console.WriteLine("Hello World!");
        }
    }
}
