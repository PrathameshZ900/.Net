// 8. Find K-th Smallest Element in an Unsorted Array
// Find the k-th smallest element without sorting.
// Signature: public static int KthSmallestElement(int[] arr, int k)
// Example Input: [7, 10, 4, 3, 20, 15], k = 3
// Output: 7 

using System;

int KthSmallestElement(int[] arr, int k) {
    return QuickSelect(arr, 0, arr.Length - 1, k - 1);
}

int QuickSelect(int[] arr, int left, int right, int k) {
    if (left == right) return arr[left];

    int pivotIndex = Partition(arr, left, right);
    
    if (k == pivotIndex) return arr[k];
    else if (k < pivotIndex) return QuickSelect(arr, left, pivotIndex - 1, k);
    else return QuickSelect(arr, pivotIndex + 1, right, k);
}

int Partition(int[] arr, int left, int right) {
    int pivot = arr[right], i = left;
    
    for (int j = left; j < right; j++) {
        if (arr[j] <= pivot) {
            (arr[i], arr[j]) = (arr[j], arr[i]);
            i++;
        }
    }
    
    (arr[i], arr[right]) = (arr[right], arr[i]);
    return i;
}

int[] arr = {7, 10, 4, 3, 20, 15};
int k = 3;
Console.WriteLine("K-th Smallest: " + KthSmallestElement(arr, k));
