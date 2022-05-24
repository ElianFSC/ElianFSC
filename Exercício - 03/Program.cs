// Exercício 03

// Menu de candidatos (colocar += para receber o anterior)
string menu = "*** ESCOLHA UM DOS CANDIDATOS ***\n";
       menu += "1) João\n";
       menu += "2) Pedro\n";
       menu += "3) Paulo\n";
       menu += "4) Finalizar Votação";

// Contadores
int joao = 0, pedro = 0, maria = 0;

// Variavel voto
int voto = 0;

// Laço
do
{
    // Obter o voto
    Console.WriteLine(menu);
    voto = Convert.ToInt32(Console.ReadLine());

    // Contabilizar votos
    switch (voto)
    {
        case 1:
            joao++;
            break;

        case 2:
            pedro++;
            break;

        case 3:
            maria++;
            break;
    }

    // Limpar console
    Console.Clear();

} while (voto != 4);

// Exibir votos
Console.WriteLine("João obteve: " + joao + " votos.");
Console.WriteLine("Pedro obteve: " + pedro + " votos.");
Console.WriteLine("Maria obteve: " + maria + " votos.");