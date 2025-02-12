// 1. Sum of Array Elements
// Write a method that returns the sum of an integer array.
// Signature: public static int ArraySum(int[] arr)
// Example Input: [1, 2, 3, 4, 10, 11]
// Output: 31



public class ArraySumCalculator {
    public static int ArraySum(int[] arr) {
        int sum = 0;
        for (int num : arr) {
            sum += num;
        }
        return sum;
    }

    public static void main(String[] args) {
        int[] arr = {1, 2, 3, 4, 10, 11};
        System.out.println(ArraySum(arr)); // Output: 31
    }
}
