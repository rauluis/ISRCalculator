using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould01
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange1()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range1;

    var person = new EISRPerson{Salary =10f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   