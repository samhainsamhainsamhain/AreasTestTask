using static Areas.Areas;

namespace Areas.Figures
{
    public class Rectangle : Areable
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            if (width < 0 || height < 0)
                throw new ArgumentOutOfRangeException("Rectangle sides must be more than 0");

            _width = width;
            _height = height;
        }

        public double CalculateArea()
        {
            return _height * _width;
        }
    }
}
