static void Main(string[] args)
        {
            //3 prestações - 1+2x

            Console.WriteLine("Informe o valor da mercadoria");
            double mercadoria = double.Parse(Console.ReadLine());

            double prestacao = 0;

            double resto = mercadoria % 3;
            mercadoria = mercadoria - resto;

            prestacao = mercadoria / 3;

            double entrada = prestacao + resto;

            Console.WriteLine("entrade de " + entrada + " e 2x de " + prestacao);
        }
