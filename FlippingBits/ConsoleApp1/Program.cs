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
using Ardalis.GuardClauses;

class Result
{

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        string outputString = Convert.ToString(n, 2);
        Console.WriteLine(outputString);
        ulong outputLong = ~ Convert.ToUInt32(outputString, 2);
        Console.WriteLine(outputLong);
        return (long)outputLong;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string qu = Console.ReadLine().Trim();
        Guard.Against.NotNumerical(qu, nameof(qu));
        int q = Convert.ToInt32(qu);

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);
        }
    }
}