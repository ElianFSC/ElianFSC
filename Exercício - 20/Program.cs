// Exercício 20
Console.WriteLine("Informe a conversão que deseja saber:");
Console.WriteLine("1) Conversão de Real para Dólar:");
Console.WriteLine("2) Conversão de Dólar para Real:");
Console.WriteLine("3) Conversão de Real para Euro:");
Console.WriteLine("4) Conversão de Euro para Real:");
Console.WriteLine("5) Conversão de Real para Libra:");
Console.WriteLine("6) Conversão de Libra para Real:");
Console.WriteLine("7) Conversão de Real para Peso Argentino:");
Console.WriteLine("8) Conversão de Peso Argentino para Real:");
int conversao = Convert.ToInt32(Console.ReadLine());

if (conversao == 1)
{
    Console.WriteLine("R$1,00 para US$0,21.");
}
else if (conversao == 2)
{
    Console.WriteLine("US$1,00 para R$4,82.");
}
else if (conversao == 3)
{
    Console.WriteLine("R$1,00 para EUR0,19.");
}
else if (conversao == 4)
{
    Console.WriteLine("EUR1,00 para R$5,17.");
}
else if (conversao == 5)
{
    Console.WriteLine("R$1,00 para £0,17.");
}
else if (conversao == 6)
{
    Console.WriteLine("£1,00 para R$6,02.");
}
else if (conversao == 7)
{
    Console.WriteLine("R$1,00 para $24,68.");
}
else
{
    Console.WriteLine("$1,00 para R$0,041.");
}