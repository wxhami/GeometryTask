using Xunit;

namespace GeometryTask;

public class CircleTests
{
    [Theory()]
    [InlineData(9, 254.34)]
    [InlineData(8, 200.96)]
    public void GetArea_ReturnsExpectedArea(int radius, double expectedArea)
    {
        //arrange
        var circle = new Circle(radius);

        //act
        var result = circle.GetArea();

        //assert
        Assert.Equal(result, expectedArea);
    }

    [Theory()]
    [InlineData(0)]
    [InlineData(-1)]
    public void Circle_ShouldThrowArgumentException_WhenRadiusIsNull(int radius)
    {
        //act
        var exception = Assert.Throws<ArgumentException>(() => new Circle(radius));

        //assert
        Assert.Equal("Radius cannot be zero or less than zero", exception.Message);
    }
}