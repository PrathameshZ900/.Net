// Write a method to find the first missing positive integer in an unsorted array (without sorting).

using System;
using System.Collections.Generic;

class MissingInt
{
    public static void Main()
    {
        int[] arr = { 3, 4,-1, 1 };
        int result = FindMissing(arr);
        Console.WriteLine("The first missing positive integer is: " + result);
    }

    public static int FindMissing(int[] arr)
    {
        int sm = 0;

        for(int i = 1; i <= arr.Length; i++){

            sm += i;
        }

        int ArrSm = 0;

        for(int i = 0; i <= arr.Length; i++){

            if(arr[i] > 0){
                ArrSm += arr[i];
            }
        }


        return sm - ArrSm;


    }
}