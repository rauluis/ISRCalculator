using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould09
{
    [Fact]
    public void ISR_WhenRangeOf974535_04fAnd1299380_04f()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=1074535.04f};
    
    var personLow = new EISRPerson{Salary=974535.04f};
    var personHigh = new EISRPerson{Salary= 1299380.04f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);


    }

}
    