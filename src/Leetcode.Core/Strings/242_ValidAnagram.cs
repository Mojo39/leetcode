namespace Leetcode.Core.Strings;

/// <summary>
/// <see href="https://leetcode.com/problems/valid-anagram/description/">242. ValidAnagram</see>
/// </summary>
/*
    Given two strings s and t, return true if t is an anagram of s, and false otherwise.

    Example 1:

    Input: s = "anagram", t = "nagaram"
    Output: true

    Example 2:

    Input: s = "rat", t = "car"
    Output: false


    Constraints:

    1 <= s.length, t.length <= 5 * 104
    s and t consist of lowercase English letters.
 

    Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
 */
public class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        var result = s.Length == t.Length;
        if (!result)
        {
            return result;
        }

        Dictionary<char, int> dic = [];
        for (var i = 0; i < s.Length; i++)
        {
            _ = dic.TryGetValue(s[i], out var count);

            dic[s[i]] = ++count;
        }

        for (var i = 0; result && i < t.Length; i++)
        {
            result = dic.TryGetValue(t[i], out var count) && count is > 0;

            dic[t[i]] = --count;
        }

        return result;
    }
}
