//Escreva um algoritmo que leia os valores para um vetor de 20 elementos
            //e então mostre na tela o índice da posição dos valores
            //correspondentes a números primos.
            int[] vetor = new int[5];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe um valor para a posição " + (i+1) + "do vetor");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                int count = 0;

                for (int x = 1; x <= vetor[i]; x++)
                {
                    if (vetor[i] % x == 0)
                    {
                        count++;
                    }
                }

                if(count == 2)
                {
                    Console.WriteLine("O valor da " +
                        "posição " + i + ":" + vetor[i] + " é um " +
                        "número primo!");
                }
            }
