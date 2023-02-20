using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould04
{
    [Fact]
    public void ISR_WhenRangeOf115375_91fAnd134119_41f()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=120000.02f};
    
   
    var personLow = new EISRPerson{Salary=115375.91f};
    var personHigh = new EISRPerson{Salary=134119.41f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);


    }

}
    