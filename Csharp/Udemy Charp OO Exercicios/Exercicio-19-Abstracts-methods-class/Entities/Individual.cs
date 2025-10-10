using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_19_Abstracts_methods_class.Entities
{
    public class Individual : TaxPayers
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}