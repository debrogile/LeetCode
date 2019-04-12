/*
 * @lc app=leetcode.cn id=14 lang=csharp
 *
 * [14] 最长公共前缀
 *
 * https://leetcode-cn.com/problems/longest-common-prefix/description/
 *
 * algorithms
 * Easy (32.24%)
 * Total Accepted:    57.6K
 * Total Submissions: 178.6K
 * Testcase Example:  '["flower","flow","flight"]'
 *
 * 编写一个函数来查找字符串数组中的最长公共前缀。
 * 
 * 如果不存在公共前缀，返回空字符串 ""。
 * 
 * 示例 1:
 * 
 * 输入: ["flower","flow","flight"]
 * 输出: "fl"
 * 
 * 
 * 示例 2:
 * 
 * 输入: ["dog","racecar","car"]
 * 输出: ""
 * 解释: 输入不存在公共前缀。
 * 
 * 
 * 说明:
 * 
 * 所有输入只包含小写字母 a-z 。
 * 
 */
using System.Text;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return string.Empty;
        }

        string result = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            result = CommonPrefix(result, strs[i]);
            if (string.IsNullOrEmpty(result))
            {
                break;
            }
        }

        return result;
    }

    private string CommonPrefix(string s1, string s2)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s1.Length && i < s2.Length; i++)
        {
            if (s1[i] == s2[i])
            {
                sb.Append(s1[i]);
            }
            else
            {
                break;
            }
        }

        return sb.ToString();
    }
}
