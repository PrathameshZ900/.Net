// Implement a method to find the subarray with the maximum sum (Kadane’s Algorithm) in a given integer array.


using System;

class MaxSumProgram {

  public static void Main(){
 
    int[] arr = {1,-2,3,-4,5,-5,3,2,4,-2};
    int n = arr.Length;

    int MxSm = MxSum(arr, n);

    Console.WriteLine("Max Subarray Sum is " + MxSm );
  }

  public static int MxSum(int[] arr, int n){
    int maximumSum = arr[0];
    int currSum = arr[0];

    for (int i = 1; i < n; i++){
        currSum = Math.Max(arr[i], currSum + arr[i]);
        maximumSum = Math.Max(currSum, maximumSum);
    }

    return maximumSum;
  }
}

MaxSumProgram.Main()