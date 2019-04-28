/*
 * @lc app=leetcode.cn id=169 lang=csharp
 *
 * [169] 求众数
 *
 * https://leetcode-cn.com/problems/majority-element/description/
 *
 * 给定一个大小为 n 的数组，找到其中的众数。众数是指在数组中出现次数大于 ⌊ n/2 ⌋ 的元素。
 *
 * 你可以假设数组是非空的，并且给定的数组总是存在众数。
 *
 * 示例 1:
 *
 * 输入: [3,2,3]
 * 输出: 3
 *
 * 示例 2:
 *
 * 输入: [2,2,1,1,1,2,2]
 * 输出: 2
 *
 */
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == major)
            {
                count++;
            }
            else if (count-- <= 0)
            {
                major = nums[i];
                count = 0;
            }
        }

        return major;
    }
}
