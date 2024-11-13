using FluentAssertions;
using GeometryTask;
using Xunit;

namespace GeometryTaskTests;

public class CircleTests
{
    [Theory()]
    [InlineData(9, 254.47)]
    [InlineData(8, 201.06)]
    public void GetArea_ReturnsExpectedArea_ValidArgs(int radius, double expectedArea)
    {
        //arrange
        var circle = new Circle(radius);

        //act
        var result = circle.GetArea();

        //assert
        result.Should().BeApproximately(expectedArea, 0.005 );
    }

    [Theory()]
    [InlineData(0)]
    [InlineData(-1)]
    public void Circle_ThrowsArgumentException_WhenRadiusIsNull(int radius)
    {
        //act
        var action = () => new Circle(radius);

        //assert
        action.Should().ThrowExactly<ArgumentException>()
            .WithMessage("Радиус не может быть равен или меньше 0.*");
    }
}