/*
 * @lc app=leetcode.cn id=703 lang=csharp
 *
 * [703] 数据流中的第K大元素
 *
 * https://leetcode-cn.com/problems/kth-largest-element-in-a-stream/description/
 *
 * algorithms
 * Easy (39.61%)
 * Likes:    71
 * Dislikes: 0
 * Total Accepted:    7K
 * Total Submissions: 17.6K
 * Testcase Example:  '["KthLargest","add","add","add","add","add"]\n' +
  '[[3,[4,5,8,2]],[3],[5],[10],[9],[4]]'
 *
 * 设计一个找到数据流中第K大元素的类（class）。注意是排序后的第K大元素，不是第K个不同的元素。
 * 
 * 你的 KthLargest 类需要一个同时接收整数 k 和整数数组nums 的构造器，它包含数据流中的初始元素。每次调用
 * KthLargest.add，返回当前数据流中第K大的元素。
 * 
 * 示例:
 * 
 * 
 * int k = 3;
 * int[] arr = [4,5,8,2];
 * KthLargest kthLargest = new KthLargest(3, arr);
 * kthLargest.add(3);   // returns 4
 * kthLargest.add(5);   // returns 5
 * kthLargest.add(10);  // returns 5
 * kthLargest.add(9);   // returns 8
 * kthLargest.add(4);   // returns 8
 * 
 * 
 * 说明: 
 * 你可以假设 nums 的长度≥ k-1 且k ≥ 1。
 * 
 */
using System;

public class KthLargest
{
    private int[] asset;

    public KthLargest(int k, int[] nums)
    {
        asset = new int[k];
        for (int i = 0; i < k; i++)
        {
            asset[i] = int.MinValue;
        }

        Array.Sort(nums);
        for (int i = nums.Length - 1, j = 0; i >= 0 && j < k; i--, j++)
        {
            asset[j] = nums[i];
        }
    }

    public int Add(int val)
    {
        int k = asset.Length;
        for (int i = 0; i < k; i++)
        {
            if (val > asset[i])
            {
                int temp = asset[i];
                asset[i] = val;
                val = temp;
            }
        }

        return asset[k - 1];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
