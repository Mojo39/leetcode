namespace Leetcode.Core.Array;
/// <summary>
/// <see href="https://leetcode.com/problems/container-with-most-water">11. Container With Most Water</see>
/// </summary>
/*
    You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

    Find two lines that together with the x-axis form a container, such that the container contains the most water.

    Return the maximum amount of water a container can store.

    Notice that you may not slant the container.
 

    Example 1:


    Input: height = [1,8,6,2,5,4,8,3,7]
    Output: 49
    Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
    Example 2:

    Input: height = [1,1]
    Output: 1
 

    Constraints:

    n == height.length
    2 <= n <= 105
    0 <= height[i] <= 104
 */
public class ContainerWithMostWater
{
    public static int MaxArea(int[] height)
    {
        var leftIndex = 0;
        var rightIndex = height.Length - 1;

        var result = GetArea(height, leftIndex, rightIndex);
        while (leftIndex < rightIndex)
        {
            var area = GetArea(height, leftIndex, rightIndex);
            if (area > result)
            {
                result = area;
            }

            if (height[leftIndex] < height[rightIndex])
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }

        return result;
    }

    private static int GetArea(int[] height, int leftEdge, int rightEdge)
    {
        var depth = Math.Min(height[leftEdge], height[rightEdge]);

        return depth * (rightEdge - leftEdge);
    }
}
