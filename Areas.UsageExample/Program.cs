using Areas.Figures;
using Areas.FiguresInspector;

namespace UsageExample;

internal class Program
{
    public static void Main(string[] args)
    {
        IFigureInspector figureInspector = new FigureInspector();

        Triangle triangle = new(3, 4, 5);

        Console.WriteLine($"Is the triangle right? {triangle.IsRightAngled}");
        Console.WriteLine($"The triangle's area is: {figureInspector.CalculateArea(triangle)}");

        IFigure figure = FigureFactory.Create(10);

        Console.WriteLine($"Is the figure right? {figureInspector.IsRightAngled(figure)}");
        Console.WriteLine($"A figure's area is: {figureInspector.CalculateArea(figure)}");
    }
}