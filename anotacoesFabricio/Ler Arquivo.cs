
            StreamReader reader = new StreamReader(@"C:\Users\fabri\Desktop\atosUfn.txt");

            string linha = "xxxx";

            Console.WriteLine("---------------------------------------------");

            linha = reader.ReadLine();

            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = reader.ReadLine();
            }

            Console.WriteLine("---------------------------------------------");

            reader.Close();
