/*
 * @lc app=leetcode.cn id=581 lang=csharp
 *
 * [581] 最短无序连续子数组
 *
 * https://leetcode-cn.com/problems/shortest-unsorted-continuous-subarray/description/
 *
 * algorithms
 * Easy (32.21%)
 * Likes:    128
 * Dislikes: 0
 * Total Accepted:    6.1K
 * Total Submissions: 18.5K
 * Testcase Example:  '[2,6,4,8,10,9,15]'
 *
 * 给定一个整数数组，你需要寻找一个连续的子数组，如果对这个子数组进行升序排序，那么整个数组都会变为升序排序。
 * 
 * 你找到的子数组应是最短的，请输出它的长度。
 * 
 * 示例 1:
 * 
 * 
 * 输入: [2, 6, 4, 8, 10, 9, 15]
 * 输出: 5
 * 解释: 你只需要对 [6, 4, 8, 10, 9] 进行升序排序，那么整个表都会变为升序排序。
 * 
 * 
 * 说明 :
 * 
 * 
 * 输入的数组长度范围在 [1, 10,000]。
 * 输入的数组可能包含重复元素 ，所以升序的意思是<=。
 * 
 * 
 */
using System;

public class Solution
{
    public int FindUnsortedSubarray(int[] nums)
    {
        int r = -1;
        int max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= max)
            {
                max = nums[i];
            }
            else
            {
                r = i;
            }
        }

        int l = r + 1;
        int min = int.MaxValue;
        for (int i = r; i >= 0; i--)
        {
            if (nums[i] <= min)
            {
                min = nums[i];
            }
            else
            {
                l = i;
            }
        }

        return r - l + 1;
    }
}
