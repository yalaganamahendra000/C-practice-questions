using System;
using System.Collections.Generic;

class q9
{
    static bool IsBalanced(string text)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in text)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                if (stack.Count == 0)
                    return false;

                char open = stack.Pop();

                if (ch == ')' && open != '(')
                    return false;

                if (ch == '}' && open != '{')
                    return false;

                if (ch == ']' && open != '[')
                    return false;
            }
        }

        return stack.Count == 0;
    }

    static void Main()
    {
        string[] tests =
        {
            "{[()]}",
            "{[(])}",
            "(("
        };

        foreach (string test in tests)
        {
            Console.WriteLine(
                $"{test} -> {(IsBalanced(test) ? "balanced" : "not balanced")}"
            );
        }
    }
}