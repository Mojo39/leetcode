using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/*
    Example 1:

    Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
    Output: [1,2,2,3,5,6]
    Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
    The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
    Example 2:

    Input: nums1 = [1], m = 1, nums2 = [], n = 0
    Output: [1]
    Explanation: The arrays we are merging are [1] and [].
    The result of the merge is [1].
    Example 3:

    Input: nums1 = [0], m = 0, nums2 = [1], n = 1
    Output: [1]
    Explanation: The arrays we are merging are [] and [1].
    The result of the merge is [1].
    Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
 */
public class MergeSortedArrayTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void Merge_Execute_Correct(int[] nums1, int m, int[] nums2, int n, int[] expectedNums)
    {
        MergeSortedArray.Merge(nums1, m, nums2, n);

        Assert.That(nums1.Take(expectedNums.Length).ToArray(), Is.EqualTo(expectedNums));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 }];
            yield return [new int[] { 1 }, 1, System.Array.Empty<int>(), 0, new int[] { 1 }];
            yield return [new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 }];
        }
    }
}
