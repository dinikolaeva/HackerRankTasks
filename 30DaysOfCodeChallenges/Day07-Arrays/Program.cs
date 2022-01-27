﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine()
                                   .TrimEnd()
                                   .Split(' ')
                                   .ToList()
                                   .Select(arrTemp => Convert.ToInt32(arrTemp))
                                                             .ToList();

            arr.Reverse();

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
/*Task
Given an array, A, of N integers, print A's elements in reverse order as a single line of space-separated numbers.

Example
A = [1, 2, 3, 4]

Print 4 3 2 1. Each integer is separated by one space.

Input Format
The first line contains an integer, N (the size of our array).
The second line contains N space-separated integers that describe array A's elements.

Constraints
1 <= N <= 1000
1 <= A[i] <= 10000, where A[i] is the i-th integer in the array.

Output Format
Print the elements of array A in reverse order as a single line of space-separated numbers.

Sample Input
4
1 4 3 2

Sample Output
2 3 4 1
 */
