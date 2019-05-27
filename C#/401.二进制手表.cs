using System.Linq.Expressions;
/*
 * @lc app=leetcode.cn id=401 lang=csharp
 *
 * [401] 二进制手表
 *
 * https://leetcode-cn.com/problems/binary-watch/description/
 *
 * algorithms
 * Easy (47.19%)
 * Likes:    61
 * Dislikes: 0
 * Total Accepted:    3.7K
 * Total Submissions: 7.9K
 * Testcase Example:  '0'
 *
 * 二进制手表顶部有 4 个 LED 代表小时（0-11），底部的 6 个 LED 代表分钟（0-59）。
 * 
 * 每个 LED 代表一个 0 或 1，最低位在右侧。
 * 
 * 
 * 
 * 例如，上面的二进制手表读取 “3:25”。
 * 
 * 给定一个非负整数 n 代表当前 LED 亮着的数量，返回所有可能的时间。
 * 
 * 案例:
 * 
 * 
 * 输入: n = 1
 * 返回: ["1:00", "2:00", "4:00", "8:00", "0:01", "0:02", "0:04", "0:08", "0:16",
 * "0:32"]
 * 
 * 
 * 
 * 注意事项:
 * 
 * 
 * 输出的顺序没有要求。
 * 小时不会以零开头，比如 “01:00” 是不允许的，应为 “1:00”。
 * 分钟必须由两位数组成，可能会以零开头，比如 “10:2” 是无效的，应为 “10:02”。
 * 
 * 
 */
using System.Collections.Generic;

public class Solution
{
    private int[] TIMES = new int[] { 1, 2, 4, 8, 16, 32, 1, 2, 4, 8 };

    public IList<string> ReadBinaryWatch(int num)
    {
        var list = new List<string>();
        DFS(list, num, 0, 0, 0);

        return list;
    }

    private void DFS(IList<string> list, int num, int index, int h, int m)
    {
        if (num == 0)
        {
            list.Add(string.Format("{0}:{1:D2}", h, m));
            return;
        }

        for (int i = index; i < TIMES.Length; i++)
        {
            if (i < 6)
            {
                if (m + TIMES[i] < 60)
                {
                    DFS(list, num - 1, i + 1, h, m + TIMES[i]);
                }
            }
            else
            {
                if (h + TIMES[i] < 12)
                {
                    DFS(list, num - 1, i + 1, h + TIMES[i], m);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
