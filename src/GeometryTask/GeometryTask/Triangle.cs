using GeometryTask.Exceptions;

namespace GeometryTask;

/// <summary>
/// Представляет треугольник с тремя сторонами. Позволяет вычислить площадь и определить, является ли треугольник прямоугольным.
/// </summary>
public class Triangle : FigureBase
{
    /// <summary>
    /// длина первой стороны треугольника.
    /// </summary>
    public double SideOne { get; }

    /// <summary>
    /// длина второй стороны треугольника.
    /// </summary>
    public double SideTwo { get; }

    /// <summary>
    /// длина третьей стороны треугольника.
    /// </summary>
    public double SideThree { get; }

    /// <summary>
    /// является ли треугольник прямоугольным.
    /// </summary>
    public bool IsRectangular { get; }
    
    /// <summary>
    /// текст ошибки при некорректном значении стороны треугольника.
    /// </summary>
    private const string IncorrectValueSideTriangleException = "Значение cтороны треугольника должно быть больше 0.";

    /// <summary>
    /// конструктор для создания треугольника с указанными сторонами.
    /// </summary>
    /// <param name="sideOne">первая сторона треугольника.</param>
    /// <param name="sideTwo">вторая сторона треугольника.</param>
    /// <param name="sideThree">третья сторона треугольника.</param>
    /// <exception cref="ArgumentException">выбрасывается, если хотя бы одна из сторон меньше или равна 0.</exception>
    /// <exception cref="InvalidTriangleException">выбрасывается, если стороны не могут образовать валидный треугольник (например, сумма двух сторон меньше третьей).</exception>
    public Triangle(double sideOne, double sideTwo, double sideThree)
    {
        if (sideOne <= 0)
            throw new ArgumentException(IncorrectValueSideTriangleException, nameof(sideOne));
        if (sideTwo <= 0)
            throw new ArgumentException(IncorrectValueSideTriangleException, nameof(sideTwo));
        if (sideThree <= 0)
            throw new ArgumentException(IncorrectValueSideTriangleException, nameof(sideThree));
        
        
        if (sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
        {
            throw new InvalidTriangleException("Сумма двух сторон треугольника должна быть больше третьей.");
        }

        SideOne = sideOne;
        SideTwo = sideTwo;
        SideThree = sideThree;
        IsRectangular = CheckRectangular();
    }

    /// <summary>
    /// проверяет, является ли треугольник прямоугольным.
    /// </summary>
    /// <returns><c>true</c>, если треугольник прямоугольный; иначе <c>false</c>.</returns>
    private bool CheckRectangular()
    {
        var sides = new[] { SideOne, SideTwo, SideThree };
        Array.Sort(sides); 
        
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }

    /// <summary>
    /// вычисляет площадь треугольника по формуле Герона.
    /// </summary>
    /// <returns>площадь треугольника, округленная до двух знаков после запятой.</returns>
    public override double GetArea()
    {
        var p = (SideOne + SideTwo + SideThree) / 2;
        var area = Math.Sqrt(p * (p - SideOne) * (p - SideTwo) * (p - SideThree));
        return double.Round(area, 2);
    }
}