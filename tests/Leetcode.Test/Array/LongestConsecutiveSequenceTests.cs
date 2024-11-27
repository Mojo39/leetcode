using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/*
    Example 1:

    Input: nums = [100,4,200,1,3,2]
    Output: 4
    Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
    Example 2:

    Input: nums = [0,3,7,2,5,8,4,6,0,1]
    Output: 9
 */
internal class LongestConsecutiveSequenceTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void LongestConsecutive_Execute_Correct(int[] nums, int expected)
    {
        var result = LongestConsecutiveSequence.LongestConsecutive(nums);

        Assert.That(result, Is.EqualTo(expected));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 0, -1 }, 2];
            yield return [new int[] { 1, 2, 0, 1 }, 3];
            yield return [new int[] { 100, 4, 200, 1, 3, 2 }, 4];
            yield return [new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9];
            yield return [new int[] { 100, 4, 200, 1, 3, 2, 101, 102, 103, 104, 105 }, 6];
        }
    }
}
