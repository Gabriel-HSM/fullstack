using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_19_Abstracts_methods_class.Entities
{
    public abstract class TaxPayers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
        
    }
}