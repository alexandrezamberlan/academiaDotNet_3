//List<string> palavras = new List<string>();

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Palavra: ");
//    palavras.Add(Console.ReadLine());
//}

//Console.WriteLine("Digite algo para pesquisar:");
//string pesquisa = Console.ReadLine();

//if (!palavras.Contains(pesquisa))
//{
//    palavras.Add("nome2");
//}

//palavras.Sort();

//foreach (var item in palavras)
//{
//    Console.WriteLine(item);
//}

using Colecoes;

//List<Pessoa> pessoas = new List<Pessoa>();
//string nome;
//string cpf;
//DateOnly dataNascimento;
//Pessoa p;

//for (int i = 0; i < 2; i++)
//{
//    Console.Write("Nome: ");
//    nome = Console.ReadLine();

//    Console.Write("CPF: ");
//    cpf = Console.ReadLine();

//    Console.Write("Data Nascimento: ");
//    dataNascimento = DateOnly.Parse(Console.ReadLine());

//    p = new Pessoa(nome, cpf, dataNascimento);

//    if (!pessoas.Contains(p)) //ainda é uma busca sequencial
//    {
//        pessoas.Add(p);
//    }
//}
//foreach (var i in pessoas)
//{
//    Console.WriteLine(i);
//}

//SortedSet<Pessoa> pessoas = new SortedSet<Pessoa>();
//Random gerador = new Random();
//int numero;
//for (int i = 0; i < 10; i++)
//{
//    numero = gerador.Next(10);
//    if (!pessoas.Add(new Pessoa("Nome" + numero, ""+numero, DateOnly.Parse("12/12/2000"))));
//    {
//        System.Console.WriteLine("Pessoa com cpf já cadastrado");
//    }
//}

//foreach (var i in pessoas)
//{
//    Console.WriteLine(i);
//}


HashSet<Pessoa> pessoas = new HashSet<Pessoa>();
string nome;
string cpf;
DateOnly dataNascimento;
Pessoa p;

for (int i = 0; i < 2; i++)
{
    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("CPF: ");
    cpf = Console.ReadLine();

    Console.Write("Data Nascimento: ");
    dataNascimento = DateOnly.Parse(Console.ReadLine());

    p = new Pessoa(nome, cpf, dataNascimento);

    if (!pessoas.Add(p))
    {
        Console.WriteLine("Pessoa não cadastrada por conflito de CPF");
    }

    //SE OBSERVAREM AQUI... NÃO HÁ O CONTAINS, LOGO NÃO HÁ PESQUISA/BUSCA SEQUENCIAL
    //MAS SIM CALCULO DE ENDEREÇAMENTO POR CHAVE HASH -> DO INGLÊS ESPALHAMENTO
}

foreach (var i in pessoas)
{
    Console.WriteLine(i);
}


















