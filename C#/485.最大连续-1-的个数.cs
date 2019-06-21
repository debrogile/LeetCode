/*
 * @lc app=leetcode.cn id=485 lang=csharp
 *
 * [485] 最大连续1的个数
 *
 * https://leetcode-cn.com/problems/max-consecutive-ones/description/
 *
 * algorithms
 * Easy (53.17%)
 * Likes:    54
 * Dislikes: 0
 * Total Accepted:    13.5K
 * Total Submissions: 25.2K
 * Testcase Example:  '[1,0,1,1,0,1]'
 *
 * 给定一个二进制数组， 计算其中最大连续1的个数。
 * 
 * 示例 1:
 * 
 * 
 * 输入: [1,1,0,1,1,1]
 * 输出: 3
 * 解释: 开头的两位和最后的三位都是连续1，所以最大连续1的个数是 3.
 * 
 * 
 * 注意：
 * 
 * 
 * 输入的数组只包含 0 和1。
 * 输入数组的长度是正整数，且不超过 10,000。
 * 
 * 
 */
using System;

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int result = 0;
        int curr = 0;
        foreach (var num in nums)
        {
            if (num == 1)
            {
                if (++curr > result)
                {
                    result = curr;
                }                
            }
            else
            {
                curr = 0;
            }
        }

        return result;
    }
}
