using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould02
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange2()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range2;

    var person = new EISRPerson{Salary =8000f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   