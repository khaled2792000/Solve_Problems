using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        // we will goes from the second to the before last one 
        // and we will goes from the second col to the before last one 
        int max_sum = 0;
        for (int row_index = 1; row_index < arr.Count - 1; row_index++)
        {
            for (int col_index = 1; col_index < arr[row_index].Count - 1; col_index++)
            {
                int hourglass = arr[row_index][col_index] + sumAboveRow(arr, row_index, col_index) + sumBottomRow(arr, row_index, col_index);
                if (hourglass > max_sum)
                {
                    max_sum = hourglass;
                }
            }
        }
        return max_sum;
    }
    private static int sumAboveRow(List<List<int>> arr, int row_index, int col_index)
    {
        int sum = 0;
        for (int index = col_index - 1; index <= col_index + 1; index++)
        {
            sum += arr[row_index - 1][index];
        }
        return sum;
    }
    private static int sumBottomRow(List<List<int>> arr, int row_index, int col_index)
    {
        int sum = 0;
        for (int index = col_index - 1; index <= col_index + 1; index++)
        {
            sum += arr[row_index + 1][index];
        }
        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
