// Exercício 24
Console.WriteLine("Informe o valor do salário recebido:");
double salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor da conta de luz:");
double luz = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor da conta de internet:");
double net = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor da conta de água:");
double agua = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor da compra no mercado:");
double merc = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor pago no aluguel:");
double aluguel = Convert.ToDouble(Console.ReadLine());

double contas = luz + net + agua + merc + aluguel;

double restante = salario - contas;

Console.WriteLine("Irá sobrar R$" + restante + " do salário.");