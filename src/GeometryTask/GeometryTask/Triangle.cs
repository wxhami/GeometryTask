namespace GeometryTask;

public class Triangle : FigureBase
{
    private double _sideOne;
    private double _sideThree;
    private double _sideTwo;


    public Triangle(double sideOne, double sideTwo, double sideThree)
    {
        if (_sideOne + _sideThree > _sideTwo || _sideThree + _sideTwo > _sideOne || _sideOne + _sideTwo > _sideThree)
        {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }
        else
        {
            throw new ArgumentException("incorrect sides of the triangle");
        }
    }

    public bool CheckRectangular()
    {
        double[] array = { _sideOne, _sideTwo, _sideThree };
        array.Sort();
        double max = array[0];
        double sumTwoSides = array[1] + array[2];
        if (max != sumTwoSides)
        {
            return false;
        }

        return true;
    }

    public override double GetArea()
    {
        double area;
        area = (_sideOne + _sideTwo + _sideThree) / 2;
        return area;
    }
}