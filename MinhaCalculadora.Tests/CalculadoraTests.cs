using System.Numerics;

namespace MinhaCalculadora.Tests;

public class CalculadoraTests
{
    [Theory]
    [InlineData(Operacao.Soma, 10, 20, 30)]
    [InlineData(Operacao.Subtracao, 20, 10, 10)]
    [InlineData(Operacao.Multiplicacao, 10, 20, 200)]
    [InlineData(Operacao.Divisao, 10, 2, 5)]
    public void Operacao_Deve_Realizar_Calculo_Correto(Operacao operacao, int x, int y, int esperado)
    {
        int resultado = Calculadora.Calcular(operacao, x, y);

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void Divisao_por_Zero_Deve_Disparar_Exception()
    {
        Assert.Throws<DivideByZeroException>(() => Calculadora.Calcular(Operacao.Divisao, 1,0));
    }
}

