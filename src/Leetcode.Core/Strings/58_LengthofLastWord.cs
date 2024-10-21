using Leetcode.Core.Extensions;

namespace Leetcode.Core.Strings;

/// <summary>
/// <see href="https://leetcode.com/problems/length-of-last-word/description">58. Length of Last Word</see>
/// </summary>
/*
    Given a string s consisting of words and spaces, return the length of the last word in the string
    A word is a maximal substring consisting of non-space characters only.

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
 

    Constraints:

    1 <= s.length <= 104
    s consists of only English letters and spaces ' '.
    There will be at least one word in s.
 */
public class LengthofLastWord
{
    public static int LengthOfLastWord(string s)
    {
        var currentIndex = s.Length - 1;

        var count = 0;
        var setOffset = true;
        while (currentIndex > -1)
        {
            if (!s[currentIndex].IsLetter())
            {
                if (!setOffset)
                {
                    return count;
                }

                currentIndex--;
            }
            else
            {
                setOffset = false;
                currentIndex--;
                count++;
            }
        }

        return count;
    }

    private static int GetOffset(string s)
    {
        var offset = 0;

        while (!s[^(offset + 1)].IsLetter())
        {
            offset++;
        }

        return offset;
    }
}
