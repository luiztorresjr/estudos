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
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        int pair = 0;
        Dictionary<int, int> groups = new Dictionary<int, int>();
        foreach (int elem in ar)
        {
            if (groups.ContainsKey(elem))
            {
                groups[elem]++;
                if (groups[elem] > 2 )
                {
                    pair++;
                    groups[elem] = 0;
                }
                else
                {
                    groups.Add(elem, 1);
                }
            }
        }
        return pair;
    }



}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = 9;

        List<int> ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
