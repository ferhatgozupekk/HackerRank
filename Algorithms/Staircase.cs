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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
int back = n - 1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < back; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = back; k < n; k++)
                    {
                        Console.Write("#");
                    }
                    back--;
                    Console.WriteLine("");
                }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
