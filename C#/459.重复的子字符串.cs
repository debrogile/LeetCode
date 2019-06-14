/*
 * @lc app=leetcode.cn id=459 lang=csharp
 *
 * [459] 重复的子字符串
 *
 * https://leetcode-cn.com/problems/repeated-substring-pattern/description/
 *
 * algorithms
 * Easy (40.43%)
 * Likes:    95
 * Dislikes: 0
 * Total Accepted:    5.9K
 * Total Submissions: 14.5K
 * Testcase Example:  '"abab"'
 *
 * 给定一个非空的字符串，判断它是否可以由它的一个子串重复多次构成。给定的字符串只含有小写英文字母，并且长度不超过10000。
 * 
 * 示例 1:
 * 
 * 
 * 输入: "abab"
 * 
 * 输出: True
 * 
 * 解释: 可由子字符串 "ab" 重复两次构成。
 * 
 * 
 * 示例 2:
 * 
 * 
 * 输入: "aba"
 * 
 * 输出: False
 * 
 * 
 * 示例 3:
 * 
 * 
 * 输入: "abcabcabcabc"
 * 
 * 输出: True
 * 
 * 解释: 可由子字符串 "abc" 重复四次构成。 (或者子字符串 "abcabc" 重复两次构成。)
 * 
 * 
 */
public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        // 子串长度
        int len = 1;

        int i = 1;
        while (i < s.Length)
        {
            if (s.Length % len == 0)
            {
                int j = len;
                while (j < s.Length)
                {
                    if (s[j] != s[j % len])
                    {
                        break;
                    }

                    j++;
                }

                if (j == s.Length)
                {
                    return true;
                }
            }
            
            len++;
            i++;
        }

        return false;
    }
}
