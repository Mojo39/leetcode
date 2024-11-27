using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/*
    Input: height = [1,8,6,2,5,4,8,3,7]
    Output: 49
    Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
    Example 2:

    Input: height = [1,1]
    Output: 1
 */
internal class ContainerWithMostWaterTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void MaxArea_Execute_Correct(int[] height, int expected)
    {
        var result = ContainerWithMostWater.MaxArea(height);

        Assert.That(result, Is.EqualTo(expected));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49];
            yield return [new int[] { 1, 1 }, 1];
        }
    }
}
