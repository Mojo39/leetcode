using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/*
    Example 1:

    Input: nums = [3, 2, 3]
    Output: 3

    Example 2:

    Input: nums = [2, 2, 1, 1, 1, 2, 2]
    Output: 2
 */
public class MajorityElementTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void Majority_Execute_Correct(int[] nums, int expected)
    {
        var result = MajorityElement.Majority(nums);

        Assert.That(result, Is.EqualTo(expected));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 3, 2, 3 }, 3];
            yield return [new int[] { 6, 5, 5 }, 5];
            yield return [new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2];
        }
    }
}
