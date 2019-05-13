/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 * 
 * https://leetcode-cn.com/problems/valid-anagram/description/
 *
 * 给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的一个字母异位词。
 * 
 * 示例 1:
 * 
 * 输入: s = "anagram", t = "nagaram"
 * 输出: true
 * 示例 2:
 * 
 * 输入: s = "rat", t = "car"
 * 输出: false
 * 说明:
 * 你可以假设字符串只包含小写字母。
 * 
 * 进阶:
 * 如果输入字符串包含 unicode 字符怎么办？你能否调整你的解法来应对这种情况？
 */
using System.Collections.Generic;

public class Solution
{
    public bool IsAnagram(string s, string t)
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
            if (!dict.ContainsKey(c))
            {
                return false;
            }
            else if (--dict[c] == 0)
            {
                dict.Remove(c);
            }
        }

        return dict.Count == 0;
    }
}
