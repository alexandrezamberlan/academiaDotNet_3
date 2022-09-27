using System;

namespace ConsoleAppTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int contagem = 0;
            //double salario = 1000;

            //for (; salario < 5000; salario = salario + 700)
            //{
            //    contagem++;
            //}

            //Console.WriteLine(contagem);
            //Console.WriteLine(salario);

            //Console.WriteLine("hi");

            //i = i + 1;//i++;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Olá");
            //    Console.WriteLine("nundo");
            //    Console.WriteLine("!");
            //    Console.WriteLine("Bem-vindos a academia .net");
            //    Console.WriteLine("sdada");
            //}


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //contem quantos valores tem, entre 55 e 127
            //int contagem = 0;

            //for (int i = 56; i < 127; i++)
            //{
            //    contagem++;
            //}

            //Console.WriteLine(contagem);

            //somem os valores entre 55 e 127
            //int soma = 0;
            //for (int i = 56; i < 127; i++)
            //{
            //    //soma = soma + i;
            //    soma += i;
            //}

            //Console.WriteLine(soma);

            //contar quantos pares existem entre 55 e 127
            //int contagem = 0;

            //for (int i = 56; i < 127; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        contagem++;
            //    }
            //}

            //Console.WriteLine(contagem);

            //contar os impares e somar os pares existentes
            //no intervalo entre 55 e 127
            //int contagem = 0;
            //int soma = 0;

            //for (int i = 56; i < 127; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        contagem++;
            //    }
            //    else
            //    {
            //        soma += i;
            //    }
            //}

            //Console.WriteLine("Contem " + contagem + " números " +
            //    "impares e a soma dos pares resulta em " + soma);

            //contar os impares e somar os pares existentes
            //no intervalo informado pelo usuário

            //Console.WriteLine("Digite o valor inicial");
            //int inicio = int.Parse(Console.ReadLine());
            //int fim = 0;

            //while (inicio > fim)
            //{
            //    Console.WriteLine("Digite o valor final");
            //    fim = int.Parse(Console.ReadLine());
            //}

            //int contagem = 0;
            //int soma = 0;

            //for (int i = (inicio + 1); i < fim; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        contagem++;
            //    }
            //    else
            //    {
            //        soma += i;
            //    }
            //}

            //Console.WriteLine("Contem " + contagem + " números " +
            //    "impares e a soma dos pares resulta em " + soma);

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);

            //    i++;
            //}

            //int valor = 0;

            //do
            //{
            //    Console.WriteLine("Digite 0 para encerrar o programa");
            //    valor = int.Parse(Console.ReadLine());

            //} while (valor != 0);

            //contar quandos valores pares o usuario digitou
            //até ele digitar um valor negativo

            int contagem = 0;
            int valor = 0;


            while (true)
            {
                Console.WriteLine("Informe um valor");
                valor = int.Parse(Console.ReadLine());

                if (valor < 0)
                {
                    //continue;//encerra a iteração atual
                    //e parte para a seguinte

                    break;//freiar, interromper o
                          //laço de repetição
                }

                if (valor % 2 == 0)
                {
                    contagem++;
                }
                //if(valor % 2 == 0 && valor >= 0)
                //{
                //    contagem++;
                //}
            }

            Console.WriteLine(contagem);


        }
    }
}
