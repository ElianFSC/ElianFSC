// Execício 18
Console.WriteLine("Informe um dia do mês de maio de 2022:");
int dia = Convert.ToInt32(Console.ReadLine());

if (dia <= 0 || dia >= 31)
{
    Console.WriteLine("Data inválida.");
}
else if (dia == 1 || dia == 8 || dia == 15 || dia == 22 || dia == 29)
{
    Console.WriteLine("Domingo");
}
else if (dia == 2 || dia == 9 || dia == 16 || dia == 23 || dia == 30)
{
    Console.WriteLine("Segunda-Feira");
}
else if (dia == 3 || dia == 10 || dia == 17 || dia == 24 || dia == 31)
{
    Console.WriteLine("Terça-Feira");
}
else if (dia == 4 || dia == 11 || dia == 18 || dia == 25)
{
    Console.WriteLine("Quarta-Feira");
}
else if (dia == 5 || dia == 12 || dia == 19 || dia == 26)
{
    Console.WriteLine("Quinta-Feira");
}
else if (dia == 6 || dia == 13 || dia == 20 || dia == 27)
{
    Console.WriteLine("Sexta-Feira");
}
else
{
    Console.WriteLine("Sábado");
}