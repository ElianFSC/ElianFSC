// Exercício 31
Console.WriteLine("Informe o valor que será aplicado");
int aplicacao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual o tempo de investimento em meses");
int tempo = Convert.ToInt32(Console.ReadLine());

double taxa = tempo * 0.1767;

double termino = aplicacao * taxa;

Console.WriteLine("Após " + tempo + " meses o valor final da aplicação será de R$" + termino + ".");