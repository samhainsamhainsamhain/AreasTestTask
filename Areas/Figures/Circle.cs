using static Areas.Areas;

namespace Areas.Figures
{
    public class Circle : Areable
    {

        private double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Radius must be more than 0");

            _radius = radius;
        }

        public double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
