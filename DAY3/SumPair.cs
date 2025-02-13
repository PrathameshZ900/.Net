// 11. Find Pair with Given Sum in a Sorted Array
// Return indices of two numbers that sum to a target (Two-Pointer approach).
// Signature: public static int[] TwoSumSorted(int[] arr, int target)
// Example Input: [1, 2, 3, 4, 6], target = 6
// Output: [1, 3]

using System;

int[] SumPairK(int[] arr, int k) {
    for (int i = 0; i < arr.Length; i++) {  
        for (int j = i + 1; j < arr.Length; j++) {  
            if (arr[i] + arr[j] == k) {
                return new int[] { arr[i], arr[j] };
            }
        }
    }
    return new int[] {};  
}

int[] arr = {1, 2, 3, 4, 6};
int k = 6;

int[] result = SumPairK(arr, k);

if (result != null && result.Length > 0) {  
    Console.WriteLine($"Pair: {result[0]}, {result[1]}");
} else {
    Console.WriteLine("No pair found");
}
