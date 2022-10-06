using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class ContaBancaria
    {
        private string agencia;
        private int tipo;
        private double valor;
        private string conta;
        public ContaBancaria(string agencia, string conta, int tipo, double valor)
        {
            this.agencia = agencia;
            this.conta = conta;
            this.tipo = tipo;
            this.valor = valor;

        }
        public void depositar(double deposito)
        {
            valor = valor + deposito;
            Console.WriteLine("Depósito efetuado. O saldo é: " + valor);
        }
        public void sacar(double saque)
        {
            valor = valor - saque;
            Console.WriteLine("Saque de "+saque+" efetuado. O saldo é: "+valor);
        }
        public void consultarSaldo()
        {
            Console.WriteLine("O saldo da conta é: "+valor);
        }
        public void exibirDados()
        {
            Console.WriteLine("Agência: "+agencia);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Tipo: "+tipo);
            Console.WriteLine("Valor: "+valor);
        }
    }
}
