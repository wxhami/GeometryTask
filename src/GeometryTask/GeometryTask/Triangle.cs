namespace GeometryTask;

public class Triangle : FigureBase
{
    
    public override double CalculatorFigureleArea()
    {
        double sideOne = 0;
        double sideTwo = 0;
        double sideThree = 0;
        double area;
        area = (sideOne + sideTwo + sideThree) / 2;
        return area;
    }
}