static void Main(string[] args)
        {
            try
            {
                int x;
                Console.WriteLine("Informe um valor para X:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("O valor de X é " + x);
                Console.WriteLine("O valor 50 dividido por " + x + " resulta em " + (50/x));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Apenas números devem ser digitados!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally//opcional 
            {
                //fechar conexão com o banco
            }
        }
