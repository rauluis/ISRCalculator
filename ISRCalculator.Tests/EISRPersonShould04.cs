using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould04
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange4()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range4;

    var person = new EISRPerson{Salary =125375.91f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   