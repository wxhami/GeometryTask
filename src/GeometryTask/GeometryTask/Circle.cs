namespace GeometryTask;

/// <summary>
/// Представляет круг с заданным радиусом. Позволяет вычислить площадь круга.
/// </summary>
public class Circle : FigureBase
{
    /// <summary>
    /// Приватное поле для хранения радиуса
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Инициализирует круг с заданным радиусом.
    /// </summary>
    /// <param name="radius">радиус круга.</param>
    /// <exception cref="ArgumentException">выбрасывается, если радиус меньше или равен 0.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус не может быть равен или меньше 0.", nameof(radius));

        Radius = radius;
    }

    /// <summary>
    /// Вычисляет площадь круга по формуле π * r².
    /// </summary>
    /// <returns>Площадь круга.</returns>
    public override double GetArea()
    {
        return Math.PI * Radius * Radius; 
    }
}
