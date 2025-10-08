using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_16_Herança_Polimorfismo1.Entities
{
    public class OutSourceEmployee : Employee
    {
        public double AdditionalChange { get; set; }

        public OutSourceEmployee()
        {
        }
        public OutSourceEmployee(string name, int hours, double valuePerHour, double additionalChange) : base(name, hours, valuePerHour)
        {
            AdditionalChange = additionalChange;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalChange * 1.1;
        }
    }
}