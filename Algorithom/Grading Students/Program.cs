﻿using System.CodeDom.Compiler;
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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> result = new List<int>();
        int nextmarks = 0;
        foreach (int grade in grades)
        {
            int Incrementvalue = 0;
            nextmarks = grade;
            while (Incrementvalue % 10 != 5)
            {
                if (Incrementvalue % 10 == 0 && Incrementvalue != 0)
                {
                    break;
                }
                else
                {
                    if (Incrementvalue == 0)
                    {
                        Incrementvalue = nextmarks + 1;
                    }
                    else
                    {
                        Incrementvalue = Incrementvalue + 1;
                    }
                }

            }
            if (Incrementvalue - grade < 3 && (Incrementvalue > 40 || Incrementvalue == 40))
            {
                result.Add(Incrementvalue);
            }
            else
            {
                result.Add(grade);
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

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
