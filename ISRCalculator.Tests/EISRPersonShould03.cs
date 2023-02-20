using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould03
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange3()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range3;

    var person = new EISRPerson{Salary =75651.08f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   