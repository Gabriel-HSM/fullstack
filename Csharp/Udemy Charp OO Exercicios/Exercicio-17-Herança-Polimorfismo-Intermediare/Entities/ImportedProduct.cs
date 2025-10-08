using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_17_Herança_Polimorfismo_Intermediare.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} ${totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee})";
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }
    }
}