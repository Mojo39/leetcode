using Leetcode.Core.Strings;

namespace Leetcode.Test.Strings;

/*
    Example 1:

    Input: s = "the sky is blue"
    Output: "blue is sky the"
    Example 2:

    Input: s = "  hello world  "
    Output: "world hello"
    Explanation: Your reversed string should not contain leading or trailing spaces.
    Example 3:

    Input: s = "a good   example"
    Output: "example good a"
    Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
 */
internal class ReverseWordsinaStringTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void ReverseWords_Execute_Correct(string s, string expected)
    {
        var result = ReverseWordsinaString.ReverseWords(s);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void ReverseWordsV2_Execute_Correct(string s, string expected)
    {
        var result = ReverseWordsinaString.ReverseWordsV1(s);

        Assert.That(result, Is.EqualTo(expected));

    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return ["the sky is blue", "blue is sky the"];
            yield return ["  hello world  ", "world hello"];
            yield return ["a good   example", "example good a"];
        }
    }
}
