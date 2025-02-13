// 2. Find the Missing Number
// Given an array of size n-1 containing distinct numbers from 1 to n, find the missing number.
// Signature: public static int FindMissNumber(int[] arr, int n)
// Example Input: [1, 2, 4, 5, 6], n = 6
// Output: 3

using System;

int[] arr = {1, 2, 3, 4, 5, 7};
int n = 7;

int FindNumber(int[] arr, int n) {
    int sumN = n * (n + 1) / 2; // Corrected sum formula
    int sumA = 0;

    foreach (int num in arr) {
        sumA += num;
    }

    return sumN - sumA;
}

Console.WriteLine("Missing Number: " + FindNumber(arr, n));
