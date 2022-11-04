using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class Modelo
    {
        public static void gravarLista(List<string> lista, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo);

            foreach (var item in lista)
            {
                escritor.WriteLine(item);
            }

            escritor.Close();
        }

        public static void lerArquivo(List<string> lista, string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    lista.Add(leitor.ReadLine());
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Base de dados inexistente. Será criada","Alerta");
            }
        }
    }
}
