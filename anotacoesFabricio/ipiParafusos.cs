Console.WriteLine("Informe o código do parafuso A");
            int codA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de parafusos A");
            int quantA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do parafuso A");
            double valorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código do parafuso B");
            int codB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de parafusos B");
            int quantB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do parafuso B");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual do IPI");
            double ipi = double.Parse(Console.ReadLine());

            double totalA, totalB;

            totalA = (quantA * valorA);
            totalA = totalA + (totalA * (ipi / 100));

            totalB = quantB * valorB;
            totalB = totalB + (totalB * (ipi/100));

            Console.WriteLine("Custo total dos parafusos A:" + totalA);
            Console.WriteLine("Custo total dos parafusos B:" + totalB);
