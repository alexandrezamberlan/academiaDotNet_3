string nomeCompleto;
List<string> nomesPessoas = new List<string>();
int continuar;
string[] dadosNome;
do
{
    //
    do
    {
        Console.Write("Digite seu nome completo: ");
        nomeCompleto = Console.ReadLine().ToUpper();
        dadosNome = nomeCompleto.Split(" ");
        Console.WriteLine(dadosNome[0]);
    } while (dadosNome.Length <= 1);

    if (nomesPessoas.Contains(nomeCompleto))
    {
        Console.WriteLine("Nome já cadastrado");
    }
    else
    {
        nomesPessoas.Add(nomeCompleto);
    }

    Console.Write("1 - para continuar; 2 - para sair: ");
    continuar = int.Parse(Console.ReadLine());
} while (continuar == 1);

nomesPessoas.Sort();
Console.WriteLine("Pessoas cadastradas");
foreach (var item in nomesPessoas)
{
    Console.WriteLine(item);
}
