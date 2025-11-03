using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Interface_X_Herança.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return "Circle color ="
            + Color
            + ", radius = "
            + Radius.ToString("F2", CultureInfo.InvariantCulture)
            + ", area = "
            + Area().ToString("F2", CultureInfo.InvariantCulture)
            ;
        }
    }
}