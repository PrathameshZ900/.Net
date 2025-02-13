// 6. Rotate an Array by K Positions
// Rotate an array to the right by k steps.
// Signature: public static void RotateArray(int[] arr, int k)
// Example Input: [1, 2, 3, 4, 5, 6, 7], k = 3
// Output: [5, 6, 7, 1, 2, 3, 4]

using System;

void Rotate(int[] arr, int k) {
    int n = arr.Length;
    k = k % n;

    Rev(arr, 0, n - 1);
    Rev(arr, 0, k - 1);
    Rev(arr, k, n - 1);
}

void Rev(int[] arr, int l, int r) {
    while (l < r) {
        (arr[l], arr[r]) = (arr[r], arr[l]);
        l++;
        r--;
    }
}

int[] arr = {1, 2, 3, 4, 5, 6, 7};
int k = 3;

Rotate(arr, k);
Console.WriteLine("Rotated: [" + string.Join(", ", arr) + "]");


