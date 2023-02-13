using Areas.Figures;

namespace Areas.Tests
{
    [TestClass]
    public class AreasTests
    {
        [TestMethod]
        public void RectangeAreaCalculationTest()
        {
            var rectangle = new Rectangle(5, 5);

            var rectArea = rectangle.CalculateArea();

            Assert.AreEqual(25, rectArea);
        }

        [TestMethod]
        public void CircleAreaCalculationTest()
        {
            var circle = new Circle(3);

            var circleArea = circle.CalculateArea();

            Assert.AreEqual(28.274333882308138, circleArea);
        }

        [TestMethod]
        public void TriangleAreaCalculationTest()
        {
            var triangle = new Triangle(5, 5, 5);

            var triangleArea = triangle.CalculateArea();

            Assert.AreEqual(10.825317547305483, triangleArea);
        }

        [TestMethod]
        public void TestIsRightTriangle_True()
        {
            var triangle = new Triangle(5, 4, 3);

            var triangleIsRight = triangle.IsRightAngledTriangle;

            Assert.IsTrue(triangleIsRight);
        }

        [TestMethod]
        public void TestIsRightTriangle_False()
        {
            var triangle = new Triangle(5, 6, 1);

            var triangleIsRight = triangle.IsRightAngledTriangle;

            Assert.IsFalse(triangleIsRight);
        }
    }
}