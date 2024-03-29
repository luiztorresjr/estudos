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

class Pangram
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        Dictionary<char, int> alphabet = new Dictionary<char, int>();
        foreach (char letter in s.ToLower())
        {
            if (alphabet.ContainsKey(letter))
            {
                alphabet[letter]++;
            }
            else
            {
                alphabet.Add(letter, 1);
            }
        }
        if (alphabet.Count() > 26) return "pangram";
        return "not pangram";
    }

}

