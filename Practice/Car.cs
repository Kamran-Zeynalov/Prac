using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Car
    {
        public string Name;
        public decimal Motor;
        public decimal HourPower;
        public decimal Price;


        public Car()
        {
                
        }

        public Car(string name, decimal motor, decimal houtPower)
        {
            Name = name;
            Motor = motor;
            HourPower = houtPower;
        }
        public Car(string name, decimal price)
        {
            Name=name;
            Price=price;
        }
    }
}
