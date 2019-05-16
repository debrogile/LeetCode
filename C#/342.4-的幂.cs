/*
 * @lc app=leetcode.cn id=342 lang=csharp
 *
 * [342] 4的幂
 *
 * https://leetcode-cn.com/problems/power-of-four/description/
 *
 * algorithms
 * Easy (45.33%)
 * Likes:    53
 * Dislikes: 0
 * Total Accepted:    8.2K
 * Total Submissions: 18K
 * Testcase Example:  '16'
 *
 * 给定一个整数 (32 位有符号整数)，请编写一个函数来判断它是否是 4 的幂次方。
 * 
 * 示例 1:
 * 
 * 输入: 16
 * 输出: true
 * 
 * 
 * 示例 2:
 * 
 * 输入: 5
 * 输出: false
 * 
 * 进阶：
 * 你能不使用循环或者递归来完成本题吗？
 * 
 */
public class Solution
{
    public bool IsPowerOfFour(int num)
    {
        if (IsPowerOfTwo(num))
        {
            // 4的幂，唯一的一个1出现在奇数位
            return (num & 0xAAAAAAAA) == 0;
        }
        else
        {
            return false;
        }
    }

    private bool IsPowerOfTwo(int num)
    {
        return num > 0 && (num & (num - 1)) == 0;
    }
}
