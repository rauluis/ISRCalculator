using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould08
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange8()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range8;

    var person = new EISRPerson{Salary =610451.01f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   