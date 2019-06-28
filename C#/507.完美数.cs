/*
 * @lc app=leetcode.cn id=507 lang=csharp
 *
 * [507] 完美数
 *
 * https://leetcode-cn.com/problems/perfect-number/description/
 *
 * algorithms
 * Easy (34.74%)
 * Likes:    32
 * Dislikes: 0
 * Total Accepted:    5.6K
 * Total Submissions: 15.8K
 * Testcase Example:  '28'
 *
 * 对于一个 正整数，如果它和除了它自身以外的所有正因子之和相等，我们称它为“完美数”。
 * 
 * 给定一个 正整数 n， 如果他是完美数，返回 True，否则返回 False
 * 
 * 
 * 
 * 示例：
 * 
 * 
 * 输入: 28
 * 输出: True
 * 解释: 28 = 1 + 2 + 4 + 7 + 14
 * 
 * 
 * 
 * 
 * 注意:
 * 
 * 输入的数字 n 不会超过 100,000,000. (1e8)
 * 
 */
using System;

public class Solution
{
    public bool CheckPerfectNumber(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        int sum = 0;
        int factor = 1;
        int max = (int) Math.Sqrt(num);
        while (factor <= max)
        {
            if (num % factor == 0)
            {
                sum += factor;
                if (factor != 1 && num != factor * factor)
                {
                    sum += num / factor;
                }
            }

            factor++;
        }

        return sum == num;
    }
}
