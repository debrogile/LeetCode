using System;
/*
 * @lc app=leetcode.cn id=633 lang=csharp
 *
 * [633] 平方数之和
 *
 * https://leetcode-cn.com/problems/sum-of-square-numbers/description/
 *
 * algorithms
 * Easy (30.54%)
 * Likes:    64
 * Dislikes: 0
 * Total Accepted:    6.8K
 * Total Submissions: 22K
 * Testcase Example:  '5'
 *
 * 给定一个非负整数 c ，你要判断是否存在两个整数 a 和 b，使得 a^2 + b^2 = c。
 * 
 * 示例1:
 * 
 * 
 * 输入: 5
 * 输出: True
 * 解释: 1 * 1 + 2 * 2 = 5
 * 
 * 
 * 
 * 
 * 示例2:
 * 
 * 
 * 输入: 3
 * 输出: False
 * 
 * 
 */
using System;

public class Solution
{
    public bool JudgeSquareSum(int c)
    {
        double max = Math.Sqrt(c * 0.5);
        for (int x = 0; x <= max; x++)
        {
            double y = Math.Sqrt(c - x * x);
            if (y == (int) y)
            {
                return true;
            }
        }

        return false;
    }
}
