// Exercício 06
Console.WriteLine("Nome do aluno:");
string aluno = Convert.ToString(Console.ReadLine());

Console.WriteLine("Digite a primeira nota:");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
double nota3 = Convert.ToDouble(Console.ReadLine());

double media = ((nota1 + nota2 + nota3) /3);

// Média
if (media < 0 || media > 10)
{
    Console.WriteLine("Média inválida.");
}
else if (media >= 7)
{
    Console.WriteLine("O " + aluno + " está aprovado(a).");
}
else if (media >= 5)
{
    Console.WriteLine("O " + aluno + " está em exame.");
}
else
{
    Console.WriteLine("O " + aluno + " está reprovado(a).");
}