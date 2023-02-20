using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould03
{
    [Fact]
    public void ISR_WhenRangeOf65651_08fAnd115375_90f()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=80000f};
    
    var personLow = new EISRPerson{Salary=65651.08f};
    var personHigh = new EISRPerson{Salary=115375.90f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);


    }

}
    