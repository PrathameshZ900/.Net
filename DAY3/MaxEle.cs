// 5. Find the Majority Element
// Find the element that appears more than n/2 times in an array (Boyer-Moore Voting Algorithm).
// Signature: public static int MajorityElement(int[] arr)
// Example Input: [3, 3, 4, 2, 3, 3, 3, 1]
// Output: 3

using System;

int MajorityElement(int[] arr) {
    int candidate = 0, count = 0;


    foreach (int num in arr) {
        if (count == 0) {
            candidate = num;
        }
        count += (num == candidate) ? 1 : -1;
    }


    count = 0;
    foreach (int num in arr) {
        if (num == candidate) {
            count++;
        }
    }

    return (count > arr.Length / 2) ? candidate : -1; 
}


int[] arr = {3, 3, 4, 2, 3, 3, 3, 1};
Console.WriteLine("Majority Element: " + MajorityElement(arr));
