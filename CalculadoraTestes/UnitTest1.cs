using Calculadora.Models;

namespace CalculadoraTestes;


public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        CalculadoraSimples calc = new CalculadoraSimples();

        int resultadoCalculadora = calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (10, 5, 5)]
    [InlineData (14, 7, 7)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        CalculadoraSimples calc = new CalculadoraSimples();

        int resultadoCalculadora = calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (2, 2, 4)]
    [InlineData (5, 5, 25)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        CalculadoraSimples calc = new CalculadoraSimples();

        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (10, 2, 5)]
    [InlineData (50, 25, 2)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        CalculadoraSimples calc = new CalculadoraSimples();

        int resultadoCalculadora = calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TesteDividirPor0()
    {
        CalculadoraSimples calc = new CalculadoraSimples();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        CalculadoraSimples calc = new CalculadoraSimples();
        
        calc.Somar(2,4);
        calc.Somar(23,6);
        calc.Somar(5,2);
        calc.Somar(21,54);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }
}