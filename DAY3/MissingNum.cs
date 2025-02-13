// 2. Find the Missing Number
// Given an array of size n-1 containing distinct numbers from 1 to n, find the missing number.
// Signature: public static int FindMissNumber(int[] arr, int n)
// Example Input: [1, 2, 4, 5, 6], n = 6
// Output: 3

public class MissingNumberFinder {
    public static int FindMissNumber(int[] arr, int n) {
        int expectedSum = n * (n + 1) / 2; // Sum of first n natural numbers
        int actualSum = 0;
        
        for (int num : arr) {
            actualSum += num;
        }
        
        return expectedSum - actualSum; // The missing number
    }

    public static void main(String[] args) {
        int[] arr = {1, 2, 4, 5, 6};
        int n = 6;
        System.out.println("Missing number: " + FindMissNumber(arr, n)); // Output: 3
    }
}
