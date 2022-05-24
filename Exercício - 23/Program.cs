// Exercício 23
Console.WriteLine("Informe a temperatura:");
double temp = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informa a conversão que deseja:");
Console.WriteLine("1) De Celsius para Fahrenheit");
Console.WriteLine("2) De Fahrenheit para Celsius");
int conv = Convert.ToInt32(Console.ReadLine());

if (conv == 1)
{
    double F = (temp * 9/5) + 32;
    Console.WriteLine("A temperatura está °F" + F);
}
else
{
    double C = (temp -32) * 5/9;
    Console.WriteLine("A temperatura está °C" + C);
}