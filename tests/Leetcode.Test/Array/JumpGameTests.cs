using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/*
    Example 1:

    Input: nums = [2,3,1,1,4]
    Output: true
    Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
    Example 2:

    Input: nums = [3,2,1,0,4]
    Output: false
    Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
 

    Constraints:

    1 <= nums.length <= 104
    0 <= nums[i] <= 105
*/
public class JumpGameTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void CanJump_Execute_Correct(int[] nums, bool expected)
    {
        var result = JumpGame.CanJump(nums);

        Assert.That(result, Is.EqualTo(expected));

    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 0 }, true];
            yield return [new int[] { 2, 3, 1, 1, 4 }, true];
            yield return [new int[] { 3, 2, 1, 0, 4 }, false];
            yield return [new int[] { 2, 3, 7, 2, 3, 0, 4 }, true];
        }
    }
}
