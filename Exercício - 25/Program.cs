// Exercício 25 - rever
Console.WriteLine("Informe a hora atual:");
int atual = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escolha uma das cidades para saber o horário local");
Console.WriteLine("1) Lisboa - Portugual");
Console.WriteLine("2) Paris - França");
Console.WriteLine("3) Tóquio - Japão");
Console.WriteLine("4) Washington - Estados Unidos");
Console.WriteLine("5) Camberra - Austrália");
int local = Convert.ToInt32(Console.ReadLine());

if (local == 1)
{
    int hora = atual + 4;
    Console.WriteLine("Em Lisboa é " + hora + " horas, está 4 horas à frente de Brasília - DF");
}
else if (local == 2)
{
    int hora = atual + 5;
    Console.WriteLine("Em Paris é " + hora + " horas, está 5 horas à frente de Brasília - DF");
}
else if (local == 3)
{
    int hora = atual + 12;
    Console.WriteLine("Em Tóquio é " + hora + " horas, está 12 horas à frente de Brasília - DF");
}
else if (local == 4)
{
    int hora = atual - 1;
    Console.WriteLine("Em Washington é " + hora + "horas, Brasília - DF está 1 hora à frente de Washington, EUA");
}
else
{
    int hora = atual + 13;
    Console.WriteLine("Em Camberra Território da Capital Australiana é " + hora + " horas, está 13 horas à frente de Brasília - DF");
}