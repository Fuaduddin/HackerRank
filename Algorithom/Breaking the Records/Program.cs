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
using static System.Runtime.InteropServices.JavaScript.JSType;

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> results = new List<int>();
        int minvalue = scores[0];
        int maxvalue = scores[0];
        int minscore = 0;
        int maxscore = 0;
        foreach (int item in scores)
        {
            if (item < minvalue)
            {
                minvalue = item;
                minscore = minscore + 1;
            }
            else if (maxvalue < item)
            {
                maxvalue = item;
                maxscore = maxscore + 1;
            }
            else
            {
                continue;
            }
        }
        results.Add(maxscore);
        results.Add(minscore);
        return results;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(System.String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
