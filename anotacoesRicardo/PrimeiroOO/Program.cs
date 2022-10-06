using System.ComponentModel.Design.Serialization;

namespace AppOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apresentando Classes, objetos, métodos e orientação a objetos básica");
            /* Exemplo 1
             * Lampada l1 = new Lampada();
             bool retorno;
             l1.ligar();
             retorno = l1.estaLigada();
             Console.WriteLine("Status da Lampada: "+retorno);
             l1.desligar();
             retorno = l1.estaLigada();
             Console.WriteLine("Status da Lampada: " + retorno); */

            /* Exemplo 2
            Aviao a = new Aviao();
            a.marca = "AirBus";
            a.modelo = "A330";
            a.altitude = 10000;
            a.velocidade = 800;
            a.acelerar();
            a.descer();
            a.reduzir();
            a.subir();
            */
            string ag;
            int tp;
            double val;
            string c;
            double s, d;
            Console.WriteLine("Digite o número da agência: ");
            ag = Console.ReadLine();
            Console.WriteLine("Digite o número da conta: ");
            c = Console.ReadLine();
            Console.WriteLine("Digite o tipo da conta: 1 - para conta corrente\n 2 - para conta poupança");
            tp = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor inicial a ser depositado na conta: ");
            val = double.Parse(Console.ReadLine());


            ContaBancaria conta = new ContaBancaria(ag, c, tp, val);
   
            conta.exibirDados();
            Console.WriteLine("Digite o valor do saque: ");
            s = double.Parse(Console.ReadLine());
            conta.sacar(s);
            conta.consultarSaldo();
            Console.WriteLine("Digite o valor do depósito: ");
            d = double.Parse(Console.ReadLine());
            conta.depositar(d);


        }
    }
}