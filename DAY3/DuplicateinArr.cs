// 18. Find Duplicates in an Array
// Find all duplicate numbers in an array.
// Signature: public static List<int> FindDuplicates(int[] arr)
// Example Input: [4, 3, 2, 7, 8, 2, 3, 1]
// Output: [2, 3]

using System;
using System.Collections.Generic;

List<int> FindDuplicates(int[] arr) {
    var res = new List<int>();
    var set = new HashSet<int>();

    foreach (int num in arr) {
        if (!set.Add(num)) res.Add(num);
    }
    return res;
}

int[] arr = {4, 3, 2, 7, 8, 2, 3, 1};
Console.WriteLine(string.Join(", ", FindDuplicates(arr)));
