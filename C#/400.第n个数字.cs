/*
 * @lc app=leetcode.cn id=400 lang=csharp
 *
 * [400] 第N个数字
 *
 * https://leetcode-cn.com/problems/nth-digit/description/
 *
 * algorithms
 * Easy (31.34%)
 * Likes:    60
 * Dislikes: 0
 * Total Accepted:    3.2K
 * Total Submissions: 10.2K
 * Testcase Example:  '3'
 *
 * 在无限的整数序列 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ...中找到第 n 个数字。
 * 
 * 注意:
 * n 是正数且在32为整形范围内 ( n < 2^31)。
 * 
 * 示例 1:
 * 
 * 
 * 输入:
 * 3
 * 
 * 输出:
 * 3
 * 
 * 
 * 示例 2:
 * 
 * 
 * 输入:
 * 11
 * 
 * 输出:
 * 0
 * 
 * 说明:
 * 第11个数字在序列 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ... 里是0，它是10的一部分。
 * 
 * 
 */
public class Solution
{
    public int FindNthDigit(int n)
    {
        // 整数位数
        int i = 1;
        int temp = 1;
        // 对应位数的整数所有数字个数
        int count = 9;
        while (count > 0 && n > count)
        {
            n -= count;
            temp *= 10;
            i++;
            count = 9 * i * temp;
        }

        int num = temp + n / i;
        int sup = n % i;
        if (sup == 0)
        {
            num -= 1;
        }
        else
        {
            sup = i - sup;
        }

        while (sup > 0)
        {
            num /= 10;
            sup--;
        }

        return num % 10;
    }
}
