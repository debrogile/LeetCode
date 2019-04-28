/*
 * @lc app=leetcode.cn id=155 lang=csharp
 *
 * [155] 最小栈
 *
 * https://leetcode-cn.com/problems/min-stack/description/
 *
 * 设计一个支持 push，pop，top 操作，并能在常数时间内检索到最小元素的栈。
 *
 * push(x) -- 将元素 x 推入栈中。
 * pop() -- 删除栈顶的元素。
 * top() -- 获取栈顶元素。
 * getMin() -- 检索栈中的最小元素。
 * 示例:
 *
 * MinStack minStack = new MinStack();
 * minStack.push(-2);
 * minStack.push(0);
 * minStack.push(-3);
 * minStack.getMin();   --> 返回 -3.
 * minStack.pop();
 * minStack.top();      --> 返回 0.
 * minStack.getMin();   --> 返回 -2.
 *
 */
using System;
using System.Collections.Generic;

public class MinStack
{
    // 数据存储
    private int[] store;
    // 保存最小数据的栈，栈顶为当前的最小数据
    private Stack<int> stack;
    // 栈的长度
    private int count;

    /** initialize your data structure here. */
    public MinStack()
    {
        store = new int[32];
        stack = new Stack<int>();
        count = 0;
    }

    public void Push(int x)
    {
        if (count >= store.Length)
        {
            Array.Resize(ref store, store.Length << 1);
        }

        store[count++] = x;
        if (stack.Count == 0 || x <= stack.Peek())
        {
            stack.Push(x);
        }
    }

    public void Pop()
    {
        if (count <= 0)
        {
            throw new InvalidOperationException("Stack Is Empty!");
        }

        if (store[--count] == stack.Peek())
        {
            stack.Pop();
        }
    }

    public int Top()
    {
        if (count >= 0)
        {
            return store[count - 1];
        }
        else
        {
            throw new InvalidOperationException("Stack Is Empty!");
        }
    }

    public int GetMin()
    {
        return stack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
