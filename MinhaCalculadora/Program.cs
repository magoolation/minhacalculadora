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

if (operacao == "+")
    Console.WriteLine($"A soma de {x} + {y} = {Calculadora.Somar(x,y)}");
else if (operacao == "-")
    Console.WriteLine($"A diferença de {x} - {y} = {Calculadora.Subtrair(x,y)}");
else if (operacao == "*")
    Console.WriteLine($"O produto de {x} * {y} = {Calculadora.Multiplicar(x,y)}");
else if (operacao == "/")
{
    if (y == 0)
    {
        Console.WriteLine("Erro de divisão por zero.");
    }
    else
        Console.WriteLine($"A divisÃo de {x} / {y} = {Calculadora.Dividir(x,y)}");
}
else
    Console.WriteLine($"Operação {operacao} é inválida.");