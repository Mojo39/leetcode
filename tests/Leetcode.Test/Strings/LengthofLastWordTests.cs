using Leetcode.Core.Strings;

namespace Leetcode.Test.Strings;

/*
    Example 1:

    Input: s = "Hello World"
    Output: 5
    Explanation: The last word is "World" with length 5.
    Example 2:

    Input: s = "   fly me   to   the moon  "
    Output: 4
    Explanation: The last word is "moon" with length 4.
    Example 3:

    Input: s = "luffy is still joyboy"
    Output: 6
    Explanation: The last word is "joyboy" with length 6.
 */
public class LengthofLastWordTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void IsPalindrome_Execute_Correct(string s, int expected)
    {
        var result = LengthofLastWord.LengthOfLastWord(s);

        Assert.That(result, Is.EqualTo(expected));

    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return ["a", 1];
            yield return ["Hello World", 5];
            yield return ["   fly me   to   the moon  ", 4];
            yield return ["luffy is still joyboy", 6];
            yield return ["luffy is still joyboy.", 6];
        }
    }
}
