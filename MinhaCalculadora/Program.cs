/*
 * Quero poder realizar as quatro operações matemáticas básicas (somar, subtrair, multiplicar e dividir) números inteiros para que eu possa estudar melhor.
 */

using MinhaCalculadora;

Console.WriteLine("Informe o primeiro número: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo número: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a operação: ");
string operacao = Console.ReadLine();

if (operacao != "+" &&
    operacao != "-" &&
    operacao != "*" &&
    operacao != "/")
{
    Console.WriteLine($"Operação {operacao} é inválida.");
    return;
}

if (operacao == "/" && y == 0)
{
    Console.WriteLine("Erro de divisão por zero.");
    return;
}

int resultado = Calculadora.Calcular(operacao, x, y);

Console.WriteLine(operacao switch
{
    "+"=> $"A soma de {x} + {y} = {resultado}",
    "-" => $"A diferença de {x} - {y} = {resultado}",
    "*" => $"O produto de {x} * {y} = {resultado}",
    "/" => $"A divisÃo de {x} / {y} = {resultado}"
}  );