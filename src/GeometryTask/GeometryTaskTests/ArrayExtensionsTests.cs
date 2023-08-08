using GeometryTask;
using Xunit;

namespace GeometryTaskTests;

public class ArrayExtensionsTests
{
    [Fact]
    public void Sort_SortArray_WhenValidArray()
    {
        //arrange
        double[] nums = { 2, 3, 1 };

        //act
        nums.Sort();

        //assert
        Assert.Equal(new double[] { 1, 2, 3 }, nums);
    }
}