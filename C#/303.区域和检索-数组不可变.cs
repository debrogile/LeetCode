/*
 * @lc app=leetcode.cn id=303 lang=csharp
 *
 * [303] 区域和检索 - 数组不可变
 *
 * https://leetcode-cn.com/problems/range-sum-query-immutable/description/
 *
 * algorithms
 * Easy (53.08%)
 * Likes:    73
 * Dislikes: 0
 * Total Accepted:    11.1K
 * Total Submissions: 20.8K
 * Testcase Example:  '["NumArray","sumRange","sumRange","sumRange"]\n[[[-2,0,3,-5,2,-1]],[0,2],[2,5],[0,5]]'
 *
 * 给定一个整数数组  nums，求出数组从索引 i 到 j  (i ≤ j) 范围内元素的总和，包含 i,  j 两点。
 * 
 * 示例：
 * 
 * 给定 nums = [-2, 0, 3, -5, 2, -1]，求和函数为 sumRange()
 * 
 * sumRange(0, 2) -> 1
 * sumRange(2, 5) -> -1
 * sumRange(0, 5) -> -3
 * 
 * 说明:
 * 
 * 
 * 你可以假设数组不可变。
 * 会多次调用 sumRange 方法。
 * 
 * 
 */
using System.Collections.Generic;

public class NumArray
{
    private int[] arr;
    private Dictionary<string, int> dict = new Dictionary<string, int>();

    public NumArray(int[] nums)
    {
        arr = nums;
    }

    public int SumRange(int i, int j)
    {
        string key = string.Format("{0},{1}", i, j);
        if (!dict.ContainsKey(key))
        {
            int sum = 0;
            for (int index = i; index <= j; index++)
            {
                sum += arr[index];
            }

            dict.Add(key, sum);
        }

        return dict[key];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */
