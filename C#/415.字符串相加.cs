/*
 * @lc app=leetcode.cn id=415 lang=csharp
 *
 * [415] 字符串相加
 *
 * https://leetcode-cn.com/problems/add-strings/description/
 *
 * algorithms
 * Easy (44.96%)
 * Likes:    73
 * Dislikes: 0
 * Total Accepted:    7.7K
 * Total Submissions: 17K
 * Testcase Example:  '"0"\n"0"'
 *
 * 给定两个字符串形式的非负整数 num1 和num2 ，计算它们的和。
 * 
 * 注意：
 * 
 * 
 * num1 和num2 的长度都小于 5100.
 * num1 和num2 都只包含数字 0-9.
 * num1 和num2 都不包含任何前导零。
 * 你不能使用任何內建 BigInteger 库， 也不能直接将输入的字符串转换为整数形式。
 * 
 * 
 */
using System.Text;

public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        var sb = new StringBuilder();

        int carry = 0;
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        while (i >= 0 || j >= 0)
        {
            int a = i >= 0 ? num1[i--] - '0' : 0;
            int b = j >= 0 ? num2[j--] - '0' : 0;
            int sum = Sum(a, b, ref carry);

            sb.Insert(0, sum);
        }

        if (carry > 0)
        {
            sb.Insert(0, carry);
        }

        return sb.ToString();
    }

    private int Sum(int a, int b, ref int carry)
    {
        int temp = a + b + carry;
        carry = temp / 10;

        return temp % 10;
    }
}
