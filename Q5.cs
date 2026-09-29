using System;
using System.Collections.Generic;

class q5
{
    static void Main()
    {
        int[] logs = { 101, 102, 103, 101, 104, 102, 105, 101 };

        HashSet<int> users = new HashSet<int>();

        int repeats = 0;

        foreach (int id in logs)
        {
            if (!users.Add(id))
            {
                repeats++;
            }
        }

        Console.WriteLine($"Log entries: {logs.Length}");
        Console.WriteLine($"Unique visitors: {users.Count}");
        Console.WriteLine($"Repeat entries: {repeats}");
    }
}