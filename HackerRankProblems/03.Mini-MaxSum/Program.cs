using System;
using System.Collections.Generic;
using System.Linq;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace Mini_MaxSum
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            var listOfSums = new List<Int64>();

            for (var i = 0; i < arr.Count; i++)
            {
                Int64 sum = 0;

                foreach (var item in arr)
                {
                    sum += item;
                }

                sum -= arr[i];
                listOfSums.Add(sum);
            }

            var minSum = listOfSums.Min();
            var maxSum = listOfSums.Max();

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}
