namespace Leetcode.Core.Array;

/// <summary>
/// <see href="https://leetcode.com/problems/majority-element/description/">169. Majority Element</see>
/// </summary>
/*
    Given an array nums of size n, return the majority element.

    The majority element is the element that appears more than [n / 2] times. You may assume that the majority element always exists in the array.
 

    Example 1:

    Input: nums = [3, 2, 3]
    Output: 3

    Example 2:

    Input: nums = [2, 2, 1, 1, 1, 2, 2]
    Output: 2
 

    Constraints:

    n == nums.length
    1 <= n <= 5 * 104
    -109 <= nums[i] <= 109
 

    Follow-up: Could you solve the problem in linear time and in O(1) space?
 */
public class MajorityElement
{
    public static int Majority(int[] nums)
    {
        var majorityCount = (int)Math.Ceiling((double)nums.Length / 2);

        var majorityElement = nums[0];
        Dictionary<int, int> cash = new() { [majorityElement] = 1 };
        for (var i = 1; i < nums.Length; i++)
        {
            _ = cash.TryGetValue(nums[i], out var count);
            cash[nums[i]] = ++count;

            if (cash[majorityElement] < cash[nums[i]])
            {
                majorityElement = nums[i];
            }

            if (count >= majorityCount)
            {
                return majorityElement;
            }
        }

        return majorityElement;
    }
}
