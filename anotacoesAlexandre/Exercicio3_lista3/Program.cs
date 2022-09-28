// 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
// Se o usuário digitar 0 o programa em VS deve parar. 
// Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

int numero;
do {
    Console.Write("Digite um número inteiro qualquer ou 0 para sair: ");
    numero = int.Parse(Console.ReadLine());
    if (numero == 0)
    {
        break;
    }

    if (numero % 2 == 0) {
        Console.WriteLine(numero + " é par!!");
    } else {
        Console.WriteLine(numero + " é impar!!");
    }
    //regra do negócio
    int qtdDivisoesPerfeitas = 0;
    for (int i = 1; i <= numero; i++) {
        if (numero % i == 0) {
            qtdDivisoesPerfeitas++;
        }
    }

    if (qtdDivisoesPerfeitas > 2) {
        Console.WriteLine(numero + " Não é primo!");
    } else {
        Console.WriteLine(numero + " É primo!");
    }

} while (numero != 0);

