using Areas.Figures;

namespace Areas.FiguresInspector;

public interface IFigureInspector
{
    public double CalculateArea(IFigure figure);

    public bool IsRightAngled(IFigure figure);
}
