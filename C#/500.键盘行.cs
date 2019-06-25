using System.Linq.Expressions;
/*
 * @lc app=leetcode.cn id=500 lang=csharp
 *
 * [500] 键盘行
 *
 * https://leetcode-cn.com/problems/keyboard-row/description/
 *
 * algorithms
 * Easy (66.35%)
 * Likes:    45
 * Dislikes: 0
 * Total Accepted:    7.8K
 * Total Submissions: 11.7K
 * Testcase Example:  '["Hello","Alaska","Dad","Peace"]'
 *
 * 给定一个单词列表，只返回可以使用在键盘同一行的字母打印出来的单词。键盘如下图所示。
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 示例：
 * 
 * 输入: ["Hello", "Alaska", "Dad", "Peace"]
 * 输出: ["Alaska", "Dad"]
 * 
 * 
 * 
 * 
 * 注意：
 * 
 * 
 * 你可以重复使用键盘上同一字符。
 * 你可以假设输入的字符串将只包含字母。
 * 
 */
using System.Collections.Generic;

public class Solution
{
    private static int[] lines;

    static Solution()
    {
        lines = new int[64];
        lines['Q' - 'A'] = 1;
        lines['W' - 'A'] = 1;
        lines['E' - 'A'] = 1;
        lines['R' - 'A'] = 1;
        lines['T' - 'A'] = 1;
        lines['Y' - 'A'] = 1;
        lines['U' - 'A'] = 1;
        lines['I' - 'A'] = 1;
        lines['O' - 'A'] = 1;
        lines['P' - 'A'] = 1;
        lines['q' - 'A'] = 1;
        lines['w' - 'A'] = 1;
        lines['e' - 'A'] = 1;
        lines['r' - 'A'] = 1;
        lines['t' - 'A'] = 1;
        lines['y' - 'A'] = 1;
        lines['u' - 'A'] = 1;
        lines['i' - 'A'] = 1;
        lines['o' - 'A'] = 1;
        lines['p' - 'A'] = 1;
        lines['A' - 'A'] = 2;
        lines['S' - 'A'] = 2;
        lines['D' - 'A'] = 2;
        lines['F' - 'A'] = 2;
        lines['G' - 'A'] = 2;
        lines['H' - 'A'] = 2;
        lines['J' - 'A'] = 2;
        lines['K' - 'A'] = 2;
        lines['L' - 'A'] = 2;
        lines['a' - 'A'] = 2;
        lines['s' - 'A'] = 2;
        lines['d' - 'A'] = 2;
        lines['f' - 'A'] = 2;
        lines['g' - 'A'] = 2;
        lines['h' - 'A'] = 2;
        lines['j' - 'A'] = 2;
        lines['k' - 'A'] = 2;
        lines['l' - 'A'] = 2;
        lines['Z' - 'A'] = 3;
        lines['X' - 'A'] = 3;
        lines['C' - 'A'] = 3;
        lines['V' - 'A'] = 3;
        lines['B' - 'A'] = 3;
        lines['N' - 'A'] = 3;
        lines['M' - 'A'] = 3;
        lines['z' - 'A'] = 3;
        lines['x' - 'A'] = 3;
        lines['c' - 'A'] = 3;
        lines['v' - 'A'] = 3;
        lines['b' - 'A'] = 3;
        lines['n' - 'A'] = 3;
        lines['m' - 'A'] = 3;
    }

    public string[] FindWords(string[] words)
    {
        var list = new List<string>();
        foreach (var word in words)
        {
            if (IsSameLine(word))
            {
                list.Add(word);
            }
        }

        return list.ToArray();
    }

    private bool IsSameLine(string word)
    {
        int line = 0;
        foreach (var c in word)
        {
            if (line == 0)
            {
                line = lines[c - 'A'];
            }
            else if (line != lines[c - 'A'])
            {
                return false;
            }
        }

        return true;
    }
}
