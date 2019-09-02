/*
 * @lc app=leetcode.cn id=709 lang=csharp
 *
 * [709] 转换成小写字母
 *
 * https://leetcode-cn.com/problems/to-lower-case/description/
 *
 * algorithms
 * Easy (74.06%)
 * Likes:    92
 * Dislikes: 0
 * Total Accepted:    26K
 * Total Submissions: 35.1K
 * Testcase Example:  '"Hello"'
 *
 * 实现函数 ToLowerCase()，该函数接收一个字符串参数 str，并将该字符串中的大写字母转换成小写字母，之后返回新的字符串。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入: "Hello"
 * 输出: "hello"
 * 
 * 示例 2：
 * 
 * 
 * 输入: "here"
 * 输出: "here"
 * 
 * 示例 3：
 * 
 * 
 * 输入: "LOVELY"
 * 输出: "lovely"
 * 
 * 
 */
using System.Text;

public class Solution
{
    public string ToLowerCase(string str)
    {
        var sb = new StringBuilder();
        foreach (char c in str) 
        {
            sb.Append((char)(c | 0x20));
        }

        return sb.ToString();
    }
}
