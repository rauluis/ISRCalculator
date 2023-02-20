using ISRCalculator.Core.Managers.Interfaces;
using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services.Interfaces;

namespace ISRCalculator.Core.Managers;


public class ISRCalculatorManager:IISRCalculatorManager {
    
    private readonly IISRCalculatorService _service;
    
    public ISRCalculatorManager(IISRCalculatorService service){
        _service = service;
    }

    public EISRCalculator GetISRCalculator(EISRPerson person){
        return _service.ProcessISRCalculator(person);
    }


}