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

    public static void gravarPessoaArquivo(Pessoa pessoa, string nomeArquivo) {
        StreamWriter escritor = new StreamWriter(nomeArquivo, append:true); //abre o arquivo para escrita
        escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email);
        escritor.Flush();
        escritor.Close();
    }

    public static void popularArquivoNaListaString(List<string> lista, string nomeArquivo) {
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

    public static void popularArquivoNaListaPessoa(List<Pessoa> lista, string nomeArquivo) {
        try {
            string linha;
            string[] dadosLinha;
            Pessoa pessoa;
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do {
                linha = leitor.ReadLine();
                dadosLinha = linha.Split(";");
                pessoa = new Pessoa(dadosLinha[0], dadosLinha[1]);
                lista.Add(pessoa);
            } while (!leitor.EndOfStream);

            leitor.Close();
        } catch(Exception ex) {
            Console.WriteLine("Deu problema no arquivo!");
        }        
    }

    public static void mostrarListaString(List<string> lista) {
        foreach (var i in lista) {
            Console.WriteLine(i);
        }
    }

    public static void mostrarListaPessoa(List<Pessoa> lista) {
        foreach (var i in lista) {
            Console.WriteLine("Nome: " + i.Nome + ". Email: " + i.Email);
        }
    }

    public static bool jaNaListaPessoa(Pessoa pessoa, List<Pessoa> lista) {
        foreach (var i in lista) {
            if (pessoa.Email == i.Email) {
                return true; //pessoa localizada pelo email
            }
        }
        return false; //pessoa não localizada pelo email
    }
}

