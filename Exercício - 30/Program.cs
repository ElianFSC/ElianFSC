// Exercício 30
Console.WriteLine("Digite o nome do jogador:");
string nome = Convert.ToString(Console.ReadLine());

Console.WriteLine("Pergunta 1: De quem é a famosa frase “Penso, logo existo”?");
Console.WriteLine("Alternativa 1) Sócrates");
Console.WriteLine("Alternativa 2) Descartes");
int resposta1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pergunta 2: De onde é a invenção do chuveiro elétrico?");
Console.WriteLine("Alternativa 1) Brasil");
Console.WriteLine("Alternativa 2) Inglaterra");
int resposta2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pergunta 3: Quantos anos tem a pintura monalisa?");
Console.WriteLine("Alternativa 1) 519");
Console.WriteLine("Alternativa 2) 627");
int resposta3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pergunta 4: Durante quanto tempo aconteceu a segunda guerra mundial?");
Console.WriteLine("Alternativa 1) 11 anos");
Console.WriteLine("Alternativa 2) 6 anos");
int resposta4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pergunta 5: Qual o nome do cantor e compositor de Billie jean?");
Console.WriteLine("Alternativa 1) Maycon Jackson");
Console.WriteLine("Alternativa 2) Michael Jackson");
int resposta5 = Convert.ToInt32(Console.ReadLine());

if (resposta1 == 2 && resposta2 == 1 && resposta3 == 1 && resposta4 == 2 && resposta5 == 2)
{
    Console.WriteLine("Parabéns " + nome + ", você acertou 5 questões");
}
else if (resposta1 != 2 && resposta2 == 1 && resposta3 == 1 && resposta4 == 2 && resposta5 == 2)
{
    Console.WriteLine("Muito bom " + nome +", você acertou 4 questões");
}
else if (resposta1 == 2 && resposta2 != 1 && resposta3 == 1 && resposta4 == 2 && resposta5 == 2)
{
    Console.WriteLine("Muito bom " + nome + ", você acertou 4 questões");
}
else if (resposta1 == 2 && resposta2 == 1 && resposta3 != 1 && resposta4 == 2 && resposta5 == 2)
{
    Console.WriteLine("Muito bom " + nome + ", você acertou 4 questões");
}
else if (resposta1 == 2 && resposta2 == 1 && resposta3 == 1 && resposta4 != 2 && resposta5 == 2)
{
    Console.WriteLine("Muito bom " + nome + ", você acertou 4 questões");
}
else if (resposta1 == 2 && resposta2 == 1 && resposta3 == 1 && resposta4 == 2 && resposta5 != 2)
{
    Console.WriteLine("Muito bom " + nome + ", você acertou 4 questões");
}
else if (resposta1 == 2 && resposta2 == 1 && resposta3 == 1 && resposta4 != 2 && resposta5 != 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 == 2 && resposta2 == 1 && resposta3 != 1 && resposta4 == 2 && resposta5 != 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 == 2 && resposta2 != 1 && resposta3 == 1 && resposta4 == 2 && resposta5 != 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 != 2 && resposta2 == 1 && resposta3 == 1 && resposta4 == 2 && resposta5 != 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 != 2 && resposta2 == 1 && resposta3 == 1 && resposta4 != 2 && resposta5 == 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 != 2 && resposta2 == 1 && resposta3 != 1 && resposta4 == 2 && resposta5 == 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 != 2 && resposta2 != 1 && resposta3 == 1 && resposta4 == 2 && resposta5 == 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 == 2 && resposta2 != 1 && resposta3 != 1 && resposta4 == 2 && resposta5 == 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 == 2 && resposta2 != 1 && resposta3 == 1 && resposta4 != 2 && resposta5 == 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 == 2 && resposta2 == 1 && resposta3 != 1 && resposta4 != 2 && resposta5 == 2)
{
    Console.WriteLine("Quase lá " + nome + ", você acertou 3 questões");
}
else if (resposta1 != 2 && resposta2 != 1 && resposta3 != 1 && resposta4 == 2 && resposta5 == 2)
{
    Console.WriteLine("Eita " + nome + ", você acertou apenas 2 questões");
}
else if (resposta1 != 2 && resposta2 == 1 && resposta3 != 1 && resposta4 != 2 && resposta5 == 2)
{
    Console.WriteLine("Eita " + nome + ", você acertou apenas 2 questões");
}
else if (resposta1 != 2 && resposta2 == 1 && resposta3 == 1 && resposta4 != 2 && resposta5 != 2)
{
    Console.WriteLine("Eita " + nome + ", você acertou apenas 2 questões");
}
else if (resposta1 == 2 && resposta2 != 1 && resposta3 != 1 && resposta4 != 2 && resposta5 == 2)
{
    Console.WriteLine("Eita " + nome + ", você acertou apenas 2 questões");
}
else if (resposta1 == 2 && resposta2 != 1 && resposta3 != 1 && resposta4 == 2 && resposta5 != 2)
{
    Console.WriteLine("Eita " + nome + ", você acertou apenas 2 questões");
}
else if (resposta1 == 2 && resposta2 == 1 && resposta3 != 1 && resposta4 != 2 && resposta5 != 2)
{
    Console.WriteLine("Eita " + nome + ", você acertou apenas 2 questões");
}
else if (resposta1 == 2 && resposta2 == 1 && resposta3 != 1 && resposta4 != 2 && resposta5 != 2)
{
    Console.WriteLine("Eita " + nome + ", você acertou apenas 2 questões");
}
else if (resposta1 == 2 && resposta2 != 1 && resposta3 != 1 && resposta4 != 2 && resposta5 != 2)
{
    Console.WriteLine("Lamento " + nome + ", você acertou apenas 1 questão");
}
else if (resposta1 != 2 && resposta2 == 1 && resposta3 != 1 && resposta4 != 2 && resposta5 != 2)
{
    Console.WriteLine("Lamento " + nome + ", você acertou apenas 1 questão");
}
else if (resposta1 != 2 && resposta2 != 1 && resposta3 == 1 && resposta4 != 2 && resposta5 != 2)
{
    Console.WriteLine("Lamento " + nome + ", você acertou apenas 1 questão");
}
else if (resposta1 != 2 && resposta2 != 1 && resposta3 != 1 && resposta4 == 2 && resposta5 != 2)
{
    Console.WriteLine("Lamento " + nome + ", você acertou apenas 1 questão");
}
else if (resposta1 != 2 && resposta2 != 1 && resposta3 != 1 && resposta4 != 2 && resposta5 == 2)
{
    Console.WriteLine("Lamento " + nome + ", você acertou apenas 1 questão");
}
else if (resposta1 != 2 && resposta2 != 1 && resposta3 != 1 && resposta4 != 2 && resposta5 != 2)
{
    Console.WriteLine("Sinto muinto " + nome + ", você não acertou nenhuma questão");
}