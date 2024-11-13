namespace GeometryTask;

/// <summary>
/// Представляет круг с заданным радиусом. Позволяет вычислить площадь круга.
/// </summary>
public class Circle : FigureBase
{
    // Приватное поле для хранения радиуса
    private readonly double _radius;

    /// <summary>
    /// Инициализирует круг с заданным радиусом.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если радиус меньше или равен 0.</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус не может быть равен или меньше 0.", nameof(radius));

        _radius = radius;
    }

    /// <summary>
    /// Вычисляет площадь круга по формуле π * r².
    /// </summary>
    /// <returns>Площадь круга.</returns>
    public override double GetArea()
    {
        return double.Round(Math.PI * _radius * _radius, 2); 
    }
}
