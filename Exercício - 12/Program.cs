// Exercício 12
Console.WriteLine("Escolha um dos três Estados:");
Console.WriteLine("1) Santa Catarina");
Console.WriteLine("2) Rio de Janeiro");
Console.WriteLine("3) Maranhão");
int estado = Convert.ToInt32(Console.ReadLine());

if (estado == 1)
{
    Console.WriteLine("Escolha uma das três Cidades:");
    Console.WriteLine("1) Florianópolis");
    Console.WriteLine("2) Blumenau");
    Console.WriteLine("3) Balneário Camboriú");
    int cidade = Convert.ToInt32(Console.ReadLine());

    if (cidade == 1)
    {
        Console.WriteLine("A cidade de Florianópolis tem cerca de 100 praias oficiais.");
    }
    else if (cidade == 2)
    {
        Console.WriteLine("A cidade de Blumenau tem um recorde de consumo de chop na comemorada OktoberFest! Em 2017, foram consumidos 1.530.558 copos, ou 612.223 litros.");
    }
    else if (cidade == 3)
    {
        Console.WriteLine("Em janeiro de 2022, foram registrados que 453.878 visitantes estiveram na cidade de Balneário Camboriú.");
    }
}
else if (estado == 2)
{
    Console.WriteLine("Escolha uma das três Cidades:");
    Console.WriteLine("1) Búzios");
    Console.WriteLine("2) Rio de Janeiro");
    Console.WriteLine("3) Paraty");
    int cidade = Convert.ToInt32(Console.ReadLine());

    if (cidade == 1)
    {
        Console.WriteLine("Quem gosta de praticar esportes aquáticos terá muitas opções em Búzios à disposição.");
    }
    else if (cidade == 2)
    {
        Console.WriteLine("O Censo de 2010, IBGE, levantou 763 favelas na cidade, que abrigam 22% da população da cidade do Rio de Janeiro.");
    }
    else if (cidade == 3)
    {
        Console.WriteLine("Uma cidade com muita história e belezas naturais, considerada Patrimônio Histórico Nacional, e conhecida como Veneza Brasileira.");
    }
}
else if (estado == 3)
{
    Console.WriteLine("Escolha uma das três Cidades:");
    Console.WriteLine("1) São Luiz");
    Console.WriteLine("2) São Bento");
    Console.WriteLine("3) Barreirinhas");
    int cidade = Convert.ToInt32(Console.ReadLine());

    if (cidade == 1)
    {
        Console.WriteLine("O trecho da música 'Ilha Magnética', do cantor e compositor maranhense César Nascimento, reflete o apelido de 'Ilha do Amor' que São Luís conquistou ao longo dos seus 401 anos.");
    }
    else if (cidade == 2)
    {
        Console.WriteLine("Uma das iguarias prediletas do Sambentoense é o mussum, semelhante ao enguia que, dependendo da época do ano, pode-se encontrar em abundância nos campos alagados.");
    }
    else if (cidade == 3)
    {
        Console.WriteLine("Sendo como porta de entrada para uma das paisagens mais lindas, o Parque Nacional dos Lençóis Maranhenses.");
    }
}