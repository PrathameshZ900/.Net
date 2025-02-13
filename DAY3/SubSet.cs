// 13. Check If an Array is a Subset of Another
// Check if arr2 is a subset of arr1.
// Signature: public static bool IsSubset(int[] arr1, int[] arr2)
// Example Input: [1, 2, 3, 4, 5], [2, 3, 4]
// Output: true

using System;
using System.Linq;

bool IsSubset(int[] arr1, int[] arr2) {
    return arr2.All(x => arr1.Contains(x));
}

int[] arr1 = {1, 2, 3, 4, 5};
int[] arr2 = {2, 3, 4};

Console.WriteLine(IsSubset(arr1, arr2));
