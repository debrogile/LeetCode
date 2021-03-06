/*
 * @lc app=leetcode.cn id=9 lang=csharp
 *
 * [9] 回文数
 *
 * https://leetcode-cn.com/problems/palindrome-number/description/
 *
 * algorithms
 * Easy (56.04%)
 * Total Accepted:    79.8K
 * Total Submissions: 142.3K
 * Testcase Example:  '121'
 *
 * 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
 * 
 * 示例 1:
 * 
 * 输入: 121
 * 输出: true
 * 
 * 
 * 示例 2:
 * 
 * 输入: -121
 * 输出: false
 * 解释: 从左向右读, 为 -121 。 从右向左读, 为 121- 。因此它不是一个回文数。
 * 
 * 
 * 示例 3:
 * 
 * 输入: 10
 * 输出: false
 * 解释: 从右向左读, 为 01 。因此它不是一个回文数。
 * 
 * 
 * 进阶:
 * 
 * 你能不将整数转为字符串来解决这个问题吗？
 * 
 */
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        if (x == 0)
        {
            return true;
        }

        int tail = x % 10;
        if (tail == 0)
        {
            return false;
        }

        int temp = 0;
        while (temp < x)
        {
            tail = x % 10;
            temp = temp * 10 + tail;

            if (temp == x)
            {
                return true;
            }

            x /= 10;
            if (temp == x)
            {
                return true;
            }
        }

        return false;
    }
}
