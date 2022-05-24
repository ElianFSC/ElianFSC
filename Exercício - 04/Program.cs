// Exercício 04
Console.WriteLine("Digite um número:");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um segundo número:");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a operação:");
Console.WriteLine("1) Somar:");
Console.WriteLine("2) Subtrarir:");
Console.WriteLine("3) Multiplicar:");
Console.WriteLine("4) Dividir:");
int operação = Convert.ToInt32(Console.ReadLine());

if(operação == 1)
{
    Console.WriteLine(numero1 + numero2);
}
else if(operação == 2)
{
    Console.WriteLine(numero1 - numero2);
}
else if(operação == 3)
{
    Console.WriteLine(numero1 * numero2);
}
else if(operação == 4)
{
    Console.WriteLine(numero2 / numero2);
}