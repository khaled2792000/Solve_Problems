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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string[] subStrings = s.Split(':');
        string suffix = subStrings[2].Substring(subStrings[2].Length - 2);
        int hours = Convert.ToInt32(subStrings[0].Substring(0, 2));

        if (suffix == "AM" && hours == 12)
        {
            hours = 0;
        }
        else if (suffix == "PM" && hours != 12)
        {
            hours += 12;
        }

        return $"{hours:D2}:{subStrings[1]}:{subStrings[2].Substring(0, 2)}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
