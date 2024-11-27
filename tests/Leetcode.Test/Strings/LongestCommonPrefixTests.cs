using Leetcode.Core.Strings;

namespace Leetcode.Test.Strings;

/*
    Example 1:

    Input: strs = ["flower","flow","flight"]
    Output: "fl"
    Example 2:

    Input: strs = ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.
 */
internal class LongestCommonPrefixTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void IsPalindrome_Execute_Correct(string[] strs, string expected)
    {
        var result = LongestCommonPrefix.CommonPrefix(strs);

        Assert.That(result, Is.EqualTo(expected));

    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new string[] { "a" }, "a"];
            yield return [new string[] { "ab", "a" }, "a"];
            yield return [new string[] { "", "" }, string.Empty];
            yield return [new string[] { "flower", "flow", "flight" }, "fl"];
            yield return [new string[] { "dog", "racecar", "car" }, string.Empty];
        }
    }
}
