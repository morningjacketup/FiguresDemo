using Figures.Model;

namespace Figures.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetSquare()
        {
            return Radius * Math.PI;
        }
    }
}