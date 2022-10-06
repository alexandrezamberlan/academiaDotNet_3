using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class Lampada
    {
        private bool ligada;
        private double potencia;
        //public int teste;
        public void ligar()
        {
            ligada = true;
            Console.WriteLine("Ligando lâmpada!");
        }
        public void desligar()
        {
            ligada = false;
            Console.WriteLine("Desligando lâmpada!");
        }
        public bool estaLigada()
        {
            return ligada;
        }
    }
}
