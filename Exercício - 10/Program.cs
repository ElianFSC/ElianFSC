// Exercício 10
Console.WriteLine("Nome do Produto:");
string produto = Convert.ToString(Console.ReadLine());

Console.WriteLine("Forma de pagamento:");
Console.WriteLine("1) À vista:");
Console.WriteLine("2) A prazo:");
int pagamento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Valor do produto:");
double valor = Convert.ToDouble(Console.ReadLine());

if (pagamento == 1 && valor >= 500)
{
    double total = valor * 0.9;
    Console.WriteLine("O valor total a pagar no(a) " + produto + " é R$ " + total );
}
else if (pagamento == 1 && valor <= 499)
{
    double total = valor;
    Console.WriteLine("O valor total a pagar no(a) " + produto + " é R$ " + total);
}
else if (pagamento == 2 && valor >= 500)
{
    double total = valor;
    Console.WriteLine("O valor total a pagar no(a) " + produto + " é R$ " + total);
}
else if (pagamento == 2 && valor <= 500)
{
    double total = valor;
    Console.WriteLine("O valor total a pagar no(a) " + produto + " é R$ " + total);
}