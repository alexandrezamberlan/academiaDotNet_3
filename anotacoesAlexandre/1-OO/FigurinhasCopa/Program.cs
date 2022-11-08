List<Figurinha> listaRepetidas = new List<Figurinha>();
List<Figurinha> listaFaltantes = new List<Figurinha>();


void cadastrarFigurinhaRepetida() {
    string codigo;
    string selecao;
    string jogador;
    Figurinha figurinha;

    Console.WriteLine("Cadastrando figurinha repetida!");

    Console.Write("Código da figurinha: ");
    codigo = Console.ReadLine().ToUpper();

    Console.Write("Seleção da figurinha: ");
    selecao = Console.ReadLine().ToUpper();

    Console.Write("Nome do jogador: ");
    jogador = Console.ReadLine().ToUpper();

    figurinha = new Figurinha(codigo, selecao, jogador);

    if (Util.jaNaListaFigurinha(figurinha, listaRepetidas)) {
        Console.WriteLine("Figurinha já cadastrada");
    } else {
        listaRepetidas.Add(figurinha);
        Util.gravarFigurinhaArquivo(figurinha,"repetidas.csv");
    }
}



//conectar com a base de dados
Util.popularArquivoNaListaFigurinha(listaRepetidas, "repetidas.csv");
Util.popularArquivoNaListaFigurinha(listaFaltantes, "faltantes.csv");

string opcao;

do {
    Console.WriteLine("1 - Cadastrar figurinha repetida");
    Console.WriteLine("2 - Cadastrar figurinha faltante");
    Console.WriteLine("3 - Listar figurinhas repetidas");
    Console.WriteLine("4 - Listar figurinhas faltantes");
    Console.WriteLine("5 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao) {
        case "1":
            cadastrarFigurinhaRepetida();
            break;
        case "2":
            break;
        case "3":
            Util.mostrarListaFigurinhas(listaRepetidas,"minhasRepetidas.txt", "Repetidas");
            break;
        case "4":
            break;
        case "5":
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

} while (opcao != "5");
