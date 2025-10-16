using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Interfaces.Entities
{
    public class Invoice
    {
        public double BasicPaymant { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPaymant, double tax)
        {
            BasicPaymant = basicPaymant;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPaymant + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: "
            + BasicPaymant.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotalPayment: "
            + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}