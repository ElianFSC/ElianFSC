// Exercício 21
Console.WriteLine("Informe o valor em R$ recebido por hora:");
double valorh = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a quantidade de horas trabalhadas no mês:");
int horas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a quantidade de horas extras trabalhadas  em dia normal:");
int extra1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a quantidade de horas extras trabalhadass em feriaddo ou final de semana:");
int extra2 = Convert.ToInt32(Console.ReadLine());

double extra1t = extra1 * valorh;

double extra2t = extra2 * valorh;

double valorn = valorh * horas;
Console.WriteLine("Valor hora horas trabalhadas normalmente é: R$" + valorn);

double valorex1 = extra1t * 1.5;
Console.WriteLine("Valor hora horas extras I: R$" + valorex1);

double valorex2 = extra2t * 2.0;
Console.WriteLine("Valor hora horas extras II: R$" + valorex2);

double total = valorn + valorex1 + valorex2;
Console.WriteLine("O valor total recebido é: R$" + total);