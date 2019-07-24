/*
 * @lc app=leetcode.cn id=643 lang=csharp
 *
 * [643] 子数组最大平均数 I
 *
 * https://leetcode-cn.com/problems/maximum-average-subarray-i/description/
 *
 * algorithms
 * Easy (33.94%)
 * Likes:    51
 * Dislikes: 0
 * Total Accepted:    5.4K
 * Total Submissions: 15.5K
 * Testcase Example:  '[1,12,-5,-6,50,3]\n4'
 *
 * 给定 n 个整数，找出平均数最大且长度为 k 的连续子数组，并输出该最大平均数。
 * 
 * 示例 1:
 * 
 * 输入: [1,12,-5,-6,50,3], k = 4
 * 输出: 12.75
 * 解释: 最大平均数 (12-5-6+50)/4 = 51/4 = 12.75
 * 
 * 
 * 
 * 
 * 注意:
 * 
 * 
 * 1 <= k <= n <= 30,000。
 * 所给数据范围 [-10,000，10,000]。
 * 
 * 
 */
public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;

        int i = 0;
        while (i < k)
        {
            sum += nums[i++];
        }

        double temp = sum;
        while (i < nums.Length)
        {
            temp -= nums[i - k];
            temp += nums[i++];

            if (temp > sum)
            {
                sum = temp;
            }
        }

        return sum / k;
    }
}
