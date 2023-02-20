using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould07
{
    [Fact]
    public void ISR_WhenRangeOf323862_01fAnd510451_00f()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=423862.01f};
    
    var personLow = new EISRPerson{Salary=323862.01f};
    var personHigh = new EISRPerson{Salary=510451.00f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);

    }

}
    