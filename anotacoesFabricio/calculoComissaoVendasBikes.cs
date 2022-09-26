static void Main(string[] args)
        {
            double salarioMin = 0;
            double comissao = 0, custo = 0;
            int quantidade = 0;

            Console.WriteLine("Informe o salário mínimo atual:");
            salarioMin = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço de custo da bike:");
            custo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de bikes vendidas:");
            quantidade = int.Parse(Console.ReadLine());

            double venda = custo + (custo * 0.5);
            comissao = (quantidade * venda) * 0.15;
            double salario = (salarioMin * 2) + comissao;

            Console.WriteLine("O salário resultou em: " + salario);
        }
