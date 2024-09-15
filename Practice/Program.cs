using System;
using System.Reflection.Emit;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car1 = new Car();
            Car car2 = new Car("BMW", 120000);
            Car car3 = new Car("Lada", 3.2m,2000);
        }

    }
}
