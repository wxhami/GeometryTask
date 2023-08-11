namespace GeometryTask;

public class Triangle : FigureBase
{
    private double _sideOne;
    private double _sideThree;
    private double _sideTwo;

    public Triangle(double sideOne, double sideTwo, double sideThree)
    {
        if (sideOne + sideThree > sideTwo
            && sideThree + sideTwo > sideOne
            && sideOne + sideTwo > sideThree
            && sideOne > 0
            && sideTwo > 0
            && sideThree > 0)
        {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }
        else
        {
            throw new ArgumentException("Incorrect sides of the triangle");
        }
    }

    public bool CheckRectangular()
    {
        double[] array = { _sideOne, _sideTwo, _sideThree };
        array.Sort();
        double sumTwoSides = (array[0] * array[0]) + (array[1] * array[1]);
        double max = array[2] * array[2];
        return max == sumTwoSides;
    }

    public override double GetArea()
    {
        double p = (_sideOne + _sideTwo + _sideThree) / 2;
        double area = Math.Sqrt(p * (p - _sideOne) * (p - _sideTwo) * (p - _sideThree));
        return double.Round(area, 2);
    }
}