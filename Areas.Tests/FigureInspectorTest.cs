using Areas.Figures;
using Areas.FiguresInspector;

namespace Areas.Tests;

[TestClass]
public class FigureInspectorTest
{
    private readonly IFigureInspector _figureInspector;

    public FigureInspectorTest()
    {
        _figureInspector = new FigureInspector();
    }

    [TestMethod]
    public void FigureInspector_Circle()
    {
        Circle circle = new(5);

        Assert.AreEqual(78.54, Math.Round(_figureInspector.CalculateArea(circle), 2));
    }

    [TestMethod]
    public void FigureInspector_Rectangle()
    {
        Rectangle rectangle = new(5, 4);

        Assert.AreEqual(20, _figureInspector.CalculateArea(rectangle));
    }

    [TestMethod]
    public void FigureInspector_Triangle()
    {
        Triangle triangle = new(5, 4, 3);

        Assert.AreEqual(6, _figureInspector.CalculateArea(triangle));
    }
}