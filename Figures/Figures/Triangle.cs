using Figures.Model;

namespace Figures.Figures
{
    public class Triangle : IFigure
    {
        public double Side { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Semiperimeter { get; set; }

        public Triangle(double side, double side2, double side3)
        {
            Side = side;
            Side2 = side2;
            Side3 = side3;

            Semiperimeter = (side + side2 + side3)/2;
        }

        public double GetSquare()
        {
            return Math.Sqrt(Semiperimeter*(Semiperimeter - Side)*(Semiperimeter - Side2)*(Semiperimeter - Side3));
        }

        public bool IsEquilateral()
        {
            if (Side == Side2 && Side2 == Side3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
