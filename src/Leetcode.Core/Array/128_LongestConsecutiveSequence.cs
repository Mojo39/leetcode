namespace Leetcode.Core.Array;

/// <summary>
/// <see href="https://leetcode.com/problems/longest-consecutive-sequence/">128. Longest Consecutive Sequence</see>
/// </summary>
/*
    Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
    You must write an algorithm that runs in O(n) time.


    Example 1:

    Input: nums = [100,4,200,1,3,2]
    Output: 4
    Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
    Example 2:

    Input: nums = [0,3,7,2,5,8,4,6,0,1]
    Output: 9
 

    Constraints:

    0 <= nums.length <= 105
    -109 <= nums[i] <= 109
 */
public class LongestConsecutiveSequence
{
    public static int LongestConsecutive(int[] nums)
    {
        nums = nums.Order().ToArray();

        var longestConsecutive = nums.Length is 0 ? 0 : 1;
        var currentConsecutive = 1;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            currentConsecutive = nums[i] switch
            {
                _ when nums[i] == nums[i + 1] => currentConsecutive,
                _ when nums[i] + 1 == nums[i + 1] => currentConsecutive + 1,
                _ => 1
            };

            if (longestConsecutive < currentConsecutive)
            {
                longestConsecutive = currentConsecutive;
            }
        }

        return longestConsecutive;
    }
}
