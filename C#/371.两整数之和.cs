/*
 * @lc app=leetcode.cn id=371 lang=csharp
 *
 * [371] 两整数之和
 *
 * https://leetcode-cn.com/problems/sum-of-two-integers/description/
 *
 * algorithms
 * Easy (52.21%)
 * Likes:    107
 * Dislikes: 0
 * Total Accepted:    10.1K
 * Total Submissions: 19.4K
 * Testcase Example:  '1\n2'
 *
 * 不使用运算符 + 和 - ​​​​​​​，计算两整数 ​​​​​​​a 、b ​​​​​​​之和。
 * 
 * 示例 1:
 * 
 * 输入: a = 1, b = 2
 * 输出: 3
 * 
 * 
 * 示例 2:
 * 
 * 输入: a = -2, b = 3
 * 输出: 1
 * 
 */
public class Solution
{
    /// <summary>
    /// 异或是不进位的加法
    /// 相与为了让进位显现出来
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int GetSum(int a, int b)
    {
        do
        {
            int temp = a;
            a ^= b;
            b = (temp & b) << 1;
        }
        while (b != 0);

        return a;
    }
}
