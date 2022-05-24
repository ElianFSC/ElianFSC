// Exercício 02

// Variavel para obter um número
int num = -1;

// Variavel para somar os valores informados
int soma = 0;

// Laço
while (num != 0)
{
    Console.WriteLine("Informe o número que deseja");
    num = Convert.ToInt32(Console.ReadLine());
    soma += num;
}

// Exibindo a soma
Console.WriteLine("A soma dos valores informados é " + soma + ".");