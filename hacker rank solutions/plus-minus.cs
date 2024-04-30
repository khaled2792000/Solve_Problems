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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positiveCount = arr.Count(x => x > 0);
        int negativeCount = arr.Count(x => x < 0);
        int zeroCount = arr.Count(x => x == 0);

        float positiveRatio = (float)positiveCount / arr.Count;
        float negativeRatio = (float)negativeCount / arr.Count;
        float zeroRatio = (float)zeroCount / arr.Count;

        Console.WriteLine(string.Format("{0:0.000000}", positiveRatio));
        Console.WriteLine(string.Format("{0:0.000000}", negativeRatio));
        Console.WriteLine(string.Format("{0:0.000000}", zeroRatio));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
