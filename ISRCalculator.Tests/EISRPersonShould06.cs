using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;
using ISRCalculator.Core.Enums;


namespace ISRCalculator.Tests;

public class EISRPersonShould06
{
    [Fact]
    public void EISRPerson_WhenTypeIsRange6()
    {

    //arrange
    var expectedType = ISRCalculatorType.Range6;

    var person = new EISRPerson{Salary =260577.66f};
    
    var sut = new ISRCalculatorService();

    //act 
    var result = sut.ProcessISRCalculator(person);

    //assert
    Assert.Equal(expectedType,result.EISRCalculatorType);



    }

}
   