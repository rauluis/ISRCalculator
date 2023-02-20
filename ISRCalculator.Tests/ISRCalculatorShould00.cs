using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould00
{
    [Fact]
    public void ISR_WhenRangeOfLessThan0_01()
    {
       
    // //arrange
    // var personExpected = new EISRPerson{Salary=-1.12f};
        
    // var sut = new ISRCalculatorService();

    // //act 
    // var resultExpected = sut.ProcessISRCalculator(personExpected);
    
    // //assert
    // Assert.True(resultExpected.Index ==0);


    var personExpected = new EISRPerson{Salary=-1f};

    var personLow = new EISRPerson{Salary=0f};
    var personHigh = new EISRPerson{Salary=0.01f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);



    }

}
    