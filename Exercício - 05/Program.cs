// Exercício 05
Console.WriteLine("Digite um ano:");
int ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ano % 4 == 0 ? "O " + ano + " é bissexto." : "O " + ano + " mão é bissexto.");