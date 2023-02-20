using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould08
{
    [Fact]
    public void ISR_WhenRangeOf510451_01fAnd974535_03f()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=610451.01f};
    
    var personLow = new EISRPerson{Salary=510451.01f};
    var personHigh = new EISRPerson{Salary=974535.03f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);

    }

}
    