//1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
//(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
//Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

int numero;

do
{
    Console.Write("Digite um número inteiro: ");
    numero = int.Parse(Console.ReadLine());
    if (numero <= 0)
    {
        Console.WriteLine("Número inválido. Vai precisar redigitar!");
    }
    else break;

} while (true);

Console.Write("\n\nOs pares entre 1 e " + numero + " são: ");
for (int i = 1; i < numero; i++)
{
    Console.Write(i + "  ");
}