/*
 * @lc app=leetcode.cn id=453 lang=csharp
 *
 * [453] 最小移动次数使数组元素相等
 *
 * https://leetcode-cn.com/problems/minimum-moves-to-equal-array-elements/description/
 *
 * algorithms
 * Easy (50.35%)
 * Likes:    53
 * Dislikes: 0
 * Total Accepted:    3.8K
 * Total Submissions: 7.4K
 * Testcase Example:  '[1,2,3]'
 *
 * 给定一个长度为 n 的非空整数数组，找到让数组所有元素相等的最小移动次数。每次移动可以使 n - 1 个元素增加 1。
 * 
 * 示例:
 * 
 * 
 * 输入:
 * [1,2,3]
 * 
 * 输出:
 * 3
 * 
 * 解释:
 * 只需要3次移动（注意每次移动会增加两个元素的值）：
 * 
 * [1,2,3]  =>  [2,3,3]  =>  [3,4,3]  =>  [4,4,4]
 * 
 * 
 */
public class Solution
{
    public int MinMoves(int[] nums)
    {
        int count = 0;

        int min = nums[0];
        int index = 1;
        while (index < nums.Length)
        {
            int diff = nums[index] - min;
            if (diff >= 0)
            {
                count += diff;
            }
            else
            {
                count -= diff * index;
                min = nums[index];
            }

            index++;
        }

        return count;

        // int count = 0;

        // int curr = nums[0];
        // int index = 1;
        // while (index < nums.Length)
        // {
        //     int temp = nums[index] + count;
        //     if (temp >= curr)
        //     {
        //         count += temp - curr;
        //         curr = temp;
        //     }
        //     else
        //     {
        //         count += index * (curr - temp);
        //         curr += (index - 1) * (curr - temp);
        //     }

        //     index++;
        // }

        // return count;
    }
}
