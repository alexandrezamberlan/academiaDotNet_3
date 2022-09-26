using System;

namespace ConsoleAppBuscaEmFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase = "";
            String palavra = "";


            Console.WriteLine("Digite um frase:");
            frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra");
            palavra = Console.ReadLine();

            if(frase.Contains(palavra))
            {
                Console.WriteLine("A palavra encontra-se na frase!");
            }
            else
            {
                Console.WriteLine("A palavra não encontra-se na frase!");
            }

        }
    }
}
