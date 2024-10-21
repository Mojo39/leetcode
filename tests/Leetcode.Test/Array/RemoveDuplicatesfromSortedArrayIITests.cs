using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/*
    Example 1:

    Input: nums = [1,1,1,2,2,3]
    Output: 5, nums = [1,1,2,2,3,_]
    Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
    It does not matter what you leave beyond the returned k (hence they are underscores).

    Example 2:

    Input: nums = [0,0,1,1,1,1,2,3,3]
    Output: 7, nums = [0,0,1,1,2,3,3,_,_]
    Explanation: Your function should return k = 7, with the first seven elements of nums being 0, 0, 1, 1, 2, 3 and 3 respectively.
    It does not matter what you leave beyond the returned k (hence they are underscores).
 */
public class RemoveDuplicatesfromSortedArrayIITests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void RemoveDuplicates_IsRun_Correct(int[] nums, int[] expectedNums)
    {
        var result = RemoveDuplicatesfromSortedArrayII.RemoveDuplicates(nums);

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
            yield return [new int[] { 1, 1, 1, 2, 2, 3 }, new int[] { 1, 1, 2, 2, 3 }];
            yield return [new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, new int[] { 0, 0, 1, 1, 2, 3, 3 }];
        }
    }
}
