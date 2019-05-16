/*
 * @lc app=leetcode.cn id=326 lang=csharp
 *
 * [326] 3的幂
 *
 * https://leetcode-cn.com/problems/power-of-three/description/
 *
 * algorithms
 * Easy (43.84%)
 * Likes:    55
 * Dislikes: 0
 * Total Accepted:    17.7K
 * Total Submissions: 40.3K
 * Testcase Example:  '27'
 *
 * 给定一个整数，写一个函数来判断它是否是 3 的幂次方。
 * 
 * 示例 1:
 * 
 * 输入: 27
 * 输出: true
 * 
 * 
 * 示例 2:
 * 
 * 输入: 0
 * 输出: false
 * 
 * 示例 3:
 * 
 * 输入: 9
 * 输出: true
 * 
 * 示例 4:
 * 
 * 输入: 45
 * 输出: false
 * 
 * 进阶：
 * 你能不使用循环或者递归来完成本题吗？
 * 
 */
public class Solution
{
    /// <summary>
    /// 1162261467为int范围内最大的3的幂
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public bool IsPowerOfThree(int n)
    {
        return n > 0 && 1162261467 % n == 0;
    }
}
