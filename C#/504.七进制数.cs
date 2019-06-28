using System.Text;
/*
 * @lc app=leetcode.cn id=504 lang=csharp
 *
 * [504] 七进制数
 *
 * https://leetcode-cn.com/problems/base-7/description/
 *
 * algorithms
 * Easy (44.50%)
 * Likes:    16
 * Dislikes: 0
 * Total Accepted:    4.2K
 * Total Submissions: 9.4K
 * Testcase Example:  '100'
 *
 * 给定一个整数，将其转化为7进制，并以字符串形式输出。
 * 
 * 示例 1:
 * 
 * 
 * 输入: 100
 * 输出: "202"
 * 
 * 
 * 示例 2:
 * 
 * 
 * 输入: -7
 * 输出: "-10"
 * 
 * 
 * 注意: 输入范围是 [-1e7, 1e7] 。
 * 
 */
public class Solution
{
    public string ConvertToBase7(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        var sb = new StringBuilder();

        bool negative = false;
        if (num < 0)
        {
            negative = true;
            num = -num;
        }

        while (num > 0)
        {
            sb.Insert(0, num % 7);
            num /= 7;
        }

        if (negative)
        {
            sb.Insert(0, '-');
        }

        return sb.ToString();
    }
}
