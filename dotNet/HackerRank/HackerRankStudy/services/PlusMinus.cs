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

class PlusMinus
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double size = arr.Count();
        double pos = arr.Where(x => x > 0).Count()/size;
        double neg = arr.Where(x => x < 0).Count()/size;
        double zero = arr.Where(x => x == 0).Count()/size;
        Console.WriteLine(pos.ToString("0.000000"));
        Console.WriteLine(neg.ToString("0.000000"));
        Console.WriteLine(zero.ToString("0.000000"));
    }

}