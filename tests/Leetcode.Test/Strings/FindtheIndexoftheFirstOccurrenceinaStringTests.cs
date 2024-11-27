using Leetcode.Core.Strings;

namespace Leetcode.Test.Strings;

/*
    Example 1:

    Input: haystack = "sadbutsad", needle = "sad"
    Output: 0
    Explanation: "sad" occurs at index 0 and 6.
    The first occurrence is at index 0, so we return 0.
    Example 2:

    Input: haystack = "leetcode", needle = "leeto"
    Output: -1
    Explanation: "leeto" did not occur in "leetcode", so we return -1.
*/
internal class FindtheIndexoftheFirstOccurrenceinaStringTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void StrStr_Execute_Correct(string haystack, string needle, int expected)
    {
        var result = FindtheIndexoftheFirstOccurrenceinaString.StrStr(haystack, needle);

        Assert.That(result, Is.EqualTo(expected));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return ["mississippi", "pi", 9];
            yield return ["mississippi", "issip", 4];
            yield return ["sadbutsad", "sad", 0];
            yield return ["leetcode", "leeto", -1];
        }
    }
}
