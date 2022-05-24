// Exercício 03
Console.WriteLine("Qual o nome do produto?");
string produto = Convert.ToString(Console.ReadLine());

Console.WriteLine("Qual o valor deste produto?");
double valor = Convert.ToDouble(Console.ReadLine());

double desconto = valor * 0.9;

Console.WriteLine("O produto " + produto + " irá custar R$" + desconto + ".");