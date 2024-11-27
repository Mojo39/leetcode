using Leetcode.Core.Array;

namespace Leetcode.Test.Array;
/*
    Example 1:

    Input: citations = [3,0,6,1,5]
    Output: 3
    Explanation: [3,0,6,1,5] means the researcher has 5 papers in total and each of them had received 3, 0, 6, 1, 5 citations respectively.
    Since the researcher has 3 papers with at least 3 citations each and the remaining two with no more than 3 citations each, their h-index is 3.
    Example 2:

    Input: citations = [1,3,1]
    Output: 1
*/
internal class H_IndexTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void HIndex_Execute_Correct(int[] citations, int expected)
    {
        var result = H_Index.HIndex(citations);

        Assert.That(result, Is.EqualTo(expected));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new int[] { 11, 15 }, 2];
            yield return [new int[] { 0 }, 0];
            yield return [new int[] { 100 }, 1];
            yield return [new int[] { 3, 0, 6, 1, 5 }, 3];
            yield return [new int[] { 1, 3, 1 }, 1];
        }
    }
}
