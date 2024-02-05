namespace Operacoes.xunit;

public class UnitTest1
{
    [Fact]
    public void SomarDoisNumeros()
    {
        double numero1 = 1;
        double numero2 = 1;
        double resultadoEsperado = 2;

        var resultado = Operacoes.Somar(numero1, numero2);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(1, 2, 4)]
    [InlineData(2, 2, 4)]
    public void SomarDoisNumerosLista(double num1, double num2, double resultadoEsperado)
    {
        var resultado = Operacoes.Somar(num1, num2);

        Assert.Equal(resultadoEsperado, resultado);
    }
}