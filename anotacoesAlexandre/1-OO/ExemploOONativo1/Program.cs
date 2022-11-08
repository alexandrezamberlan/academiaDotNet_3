//Console é uma classe nativa
//WriteLine() é um método de classe da classe Console, sem retorno
//Beep() é um método de classe da classe Console, sem retorno
//ReadLine() é um método de classe da classe Console, com retorno - string

//métodos de classe
//Classe.metodoDeClasse()

Console.Beep();
Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();


//frase é um objeto da classe string, que encapsula/recebe atributos e métodos 
//da classe string

int tamanhoFrase = frase.Length;
frase = frase.ToUpper();

//Length é um atributo de instância da classe string, que informa a quantidade de caracteres da frase
//ToUpper() é um método de instância, com retorno

Random gerador = new Random(); //o método construtor da classe Random é chamado
//o construtor aloca memória para o objeto gerador

int numeroQualquer = gerador.Next(10, 50);
//Next é um método de instância da classe Random com retorno
//Next possui 3 opcoes de comportamento/funcionalidade - polimorfismo de sobrecarga
Console.WriteLine("Número sorteado até 50: " + numeroQualquer);


List<string> nomesPessoas = new List<string>(); //construtor que instancia o
                                                //objeto nomesPessoas em memória

nomesPessoas.Add("Rafael Gioffi");
nomesPessoas.Add("Isabela da Silva");
nomesPessoas.Add("Kaue de Oliveira Victorio");

//Add é um método da instância nomesPessoas que insere uma string no final da lista

for (int i = 0; i < nomesPessoas.Count; i++)
{
    Console.WriteLine(nomesPessoas[i]);
}

//Count é um método de instância que sabe o tamanho da lista até aquele momento

nomesPessoas.Clear(); //limpa o conteúdo da lista
string nome;
do
{
    Console.WriteLine("Digite um nome ou 'sair': ");
    nome = Console.ReadLine().ToUpper();

    if (nome == "SAIR")
    {
        break;
    }

    if (nomesPessoas.Contains(nome))
    {
        Console.WriteLine("Nome já cadastrado!!");
    }
    else
    {
        nomesPessoas.Add(nome);
    }

} while (true);

//Contains é um método de instância com retorno que verifica se um valor está 
//ou não na lista
for (int i = 0; i < nomesPessoas.Count; i++)
{
    Console.WriteLine(nomesPessoas[i]);
}

Console.WriteLine("Tamanho da lista: " + nomesPessoas.Count);

nomesPessoas.Remove("ALEXANDRE");

Console.WriteLine("Tamanho da lista após remoção: " + nomesPessoas.Count);

Console.WriteLine("Lista ordenada");
nomesPessoas.Sort();

for (int i = 0; i < nomesPessoas.Count; i++)
{
    Console.WriteLine(nomesPessoas[i]);
}

//foreach (var pessoa in nomesPessoas)
//{
//    Console.WriteLine(pessoa);
//}


//métodos e atributos da classe List
//Add()
//Clear()
//Contains()
//Count
//Remove()
//Sort()
//IndexOf()

//métodos e atributos da classe string
//Length
//Contains()
//Replace()
//Split()
//string.IsNullOrWhiteSpace()

string email = "alexz@ufn.edu.br";

string[] dadosEmail = email.Split("@");
Console.WriteLine("usuario: " + dadosEmail[0]);
Console.WriteLine("dominio: " + dadosEmail[1]);

string frase = "A Margareth é do Rio de Janeiro e estuda C# em Santa Maria";
string [] palavrasFrase = frase.Split(" ");

foreach (var item in palavrasFrase)
{
    Console.WriteLine(item);
}

//for (int i = 0; i < palavrasFrase.Length; i++)
//{
//    Console.WriteLine(palavrasFrase[i]);
//}