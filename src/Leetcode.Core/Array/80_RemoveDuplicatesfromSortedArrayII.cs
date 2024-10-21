namespace Leetcode.Core.Array;

/// <summary>
/// <see href="https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii">80. Remove Duplicates from Sorted Array II</see>
/// </summary>
/*
    Given an integer array nums sorted in non-decreasing order, remove some duplicates in-place such that each unique element appears at most twice.
    The relative order of the elements should be kept the same.

    Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally,
    if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.

    Return k after placing the final result in the first k slots of nums.

    Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

    Example 1:

    Input: nums = [1, 1, 1, 2, 2, 3]
    Output: 5, nums = [1, 1, 2, 2, 3 , _]
    Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
    It does not matter what you leave beyond the returned k (hence they are underscores).

    Example 2:

    Input: nums = [0, 0, 1, 1, 1, 1, 2, 3, 3]
    Output: 7, nums = [0, 0, 1, 1, 2, 3, 3, _, _]
    Explanation: Your function should return k = 7, with the first seven elements of nums being 0, 0, 1, 1, 2, 3 and 3 respectively.
    It does not matter what you leave beyond the returned k (hence they are underscores).
 

    Constraints:

    1 <= nums.length <= 3 * 104
    -104 <= nums[i] <= 104
    nums is sorted in non-decreasing order.

    [1, 1, 1, 2, 2, 3]

    uniqueOrTwice = 2
    i = 2, uniqueOrTwice = 3 [0, 0, 1, _, _, _, _, _, _]
    i = 4, uniqueOrTwice = 4 [0, 0, 1, 1, 1, _, _, _, _]
    i = 6, uniqueOrTwice = 5 [0, 0, 1, 1, 2, 1, 2, _, _]
    i = 8, uniqueOrTwice = 7 [0, 0, 1, 1, 2, 3, 3, _, _]
 */
public class RemoveDuplicatesfromSortedArrayII
{
    public static int RemoveDuplicates(int[] nums)
    {
        var uniqueOrTwice = nums.Length > 2 ? 2 : nums.Length;
        for (var i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueOrTwice - 2])
            {
                nums[uniqueOrTwice] = nums[i];
                uniqueOrTwice++;
            }
        }

        return uniqueOrTwice;
    }
}
