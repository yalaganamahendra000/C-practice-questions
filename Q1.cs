using System;
namespace q1
{
class qn1
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Console.Write("Before: ");
        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
        Console.WriteLine("k = " + k);

        int n = arr.Length;
        k = k % n;

        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[(i + k) % n] = arr[i];
        }

        Console.Write("After: ");
        foreach (int x in result)
        {
            Console.Write(x + " ");
        }
    }
}
}