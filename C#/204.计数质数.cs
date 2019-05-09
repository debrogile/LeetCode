/*
 * @lc app=leetcode.cn id=204 lang=csharp
 *
 * [204] 计数质数
 *
 * https://leetcode-cn.com/problems/count-primes/description/
 * 
 * 统计所有小于非负整数 n 的质数的数量。
 * 
 * 示例:
 * 
 * 输入: 10
 * 输出: 4
 * 解释: 小于 10 的质数一共有 4 个, 它们是 2, 3, 5, 7 。
 */
using System;
using System.Linq;

public class Solution
{
    /// <summary>
    /// 埃氏筛法
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int CountPrimes(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (arr[i] == 1)
            {
                continue;
            }

            for (int j = 2; i * j < n; j++)
            {
                arr[i * j] = 1;
            }
        }

        return arr.Count(i => i > 1);
    }
}
