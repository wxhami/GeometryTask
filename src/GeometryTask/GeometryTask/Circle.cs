namespace GeometryTask;

public class Circle : FigureBase
{
    private double _radius;

    public Circle(double radius)
    {
        if (radius > 0)
        {
            _radius = radius;
        }
        else
        {
            throw new ArgumentException("Radius cannot be zero or less than zero");
        }
    }

    public override double GetArea()
    {
        return 3.14 * (_radius * _radius);
    }
}