﻿using System;

public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        var sum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}

namespace Day19_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}


/*Task
The AdvancedArithmetic interface and the method declaration for the abstract divisorSum(n) method are provided for you in the editor below.

Complete the implementation of Calculator class, which implements the AdvancedArithmetic interface. The implementation for the divisorSum(n) method must return the sum of all divisors of n.

Example

n = 25
The divisors of 25 are 1, 5, 25. Their sum is 31.

n = 20
The divisors of 20 are 1, 2, 4, 5, 10, 20 and their sum is 42.

Input Format

A single line with an integer, n.

Constraints

1 <= n <= 1000

Output Format

You are not responsible for printing anything to stdout. The locked template code in the editor below will call your code and print the necessary output.

Sample Input

6

Sample Output

I implemented: AdvancedArithmetic
12

Explanation

The integer 6 is evenly divisible by 1, 2, 3, and 6. Our divisorSum method should return the sum of these numbers, which is 1 + 2 + 3 + 6 = 12. The Solution class then prints I implemented: AdvancedArithmetic on the first line, followed by the sum returned by divisorSum (which is 12) on the second line.
 */
