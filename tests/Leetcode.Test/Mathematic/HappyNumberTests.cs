using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Core.Mathematic;
using Leetcode.Core.Strings;

namespace Leetcode.Test.Mathematic;
/*
 
    Example 1:

    Input: n = 19
    Output: true
    Explanation:
    12 + 92 = 82
    82 + 22 = 68
    62 + 82 = 100
    12 + 02 + 02 = 1
    Example 2:

    Input: n = 2
    Output: false
 
 */
internal class HappyNumberTests
{
    [Theory]
    [TestCaseSource(nameof(TestData))]
    public void IsAnagram_Execute_Correct(int n, bool expected)
    {
        var result = HappyNumber.IsHappy(n);

        Assert.That(result, Is.EqualTo(expected));
    }

    private static IEnumerable<object[]> TestData
    {
        get
        {
            yield return [19, true];
            yield return [2, false];
            yield return [0, false];
            yield return [7, true];
            yield return [3, false];
        }
    }
}
