using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class Aviao
    {
        public string modelo;
        public double velocidade;
        public double altitude;
        public string marca;
        public void reduzir()
        {
            velocidade = velocidade - 10;
            Console.WriteLine("Reduzindo velocidade para "+velocidade);
        }
        public void acelerar()
        {
            velocidade = velocidade + 10;
            Console.WriteLine("Acelerando velocidade para " + velocidade);
        }
        public void descer()
        {
            altitude = altitude - 100;
            Console.WriteLine("Descendo para "+altitude+" metros...");
        }
        public void subir()
        {
            altitude = altitude + 100;
            Console.WriteLine("Subindo para " + altitude + " metros...");
        }
    }
}
