using Areas.Figures;

namespace Areas.Tests
{
    [TestClass]
    public class AreasTests
    {
        [TestMethod]
        public void RectangeAreaCalculationTest()
        {
            Rectangle rectangle = new Rectangle(5, 5);

            double rectArea = rectangle.CalculateArea();

            Assert.AreEqual(25, rectArea);
        }

        [TestMethod]
        public void CircleAreaCalculationTest()
        {
            Circle circle = new Circle(3);

            double circleArea = circle.CalculateArea();

            Assert.AreEqual(28.274333882308138, circleArea);
        }

        [TestMethod]
        public void TriangleAreaCalculationTest()
        {
            Triangle triangle = new Triangle(5, 5, 5);

            double triangleArea = triangle.CalculateArea();

            Assert.AreEqual(10.825317547305483, triangleArea);
        }

        [TestMethod]
        public void TestIsRightTriangle_True()
        {
            Triangle triangle = new Triangle(5, 4, 3);

            bool triangleIsRight = triangle.IsRightAngledTriangle;

            Assert.IsTrue(triangleIsRight);
        }

        [TestMethod]
        public void TestIsRightTriangle_False()
        {
            Triangle triangle = new Triangle(5, 6, 1);

            bool triangleIsRight = triangle.IsRightAngledTriangle;

            Assert.IsFalse(triangleIsRight);
        }
    }
}