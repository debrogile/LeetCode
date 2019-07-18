using System;
/*
 * @lc app=leetcode.cn id=594 lang=csharp
 *
 * [594] 最长和谐子序列
 *
 * https://leetcode-cn.com/problems/longest-harmonious-subsequence/description/
 *
 * algorithms
 * Easy (40.87%)
 * Likes:    52
 * Dislikes: 0
 * Total Accepted:    3.7K
 * Total Submissions: 9K
 * Testcase Example:  '[1,3,2,2,5,2,3,7]'
 *
 * 和谐数组是指一个数组里元素的最大值和最小值之间的差别正好是1。
 * 
 * 现在，给定一个整数数组，你需要在所有可能的子序列中找到最长的和谐子序列的长度。
 * 
 * 示例 1:
 * 
 * 
 * 输入: [1,3,2,2,5,2,3,7]
 * 输出: 5
 * 原因: 最长的和谐数组是：[3,2,2,2,3].
 * 
 * 
 * 说明: 输入的数组长度最大不超过20,000.
 * 
 */
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int FindLHS(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
        }

        int length = 0;
        foreach (int key in dict.Keys)
        {
            if (dict.ContainsKey(key - 1))
            {
                length = Math.Max(length, dict[key] + dict[key - 1]);
            }
        }

        return length;
    }
}
