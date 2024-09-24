/*
 * Quero poder realizar as quatro operações matemáticas básicas (somar, subtrair, multiplicar e dividir) números inteiros para que eu possa estudar melhor.
 */

using MinhaCalculadora;

Console.WriteLine("Informe o primeiro número: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo número: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a operação: ");
string input = Console.ReadLine();

if (input.IsOperacao())
{
    Console.WriteLine($"Operação {input} é inválida.");
    return;
}

Operacao operacao = input.ToOperacao();

if (operacao == Operacao.Divisao && y == 0)
{
    Console.WriteLine("Erro de divisão por zero.");
    return;
}

int resultado = Calculadora.Calcular(operacao, x, y);

Console.WriteLine(operacao switch
{
    Operacao.Soma => $"A soma de {x} + {y} = {resultado}",
    Operacao.Subtracao => $"A diferença de {x} - {y} = {resultado}",
    Operacao.Multiplicacao => $"O produto de {x} * {y} = {resultado}",
    Operacao.Divisao => $"A divisÃo de {x} / {y} = {resultado}"
}  );