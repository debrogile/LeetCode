/*
 * @lc app=leetcode.cn id=189 lang=csharp
 *
 * [189] 旋转数组
 *
 * https://leetcode-cn.com/problems/rotate-array/description/ 
 *
 * 给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
 * 
 * 示例 1:
 * 
 * 输入: [1,2,3,4,5,6,7] 和 k = 3
 * 输出: [5,6,7,1,2,3,4]
 * 解释:
 * 向右旋转 1 步: [7,1,2,3,4,5,6]
 * 向右旋转 2 步: [6,7,1,2,3,4,5]
 * 向右旋转 3 步: [5,6,7,1,2,3,4]
 * 
 * 示例 2:
 * 
 * 输入: [-1,-100,3,99] 和 k = 2
 * 输出: [3,99,-1,-100]
 * 解释: 
 * 向右旋转 1 步: [99,-1,-100,3]
 * 向右旋转 2 步: [3,99,-1,-100]
 * 说明:
 * 
 * 尽可能想出更多的解决方案，至少有三种不同的方法可以解决这个问题。
 * 要求使用空间复杂度为 O(1) 的原地算法。
 * 
 */
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        // Rotate1(nums, k);
        // Rotate2(nums, k);
        Rotate3(nums, k);
    }

    /// <summary>
    /// 三次翻转
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    private void Rotate1(int[] nums, int k)
    {
        k %= nums.Length;

        if (k > 0)
        {
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }
    }

    /// <summary>
    /// 循环置换，每次置换之后前k位正确
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    private void Rotate2(int[] nums, int k)
    {
        int n = nums.Length;

        k %= n;
        for (int i = 0; i < nums.Length && k > 0;)
        {
            for (int j = 0; j < k; j++)
            {
                Swap(nums, i + j, nums.Length - k + j);
            }

            n -= k;
            i += k;
            k %= n;
        }
    }

    /// <summary>
    /// 定位法，每个元素直接找到该去的位置
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    private void Rotate3(int[] nums, int k)
    {
        // 定位次数
        int n = 0;
        // 起始位置
        int i = 0;
        while (n < nums.Length)
        {
            int curr = nums[i];
            int j = (i + k) % nums.Length;
            while (i != j)
            {
                int temp = curr;
                curr = nums[j];
                nums[j] = temp;

                j = (j + k) % nums.Length;
                n++;
            }

            nums[i] = curr;
            n++;
            
            i++;
        }
    }

    /// <summary>
    /// 翻转
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="begin"></param>
    /// <param name="end"></param>
    private void Reverse(int[] nums, int begin, int end)
    {
        for (int i = 0; i <= (end - begin) / 2; i++)
        {
            Swap(nums, begin + i, end - i);
        }
    }

    /// <summary>
    /// 交换
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="i"></param>
    /// <param name="j"></param>
    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
