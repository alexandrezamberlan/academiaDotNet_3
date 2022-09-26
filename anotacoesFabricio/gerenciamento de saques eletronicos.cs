using System;

namespace ConsoleAppBuscaEmFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            double saque = 0;

            int total200 = 0, total100 = 0, total50 = 0, total20 = 0, total10 = 0, total5 = 0, total2 = 0, total1 = 0;

            Console.WriteLine("Informar o valor do saque:");
            saque = double.Parse(Console.ReadLine());

            total200 = (int)(saque / 200);
            Console.WriteLine("Notas de 200: " + total200);
            saque = saque - (200 * total200);

            total100 = (int)(saque / 100);
            Console.WriteLine("Notas de 100: " + total100);
            saque = saque - (100 * total100);

            total50 = (int)(saque / 50);
            Console.WriteLine("Notas de 50: " + total50);
            saque = saque - (50 * total50);

            total20 = (int)(saque / 20);
            Console.WriteLine("Notas de 20: " + total20);
            saque = saque - (20 * total20);

            total10 = (int)(saque / 10);
            Console.WriteLine("Notas de 10: " + total10);
            saque = saque - (10 * total10);

            total5 = (int)(saque / 5);
            Console.WriteLine("Notas de 5: " + total5);
            saque = saque - (5 * total5);

            total2 = (int)(saque / 2);
            Console.WriteLine("Notas de 2: " + total2);
            saque = saque - (2 * total2);

            total1 = (int)(saque / 1);
            Console.WriteLine("Notas de 1: " + total1);
            saque = saque - (1 * total1);

        }
    }
}
