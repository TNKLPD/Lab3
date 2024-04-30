using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RaceCar raceCar = new Formula1Car("Car1");
            RaceCar raceCar1 = new Formula1Car("Car2");

            raceCar.StartEngine();
            raceCar.StartEngine();
            raceCar.Accelerate();
            raceCar.Brake();

            raceCar1.Brake();
            raceCar1.StartEngine();
            raceCar1.StartEngine();
            raceCar1.Accelerate();

            Console.WriteLine(raceCar + "\n" + raceCar1);
            Console.ReadLine();
            /*Создайте интерфейс `IRaceCar` с методами `void StartEngine()`,
             * `void Accelerate()`, и `void Brake()`. 
             * Реализуйте этот интерфейс в абстрактном классе `RaceCar`
             * с readonly полем `string teamName` и конструктором с init спецификатором. 
             * Создайте класс `Formula1Car`, 
             * который наследуется от `RaceCar` и реализует интерфейс `IRaceCar`.
             * */
        }
    }
}
