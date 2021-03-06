/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 *
 * https://leetcode-cn.com/problems/maximum-subarray/description/
 *
 * algorithms
 * Easy (43.65%)
 * Total Accepted:    45.3K
 * Total Submissions: 103.8K
 * Testcase Example:  '[-2,1,-3,4,-1,2,1,-5,4]'
 *
 * 给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
 * 
 * 示例:
 * 
 * 输入: [-2,1,-3,4,-1,2,1,-5,4],
 * 输出: 6
 * 解释: 连续子数组 [4,-1,2,1] 的和最大，为 6。
 * 
 * 
 * 进阶:
 * 
 * 如果你已经实现复杂度为 O(n) 的解法，尝试使用更为精妙的分治法求解。
 * 
 */
using System;

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        return MaxSubArray(nums, 0, nums.Length - 1);
    }

    private int MaxSubArray(int[] nums, int bi, int ei)
    {
        if (bi >= ei)
        {
            return nums[bi];
        }

        int mi = (bi + ei) / 2;
        int lmax = MaxSubArray(nums, bi, mi - 1);
        int rmax = MaxSubArray(nums, mi + 1, ei);
        int mmax = nums[mi];

        int temp = mmax;
        for (int i = mi - 1; i >= bi; i--)
        {
            temp += nums[i];
            mmax = Math.Max(mmax, temp);
        }

        temp = mmax;
        for (int i = mi + 1; i <= ei; i++)
        {
            temp += nums[i];
            mmax = Math.Max(mmax, temp);
        }

        return Math.Max(lmax, Math.Max(mmax, rmax));
    }
}
