using Leetcode.Core.Strings;

namespace Leetcode.Test.Strings;

/*
    Example 1:

    Input: s = "anagram", t = "nagaram"
    Output: true

    Example 2:

    Input: s = "rat", t = "car"
    Output: false

 */
internal class ValidAnagramTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void IsAnagram_Execute_Correct(string s, string t, bool expected)
    {
        var result = ValidAnagram.IsAnagram(s, t);

        Assert.That(result, Is.EqualTo(expected));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return ["anagram", "nagaram", true];
            yield return ["rat", "cat", false];
            yield return ["rat", "at", false];
        }
    }
}
