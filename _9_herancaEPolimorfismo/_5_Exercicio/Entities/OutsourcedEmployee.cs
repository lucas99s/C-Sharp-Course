using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Exercicio.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return (Hours * ValuePerHour) + (AdditionalCharge + (AdditionalCharge * 0.1));
        }
    }
}
