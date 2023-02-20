using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Managers;
using ISRCalculator.Core.Services;

namespace ISRCalculator.Console;


public static class Program {

    public static void Main(string[] args){

        
        float Salary = 0;  
        System.Console.WriteLine("Please enter the Salary Brute(please use ','):");
        Single.TryParse(System.Console.ReadLine(), out Salary);

    
        var EISRperson = new  EISRPerson{Salary =Salary};

        var service = new ISRCalculatorService();
        var manager = new ISRCalculatorManager(service);

        EISRCalculator ISRCalculator = manager.GetISRCalculator(EISRperson);

        System.Console.WriteLine($"ISR: {ISRCalculator.Index}");

    
        // while (true)
        // {
        //     System.Console.WriteLine("Please enter the Salary Brute (please use ','):");
        //     string input = System.Console.ReadLine();

        //     if (string.IsNullOrEmpty(input))
        //     {
        //         break; // si el usuario ingresa una cadena vacía, salimos del ciclo
        //     }

        //     if (float.TryParse(input, out Salary))
        //     {
        //         var EISRperson = new EISRPerson { Salary = Salary };
        //         var service = new ISRCalculatorService();
        //         var manager = new ISRCalculatorManager(service);
        //         EISRCalculator ISRCalculator = manager.GetISRCalculator(EISRperson);
        //         System.Console.WriteLine($"ISR: {ISRCalculator.Index}");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Invalid input. Please enter a valid salary.");
        //     }
        // }
    }

}
 

 