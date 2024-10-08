﻿namespace MinhaCalculadora;

public static class Calculadora
{
    public static int Calcular(Operacao operacao, int x, int y) => operacao switch
    {
        Operacao.Soma => Calculadora.Somar(x, y),
        Operacao.Subtracao => Calculadora.Subtrair(x, y),
        Operacao.Multiplicacao => Calculadora.Multiplicar(x, y),
        Operacao.Divisao => Calculadora.Dividir(x, y)
    };

    private static int Somar(int x, int y) => x + y;

    private static int Subtrair(int x, int y) => x - y;

private static int Multiplicar(int x, int y) => x * y;

    private static int Dividir(int x, int y) => x / y;
}