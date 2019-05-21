/*
 * @lc app=leetcode.cn id=387 lang=csharp
 *
 * [387] 字符串中的第一个唯一字符
 *
 * https://leetcode-cn.com/problems/first-unique-character-in-a-string/description/
 *
 * algorithms
 * Easy (38.23%)
 * Likes:    117
 * Dislikes: 0
 * Total Accepted:    29.8K
 * Total Submissions: 78K
 * Testcase Example:  '"leetcode"'
 *
 * 给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。
 * 
 * 案例:
 * 
 * 
 * s = "leetcode"
 * 返回 0.
 * 
 * s = "loveleetcode",
 * 返回 2.
 * 
 * 
 * 
 * 
 * 注意事项：您可以假定该字符串只包含小写字母。
 * 
 */
using System.Collections.Generic;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                dict[s[i]] = -1;
            }
            else
            {
                dict.Add(s[i], i);
            }
        }

        foreach (var item in dict)
        {
            if (item.Value > -1)
            {
                return item.Value;
            }
        }

        return -1;
    }
}
