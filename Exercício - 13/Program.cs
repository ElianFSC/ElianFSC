// Exercício 13
Console.WriteLine("Informe o primeiro número:");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o segundo número:");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o terceiro número:");
int numero3 = Convert.ToInt32(Console.ReadLine());

// Ordem crescente

if (numero1 <= numero2 && numero1 <= numero3 && numero2 <= numero3)
{
    Console.WriteLine("Em ordem crescente a sequência fica: " + numero1 + numero2 + numero3);
}
else if (numero1 <= numero2 && numero1 <= numero3 && numero3 <= numero2)
{
    Console.WriteLine("Em ordem crescente a sequência fica: " + numero1 + numero3 + numero2);
}
else if (numero2 <= numero1 && numero2 <= numero3 && numero1 <= numero3)
{
    Console.WriteLine("Em ordem crescente a sequência fica: " + numero2 + numero1 + numero3);
}
else if (numero2 <= numero1 && numero2 <= numero3 && numero3 <= numero1)
{
    Console.WriteLine("Em ordem crescente a sequência fica: " + numero2 + numero3 + numero1);
}
else if (numero3 <= numero2 && numero3 <= numero1 && numero2 <= numero1)
{
    Console.WriteLine("Em ordem crescente a sequência fica: " + numero3 + numero2 + numero1);
}
else
{
    Console.WriteLine("Em ordem crescente a sequência fica: " + numero3 + numero1 + numero2);
}