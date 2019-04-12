/*
 * @lc app=leetcode.cn id=67 lang=csharp
 *
 * [67] 二进制求和
 *
 * https://leetcode-cn.com/problems/add-binary/description/
 *
 * algorithms
 * Easy (47.38%)
 * Total Accepted:    20.9K
 * Total Submissions: 44.2K
 * Testcase Example:  '"11"\n"1"'
 *
 * 给定两个二进制字符串，返回他们的和（用二进制表示）。
 * 
 * 输入为非空字符串且只包含数字 1 和 0。
 * 
 * 示例 1:
 * 
 * 输入: a = "11", b = "1"
 * 输出: "100"
 * 
 * 示例 2:
 * 
 * 输入: a = "1010", b = "1011"
 * 输出: "10101"
 * 
 */
using System.Text;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var sb = new StringBuilder();

        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        while (i >= 0 || j >= 0)
        {
            int addend = i >= 0 ? a[i--] - '0' : 0;
            int augend = j >= 0 ? b[j--] - '0' : 0;
            int sum = Sum(addend, augend, ref carry);

            sb.Insert(0, sum);
        }

        if (carry == 1)
        {
            sb.Insert(0, carry);
        }

        return sb.ToString();
    }

    private int Sum(int addend, int augend, ref int carry)
    {
        int temp = addend + augend + carry;
        carry = temp / 2;

        return temp % 2;
    }
}
