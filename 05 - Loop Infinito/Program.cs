// Variavel para Continuar um Laço de Repetição
bool continuar = true;

// Laço até informar o valor (nota) correto
do
{
    // Tentatica para obter a nota
    try
    {

        // Obter a nota
        int nota = Convert.ToInt32(Console.ReadLine());

        // Condicional
        if (nota < 0 || nota > 10)
        {
            Console.WriteLine("A nota informada não é válida");
        }
        else
        {
            continuar = false;
        }

    // Arrumando try, para não dar erro no sistema, caso não seja colocado um número
    } catch (Exception ex)
    {
        Console.WriteLine("Falha ao obter a nota" + ex.Message); // ex.Message é para saber qual motivo do erro
    }
} while (continuar);