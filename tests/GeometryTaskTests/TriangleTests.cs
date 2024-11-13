using FluentAssertions;
using GeometryTask;
using GeometryTask.Exceptions;
using Xunit;

namespace GeometryTaskTests;

public class TriangleTests
{
    [Theory()]
    [InlineData(1, 3, 0)]
    [InlineData(1, 0, 3)]
    [InlineData(0, 1, 3)]
    public void Triangle_ThrowsArgumentException_WhenOneOfSidesHasIncorrectValue(double sideOne, double sideTwo,
        double sideThree)
    {
        //act
        var action = () => new Triangle(sideOne, sideTwo, sideThree);

        //assert
        action.Should().ThrowExactly<ArgumentException>()
            .WithMessage("Значение cтороны треугольника должно быть больше 0.*");
    }

    [Theory()]
    [InlineData(1, 3, 1)]
    [InlineData(1, 1, 3)]
    [InlineData(3, 1, 1)]
    public void Triangle_ThrowsArgumentException_WhenSumTwoSidesLessThenThird(double sideOne, double sideTwo,
        double sideThree)
    {
        //act
        var action = () => new Triangle(sideOne, sideTwo, sideThree);

        //assert
        action.Should().ThrowExactly<InvalidTriangleException>()
            .WithMessage("Сумма двух сторон треугольника должна быть больше третьей.");
    }

    [Theory()]
    [InlineData(4, 2, 3, 2.90)]
    [InlineData(4, 3, 3, 4.47)]
    public void GetArea_ReturnsExpectedArea_ValidArgs(double sideOne, double sideTwo, double sideThree,
        double expectedArea)
    {
        //arrange
        var triangle = new Triangle(sideOne, sideTwo, sideThree);

        //act
        var result = triangle.GetArea();

        //assert
        result.Should().BeApproximately(expectedArea, 0.005);
    }

    [Theory()]
    [InlineData(4, 2, 3, false)]
    [InlineData(6, 8, 10, true)]
    public void IsRectangular_ShouldBeValid_ValidArgs(double sideOne, double sideTwo, double sideThree, bool expected)
    {
        //arrange
        var triangle = new Triangle(sideOne, sideTwo, sideThree);


        //assert
        triangle.IsRectangular.Should().Be(expected);
    }
}