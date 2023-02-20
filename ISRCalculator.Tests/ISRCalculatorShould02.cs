using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services;


namespace ISRCalculator.Tests;

public class ISRCalculatorShould02
{
    [Fact]
    public void ISR_WhenRangeOf7735_01And65651_07()
    {
       
    //arrange
    //modificar este
    var personExpected = new EISRPerson{Salary=8000f};

    var personLow = new EISRPerson{Salary=7735.01f};
    var personHigh = new EISRPerson{Salary=65651.07f};
    
    var sut = new ISRCalculatorService();

    //act 
    var resultExpected = sut.ProcessISRCalculator(personExpected);
    var resultLow = sut.ProcessISRCalculator(personLow);
    var resultHigh = sut.ProcessISRCalculator(personHigh);


    //assert
    Assert.InRange(resultExpected.Index,resultLow.Index,resultHigh.Index);


    }

}
    