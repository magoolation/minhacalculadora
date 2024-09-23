namespace MinhaCalculadora;

public static class Calculadora
{
    public static int Calcular(string operacao, int x, int y) => operacao switch
    {
        "+" => Calculadora.Somar(x, y),
        "-" => Calculadora.Subtrair(x, y),
        "*" => Calculadora.Multiplicar(x, y),
        "/" => Calculadora.Dividir(x, y)
    };

    private static int Somar(int x, int y) => x + y;

    private static int Subtrair(int x, int y) => x - y;

private static int Multiplicar(int x, int y) => x * y;

    private static int Dividir(int x, int y) => x / y;
}