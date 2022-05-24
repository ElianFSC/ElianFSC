// Exercício 14
Console.WriteLine("Digite um número inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 1)
{
    Console.WriteLine("Este número é positivo.");
}
else if (numero <= (-1))
{
    Console.WriteLine("Este número é negativo.");
}
else
{
    Console.WriteLine("O número 0 não é positivo ou negativo, mas sim neutro.");
}