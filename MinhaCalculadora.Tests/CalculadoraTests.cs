using System.Numerics;

namespace MinhaCalculadora.Tests;

public class CalculadoraTests
{
    [Theory]
    [InlineData("+", 10, 20, 30)]
    [InlineData("-", 20, 10, 10)]
    [InlineData("*", 10, 20, 200)]
    [InlineData("/", 10, 2, 5)]
    public void Operacao_Deve_Realizar_Calculo_Correto(string operacao, int x, int y, int esperado)
    {
        int resultado = Calculadora.Calcular(operacao, x, y);

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void Divisao_por_Zero_Deve_Disparar_Exception()
    {
        Assert.Throws<DivideByZeroException>(() => Calculadora.Calcular("/", 1,0));
    }
}

