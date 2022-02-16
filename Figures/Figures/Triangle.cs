using Figures.Model;

namespace Figures.Figures
{
    public class Triangle : IFigure
    {
        public double Side { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }
        public double Semiperimeter { get; private set; }
        public double Square { get; private set; }

        public Triangle(double side, double side2, double side3)
        {
            
            if(side <= 0 ||  side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Сторона не может быть меньше или равна нулю");
            }
            
            Side = side;
            Side2 = side2;
            Side3 = side3;

            Semiperimeter = (side + side2 + side3)/2;
        }

        public double GetSquare()
        {
            return Square = Math.Sqrt(Semiperimeter*(Semiperimeter - Side)*(Semiperimeter - Side2)*(Semiperimeter - Side3));
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
