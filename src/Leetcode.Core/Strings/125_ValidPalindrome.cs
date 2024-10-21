namespace Leetcode.Core.Strings;

/// <summary>
/// <see cref="https://leetcode.com/problems/valid-palindrome/description">125. Valid Palindrome</see>
/// </summary>
/*
    A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters,
    it reads the same forward and backward. Alphanumeric characters include letters and numbers.

    Given a string s, return true if it is a palindrome, or false otherwise.

 

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
 

    Constraints:

    1 <= s.length <= 2 * 105
    s consists only of printable ASCII characters.
 */
public class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        var str = s.ToLowerInvariant();

        var isPalindrome = true;

        var leftIndex = 0;
        var rightIndex = s.Length - 1;

        while (leftIndex < rightIndex && isPalindrome)
        {
            leftIndex += GetLeftOffset(str, leftIndex);
            rightIndex -= GetRightOffset(str, rightIndex);

            if (rightIndex <= leftIndex)
            {
                return true;
            }

            isPalindrome &= str[leftIndex++] == str[rightIndex--];
        }

        return isPalindrome;
    }

    private static int GetLeftOffset(string str, int startIndex)
    {
        var offset = 0;
        var move = true;
        while (startIndex + offset < str.Length && move)
        {
            move = !CharIsNumberOrLowerSymbol(str[startIndex + offset]);
            offset = move ? offset + 1 : offset;
        }

        return offset;
    }

    private static int GetRightOffset(string str, int startIndex)
    {
        var offset = 0;
        var move = true;
        while (startIndex - offset > -1 && move)
        {
            move = !CharIsNumberOrLowerSymbol(str[startIndex - offset]);
            offset = move ? offset + 1 : offset;
        }

        return offset;
    }

    private static bool CharIsNumberOrLowerSymbol(char c)
        => (int)c is (> 47 and < 58) or (> 96 and < 123);
}
