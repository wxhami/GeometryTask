using Xunit;

namespace GeometryTask;

public class CircleTests
{
    [Theory()]
    [InlineData(9, 254.34)]
    [InlineData(8, 200.96)]
    public void Test(int radius, double expectedArea)
    {
        //arrange
        var circle = new Circle(radius);

        //act
        var result = circle.GetArea();

        //assert
        Assert.Equal(result, expectedArea);
    }
}