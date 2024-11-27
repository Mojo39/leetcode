using Leetcode.Core.Strings;

namespace Leetcode.Test.Strings;

/*
    Example 1:

    Input: s = "A man, a plan, a canal: Panama"
    Output: true
    Explanation: "amanaplanacanalpanama" is a palindrome.
    Example 2:

    Input: s = "race a car"
    Output: false
    Explanation: "raceacar" is not a palindrome.
    Example 3:

    Input: s = " "
    Output: true
    Explanation: s is an empty string "" after removing non-alphanumeric characters.
    Since an empty string reads the same forward and backward, it is a palindrome.
 */
internal class ValidPalindromeTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void IsPalindrome_Execute_Correct(string s, bool expected)
    {
        var result = ValidPalindrome.IsPalindrome(s);

        Assert.That(result, Is.EqualTo(expected));

    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [".,", true];
            yield return ["A man, a plan, a canal: Panama", true];
            yield return ["race a car", false];
            yield return [" ", true];
            yield return [string.Empty, true];
            yield return ["rar", true];
            yield return ["ra r", true];
        }
    }
}
