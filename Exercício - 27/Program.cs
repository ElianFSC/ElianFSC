// Exercício 27
Console.WriteLine("Informe o número do seu dia de nascimento");
int dia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o número do seu mês de nascimento.");
int mes = Convert.ToInt32(Console.ReadLine());

if (dia >= 21 && mes >=3 || dia <= 20 && mes <= 4)
{
    Console.WriteLine("Seu signo é Áries.");
}
else if (dia >= 21 && mes >=4 || dia <= 20 && mes >= 5)
{
    Console.WriteLine("Seu signo é Touro.");
}
else if (dia >= 21 && mes >= 5 || dia <= 20 && mes >= 6)
{
    Console.WriteLine("Seu signo é Gêmeos.");
}
else if (dia >= 21 && mes >= 6 || dia <= 22 && mes >= 7)
{
    Console.WriteLine("Seu signo é Cãncer.");
}
else if (dia >= 23 && mes >= 7 || dia <= 22 && mes >=8)
{
    Console.WriteLine("Seu signo é Leão.");
}
else if (dia >= 23 && mes >= 8 || dia <= 22 && mes >= 9)
{
    Console.WriteLine("Seu signo é Virgem.");
}
else if (dia >= 23 && mes >= 9 || dia <= 22 && mes >= 10)
{
    Console.WriteLine("Seu signo é Libra.");
}
else if (dia >= 23 && mes >= 10 || dia <= 21 && mes >= 11)
{
    Console.WriteLine("Seu signo é Escorpião.");
}
else if (dia >= 22 && mes >= 11 || dia <= 21 && mes >= 12)
{
    Console.WriteLine("Seu signo é Sagitário.");
}
else if (dia >= 22 && mes >= 12 || dia <= 20 && mes >= 1)
{
    Console.WriteLine("Seu signo é Capricórnio");
}
else if (dia >= 21 && mes >= 1 || dia <= 18 && mes >= 2)
{
    Console.WriteLine("Seu signo é Aquário.");
}
else if (dia >= 19 && mes >= 2 || dia <= 20 && mes >= 3)
{
    Console.WriteLine("Seu signo é Peixes");
}