using Leetcode.Core.Strings;

namespace Leetcode.Test.Strings;

/*
    Example 1:

    Input: s = "abc", t = "ahbgdc"
    Output: true
    Example 2:

    Input: s = "axc", t = "ahbgdc"
    Output: false
 */
internal class IsSubsequenceProblemTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void IsSubsequence_Execute_Correct(string s, string t, bool expected)
    {
        var result = IsSubsequenceProblem.IsSubsequence(s, t);

        Assert.That(result, Is.EqualTo(expected));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return ["abc", "ahbgdc", true];
            yield return ["axc", "ahbgdc", false];
        }
    }
}
