using System;
using System.Collections.Generic;

class Q12
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            3, 7, 3, 9, 7, 1, 3
        };

        Dictionary<int, int> count =
            new Dictionary<int, int>();

        foreach (int num in numbers)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        foreach (var item in count)
        {
            if (item.Value > 1)
            {
                Console.WriteLine(
                    $"{item.Key} appears {item.Value} times"
                );
            }
        }
    }
}
