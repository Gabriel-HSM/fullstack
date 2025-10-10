using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_19_Abstracts_methods_class.Entities
{
    public class Company : TaxPayers
    {
        public int NumberOfEmployee { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployee) : base(name, anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }


        public override double Tax()
        {
            if (NumberOfEmployee < 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}