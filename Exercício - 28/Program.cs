// Exercício 28
Console.WriteLine("Informe a medida que deseja converter:");
int medida = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o tipo de conversão que deseja:");
Console.WriteLine("1) De metros para quilômetros");
Console.WriteLine("2) De quilômetros para metros");
int conversao = Convert.ToInt32(Console.ReadLine());

if (conversao == 1)
{
    int km = medida / 1000;
    Console.WriteLine("A comprimento de " + medida + "m é igual a " + km + "km.");
}
else
{
    int m = medida * 1000;
    Console.WriteLine("A comprimento de " + medida + "km é igual a " + m + "m.");

}