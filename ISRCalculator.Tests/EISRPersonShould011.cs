using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould11
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange11()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range11;

    var person = new EISRPerson{Salary =4000000f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   