/*
 * @lc app=leetcode.cn id=125 lang=csharp
 *
 * [125] 验证回文串
 *
 * https://leetcode-cn.com/problems/valid-palindrome/description/
 *
 * 给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。
 *
 * 说明：本题中，我们将空字符串定义为有效的回文串。
 *
 * 示例 1:
 *
 * 输入: "A man, a plan, a canal: Panama"
 * 输出: true
 *
 * 示例 2:
 *
 * 输入: "race a car"
 * 输出: false
 *
 */
public class Solution
{
    public bool IsPalindrome(string s)
    {
        int head = 0;
        int tail = s.Length - 1;
        while (head < tail)
        {
            char h = (char) (s[head] | 0x20);
            if (!IsDigitOrLetter(h))
            {
                head++;
                continue;
            }

            char t = (char) (s[tail] | 0x20);
            if (!IsDigitOrLetter(t))
                {
                    tail--;
                    continue;
                }

                if (h != t)
                {
                    return false;
                }

                head++; tail--;
            }

            return true;
        }

        private bool IsDigitOrLetter(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'a' && c <= 'z');
        }
    }
