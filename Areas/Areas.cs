namespace Areas
{
    public class Areas
    {
        public interface Areable
        {
            double CalculateArea();
        }

        public class Circle : Areable
        {

            public double Radius { get; }

            public Circle(double radius)
            {
                if (radius < 0)
                    throw new ArgumentOutOfRangeException("Radius must be more than 0");

                Radius = radius;
            }

            public double CalculateArea()
            {
                return Radius * Radius * Math.PI;
            }
        }
        public class Rectangle : Areable
        {
            public double Width { get; }
            public double Height { get; }

            public Rectangle(double width, double height)
            {
                if (width < 0 || height < 0)
                    throw new ArgumentOutOfRangeException("Rectangle sides must be more than 0");

                Width = width;
                Height = height;
            }

            public double CalculateArea()
            {
                return Height * Width;
            }
        }
        public class Triangle : Areable
        {
            private readonly Lazy<bool> _isRightAngled;
            private double SideA { get; }
            private double SideB { get; }
            private double SideC { get; }
            public bool IsRightAngledTriangle => _isRightAngled.Value;

            public Triangle(double sideA, double sideB, double sideC)
            {
                if (sideA < 0 || sideB < 0 || sideC < 0)
                    throw new ArgumentOutOfRangeException("Side length can't be negative");

                SideA = sideA;
                SideB = sideB;
                SideC = sideC;

                _isRightAngled = new Lazy<bool>(CheckIsRightAngled);
            }

            public double CalculateArea()
            {
                double p = (SideA + SideB + SideC) / 2;

                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
            private bool CheckIsRightAngled()
            {
                var maxSide = new[] { SideA, SideB, SideC }.Max();
                var maxSideSqr = maxSide * maxSide;
                return maxSideSqr + maxSideSqr == SideA * SideA + SideB * SideB + SideC * SideC;
            }
        }
    }
}