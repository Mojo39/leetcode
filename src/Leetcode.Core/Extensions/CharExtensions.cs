namespace Leetcode.Core.Extensions;

internal static class CharExtensions
{
    public static bool IsNumberOrLowerLatter(this char self)
        => (int)self is (> 47 and < 58) or (> 96 and < 123);

    public static bool IsLetter(this char self)
        => self is (>= 'A' and <= 'Z') or (>= 'a' and <= 'z');
}
