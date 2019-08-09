/*
 * @lc app=leetcode.cn id=686 lang=csharp
 *
 * [686] 重复叠加字符串匹配
 *
 * https://leetcode-cn.com/problems/repeated-string-match/description/
 *
 * algorithms
 * Easy (29.95%)
 * Likes:    46
 * Dislikes: 0
 * Total Accepted:    3.9K
 * Total Submissions: 12.4K
 * Testcase Example:  '"abcd"\n"cdabcdab"'
 *
 * 给定两个字符串 A 和 B, 寻找重复叠加字符串A的最小次数，使得字符串B成为叠加后的字符串A的子串，如果不存在则返回 -1。
 * 
 * 举个例子，A = "abcd"，B = "cdabcdab"。
 * 
 * 答案为 3， 因为 A 重复叠加三遍后为 “abcdabcdabcd”，此时 B 是其子串；A 重复叠加两遍后为"abcdabcd"，B
 * 并不是其子串。
 * 
 * 注意:
 * 
 * A 与 B 字符串的长度在1和10000区间范围内。
 * 
 */
using System;

public class Solution
{
    public int RepeatedStringMatch(string A, string B)
    {
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == B[0])
            {
                int k = i;
                int j = 0;
                while (j < B.Length)
                {
                    if (A[k % A.Length] == B[j])
                    {
                        j++;
                        k++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (j == B.Length)
                {
                    return (int)Math.Ceiling((double)k / A.Length);
                }
            }
        }

        return -1;
    }
}
