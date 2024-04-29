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
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY stringList
     *  2. STRING_ARRAY queries
     */

    // first one 
    // public static List<int> matchingStrings(List<string> stringList, List<string> queries)
    // {
    //     List<int> result = new List<int>(new int[queries.Count]);
    //     for (int i = 0; i < queries.Count; i++)
    //     {
    //         for (int j = 0; j < stringList.Count; j++)
    //         {
    //             if (stringList[j] == queries[i])
    //             {
    //                 result[i]++;
    //             }
    //         }
    //     }
    //     return result;
    // }
    // optimize with dict 
    public static List<int> matchingStrings(List<string> stringList, List<string> queries)
    {
        List<int> result = new List<int>(new int[queries.Count]);
        Dictionary<string, int> dict = new Dictionary<string, int>();


        for (int i = 0; i < stringList.Count; i++)
        {
            if (!dict.ContainsKey(stringList[i]))
            {
                dict.Add(stringList[i], 1);
            }
            else
            {
                dict[stringList[i]]++;
            }
        }


        for (int i = 0; i < queries.Count; i++)
        {
            if (!dict.ContainsKey(queries[i]))
            {
                result.Add(0);
            }
            else
            {
                result.Add(dict[queries[i]]);
            }
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringListCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> stringList = new List<string>();

        for (int i = 0; i < stringListCount; i++)
        {
            string stringListItem = Console.ReadLine();
            stringList.Add(stringListItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = Result.matchingStrings(stringList, queries);

        textWriter.WriteLine(String.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
