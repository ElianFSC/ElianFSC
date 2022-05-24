// Exercíco 09
Console.WriteLine("Digite um número:");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite um segundo número:");
double numero2 = Convert.ToDouble(Console.ReadLine());

if (numero1 == numero2)
{
    double resultado = (numero1 + numero2);
    Console.WriteLine("A soma dos dois números é " + resultado + ".");
}
else if (numero1 != numero2)
{
    double resultado = (numero1 * numero2);
    Console.WriteLine("A multiplicação dos dois números é " + resultado + ".");
}