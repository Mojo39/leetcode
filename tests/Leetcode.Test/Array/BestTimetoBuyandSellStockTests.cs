using Leetcode.Core.Array;

namespace Leetcode.Test.Array;

/// <summary>
/// <see href="https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description">121. Best Time to Buy and Sell Stock</see>
/// </summary>
/*
 

    Example 1:

    Input: prices = [7,1,5,3,6,4]
    Output: 5
    Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
    Example 2:

    Input: prices = [7,6,4,3,1]
    Output: 0
    Explanation: In this case, no transactions are done and the max profit = 0.
 
 */
public class BestTimetoBuyandSellStockTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void MaxProfit_Execute_Correct(int[] nums, int expected)
    {
        var result = BestTimetoBuyandSellStock.MaxProfit(nums);

        Assert.That(result, Is.EqualTo(expected));

    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 1, 2 }, 1];
            yield return [new int[] { 7, 1, 5, 3, 6, 4 }, 5];
            yield return [new int[] { 7, 6, 4, 3, 1 }, 0];
        }
    }
}
