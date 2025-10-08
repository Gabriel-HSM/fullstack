using Exercicio_18_Abstratos.Entities.Enums;

namespace Exercicio_18_Abstratos.Entities
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Heigth = height;
        }
        public double Width { get; set; }
        public double Heigth { get; set; }

        public override double Area()
        {
            return Width * Heigth;
        }
    }
}