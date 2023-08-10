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
        Assert.Equal("incorrect sides of the triangle", exception.Message);
    }
}