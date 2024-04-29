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
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */



    //first solution 
    // public static List<int> rotateLeft(int d, List<int> arr)
    // {
    //     List<int> result = new List<int>();
    //     for (int i = 0; i < d; i++)
    //     {
    //         for (int j = 0; j < arr.Count - 1; j++)
    //         {
    //             Swap<int>(arr, j, j + 1);
    //         }
    //     }
    //     return arr;
    // }
    // private static void Swap<T>(IList<T> list, int indexA, int indexB)
    // {
    //     T tmp = list[indexA];
    //     list[indexA] = list[indexB];
    //     list[indexB] = tmp;

    // }
    public static List<int> rotateLeft(int d, List<int> arr)
    {
        List<int> result = new List<int>();
        for (int i = d; i < arr.Count; i++)
        {
            result.Add(arr[i]);
        }
        for (int i = 0; i < d; i++)
        {
            result.Add(arr[i]);
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.rotateLeft(d, arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
