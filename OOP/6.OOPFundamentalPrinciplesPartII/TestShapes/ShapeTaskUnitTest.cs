using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTask;

namespace TestShapes
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void UTestTriangle()
        {
            Triangle triangle = new Triangle(7, 4);

            double res = triangle.CalculateSurface();
            Assert.AreEqual(14, res);
        }
    }

    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void UTestCircle()
        {
            Circle circle = new Circle(5);

            double res = circle.CalculateSurface();
            Assert.AreEqual(78.5398163397448d, res);//Гърми заради десетичния разделител
        }
    }

    [TestClass]
    public class TestRectangle
    {
        [TestMethod]
        public void UTestRectangle()
        {
            Rectangle rectangle = new Rectangle(2, 3);

            double res = rectangle.CalculateSurface();
            Assert.AreEqual(6, res);
        }
    }
}
