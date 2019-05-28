/*
 * @lc app=leetcode.cn id=412 lang=csharp
 *
 * [412] Fizz Buzz
 *
 * https://leetcode-cn.com/problems/fizz-buzz/description/
 *
 * algorithms
 * Easy (59.42%)
 * Likes:    28
 * Dislikes: 0
 * Total Accepted:    13.9K
 * Total Submissions: 23.3K
 * Testcase Example:  '1'
 *
 * 写一个程序，输出从 1 到 n 数字的字符串表示。
 * 
 * 1. 如果 n 是3的倍数，输出“Fizz”；
 * 
 * 2. 如果 n 是5的倍数，输出“Buzz”；
 * 
 * 3.如果 n 同时是3和5的倍数，输出 “FizzBuzz”。
 * 
 * 示例：
 * 
 * n = 15,
 * 
 * 返回:
 * [
 * ⁠   "1",
 * ⁠   "2",
 * ⁠   "Fizz",
 * ⁠   "4",
 * ⁠   "Buzz",
 * ⁠   "Fizz",
 * ⁠   "7",
 * ⁠   "8",
 * ⁠   "Fizz",
 * ⁠   "Buzz",
 * ⁠   "11",
 * ⁠   "Fizz",
 * ⁠   "13",
 * ⁠   "14",
 * ⁠   "FizzBuzz"
 * ]
 * 
 * 
 */
using System.Collections.Generic;

public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
            {
                list.Add("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                list.Add("Buzz");
            }
            else if (i % 3 == 0)
            {
                list.Add("Fizz");
            }
            else
            {
                list.Add(i.ToString());
            }
        }
        return list;
    }
}
