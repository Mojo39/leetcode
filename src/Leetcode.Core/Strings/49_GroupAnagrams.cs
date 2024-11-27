using System.Linq;

namespace Leetcode.Core.Strings;

/// <summary>
/// <see href="https://leetcode.com/problems/group-anagrams/description/">49. Group Anagrams</see>
/// </summary>
/*
     Given an array of strings strs, group the anagrams together. You can return the answer in any order.
 

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

 

    Constraints:

    1 <= strs.length <= 104
    0 <= strs[i].length <= 100
    strs[i] consists of lowercase English letters.
 */
public class GroupAnagrams
{
    public static List<List<string>> Solution(string[] strs)
    {
        Dictionary<string, IList<string>> parseOfSymbolsDict = new();
        for (var i = 0; i < strs.Length; i++)
        {
            var sortedStr = new string(strs[i].Order().ToArray());
            if (!parseOfSymbolsDict.TryGetValue(sortedStr, out var list))
            {
                list = [];

            }
            list.Add(strs[i]);
            parseOfSymbolsDict[sortedStr] = list;
        }

        List<IList<string>> result = [];
        foreach (var groups in parseOfSymbolsDict.Values.OrderBy(itm => itm.Count))
        {
            result.Add(groups);
        }
        return result.Select(itm => itm.ToList()).ToList();
    }
}
