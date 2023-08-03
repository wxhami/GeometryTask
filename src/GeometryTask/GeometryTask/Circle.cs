namespace GeometryTask;

public class Circle : FigureBase
{
    public override double CalculatorFigureArea()
    {
        int radius = 0;
        double area; 
        area = 3.14 * (radius * 2);
        return area;
    }
}