using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/// <summary>
/// <see href="https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description">121. Best Time to Buy and Sell Stock</see>
/// </summary>
/*
    Example 1:

    Input: prices = [7,1,5,3,6,4]
    Output: 7
    Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
    Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
    Total profit is 4 + 3 = 7.
    Example 2:

    Input: prices = [1,2,3,4,5]
    Output: 4
    Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4.
    Total profit is 4.
    Example 3:

    Input: prices = [7,6,4,3,1]
    Output: 0
    Explanation: There is no way to make a positive profit, so we never buy the stock to achieve the maximum profit of 0.
 
 */
public class BestTimetoBuyandSellStockIITests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void MaxProfit_Execute_Correct(int[] nums, int expected)
    {
        var result = BestTimetoBuyandSellStockII.MaxProfit(nums);

        Assert.That(result, Is.EqualTo(expected));

    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 1, 2, 3, 4, 5 }, 4];
            yield return [new int[] { 7, 6, 4, 3, 1 }, 0];
            yield return [new int[] { 7, 1, 5, 3, 6, 4 }, 7];
            yield return [new int[] { 7, 2, 1, 5, 3, 5, 1, 6, 8 }, 13];
            yield return [new int[] { 2, 7, 8, 1, 5, 3, 5, 1, 6, 8 }, 19];
        }
    }
}
