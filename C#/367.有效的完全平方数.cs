/*
 * @lc app=leetcode.cn id=367 lang=csharp
 *
 * [367] 有效的完全平方数
 *
 * https://leetcode-cn.com/problems/valid-perfect-square/description/
 *
 * algorithms
 * Easy (40.83%)
 * Likes:    48
 * Dislikes: 0
 * Total Accepted:    9.5K
 * Total Submissions: 23.1K
 * Testcase Example:  '16'
 *
 * 给定一个正整数 num，编写一个函数，如果 num 是一个完全平方数，则返回 True，否则返回 False。
 * 
 * 说明：不要使用任何内置的库函数，如  sqrt。
 * 
 * 示例 1：
 * 
 * 输入：16
 * 输出：True
 * 
 * 示例 2：
 * 
 * 输入：14
 * 输出：False
 * 
 * 
 */
public class Solution
{
    /// <summary>
    /// 1+3+5+7+9+…+(2n-1)=n^2
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public bool IsPerfectSquare(int num)
    {
        int temp = 1;
        while (num > 0)
        {
            num -= temp;
            temp += 2;
        }

        return num == 0;
    }
}
