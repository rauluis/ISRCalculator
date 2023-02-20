using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould05
{
    [Fact]
    public void ISR_WhenRangeOf134119_42fAnd160577_65f()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=144119.43f};
    
     var personLow = new EISRPerson{Salary=134119.42f};
    var personHigh = new EISRPerson{Salary=160577.65f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);

    }

}
    