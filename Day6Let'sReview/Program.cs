using System;
using System.Collections.Generic;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int test = int.Parse(Console.ReadLine());
        string s = string.Empty;
        List<string> list = new List<string>();
        while (test >= 1 && test <= 10)
        {
            for (int i = 0; i < test; i++)
            {
                s = Console.ReadLine().TrimEnd().TrimStart();
                list.Add(s);
            }
            
            foreach (var item in list)
            {
                List<char> oddindex = new List<char>();
                List<char> evenindex = new List<char>();
                for (int i=0;i<item.Length;i++)
                {
                    if (i %2 == 0)
                    {
                        char b = item[i];
                        evenindex.Add(b);
                    }
                    else
                    {
                        char a = item[i];
                        oddindex.Add(a); 
                    }
                }
                foreach (var item1 in evenindex)
                {
                    Console.Write(item1);
                }
                Console.Write(" ");    
                foreach(var item2 in oddindex)
                { 
                    Console.Write(item2);   
                }
                Console.WriteLine("");
            }
            break;
        }
        
        Console.ReadKey ();


    }
}

