/*
 * @lc app=leetcode.cn id=231 lang=csharp
 *
 * [231] 2的幂
 * 
 * https://leetcode-cn.com/problems/power-of-two/description/
 *
 * 给定一个整数，编写一个函数来判断它是否是 2 的幂次方。
 * 
 * 示例 1:
 * 
 * 输入: 1
 * 输出: true
 * 解释: 20 = 1
 * 示例 2:
 * 
 * 输入: 16
 * 输出: true
 * 解释: 24 = 16
 * 示例 3:
 * 
 * 输入: 218
 * 输出: false
 */
public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        // if (n <= 0)
        // {
        //     return false;
        // }
        // else if (n == 1)
        // {
        //     return true;
        // }
        // else if (n % 2 == 0)
        // {
        //     return IsPowerOfTwo(n / 2);
        // }
        // else
        // {
        //     return false;
        // }

        if (n <= 0)
        {
            return false;
        }
        else
        {
            return (n & (n - 1)) == 0;
        }
    }
}
