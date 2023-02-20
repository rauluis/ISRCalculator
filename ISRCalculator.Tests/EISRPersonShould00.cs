using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould00
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange0()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range0;

    var person = new EISRPerson{Salary =0f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   