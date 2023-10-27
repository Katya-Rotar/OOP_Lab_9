﻿using System.Collections;

class Stack<T> : IEnumerable<T>
{
    private List<T> stack;
    public Stack() {
        stack = new List<T>();
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = stack.Count - 1; i >= 0; i--) {
            yield return stack[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void Push(T[] elements) {
        foreach (T element in elements) {
            stack.Add(element);
        }
    }
    public void Pop() {
        if (stack.Count > 0)
        {
            stack.RemoveAt(stack.Count - 1);
        }
        else
        {
            Console.WriteLine("No elements");
        }
    }
}
