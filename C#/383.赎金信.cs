/*
 * @lc app=leetcode.cn id=383 lang=csharp
 *
 * [383] 赎金信
 *
 * https://leetcode-cn.com/problems/ransom-note/description/
 *
 * algorithms
 * Easy (47.29%)
 * Likes:    41
 * Dislikes: 0
 * Total Accepted:    7K
 * Total Submissions: 14.7K
 * Testcase Example:  '"a"\n"b"'
 *
 * 给定一个赎金信 (ransom)
 * 字符串和一个杂志(magazine)字符串，判断第一个字符串ransom能不能由第二个字符串magazines里面的字符构成。如果可以构成，返回
 * true ；否则返回 false。
 * 
 * (题目说明：为了不暴露赎金信字迹，要从杂志上搜索各个需要的字母，组成单词来表达意思。)
 * 
 * 注意：
 * 
 * 你可以假设两个字符串均只含有小写字母。
 * 
 * 
 * canConstruct("a", "b") -> false
 * canConstruct("aa", "ab") -> false
 * canConstruct("aa", "aab") -> true
 * 
 * 
 */
using System.Collections.Generic;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in ransomNote)
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

        int index = 0;
        while (dict.Count > 0 && index < magazine.Length)
        {
            char c = magazine[index];
            if (dict.ContainsKey(c))
            {
                dict[c]--;
                if (dict[c] <= 0)
                {
                    dict.Remove(c);
                }
            }

            index++;
        }

        return dict.Count == 0;
    }
}
