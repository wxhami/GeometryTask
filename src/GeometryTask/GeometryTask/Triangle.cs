namespace GeometryTask;

public class Triangle : FigureBase
{
    private double _sideOne;
    private double _sideTwo;
    private double _sideThree;
    
    
    public Triangle(double sideOne, double sideTwo, double sideThree)
    {
        this._sideOne = sideOne;
        this._sideTwo = sideTwo;
        this._sideThree = sideThree;
    }

    private bool PiphagorTheory()
    {
       

        
    }
    
    public override double CalculatorFigureArea()
    {
        double area;
        area = (_sideOne + _sideTwo + _sideThree) / 2;
        return area;
    }

    private void ArraySort()
    {
        double max;
        double[] sides = new double[] { _sideOne, _sideTwo, _sideThree };
        for (int i = 0; i < sides.Length - 1; i++)
        {
            for (int j = i + 1; j < sides.Length; j++)
            {
                if (sides[i].CompareTo(sides[j]) > 0)
                {
                    max = sides[j];
                    sides[j] = sides[i];
                    sides[i] = max;
                }
            }
        }
    }
}