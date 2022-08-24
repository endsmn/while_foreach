using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1 den başlayarak console dan girilen sayıya kadar ortalama hesaplayıp console'a yazdıran program.

            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
                
            }
            Console.WriteLine(toplam/sayi);

            char character = 'a';

            while (character<'z')
            {
                Console.Write(character);
                character++;
                
            }

            //Foreach
            string[] arabalar = {"BMW","Ford","Toyota","Volvo"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
                
            }

        }


    }
}
