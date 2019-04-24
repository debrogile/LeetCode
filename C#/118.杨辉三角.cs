/*
 * @lc app=leetcode.cn id=118 lang=csharp
 *
 * [118] 杨辉三角
 *
 * https://leetcode-cn.com/problems/pascals-triangle/description/
 *
 * 给定一个非负整数 numRows，生成杨辉三角的前 numRows 行。
 *
 * 示例:
 *
 * 输入: 5
 * 输出:
 * [
 *      [1],
 *     [1,1],
 *    [1,2,1],
 *   [1,3,3,1],
 *  [1,4,6,4,1]
 * ]
 *
 */
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        if (numRows <= 0)
        {
            return new List<IList<int>>();
        }

        var list = new List<IList<int>>();
        IList<int> level = new List<int>();
        level.Add(1);
        list.Add(level);

        while (--numRows > 0)
        {
            level = Next(level);
            list.Add(level);
        }

        return list;
    }

    private IList<int> Next(IList<int> prev)
    {
        var next = new List<int>();
        next.Add(1);

        for (int i = 0; i < prev.Count - 1; i++)
        {
            next.Add(prev[i] + prev[i + 1]);
        }
        next.Add(1);

        return next;
    }
}
