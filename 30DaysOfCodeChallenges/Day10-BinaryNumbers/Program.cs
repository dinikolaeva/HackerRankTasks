using System;
using System.Linq;

namespace Day10_BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            var b = Convert.ToString(n, 2);
            string[] arr = b.Split('0').ToArray();
            int c = arr.Select(x => x.Length).Max();
            Console.WriteLine(c);
        }
    }
}
/*Task
Given a base-10 integer, n, convert it to binary (base-2). Then find and print the base-10 integer denoting the maximum number of consecutive 1's in n's binary representation. When working with different bases, it is common to show the base as a subscript.

Example
n = 125

The binary representation of 125(10) is 1111101(2). In base 10, there are 5 and 1 consecutive ones in two groups. Print the maximum, 5.

Input Format

A single integer, n.

Output Format

Print a single base-10 integer that denotes the maximum number of consecutive 1's in the binary representation of n.

Sample Input 1
5
Sample Output 1
1
Sample Input 2
13
Sample Output 2
2

Explanation

Sample Case 1:
The binary representation of 5(10) is 101(2), so the maximum number of consecutive 1's is 1.

Sample Case 2:
The binary representation of 13(10) is 1101(2), so the maximum number of consecutive 1's is 2.
 */
