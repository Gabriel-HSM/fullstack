using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_22_Interfaces.Entities
{
    public class Contract
    {
       public int Number { get; set; }
       public DateTime Date { get; set; }
       public double TotalValue { get; set; }
       public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalvalue)
        {
            Number = number;
            Date = date;
            TotalValue = totalvalue;
        }
     
     public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}