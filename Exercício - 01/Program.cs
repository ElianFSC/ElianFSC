// Exercício 01
Console.WriteLine("Informe o número que deseja saber a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe até quanto quer a tabuada");
int x = Convert.ToInt32(Console.ReadLine());

int y = 0;

while (y <= (x))
{
    Console.WriteLine(numero * y);
    y++;
}