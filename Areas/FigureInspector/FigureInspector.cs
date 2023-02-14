using Areas.Figures;

namespace Areas.FiguresInspector;

public class FigureInspector : IFigureInspector
{
    public double CalculateArea(IFigure figure)
    {
        return figure.CalculateArea();
    }

    public bool IsRightAngled(IFigure figure)
    {
        if (figure is Triangle triangle)
        {
            return triangle.IsRightAngled;
        }

        return false;
    }
}