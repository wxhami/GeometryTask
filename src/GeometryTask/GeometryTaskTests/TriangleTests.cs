using GeometryTask;
using Xunit;

namespace GeometryTaskTests;

public class TriangleTests
{
    [Theory()]
    [InlineData(1, 3, 0)]
    [InlineData(1, 2, 1)]
    public void Circle_ShouldThrowArgumentException_WhenSidesIncorrect(double sideOne, double sideTwo, double sideThree)
    {
        //act
        var exception = Assert.Throws<ArgumentException>(() => new Triangle(sideOne, sideTwo, sideThree));

        //assert
        Assert.Equal("Incorrect sides of the triangle", exception.Message);
    }

    [Theory()]
    [InlineData(4, 2, 3, 2.90)]
    [InlineData(4, 3, 3, 4.47)]
    public void GetArea_ReturnsExpectedArea(double sideOne, double sideTwo, double sideThree, double expectedArea)
    {
        //arrange
        var triangle = new Triangle(sideOne, sideTwo, sideThree);

        //act
        var result = triangle.GetArea();

        //assert
        Assert.Equal(expectedArea, result);
    }

    [Theory()]
    [InlineData(4, 2, 3, false)]
    [InlineData(6, 8, 10, true)]
    public void CheckRectangular_ReturnsCheckResult(double sideOne, double sideTwo, double sideThree, bool expected)
    {
        //arrange
        var triangle = new Triangle(sideOne, sideTwo, sideThree);

        //act
        var result = triangle.CheckRectangular();

        //assert
        Assert.Equal(expected, result);
    }
}