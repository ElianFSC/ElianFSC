// Exercício 17
Console.WriteLine("Qual seu nome?");
string nome = Convert.ToString(Console.ReadLine());

Console.WriteLine("Qual sua idade?");
int idade = Convert.ToInt32(Console.ReadLine());

int ano = 2022;

int nascimento = ano - idade;

Console.WriteLine("O(A) " + nome + " nasceu no ano de " + nascimento + ".");