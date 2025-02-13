// 7. Find the Longest Consecutive Sequence
// Find the length of the longest sequence of consecutive numbers.
// Signature: public static int LongestConsecutive(int[] arr)
// Example Input: [100, 4, 200, 1, 3, 2]
// Output: 4


using System;
using System.Collections.Generic;

int LongestConsecutive(int[] arr) {
    HashSet<int> set = new HashSet<int>(arr);
    int longest = 0;

    foreach (int num in arr) {
        if (!set.Contains(num - 1)) {
            int currNum = num;
            int currStreak = 1;

            while (set.Contains(currNum + 1)) {
                currNum++;
                currStreak++;
            }

            longest = Math.Max(longest, currStreak);
        }
    }
    return longest;
}

int[] arr = {100, 4, 200, 1, 3, 2};
Console.WriteLine("Longest Sequence: " + LongestConsecutive(arr));
