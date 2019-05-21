using System;
/*
 * @lc app=leetcode.cn id=389 lang=csharp
 *
 * [389] 找不同
 *
 * https://leetcode-cn.com/problems/find-the-difference/description/
 *
 * algorithms
 * Easy (56.41%)
 * Likes:    70
 * Dislikes: 0
 * Total Accepted:    9.4K
 * Total Submissions: 16.6K
 * Testcase Example:  '"abcd"\n"abcde"'
 *
 * 给定两个字符串 s 和 t，它们只包含小写字母。
 * 
 * 字符串 t 由字符串 s 随机重排，然后在随机位置添加一个字母。
 * 
 * 请找出在 t 中被添加的字母。
 * 
 * 
 * 
 * 示例:
 * 
 * 输入：
 * s = "abcd"
 * t = "abcde"
 * 
 * 输出：
 * e
 * 
 * 解释：
 * 'e' 是那个被添加的字母。
 * 
 * 
 */
using System.Collections.Generic;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }

        foreach (var c in t)
        {
            if (!dict.ContainsKey(c) || dict[c] <= 0)
            {
                return c;
            }
            else
            {
                dict[c]--;
            }
        }

        throw new ArgumentException();
    }
}
