/*
 * @lc app=leetcode.cn id=409 lang=csharp
 *
 * [409] 最长回文串
 *
 * https://leetcode-cn.com/problems/longest-palindrome/description/
 *
 * algorithms
 * Easy (47.45%)
 * Likes:    53
 * Dislikes: 0
 * Total Accepted:    5.8K
 * Total Submissions: 12.2K
 * Testcase Example:  '"abccccdd"'
 *
 * 给定一个包含大写字母和小写字母的字符串，找到通过这些字母构造成的最长的回文串。
 * 
 * 在构造过程中，请注意区分大小写。比如 "Aa" 不能当做一个回文字符串。
 * 
 * 注意:
 * 假设字符串的长度不会超过 1010。
 * 
 * 示例 1: 
 * 
 * 
 * 输入:
 * "abccccdd"
 * 
 * 输出:
 * 7
 * 
 * 解释:
 * 我们可以构造的最长的回文串是"dccaccd", 它的长度是 7。
 * 
 * 
 */
using System.Collections.Generic;

public class Solution
{
    public int LongestPalindrome(string s)
    {
        int length = 0;
        var hs = new HashSet<char>();
        foreach (var c in s)
        {
            if (hs.Contains(c))
            {
                length += 2;
                hs.Remove(c);
            }
            else
            {
                hs.Add(c);
            }
        }

        if (hs.Count > 0)
        {
            length++;
        }

        return length;
    }
}
