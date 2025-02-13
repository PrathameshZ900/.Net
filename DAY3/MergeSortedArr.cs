// 10. Merge Two Sorted Arrays
// Merge two sorted arrays into one sorted array.
// Signature: public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
// Example Input: [1, 3, 5], [2, 4, 6]
// Output: [1, 2, 3, 4, 5, 6]


using System;

int[] MergeSortedArrays(int[] a, int[] b) {
    int[] res = new int[a.Length + b.Length];
    int i = 0, j = 0, k = 0;

    while (i < a.Length && j < b.Length) {
        res[k++] = (a[i] < b[j]) ? a[i++] : b[j++];
    }

    while (i < a.Length) res[k++] = a[i++];
    while (j < b.Length) res[k++] = b[j++];

    return res;
}

int[] arr1 = {1, 3, 5};
int[] arr2 = {2, 4, 6};
Console.WriteLine(string.Join(", ", MergeSortedArrays(arr1, arr2)));
