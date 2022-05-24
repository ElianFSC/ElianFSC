// Exercício 22
Console.WriteLine("Digite as quantidades de cada cédula:");
Console.WriteLine("Nota de R$2.00:");
int nota02 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nota de R$5.00:");
int nota05 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nota de R$10.00:");
int nota10 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nota de R$20.00:");
int nota20 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nota de R$50.00:");
int nota50 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nota de R$100.00:");
int nota100 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Nota de R$200.00:");
int nota200 = Convert.ToInt32(Console.ReadLine());

// Resolução

if (nota02 >= 0 && nota05 >= 0 && nota10 >= 0 && nota20 >= 0 && nota50 >= 0 && nota100 >= 0 && nota200 >= 0)
{
    Console.WriteLine("O valor total de cada nota é:");
    Console.WriteLine(nota02 * 2);
    Console.WriteLine(nota05 * 5);
    Console.WriteLine(nota10 * 10);
    Console.WriteLine(nota20 * 20);
    Console.WriteLine(nota50 * 50);
    Console.WriteLine(nota100 * 100);
    Console.WriteLine(nota200 * 200);
}

double n2 = nota02 * 2;

double n5 = nota05 * 5;

double n10 = nota10 * 10;

double n20 = nota20 * 20;

double n50 = nota50 * 50;

double n100 = nota100 * 100;

double n200 = nota200 * 200;

double total = n2 + n5 + n10 + n20 + n50 + n100 + n200;

Console.WriteLine("O valor total em cédulas é R$" + total + ".");