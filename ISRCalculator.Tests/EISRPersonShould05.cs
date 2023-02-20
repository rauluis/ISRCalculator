using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould05
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange5()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range5;

    var person = new EISRPerson{Salary =144119.42f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   