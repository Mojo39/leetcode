namespace Leetcode.Core.Mathematic;

/// <summary>
/// <see href="https://leetcode.com/problems/sqrtx/description/">69. Sqrt(x)</see>
/// </summary>
public class Sqrtx
{
    public static int MySqrt(int x)
    {
        var left = 1;
        var right = x;
        var expectedSqrt = 0;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            expectedSqrt = x / mid;
            if (expectedSqrt == mid)
            {
                return mid;
            }
            else if (expectedSqrt < mid)
            {
                right = mid - 1;
            }
            else if (expectedSqrt > mid)
            {
                left = mid + 1;
            }
        }
        return right;
    }
}
