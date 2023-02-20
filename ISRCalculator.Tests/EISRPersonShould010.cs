using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould10
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange10()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range10;

    var person = new EISRPerson{Salary =2299380.05f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   