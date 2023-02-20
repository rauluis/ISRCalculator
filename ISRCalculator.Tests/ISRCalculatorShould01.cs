using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould01
{
    [Fact]
    public void ISR_WhenRangeOf0_01And7735()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=10f};

    var personLow = new EISRPerson{Salary=0.01f};
    var personHigh = new EISRPerson{Salary=7735f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);





    }

}
    