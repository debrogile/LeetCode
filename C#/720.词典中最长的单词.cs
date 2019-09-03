/*
 * @lc app=leetcode.cn id=720 lang=csharp
 *
 * [720] 词典中最长的单词
 *
 * https://leetcode-cn.com/problems/longest-word-in-dictionary/description/
 *
 * algorithms
 * Easy (43.58%)
 * Likes:    42
 * Dislikes: 0
 * Total Accepted:    3.4K
 * Total Submissions: 7.8K
 * Testcase Example:  '["w","wo","wor","worl","world"]'
 *
 * 
 * 给出一个字符串数组words组成的一本英语词典。从中找出最长的一个单词，该单词是由words词典中其他单词逐步添加一个字母组成。若其中有多个可行的答案，则返回答案中字典序最小的单词。
 * 
 * 若无答案，则返回空字符串。
 * 
 * 示例 1:
 * 
 * 
 * 输入: 
 * words = ["w","wo","wor","worl", "world"]
 * 输出: "world"
 * 解释: 
 * 单词"world"可由"w", "wo", "wor", 和 "worl"添加一个字母组成。
 * 
 * 
 * 示例 2:
 * 
 * 
 * 输入: 
 * words = ["a", "banana", "app", "appl", "ap", "apply", "apple"]
 * 输出: "apple"
 * 解释: 
 * "apply"和"apple"都能由词典中的单词组成。但是"apple"得字典序小于"apply"。
 * 
 * 
 * 注意:
 * 
 * 
 * 所有输入的字符串都只包含小写字母。
 * words数组长度范围为[1,1000]。
 * words[i]的长度范围为[1,30]。
 * 
 * 
 */
using System.Collections.Generic;

public class Solution
{
    public string LongestWord(string[] words)
    {
        var trie = new Trie();
        foreach (string word in words)
        {
            trie.Insert(word);
        }

        string result = string.Empty;
        var queue = new Queue<Node>();
        foreach (var node in trie.Root.Nodes)
        {
            if (node != null && !string.IsNullOrEmpty(node.Word))
            {
                queue.Enqueue(node);
            }
        }

        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();
            if (curr.Word.Length > result.Length)
            {
                result = curr.Word;
            }

            foreach (var node in curr.Nodes)
            {
                if (node != null && !string.IsNullOrEmpty(node.Word))
                {
                    queue.Enqueue(node);
                }
            }
        }

        return result;
    }
}

public class Trie
{
    public Node Root { get; private set; }

    public Trie()
    {
        Root = new Node();
    }

    public void Insert(string word)
    {
        var curr = Root;
        foreach(char c in word)
        {
            int index = c - 'a';
            if (curr.Nodes[index] == null)
            {
                var node = new Node(c);
                curr.Nodes[index] = node;
            }

            curr = curr.Nodes[index];
        }

        curr.Word = word;
    }
}

public class Node
{
    private const int L = 26;

    public char Value { get; private set; }
    public Node[] Nodes { get; private set; }
    public string Word { get; set; }

    public Node()
    {
        Nodes = new Node[L];
    }

    public Node(char c) : base()
    {
        Value = c;
    }
}
