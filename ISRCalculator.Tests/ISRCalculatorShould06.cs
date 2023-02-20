using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould06
{
    [Fact]
    public void ISR_WhenRangeOf160577_66And323862_00f()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=260577.66f};
    
    var personLow = new EISRPerson{Salary=160577.66f};
    var personHigh = new EISRPerson{Salary=323862.00f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);

    }

}
    