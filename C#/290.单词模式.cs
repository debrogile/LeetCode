/*
 * @lc app=leetcode.cn id=290 lang=csharp
 *
 * [290] 单词模式
 *
 * https://leetcode-cn.com/problems/word-pattern/description/
 *
 * algorithms
 * Easy (38.85%)
 * Likes:    73
 * Dislikes: 0
 * Total Accepted:    7.1K
 * Total Submissions: 18.2K
 * Testcase Example:  '"abba"\n"dog cat cat dog"'
 *
 * 给定一种 pattern(模式) 和一个字符串 str ，判断 str 是否遵循相同的模式。
 * 
 * 这里的遵循指完全匹配，例如， pattern 里的每个字母和字符串 str 中的每个非空单词之间存在着双向连接的对应模式。
 * 
 * 示例1:
 * 
 * 输入: pattern = "abba", str = "dog cat cat dog"
 * 输出: true
 * 
 * 示例 2:
 * 
 * 输入:pattern = "abba", str = "dog cat cat fish"
 * 输出: false
 * 
 * 示例 3:
 * 
 * 输入: pattern = "aaaa", str = "dog cat cat dog"
 * 输出: false
 * 
 * 示例 4:
 * 
 * 输入: pattern = "abba", str = "dog dog dog dog"
 * 输出: false
 * 
 * 说明:
 * 你可以假设 pattern 只包含小写字母， str 包含了由单个空格分隔的小写字母。    
 * 
 */
using System.Collections.Generic;

public class Solution
{
    public bool WordPattern(string pattern, string str)
    {
        var words = str.Split(" ");
        if (words.Length != pattern.Length)
        {
            return false;
        }

        var dict1 = new Dictionary<string, char>();
        var dict2 = new Dictionary<char, string>();
        for (int i = 0; i < words.Length; i++)
        {
            if (dict1.ContainsKey(words[i]))
            {
                if (pattern[i] != dict1[words[i]])
                {
                    return false;
                }
            }
            else if (dict2.ContainsKey(pattern[i]))
            {
                if (words[i] != dict2[pattern[i]])
                {
                    return false;
                }
            }
            else
            {
                dict1.Add(words[i], pattern[i]);
                dict2.Add(pattern[i], words[i]);
            }
        }

        return true;
    }
}
