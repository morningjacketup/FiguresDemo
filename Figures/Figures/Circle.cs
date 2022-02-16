using Figures.Model;

namespace Figures.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }
        public double Square { get; private set; }


        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус окружности не может быть меньше или равен нулю");
            }

            Radius = radius;
        }

        public double GetSquare()
        {
            return Square = Radius * Math.PI;
        }
    }
}