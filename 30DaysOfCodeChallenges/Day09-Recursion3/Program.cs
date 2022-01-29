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
     * Complete the 'factorial' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int factorial(int n)
    {
        if (n == 0)

        {

            return 1;

        }

        return n * factorial(n - 1);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.factorial(n);

        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}

/*Recursive Method for Calculating Factorial
 * 
 * if n > 1:
 * factorial(n) = n × factorial(n – 1)
 * 
 * else n <= 1:
 *factorial(n) = 1
 * 
Function Description

Complete the factorial function in the editor below. Be sure to use recursion.
factorial has the following paramter:
int n: an integer

Returns

int: the factorial of n

Note: If you fail to use recursion or fail to name your recursive function factorial or Factorial, you will get a score of 0.

Input Format

A single integer, n (the argument to pass to factorial).

Constraints
2 <= n <= 12

Your submission must contain a recursive function named factorial.

Sample Input
3

Sample Output
6

Explanation

Consider the following steps. After the recursive calls from step 1 to 3, results are accumulated from step 3 to 1.

1. factorial(3) = 3 × factorial(2) = 3 * 2 = 6;
2. factorial(2) = 2 × factorial(1) = 2 * 1 = 2;
3. factorial(1) = 1;

 */
