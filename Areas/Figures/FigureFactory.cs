namespace Areas.Figures;

public class FigureFactory
{
    public static IFigure Create(double radius)
    {
        return new Circle(radius);
    }

    public static IFigure Create(double width, double height)
    {
        return new Rectangle(width, height);
    }

    public static IFigure Create(double sideA, double sideB, double sideC)
    {
        return new Triangle(sideA, sideB, sideC);
    }
}