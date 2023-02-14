namespace Areas.Figures;
public class Triangle : IFigure
{
    private readonly Lazy<bool> _isRightAngled;
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public bool IsRightAngled => _isRightAngled.Value;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA < 0 || sideB < 0 || sideC < 0)
            throw new ArgumentOutOfRangeException("Side length can't be negative");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;

        _isRightAngled = new Lazy<bool>(CheckIsRightAngled);
    }

    public double CalculateArea()
    {
        double p = (_sideA + _sideB + _sideC) / 2;

        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }

    private bool CheckIsRightAngled()
    {
        var maxSide = new[] { _sideA, _sideB, _sideC }.Max();
        var maxSideSqr = maxSide * maxSide;
        return maxSideSqr + maxSideSqr == _sideA * _sideA + _sideB * _sideB + _sideC * _sideC;
    }
}
