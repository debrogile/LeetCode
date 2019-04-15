/*
 * @lc app=leetcode.cn id=69 lang=csharp
 *
 * [69] x 的平方根
 *
 * https://leetcode-cn.com/problems/sqrtx/description/
 *
 * algorithms
 * Easy (35.27%)
 * Total Accepted:    30.2K
 * Total Submissions: 85.7K
 * Testcase Example:  '4'
 *
 * 实现 int sqrt(int x) 函数。
 * 
 * 计算并返回 x 的平方根，其中 x 是非负整数。
 * 
 * 由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
 * 
 * 示例 1:
 * 
 * 输入: 4
 * 输出: 2
 * 
 * 
 * 示例 2:
 * 
 * 输入: 8
 * 输出: 2
 * 说明: 8 的平方根是 2.82842..., 
 * 由于返回类型是整数，小数部分将被舍去。
 * 
 * 
 */
using System.Collections.Generic;

public class Solution
{
    /// <summary>
    /// 模拟手动开平方运算
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public int MySqrt(int x)
    {
        var stack = new Stack<int>();
        while (x > 100)
        {
            int temp = x % 100;
            x /= 100;

            stack.Push(temp);
        }
        stack.Push(x);

        int result = 0;
        int remainder = 0;
        while (stack.Count > 0)
        {
            Calculate(ref result, ref remainder, stack.Pop());
        }

        return result;
    }

    private void Calculate(ref int sqrt, ref int remainder, int supplement)
    {
        int temp = 0;
        int max = remainder * 100 + supplement;
        int i = 9;
        for (; i >= 0; i--)
        {
            temp = (sqrt * 20 + i) * i;
            if (max >= temp)
            {
                break;
            }
        }

        sqrt = sqrt * 10 + i;
        remainder = max - temp;
    }
}
