Design a method to rotate a 2D matrix (NxN) 90 degrees clockwise in place without using extra space.

using System;

class RotateMatrix
{
    public static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Rotate(matrix);
        Print(matrix);
    }

    public static void Rotate(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        for (int layer = 0; layer < n / 2; layer++)
        {
            int first = layer;
            int last = n - 1 - layer;

            for (int i = first; i < last; i++)
            {
                int offset = i - first;
                int top = matrix[first, i];

                matrix[first, i] = matrix[last - offset, first];
                matrix[last - offset, first] = matrix[last, last - offset];
                matrix[last, last - offset] = matrix[i, last];
                matrix[i, last] = top;
            }
        }
    }

    public static void Print(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}