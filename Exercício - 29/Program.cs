// Exercício 29
Console.WriteLine("Informe a velocidade máxima da pista:");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a velocidade do veículo:");
int veiculo = Convert.ToInt32(Console.ReadLine());

if (max > veiculo)
{
    Console.WriteLine("Ok, bom motorista");
}
else if (veiculo <= max+10)
{
    Console.WriteLine("Multa de R$50,00");
}
else if (veiculo <= max + 10.1 || veiculo <= max + 20)
{
    Console.WriteLine("Multa de R$100,00");
}
else if (veiculo <= max + 20.1 || veiculo <= max + 30)
{
    Console.WriteLine("Multa de R$200,00");
}
else if (veiculo <= max + 30.1 || veiculo <= max + 500)
{
    Console.WriteLine("Multa de R$300,00");
}