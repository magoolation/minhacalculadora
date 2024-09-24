namespace MinhaCalculadora.Tests;
public class OperacoesTests
{
    [Theory]
    [InlineData("+", true)]
    [InlineData("-", true)]
    [InlineData("*", true)]
    [InlineData("/", true)]
    [InlineData("_", false)]
    public void Verifica_Operacao_Valida(string operacao, bool esperado)
    {
        Assert.Equal(esperado, operacao.IsOperacao());
    }

    [Fact]
    public void Operacao_Invalida_Deve_Disparar_Exception()
    {
        Assert.Throws<ArgumentException>(() => "_".ToOperacao());
    }
}
