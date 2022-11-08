public class Figurinha {
    public string CodigoFigurinha {get;set;}
    public string Selecao {get; set;}
    public string NomeJogador {get;set;}

    public Figurinha(string codigo, string selecao, string jogador) {
        CodigoFigurinha = codigo;
        Selecao = selecao;
        NomeJogador = jogador;
    }
}