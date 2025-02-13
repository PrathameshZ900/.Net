// 3. Reverse an Array in Place
// Write a method to reverse an integer array without using extra space.
// Signature: public static void ReverseArray(int[] arr)
// Example Input: [1, 2, 3, 4]
// Output: [4, 3, 2, 1]

using System;

int[] arr = {1, 2, 3, 4};

int[] ReverseArr(int[] arr) {
    int left = 0, right = arr.Length - 1;

    while (left < right) {
        (arr[left], arr[right]) = (arr[right], arr[left]);
        left++;
        right--;
    }

    return arr;
}

Console.WriteLine("Reversed Array: " + string.Join(", ", ReverseArr(arr)));


