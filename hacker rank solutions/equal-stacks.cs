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
     * Complete the 'equalStacks' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h1
     *  2. INTEGER_ARRAY h2
     *  3. INTEGER_ARRAY h3
     */

    public static int equalStacks(List<Integer> h1, List<Integer> h2, List<Integer> h3)
    {
        int sum1 = h1.stream().reduce(0, (a, b)->a + b);
        int sum2 = h2.stream().reduce(0, Integer::sum);
        int sum3 = h3.stream().mapToInt(Integer::intValue).sum();

        while (true)
        {
            if (sum1 == sum2 && sum1 == sum3)
                return sum1;
            if (sum1 >= sum2 && sum1 >= sum3)
                sum1 -= h1.remove(0);
            else if (sum2 >= sum1 && sum2 >= sum3)
                sum2 -= h2.remove(0);
            else if (sum3 >= sum1 && sum3 >= sum2)
                sum3 -= h3.remove(0);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n1 = Convert.ToInt32(firstMultipleInput[0]);

        int n2 = Convert.ToInt32(firstMultipleInput[1]);

        int n3 = Convert.ToInt32(firstMultipleInput[2]);

        List<int> h1 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h1Temp => Convert.ToInt32(h1Temp)).ToList();

        List<int> h2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h2Temp => Convert.ToInt32(h2Temp)).ToList();

        List<int> h3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h3Temp => Convert.ToInt32(h3Temp)).ToList();

        int result = Result.equalStacks(h1, h2, h3);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
