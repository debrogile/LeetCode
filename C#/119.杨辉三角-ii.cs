/*
 * @lc app=leetcode.cn id=119 lang=csharp
 *
 * [119] 杨辉三角 II
 *
 * https://leetcode-cn.com/problems/pascals-triangle-ii/description/
 *
 * 给定一个非负索引 k，其中 k ≤ 33，返回杨辉三角的第 k 行。
 *
 * 在杨辉三角中，每个数是它左上方和右上方的数的和。
 *
 * 示例:
 *
 * 输入: 3
 * 输出: [1,3,3,1]
 * 进阶：
 * 
 * 你可以优化你的算法到 O(k) 空间复杂度吗？
 *
 */
using System.Collections.Generic;

public class Solution
{
    /**
     * 杨辉三角 第n行的第m个数可表示为 C(n, m) = n! / (m!(n-m)!)
     * C(n, m+1) = C(n, m) * (n-m) / (m+1)
     */
    public IList<int> GetRow(int rowIndex)
    {
        var list = new List<int>();
        long temp = 1;
        for (int i = 0; i <= rowIndex; i++)
        {
            list.Add((int)temp);
            temp = temp * (rowIndex - i) / (i + 1);
        }

        return list;
    }
}
