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
        List<double> result = new List<double>();
        //var Numberlist = arr;
        double totaldigit = arr.Count;
        double totalnegative = 0;
        double totalpositive = 0;
        double totalzero = 0;
        foreach (var digit in arr)
        {
            if (digit == 0)
            {
                totalzero = totalzero + 1;
            }
            else if (digit < 0)
            {
                totalnegative = totalnegative + 1;
            }
            else
            {
                totalpositive = totalpositive + 1;
            }
        }
        double positive = totalpositive / totaldigit;
        double negative = totalnegative / totaldigit;
        double zero = (totalzero / totaldigit);
        result.Add(positive);
        result.Add(negative);
        result.Add(zero);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
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
