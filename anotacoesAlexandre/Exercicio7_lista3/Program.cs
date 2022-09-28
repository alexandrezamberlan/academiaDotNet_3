//Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
//A cada solicitação, teste se o usuário informou um valor válido. 
//Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
//informe que ele está incorreto e saia do programa em VS. 
//Se o nome for lido corretamente, solicite a idade. Se ela for incorreta
//(menor ou igual a zero), 
//informe que está errada e saia. Se estiver correta, solicite o salário. 
//Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
//Se estiver correto, mostre todos os valores lidos.

string nome;
int idade;
float salario;

do
{
    Console.Write("Nome: ");
    nome = Console.ReadLine();
    if (nome.Any(char.IsDigit) || string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Digite um nome válido!!");
    } else
    {
        break;
    }
} while (true);

do
{
    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());
    if (idade <= 0)
    {
        Console.WriteLine("Digite uma idade válida!!");
    } else
    {
        break;
    }

} while (true);

do
{
    Console.Write("Salário: ");
    salario = float.Parse(Console.ReadLine());
    if (salario <= 0)
    {
        Console.WriteLine("Digite um salário válido!!");
    } else
    {
        break;
    }
} while (true);

Console.WriteLine("Seus dados são: ");
Console.WriteLine("Nome: " + nome.ToUpper());
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Salário: " + salario);
