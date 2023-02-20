using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould11
{
    [Fact]
    public void ISR_WhenRangeOfMore3898140_13f()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=3998140.13f};
    
    
    var personLow = new EISRPerson{Salary=3898140.13f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);

    //assert
    Assert.True(resultExpected.Index > resultLow.Index);


    }

}
    