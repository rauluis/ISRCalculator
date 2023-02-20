using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould07
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange7()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range7;

    var person = new EISRPerson{Salary =423862.01f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   