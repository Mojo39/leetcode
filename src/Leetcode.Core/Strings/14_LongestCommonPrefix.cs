using System.Text;

namespace Leetcode.Core.Strings;

/// <summary>
/// <see href="https://leetcode.com/problems/longest-common-prefix/description">14. Longest Common Prefix</see>
/// </summary>
/*
    Write a function to find the longest common prefix string amongst an array of strings.

    If there is no common prefix, return an empty string "".


    Example 1:

    Input: strs = ["flower","flow","flight"]
    Output: "fl"
    Example 2:

    Input: strs = ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.
 

    Constraints:

    1 <= strs.length <= 200
    0 <= strs[i].length <= 200
    strs[i] consists of only lowercase English letters.
 */
public class LongestCommonPrefix
{
    public static string CommonPrefix(string[] strs)
    {
        strs = strs.Order().ToArray();

        var sb = new StringBuilder();

        var first = strs[0];
        var last = strs[^1];

        for (var i = 0; i < Math.Min(first.Length, last.Length); i++)
        {
            if (first[i] != last[i])
            {
                return sb.ToString();
            }
            _ = sb.Append(first[i]);
        }

        return sb.ToString();
    }
}
/*
 * максимальный префикс не всех строк, а хотя бы для 2х
 if (strs.Length == 1)
        {
            return strs[0];
        }

        var prefixLength = 1;
        var currentArr = strs;
        while (true)
        {
            if (currentArr.Length is 1)
            {
                if (prefixLength is 1)
                {
                    break;
                }
                return currentArr[0][..(prefixLength - 2)];
            }

            Dictionary<string, List<string>> dic = [];

            foreach (var str in currentArr.Where(itm => itm.Length != 0 && itm.Length >= prefixLength))
            {
                var prefix = str[..prefixLength];

                if (!dic.TryGetValue(prefix, out var current))
                {
                    current = [];
                }
                if (str.Length >= prefixLength)
                {
                    current.Add(str);
                }
                dic[prefix] = current;
            }

            if (dic.Count is 0)
            {
                break;
            }

            var maxLength = 0;
            foreach (var arr in dic)
            {
                if (maxLength < arr.Value.Count)
                {
                    currentArr = arr.Value.ToArray();
                }
            }

            prefixLength++;
        }

        return string.Empty;
 */
