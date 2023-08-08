using Xunit;

namespace GeometryTask;

public class CircleTests
{
    [Theory()]
    [InlineData(9, 6)]
    [InlineData()]
    [InlineData()
    public void Test(int radius, int area)
    {
        //act
        var circle = new Circle();
        var result = circle.GetArea();


        //assert
        Assert.Equal(expectedTarget, target);
    }
}