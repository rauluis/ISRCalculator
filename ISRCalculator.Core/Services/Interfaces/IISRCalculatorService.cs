using  ISRCalculator.Core.Entities;

namespace ISRCalculator.Core.Services.Interfaces;

public interface IISRCalculatorService {
    EISRCalculator ProcessISRCalculator(EISRPerson person);
}