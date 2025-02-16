// Implement a sparse matrix multiplication algorithm using a 2D array in C#.



using System;

class MatrixProduct
{
    public static void Main(string[] args)
    {
        int[,] matrix = {
            { 1, 0, 0, 0 },
            { 0, 0, 0, 2 },
            { 0, 3, 0, 0 },
            { 4, 0, 0, 0 }
        };

        int[] vector = { 1, 2, 3, 4 };

        int[] result = Multiply(matrix, vector);

        Console.WriteLine("Result:");
        Print(result);
    }

    static int[] Multiply(int[,] m, int[] v)
    {
        int rows = m.GetLength(0);
        int[] res = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < v.Length; j++)
            {
                res[i] += m[i, j] * v[j];
            }
        }

        return res;
    }

    static void Print(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}