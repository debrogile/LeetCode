using System;
/*
 * @lc app=leetcode.cn id=661 lang=csharp
 *
 * [661] 图片平滑器
 *
 * https://leetcode-cn.com/problems/image-smoother/description/
 *
 * algorithms
 * Easy (47.13%)
 * Likes:    27
 * Dislikes: 0
 * Total Accepted:    3.4K
 * Total Submissions: 6.9K
 * Testcase Example:  '[[1,1,1],[1,0,1],[1,1,1]]'
 *
 * 包含整数的二维矩阵 M 表示一个图片的灰度。你需要设计一个平滑器来让每一个单元的灰度成为平均灰度 (向下舍入)
 * ，平均灰度的计算是周围的8个单元和它本身的值求平均，如果周围的单元格不足八个，则尽可能多的利用它们。
 * 
 * 示例 1:
 * 
 * 
 * 输入:
 * [[1,1,1],
 * ⁠[1,0,1],
 * ⁠[1,1,1]]
 * 输出:
 * [[0, 0, 0],
 * ⁠[0, 0, 0],
 * ⁠[0, 0, 0]]
 * 解释:
 * 对于点 (0,0), (0,2), (2,0), (2,2): 平均(3/4) = 平均(0.75) = 0
 * 对于点 (0,1), (1,0), (1,2), (2,1): 平均(5/6) = 平均(0.83333333) = 0
 * 对于点 (1,1): 平均(8/9) = 平均(0.88888889) = 0
 * 
 * 
 * 注意:
 * 
 * 
 * 给定矩阵中的整数范围为 [0, 255]。
 * 矩阵的长和宽的范围均为 [1, 150]。
 * 
 * 
 */
using System;

public class Solution
{
    public int[][] ImageSmoother(int[][] M)
    {
        var matrix = new int[M.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[M[i].Length];
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                double sum = M[i][j];
                int count = 1;

                if (j > 0)
                {
                    sum += M[i][j - 1];
                    count++;
                }

                if (j + 1 < matrix[i].Length)
                {
                    sum += M[i][j + 1];
                    count++;
                }

                if (i > 0)
                {
                    sum += M[i - 1][j];
                    count++;

                    if (j > 0)
                    {
                        sum += M[i - 1][j - 1];
                        count++;
                    }

                    if (j + 1 < matrix[i].Length)
                    {
                        sum += M[i - 1][j + 1];
                        count++;
                    }
                }

                if (i + 1 < matrix.Length)
                {
                    sum += M[i + 1][j];
                    count++;

                    if (j > 0)
                    {
                        sum += M[i + 1][j - 1];
                        count++;
                    }

                    if (j + 1 < matrix[i].Length)
                    {
                        sum += M[i + 1][j + 1];
                        count++;
                    }
                }

                matrix[i][j] = (int) Math.Floor(sum / count);
            }
        }

        return matrix;
    }
}
