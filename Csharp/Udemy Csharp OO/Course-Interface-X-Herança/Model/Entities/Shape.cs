using System;
using System.Collections.Generic;
using Course_Interface_X_Herança.Model.Enums;

namespace Course_Interface_X_Herança.Model.Entities
{
    abstract class Shape
    {
        public Colors Color { get; set; }

        public abstract double Area();
    }
}