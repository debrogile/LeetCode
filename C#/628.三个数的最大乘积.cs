/*
 * @lc app=leetcode.cn id=628 lang=csharp
 *
 * [628] 三个数的最大乘积
 *
 * https://leetcode-cn.com/problems/maximum-product-of-three-numbers/description/
 *
 * algorithms
 * Easy (44.99%)
 * Likes:    73
 * Dislikes: 0
 * Total Accepted:    7.7K
 * Total Submissions: 16.8K
 * Testcase Example:  '[1,2,3]'
 *
 * 给定一个整型数组，在数组中找出由三个数组成的最大乘积，并输出这个乘积。
 * 
 * 示例 1:
 * 
 * 
 * 输入: [1,2,3]
 * 输出: 6
 * 
 * 
 * 示例 2:
 * 
 * 
 * 输入: [1,2,3,4]
 * 输出: 24
 * 
 * 
 * 注意:
 * 
 * 
 * 给定的整型数组长度范围是[3,10^4]，数组中所有的元素范围是[-1000, 1000]。
 * 输入的数组中任意三个数的乘积不会超出32位有符号整数的范围。
 * 
 * 
 */
using System;

public class Solution
{
    public int MaximumProduct(int[] nums)
    {
        if (nums.Length == 3)
        {
            return nums[0] * nums[1] * nums[2];
        }
        else
        {
            int min1 = 0;
            int min2 = 0;
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (int num in nums)
            {
                if (num > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2)
                {
                    max3 = max2;
                    max2 = num;
                }
                else if (num > max3)
                {
                    max3 = num;
                }

                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if (num < min2)
                {
                    min2 = num;
                }
            }

            if (max1 > 0)
            {
                return max1 * Math.Max(max2 * max3, min1 * min2);
            }
            else
            {
                return max1 * Math.Min(max2 * max3, min1 * min2);
            }
        }
    }
}
