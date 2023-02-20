using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould09
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange9()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range9;

    var person = new EISRPerson{Salary =984535.04f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   