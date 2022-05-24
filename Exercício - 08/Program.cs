// Exercício 08
Console.WriteLine("Digita o tamanho do primeiro lado");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digita o tamanho do segundo lado");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digita o tamanho do terceiro lado");
double lado3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digita o tamanho do quarto lado");
double lado4 = Convert.ToDouble(Console.ReadLine());

if (lado1 != lado2 || lado3 != lado4)
{
    Console.WriteLine("Não é um quadrado");
}
else if (lado2 != lado3 || lado4 != lado1)
{
    Console.WriteLine("Não é um quadrado");
}
else if (lado1 == lado2 && lado3 == lado4)
{
    Console.WriteLine("É um quadrado");
}
else if (lado2 == lado3 && lado4 == lado1)
{
    Console.WriteLine("É um quadrado");
}