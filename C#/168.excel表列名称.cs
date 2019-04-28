/*
 * @lc app=leetcode.cn id=168 lang=csharp
 *
 * [168] Excel表列名称
 *
 * https://leetcode-cn.com/problems/excel-sheet-column-title/description/
 *
 * 给定一个正整数，返回它在 Excel 表中相对应的列名称。
 *
 * 例如，
 *
 * 1 -> A
 * 2 -> B
 * 3 -> C
 * ...
 * 26 -> Z
 * 27 -> AA
 * 28 -> AB 
 * ...
 * 示例 1:
 *
 * 输入: 1
 * 输出: "A"
 *
 *示例 2:
 *
 * 输入: 28
 * 输出: "AB"
 *
 * 示例 3:
 *
 * 输入: 701
 * 输出: "ZY"
 *
 */
using System.Text;

public class Solution
{
    public string ConvertToTitle(int n)
    {
        var sb = new StringBuilder();
        while (n > 0)
        {
            n--;

            char c = (char) ((n % 26) + 'A');
            n /= 26;

            sb.Insert(0, c);
        }

        return sb.ToString();
    }
}
