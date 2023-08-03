using GeometryTask;

namespace GeometryTaskTests;

public class UnitTest1
{
    [Fact]
    public void ArrayExtensions_SortArray()
    {
        //arrange
        double[] nums = { 2,3,1 };

        //act
        nums.Sort();

        //assert
        Assert.Equal(new double[]{1,2,3}, nums);
    }
}