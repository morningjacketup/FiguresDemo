using NUnit.Framework;
using Figures.Figures;
using System;

namespace FiguresTests
{
    public class Tests
    {
        [Test]
        public void Circle_Square_Test()
        {
            Circle circle = new Circle(5);
            circle.GetSquare();
            
            Assert.AreEqual(5*Math.PI, circle.Square);
        }

        [Test]
        public void Triangle_Square_Test()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            triangle.GetSquare();

            Assert.AreEqual(6, triangle.Square);
        }

        [Test]
        public void Triangle_IsEquilateral_Test()
        {
            Triangle triangle = new Triangle(2, 2, 2);

            Assert.AreEqual(true, triangle.IsEquilateral());
        }

        [Test]
        public void TriangleIsNotEquilateralTest()
        {
            Triangle triangle = new Triangle(1d, 5d, 7d);

            Assert.AreEqual(false, triangle.IsEquilateral());
        }

        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 0, 0)]
        public void TriangleSideIsZeroOrNegative(double side, double side2, double side3)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(side, side2, side3));
        }

        [TestCase(0)]
        [TestCase(-1d)]
        public void CircleRadiusIsZeroOrNegative(double radius)
        {
            Assert.Catch<ArgumentException>(() => new Circle(radius));
        }
    }
}