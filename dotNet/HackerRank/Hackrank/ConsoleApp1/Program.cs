using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using interviewPreparation;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {


        List<int> arr = new List<int>() { 1, 1, 3, 2, 1};      

        List<int> result = Result.countingSort(arr);

        result.ForEach(i => Console.WriteLine(i));

    }
}
