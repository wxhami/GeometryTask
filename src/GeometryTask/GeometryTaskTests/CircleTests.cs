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

    [Fact]
    public void Circle_ShouldThrowArgumentException_WhenRadiusIsNull()
    {
        //arrange
        int radius = 0;

        //act
        var exception = Assert.Throws<ArgumentException>(() => new Circle(0));


        //assert
        Assert.Equal("radius cannot be null", exception.Message);
    }
}