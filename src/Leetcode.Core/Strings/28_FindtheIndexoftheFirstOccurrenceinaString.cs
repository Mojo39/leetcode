using Leetcode.Core.Tree;

namespace Leetcode.Core.Strings;

/// <summary>
/// <see href="https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string">28. Find the Index of the First Occurrence in a String</see>
/// </summary>
/*
    Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.


    Example 1:

    Input: haystack = "sadbutsad", needle = "sad"
    Output: 0
    Explanation: "sad" occurs at index 0 and 6.
    The first occurrence is at index 0, so we return 0.
    Example 2:

    Input: haystack = "leetcode", needle = "leeto"
    Output: -1
    Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

    Constraints:

    1 <= haystack.length, needle.length <= 104
    haystack and needle consist of only lowercase English characters.
 */
public class FindtheIndexoftheFirstOccurrenceinaString
{
    public static int StrStr(string haystack, string needle)
    {
        var haystackIndex = 0;
        var needleIndex = 0;
        while (haystackIndex < haystack.Length && needleIndex < needle.Length)
        {
            if (haystack[haystackIndex] == needle[needleIndex])
            {
                needleIndex++;
            }
            else
            {
                if (needleIndex is not 0)
                {
                    haystackIndex -= needleIndex;
                }
                needleIndex = 0;
            }

            haystackIndex++;
        }

        return needleIndex == needle.Length ? haystackIndex - needle.Length : -1;
    }
}
