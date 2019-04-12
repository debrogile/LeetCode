/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 *
 * https://leetcode-cn.com/problems/search-insert-position/description/
 *
 * algorithms
 * Easy (43.01%)
 * Total Accepted:    36.2K
 * Total Submissions: 84.2K
 * Testcase Example:  '[1,3,5,6]\n5'
 *
 * 给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
 * 
 * 你可以假设数组中无重复元素。
 * 
 * 示例 1:
 * 
 * 输入: [1,3,5,6], 5
 * 输出: 2
 * 
 * 
 * 示例 2:
 * 
 * 输入: [1,3,5,6], 2
 * 输出: 1
 * 
 * 
 * 示例 3:
 * 
 * 输入: [1,3,5,6], 7
 * 输出: 4
 * 
 * 
 * 示例 4:
 * 
 * 输入: [1,3,5,6], 0
 * 输出: 0
 * 
 * 
 */
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        return SearchInsert(nums, target, 0, nums.Length - 1);
    }

    private int SearchInsert(int[] nums, int target, int begin, int end)
    {
        if (begin == end)
        {
            return target <= nums[begin] ? begin : begin + 1;
        }

        int index = (begin + end) / 2;
        if (target <= nums[index])
        {
            return SearchInsert(nums, target, begin, index);
        }
        else if (target >= nums[++index])
        {
            return SearchInsert(nums, target, index, end);
        }
        else
        {
            return index;
        }
    }
}
