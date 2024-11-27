namespace Leetcode.Core.Mathematic;

/// <summary>
/// <see href="https://leetcode.com/problems/happy-number/">202. Happy Number</see>
/// </summary>
/*
    Write an algorithm to determine if a number n is happy.

    A happy number is a number defined by the following process:

    Starting with any positive integer, replace the number by the sum of the squares of its digits.
    Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    Those numbers for which this process ends in 1 are happy.
    Return true if n is a happy number, and false if not.

    Example 1:

    Input: n = 19
    Output: true
    Explanation:
    12 + 92 = 82
    82 + 22 = 68
    62 + 82 = 100
    12 + 02 + 02 = 1
    Example 2:

    Input: n = 2
    Output: false
 

    Constraints:

    1 <= n <= 231 - 1
 */
public class HappyNumber
{
    public static bool IsHappy(int n)
    {
        HashSet<int> cache = new();
        var exite = false;
        while (!exite)
        {
            var digitsSquare = 0;
            do
            {
                digitsSquare += (int)Math.Pow(n % 10, 2);
                n /= 10;
            }
            while (n is not 0);

            n = digitsSquare;
            if (n is 1)
            {
                exite = true;
            }
            else
            {
                if (cache.TryGetValue(n, out var _))
                {
                    exite = true;
                }
                else
                {
                    cache.Add(n);
                }

            }

        }

        return n is 1;
    }
}
