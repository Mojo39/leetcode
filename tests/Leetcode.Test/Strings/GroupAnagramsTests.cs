using Leetcode.Core.Strings;

namespace Leetcode.Test.Strings;

/*
 
    Example 1:

    Input: strs = ["eat","tea","tan","ate","nat","bat"]

    Output: [["bat"],["nat","tan"],["ate","eat","tea"]]


    Explanation:

    There is no string in strs that can be rearranged to form "bat".
    The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
    The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
    Example 2:

    Input: strs = [""]

    Output: [[""]]

    Example 3:

    Input: strs = ["a"]

    Output: [["a"]]

 */
internal class GroupAnagramsTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void IsAnagram_Execute_Correct(string[] strs, List<List<string>> expected)
    {
        var result = GroupAnagrams.Solution(strs);

        Assert.That(result, Is.EqualTo(expected));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [new[] { "eat", "tea", "tan", "ate", "nat", "bat" }, new List<List<string>>() { new() { "bat" }, new() { "tan", "nat" }, new() { "eat", "tea", "ate" } }];
            yield return [new[] { "" }, new List<List<string>>() { new() { "" } }];
            yield return [new[] { "a" }, new List<List<string>>() { new() { "a" } }];
            yield return [new[] { "bdddddddddd", "bbbbbbbbbbc" }, new List<List<string>>() { new() { "bdddddddddd" }, new() { "bbbbbbbbbbc" } }];
        }
    }
}
