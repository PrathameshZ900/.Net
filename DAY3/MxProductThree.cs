// 9. Find the Maximum Product of Three Numbers
// Find the maximum product of any three numbers in an array.
// Signature: public static int MaxProductOfThree(int[] arr)
// Example Input: [1, 10, -5, 1, -100]
// Output: 5000

using System;

int MaxProductOfThree(int[] arr) {
    Array.Sort(arr);
    int n = arr.Length;
    return Math.Max(arr[n-1] * arr[n-2] * arr[n-3], arr[0] * arr[1] * arr[n-1]);
}

int[] arr = {1, 10, -5, 1, -100};
Console.WriteLine(MaxProductOfThree(arr));
