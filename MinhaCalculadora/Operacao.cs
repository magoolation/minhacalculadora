namespace MinhaCalculadora;
public enum Operacao
{
    Soma = 1,
    Subtracao,
    Multiplicacao,
    Divisao
}

public static class OperacaoExtensions
{
    public static Operacao ToOperacao(this string operacao) => operacao switch
    {
        "+" => Operacao.Soma,
        "-" => Operacao.Subtracao,
        "*" => Operacao.Multiplicacao,
        "/" => Operacao.Divisao,
        _ => throw new ArgumentException(operacao)
    };

    public static bool IsOperacao(this string operacao)
    {
        string[] operacoes = { "+", "-", "*", "/" };

        return operacoes.Contains(operacao);
    }
}