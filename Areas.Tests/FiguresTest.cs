using Areas.Figures;

namespace Areas.Tests
{
    [TestClass]
    public class FiguresTests
    {
        [TestMethod]
        public void RectangeAreaCalculationTest()
        {
            Rectangle rectangle = new Rectangle(5, 5);

            Assert.AreEqual(25, rectangle.CalculateArea());
        }

        [TestMethod]
        public void CircleAreaCalculationTest()
        {
            Circle circle = new Circle(3);

            Assert.AreEqual(28.274333882308138, circle.CalculateArea());
        }

        [TestMethod]
        public void TriangleAreaCalculationTest()
        {
            Triangle triangle = new Triangle(5,5,5);

            Assert.AreEqual(10.825317547305483, triangle.CalculateArea());
        }

        [TestMethod]
        public void IsRightAngledTriangle_RightTriangle_True()
        {
            Triangle triangle = new Triangle(5, 4, 3);

            Assert.IsTrue(triangle.IsRightAngled);
        }

        [TestMethod]
        public void IsRightAngledTriangle_NotRightTriangle_False()
        {
            Triangle triangle = new Triangle(5, 5, 5);

            Assert.IsFalse(triangle.IsRightAngled);
        }
    }
}