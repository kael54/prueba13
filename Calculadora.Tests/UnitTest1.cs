using CalculadoraDemo;

namespace Calculadora.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var n1 = 5;
        var n2 = 5;
        var expectedResult = 25 ;
        //act
        var  resultado = Mathematics.Multiplication(n1 , n2);
        //asser
        Assert.Equal(expectedResult,  resultado);
        
    }
}