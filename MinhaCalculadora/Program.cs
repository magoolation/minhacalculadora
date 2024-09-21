/*
 * Quero poder realizar as quatro operações matemáticas básicas (somar, subtrair, multiplicar e dividir) números inteiros para que eu possa estudar melhor.
 */

Console.WriteLine("Informe o primeiro número: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo número: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a operação: ");
string operacao = Console.ReadLine();

if (operacao == "+")
    Console.WriteLine($"A soma de {x} + {y} = {x + y}");
else if (operacao == "-")
    Console.WriteLine($"A diferença de {x} - {y} = {x - y}");
else
    Console.WriteLine($"Operação {operacao} é inválida.");