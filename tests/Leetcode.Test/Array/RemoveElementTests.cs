using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/*
    Example 1:

    Input: nums = [3,2,2,3], val = 3
    Output: 2, nums = [2,2,_,_]
    Explanation: Your function should return k = 2, with the first two elements of nums being 2.
    It does not matter what you leave beyond the returned k (hence they are underscores).
    Example 2:

    Input: nums = [0,1,2,2,3,0,4,2], val = 2
    Output: 5, nums = [0,1,3,0,4,_,_,_]
    Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
    Note that the five elements can be returned in any order.
    It does not matter what you leave beyond the returned k (hence they are underscores).
 */
public class RemoveElementTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void Remove_Execute_Correct(int[] nums, int val, int[] expectedNums)
    {
        var result = RemoveElement.Remove(nums, val);

        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expectedNums.Length));
            Assert.That(nums.Take(result).ToArray(), Is.EqualTo(expectedNums));
        });
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 }];
            yield return [new int[] { 0, 1, 2, 2, 4, 0, 3, 2 }, 2, new int[] { 0, 1, 4, 0, 3 }];
        }
    }
}
