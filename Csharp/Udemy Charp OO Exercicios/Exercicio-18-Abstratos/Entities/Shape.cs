using Exercicio_18_Abstratos.Entities.Enums;

namespace Exercicio_18_Abstratos.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}