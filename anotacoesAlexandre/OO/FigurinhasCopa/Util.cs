using System;
using System.Collections.Generic;
using System.IO;
using System.Text; 

public class Util {

    public static void gravarFigurinhaArquivo(Figurinha figurinha, string nomeArquivo) {
        StreamWriter escritor = new StreamWriter(nomeArquivo, append:true); //abre o arquivo para escrita
        escritor.WriteLine(figurinha.CodigoFigurinha + ";" + figurinha.Selecao + ";" + figurinha.NomeJogador);
        escritor.Flush();
        escritor.Close();
    }


    public static void popularArquivoNaListaFigurinha(List<Figurinha> lista, string nomeArquivo) {
        try {
            string linha;
            string[] dadosLinha;
            Figurinha figurinha;
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do {
                linha = leitor.ReadLine();
                dadosLinha = linha.Split(";");
                figurinha = new Figurinha(dadosLinha[0], dadosLinha[1], dadosLinha[2]);
                lista.Add(figurinha);
            } while (!leitor.EndOfStream);

            leitor.Close();
        } catch(Exception ex) {
            // Console.WriteLine("Deu problema no arquivo ou o arquivo está vazio!");
        }        
    }

    public static void mostrarListaFigurinhas(List<Figurinha> lista, string nomeArquivo, string tipo) {
        Console.WriteLine("Lista de figurinhas...." + tipo.ToUpper());
        StreamWriter escritor = new StreamWriter(nomeArquivo);
        foreach (var i in lista) {
            Console.WriteLine("Codigo: " + i.CodigoFigurinha + ". Seleção: " + i.Selecao + ". Jogador: " + i.NomeJogador);
            Console.WriteLine("----------------------------------");
            
            escritor.WriteLine("Codigo: " + i.CodigoFigurinha + ". Seleção: " + i.Selecao + ". Jogador: " + i.NomeJogador);
            escritor.WriteLine("----------------------------------");
            
        }
        escritor.Close();
    }

    public static bool jaNaListaFigurinha(Figurinha figurinha, List<Figurinha> lista) {
        
        foreach (var i in lista) {
            if (figurinha.CodigoFigurinha == i.CodigoFigurinha) {
                return true; //Figurinha localizada pelo codigo
            }
        }
        return false; //Figurinha não localizada pelo codigo
    }
}

