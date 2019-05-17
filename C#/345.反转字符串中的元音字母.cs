using System;
/*
 * @lc app=leetcode.cn id=345 lang=csharp
 *
 * [345] 反转字符串中的元音字母
 *
 * https://leetcode-cn.com/problems/reverse-vowels-of-a-string/description/
 *
 * algorithms
 * Easy (46.48%)
 * Likes:    46
 * Dislikes: 0
 * Total Accepted:    9.4K
 * Total Submissions: 20.3K
 * Testcase Example:  '"hello"'
 *
 * 编写一个函数，以字符串作为输入，反转该字符串中的元音字母。
 * 
 * 示例 1:
 * 
 * 输入: "hello"
 * 输出: "holle"
 * 
 * 
 * 示例 2:
 * 
 * 输入: "leetcode"
 * 输出: "leotcede"
 * 
 * 说明:
 * 元音字母不包含字母"y"。
 * 
 */
using System.Collections.Generic;

public class Solution
{
    private HashSet<char> vowels = new HashSet<char> { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };

    public string ReverseVowels(string s)
    {
        var arr = s.ToCharArray();

        int i = 0;
        int j = arr.Length - 1;
        while (i < j)
        {
            if (!vowels.Contains(arr[i]))
            {
                i++;
                continue;
            }

            if (!vowels.Contains(arr[j]))
            {
                j--;
                continue;
            }

            char temp = arr[i];
            arr[i++] = arr[j];
            arr[j--] = temp;
        }

        return new string(arr);
    }
}
