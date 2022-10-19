using System;
using System.Collections.Generic;
using System.IO;
using System.Text; 


public class Util {

    //méotod de classe
    public static void gravarFraseArquivo(string frase, string nomeArquivo) {
        StreamWriter escritor = new StreamWriter(nomeArquivo, append:true); //abre o arquivo para escrita
        escritor.WriteLine(frase.ToUpper());
        escritor.Flush();
        escritor.Close();
    }

    public static void popularArquivoNaLista(List<string> lista, string nomeArquivo) {
        try {

            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do {
                lista.Add(leitor.ReadLine());
            } while (!leitor.EndOfStream);

            leitor.Close();
        } catch(Exception ex) {
            Console.WriteLine("Deu problema no arquivo!");
        }        
    }

    public static void mostrarLista(List<string> lista) {
        foreach (var i in lista) {
            Console.WriteLine(i);
        }
    }


}

