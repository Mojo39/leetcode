using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/// <summary>
/// <see href="https://leetcode.com/problems/rotate-array/description/">189. Rotate Array</see>
/// </summary>
/*
    Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

    Example 1:

    Input: nums = [1,2,3,4,5,6,7], k = 3
    Output: [5,6,7,1,2,3,4]
    Explanation:
    rotate 1 steps to the right: [7,1,2,3,4,5,6]
    rotate 2 steps to the right: [6,7,1,2,3,4,5]
    rotate 3 steps to the right: [5,6,7,1,2,3,4]
    Example 2:

    Input: nums = [-1,-100,3,99], k = 2
    Output: [3,99,-1,-100]
    Explanation: 
    rotate 1 steps to the right: [99,-1,-100,3]
    rotate 2 steps to the right: [3,99,-1,-100]
 

    Constraints:

    1 <= nums.length <= 105
    -231 <= nums[i] <= 231 - 1
    0 <= k <= 105
 

    Follow up:

    Try to come up with as many solutions as you can. There are at least three different ways to solve this problem.
    Could you do it in-place with O(1) extra space?
 */
internal class RotateArrayTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void Rotate_Execute_Correct(int[] nums, int k, int[] expectedNums)
    {
        RotateArray.Rotate(nums, k);

        Assert.That(nums, Is.EqualTo(expectedNums));

    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 1, 2 }, 3, new int[] { 2, 1 }];
            yield return [new int[] { 1, 2 }, 2, new int[] { 1, 2 }];
            yield return [new int[] { 1, 2, 3 }, 2, new int[] { 2, 3, 1 }];
            yield return [new int[] { 3, 2, 2, 3 }, 1, new int[] { 3, 3, 2, 2 }];
            yield return [new int[] { 3, 2, 5, 4, 6 }, 3, new int[] { 5, 4, 6, 3, 2 }];
            yield return [new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 }];
            yield return [new int[] { 1, 2, 3, 4, 5, 6, 7 }, 4, new int[] { 4, 5, 6, 7, 1, 2, 3 }];
            yield return [new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 }];
        }
    }
}
