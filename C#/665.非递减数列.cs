/*
 * @lc app=leetcode.cn id=665 lang=csharp
 *
 * [665] 非递减数列
 *
 * https://leetcode-cn.com/problems/non-decreasing-array/description/
 *
 * algorithms
 * Easy (19.77%)
 * Likes:    158
 * Dislikes: 0
 * Total Accepted:    6.7K
 * Total Submissions: 33.5K
 * Testcase Example:  '[4,2,3]'
 *
 * 给定一个长度为 n 的整数数组，你的任务是判断在最多改变 1 个元素的情况下，该数组能否变成一个非递减数列。
 * 
 * 我们是这样定义一个非递减数列的： 对于数组中所有的 i (1 <= i < n)，满足 array[i] <= array[i + 1]。
 * 
 * 示例 1:
 * 
 * 
 * 输入: [4,2,3]
 * 输出: True
 * 解释: 你可以通过把第一个4变成1来使得它成为一个非递减数列。
 * 
 * 
 * 示例 2:
 * 
 * 
 * 输入: [4,2,1]
 * 输出: False
 * 解释: 你不能在只改变一个元素的情况下将其变为非递减数列。
 * 
 * 
 * 说明:  n 的范围为 [1, 10,000]。
 * 
 */
public class Solution
{
    public bool CheckPossibility(int[] nums)
    {
        int count = 0;

        for (int i = 0; i < nums.Length -1; i++)
        {
            int a = nums[i];
            int b = nums[i + 1];
            if (a > b)
            {
                if (++count > 1)
                {
                    return false;
                }
                else if (i - 1 >= 0 && nums[i - 1] > b && i + 2 < nums.Length && a > nums[i + 2])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
