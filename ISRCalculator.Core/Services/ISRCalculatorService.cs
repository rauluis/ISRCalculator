using ISRCalculator.Core.Entities;
using ISRCalculator.Core.Services.Interfaces;
using ISRCalculator.Core.Enums;
namespace ISRCalculator.Core.Services;
public class ISRCalculatorService: IISRCalculatorService{
    public  EISRCalculator ProcessISRCalculator(EISRPerson person){
      
        var EISRCalculator = new EISRCalculator();
        var Base = 0.0f;
        var Resultado = 0.0f;

        if(person.Salary < 0.01f ){
          System.Console.WriteLine("The gross salary cannot be less than 0.01");
          EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range0;
          EISRCalculator.Index= Resultado;
        }
        else if(person.Salary >= 0.01f && person.Salary <=7735f ){          
        Base =(person.Salary-0.01f);
        Resultado = Base *(1.92f/100f);
        EISRCalculator.Index = Resultado + 0.0f;
        System.Console.WriteLine("Es el 0.01===7735");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range1;
        }
        else if(person.Salary >=7735.01f && person.Salary <=65651.07f ){
        Base =(person.Salary-7735.01f);
        Resultado = Base *(6.40f/100f);
        EISRCalculator.Index = Resultado + 148.51f;
        System.Console.WriteLine("Es el 7735===65651");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range2;
        }
        else if(person.Salary >=65651.08f && person.Salary <=115375.90f ){
        Base =(person.Salary-65651.08f);
        Resultado = Base *(10.88f/100f);
        EISRCalculator.Index = Resultado + 3855.14f;
        System.Console.WriteLine("Es el 65651===115375");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range3;
        }
        else if(person.Salary >=115375.91f && person.Salary <=134119.41f ){
        Base =(person.Salary-115375.91f);
        Resultado = Base *(16.00f/100f);
        EISRCalculator.Index = Resultado + 9265.20f;
        System.Console.WriteLine("Es el 115375===134119");
        EISRCalculator.EISRCalculatorType =ISRCalculatorType.Range4;
        }
        else if(person.Salary >=134119.42f && person.Salary <=160577.65f ){
        Base =(person.Salary-134119.42f);
        Resultado = Base *(17.92f/100f);
        EISRCalculator.Index = Resultado + 12264.20f;
        System.Console.WriteLine("Es el 134119===160577");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range5;
        }
        else if(person.Salary >=160577.66f && person.Salary <=323862.00f ){
        Base =(person.Salary-160577.66f);
        Resultado = Base *(21.36f/100f);
        EISRCalculator.Index = Resultado + 17005.47f;
        System.Console.WriteLine("Es el 160577===323862");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range6;
        }
        else if(person.Salary >=323862.01f && person.Salary <=510451.00f ){
        Base =(person.Salary-323862.01f);
        Resultado = Base *(23.52f/100f);
        EISRCalculator.Index = Resultado + 51883.01f;
        System.Console.WriteLine("Es el 323862===510451");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range7;
        }
        else if(person.Salary >=510451.01f && person.Salary <=974535.03f ){
        Base =(person.Salary-510451.01f);
        Resultado = Base *(30.00f/100f);
        EISRCalculator.Index = Resultado + 95768.74f;
        System.Console.WriteLine("Es el 510451===974535");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range8;
        }
        else if(person.Salary >=974535.04f && person.Salary <=1299380.04f ){
        Base =(person.Salary-974535.04f);
        Resultado = Base *(32.00f/100f);
        EISRCalculator.Index = Resultado + 234993.95f;
        System.Console.WriteLine("Es el 974535===1299380");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range9;
        }
        else if(person.Salary >=1299380.05f && person.Salary <=3898140.12f ){
        Base =(person.Salary-1299380.05f);
        Resultado = Base *(34.00f/100f);
        EISRCalculator.Index = Resultado + 338944.34f;
        System.Console.WriteLine("Es el 1299380===3898140");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range10;
        }
        else if(person.Salary >=3898140.13f){
        Base =(person.Salary-3898140.13f);
        Resultado = Base *(35.00f/100f);
        EISRCalculator.Index = Resultado + 1222522.76f;
        System.Console.WriteLine("Es el 3898140===....");
        EISRCalculator.EISRCalculatorType = ISRCalculatorType.Range11;
        }
        return EISRCalculator;
    }
}
