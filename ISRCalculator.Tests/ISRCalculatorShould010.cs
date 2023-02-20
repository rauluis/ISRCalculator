using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould10
{
    [Fact]
    public void ISR_WhenRangeOf1299380_05fAnd3898140_12f()
    {
       
    //arrange
    var personExpected = new EISRPerson{Salary=2299380.05f };
    
     var personLow = new EISRPerson{Salary=1299380.05f};
    var personHigh = new EISRPerson{Salary=3898140.12f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);



    }

}
    