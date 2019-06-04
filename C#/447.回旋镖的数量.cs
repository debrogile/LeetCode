/*
 * @lc app=leetcode.cn id=447 lang=csharp
 *
 * [447] 回旋镖的数量
 *
 * https://leetcode-cn.com/problems/number-of-boomerangs/description/
 *
 * algorithms
 * Easy (53.71%)
 * Likes:    53
 * Dislikes: 0
 * Total Accepted:    4.4K
 * Total Submissions: 8.3K
 * Testcase Example:  '[[0,0],[1,0],[2,0]]'
 *
 * 给定平面上 n 对不同的点，“回旋镖” 是由点表示的元组 (i, j, k) ，其中 i 和 j 之间的距离和 i 和 k
 * 之间的距离相等（需要考虑元组的顺序）。
 * 
 * 找到所有回旋镖的数量。你可以假设 n 最大为 500，所有点的坐标在闭区间 [-10000, 10000] 中。
 * 
 * 示例:
 * 
 * 
 * 输入:
 * [[0,0],[1,0],[2,0]]
 * 
 * 输出:
 * 2
 * 
 * 解释:
 * 两个回旋镖为 [[1,0],[0,0],[2,0]] 和 [[1,0],[2,0],[0,0]]
 * 
 * 
 */
using System.Collections.Generic;

public class Solution
{
    public int NumberOfBoomerangs(int[][] points)
    {
        int count = 0;
        var dict = new Dictionary<int, int>();

        foreach (var p1 in points)
        {
            foreach (var p2 in points)
            {
                if (p1 != p2)
                {
                    int dist = Disantce(p2, p1);
                    if (dict.ContainsKey(dist))
                    {
                        count += 2 * dict[dist];
                        dict[dist]++;
                    }
                    else
                    {
                        dict.Add(dist, 1);
                    }
                }
            }

            dict.Clear();
        }

        return count;
    }

    /// <summary>
    /// 计算两点之间的距离
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private int Disantce(int[] a, int[] b)
    {
        return (b[0] - a[0]) * (b[0] - a[0]) + (b[1] - a[1]) * (b[1] - a[1]);
    }
}
