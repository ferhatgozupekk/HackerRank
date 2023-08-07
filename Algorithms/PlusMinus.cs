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
    public static void plusMinus(List<int> arr)
    {
        double pozitif = 0;
        double negatif = 0;
        double notr = 0;
        double sayac= 0;

        foreach (var item in arr)
        {
            if (item > 0)
            {
                pozitif++;
            }
            else if (item == 0)
            {
                notr++;
            }
            else
            {
                negatif++;
            }
            sayac++;
        }
        double sonuc = pozitif / sayac;
        Console.WriteLine(sonuc);
        double sonuc1 = negatif / sayac;
        Console.WriteLine(sonuc1);
        double sonuc2 = notr / sayac;
        Console.WriteLine(sonuc2);

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
