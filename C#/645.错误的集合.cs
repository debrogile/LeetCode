/*
 * @lc app=leetcode.cn id=645 lang=csharp
 *
 * [645] 错误的集合
 *
 * https://leetcode-cn.com/problems/set-mismatch/description/
 *
 * algorithms
 * Easy (36.08%)
 * Likes:    48
 * Dislikes: 0
 * Total Accepted:    4.7K
 * Total Submissions: 12.6K
 * Testcase Example:  '[1,2,2,4]'
 *
 * 集合 S 包含从1到 n
 * 的整数。不幸的是，因为数据错误，导致集合里面某一个元素复制了成了集合里面的另外一个元素的值，导致集合丢失了一个整数并且有一个元素重复。
 * 
 * 给定一个数组 nums 代表了集合 S 发生错误后的结果。你的任务是首先寻找到重复出现的整数，再找到丢失的整数，将它们以数组的形式返回。
 * 
 * 示例 1:
 * 
 * 
 * 输入: nums = [1,2,2,4]
 * 输出: [2,3]
 * 
 * 
 * 注意:
 * 
 * 
 * 给定数组的长度范围是 [2, 10000]。
 * 给定的数组是无序的。
 * 
 * 
 */
public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int repeat = 0;
        int sum = 0;
        int n = nums.Length;
        int[] temp = new int[n];
        foreach (int num in nums)
        {
            if (temp[num - 1] != 0)
            {
                repeat = num;
            }
            else
            {
                temp[num - 1] = num;
            }

            sum += num;
        }

        int lost = repeat - (sum - n * (n + 1) / 2);

        return new int[2] { repeat, lost };
    }
}
