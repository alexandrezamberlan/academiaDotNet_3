// Manipulando arquivos texto/
using System;
using System.Collections.Generic;


string frase = "";
List<string> listaDeFrases = new List<string>();

//conecto o sistema com a base de dados
Util.popularArquivoNaLista(listaDeFrases,"frases.txt");

//lista conteúdo da base de dados
Console.WriteLine("Frase já cadastradas!");
Util.mostrarLista(listaDeFrases);

while (true) {
    Console.Write("Digite uma frase qualquer ou sair: ");
    frase = Console.ReadLine();
    if (frase.ToUpper() == "SAIR") {
        break;
    }
    //adicionar na lista a frase, desque que não esteja cadastrada
    if (listaDeFrases.Contains(frase.ToUpper())) {
        Console.WriteLine("Frase já cadastrada na estrutura!");
    } else {
        listaDeFrases.Add(frase);        
        //gravar ou persistir o dado no arquivo
        Util.gravarFraseArquivo(frase, "frases.txt");
    }
}
