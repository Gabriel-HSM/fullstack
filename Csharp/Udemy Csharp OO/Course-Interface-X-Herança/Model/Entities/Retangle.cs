using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Interface_X_Herança.Model.Entities
{
    class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color ="
            + Color
            + ", width = "
            + Width.ToString("F2", CultureInfo.InvariantCulture)
            + ", height = "
            + Height.ToString("F2", CultureInfo.InvariantCulture)
            + ", area = "
            + Area().ToString("F2", CultureInfo.InvariantCulture)
            ;
        }
    }
}