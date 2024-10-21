namespace Leetcode.Core.Numeric;

/// <summary>
/// <see href="https://leetcode.com/problems/palindrome-number/">9. Palindrome Number</see>
/// </summary>
/*
    Given an integer x, return true if x is a palindrome, and false otherwise.

    Example 1:

    Input: x = 121
    Output: true
    Explanation: 121 reads as 121 from left to right and from right to left.
    Example 2:

    Input: x = -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    Example 3:

    Input: x = 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

    Constraints:

    -231 <= x <= 231 - 1
 

    Follow up: Could you solve it without converting the integer to a string?
 */
public class PalindromeNumber
{
    public static bool Solution(int x)
    {
        int r = 0, c = x;
        while (c > 0)
        {
            r = r * 10 + c % 10;
            c /= 10;
        }
        return r == x;
    }
}
