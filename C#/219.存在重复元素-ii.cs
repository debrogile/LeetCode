/*
 * @lc app=leetcode.cn id=219 lang=csharp
 *
 * [219] 存在重复元素 II
 *
 * https://leetcode-cn.com/problems/contains-duplicate-ii/description/
 *
 * 给定一个整数数组和一个整数 k，判断数组中是否存在两个不同的索引 i 和 j，使得 nums [i] = nums [j]，并且 i 和 j 的差的绝对值最大为 k。
 * 
 * 示例 1:
 * 
 * 输入: nums = [1,2,3,1], k = 3
 * 输出: true
 * 示例 2:
 * 
 * 输入: nums = [1,0,1,1], k = 1
 * 输出: true
 * 示例 3:
 * 
 * 输入: nums = [1,2,3,1,2,3], k = 2
 * 输出: false
 */
using System.Collections.Generic;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                if (dict[nums[i]] + k >= i)
                {
                    return true;
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }
            else
            {
                dict.Add(nums[i], i);
            }
        }

        return false;
    }
}
