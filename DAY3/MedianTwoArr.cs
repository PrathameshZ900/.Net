// 20. Find the Median of Two Sorted Arrays
// Find the median of two sorted arrays in O(log(n+m)) time.
// Signature: public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
// Example Input: [1, 3], [2]
// Output: 2.0

using System;

double FindMedianSortedArrays(int[] nums1, int[] nums2) {
    if (nums1.Length > nums2.Length) return FindMedianSortedArrays(nums2, nums1);

    int x = nums1.Length, y = nums2.Length;
    int low = 0, high = x;

    while (low <= high) {
        int partitionX = (low + high) / 2;
        int partitionY = (x + y + 1) / 2 - partitionX;

        int maxX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
        int minX = (partitionX == x) ? int.MaxValue : nums1[partitionX];

        int maxY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
        int minY = (partitionY == y) ? int.MaxValue : nums2[partitionY];

        if (maxX <= minY && maxY <= minX) {
            return (x + y) % 2 == 0 ? (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0 : Math.Max(maxX, maxY);
        } else if (maxX > minY) {
            high = partitionX - 1;
        } else {
            low = partitionX + 1;
        }
    }
    
    return 0.0;
}

int[] nums1 = {1, 3};
int[] nums2 = {2};
Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
