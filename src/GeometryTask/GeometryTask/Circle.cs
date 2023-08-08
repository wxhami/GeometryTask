namespace GeometryTask;

public class Circle : FigureBase
{
    private double _radius;

    public Circle(double radius)
    {
        if (radius != 0)
        {
            _radius = radius;
        }
        else
        {
            throw new ArgumentException("radius cannot be null");
        }
    }

    public override double GetArea()
    {
        return 3.14 * (_radius * _radius);
    }
}