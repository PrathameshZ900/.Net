// Write a program to find the intersection and union of two unsorted arrays without using built-in functions.

using System;
using System.Collections.Generic;

class UnionOfArr
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4 };
        int[] arr2 = { 2, 5, 4, 1 };
        int n = arr1.Length;
        int m = arr2.Length;

        int[] Union = UnionArr(arr1, arr2, n, m);
        int[] intrSetArr = InterSectorArr(arr1, arr2, n, m);
        Console.WriteLine("Union Arr of arr1 and arr2 is: " + string.Join(", ", Union));
        Console.WriteLine("Intersection Arr of arr1 and arr2 is: " + string.Join(", ", intrSetArr));



    }
     
      public static int[] InterSectorArr(int[] arr1, int[] arr2, int n, int m){

        int[] ansArr = {};


        for(int i = 0; i < n; i++){
            if(arr2.Contains(arr1[i])){
                ansArr.Add(arr1[i]);
            }
        }

        return ansArr;

      }
   



    public static int[] UnionArr(int[] arr1, int[] arr2, int n, int m)
    {
        List<int> ansArr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            if (!ansArr.Contains(arr1[i]))
            {
                ansArr.Add(arr1[i]);
            }
        }

        for (int i = 0; i < m; i++)
        {
            if (!ansArr.Contains(arr2[i]))
            {
                ansArr.Add(arr2[i]);
            }
        }

        return ansArr.ToArray();
    }
}