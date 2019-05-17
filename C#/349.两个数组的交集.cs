/*
 * @lc app=leetcode.cn id=349 lang=csharp
 *
 * [349] 两个数组的交集
 *
 * https://leetcode-cn.com/problems/intersection-of-two-arrays/description/
 *
 * algorithms
 * Easy (62.49%)
 * Likes:    93
 * Dislikes: 0
 * Total Accepted:    20.5K
 * Total Submissions: 32.8K
 * Testcase Example:  '[1,2,2,1]\n[2,2]'
 *
 * 给定两个数组，编写一个函数来计算它们的交集。
 * 
 * 示例 1:
 * 
 * 输入: nums1 = [1,2,2,1], nums2 = [2,2]
 * 输出: [2]
 * 
 * 
 * 示例 2:
 * 
 * 输入: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
 * 输出: [9,4]
 * 
 * 说明:
 * 
 * 
 * 输出结果中的每个元素一定是唯一的。
 * 我们可以不考虑输出结果的顺序。
 * 
 * 
 */
using System.Collections.Generic;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var hs = new HashSet<int>();
        var hs1 = new HashSet<int>(nums1);
        foreach (var num in nums2)
        {
            if (hs1.Contains(num))
            {
                hs.Add(num);
            }
        }

        return hs.ToArray();
    }
}
