using System;
using System.Collections.Generic;

namespace Day18_QueuesАndStacks
{
    class Program
    {
        static void Main(String[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}

class Solution
{
    public Stack<char> stack = new Stack<char>();
    public Queue<char> queue = new Queue<char>();

    public void pushCharacter(char c)
    {
        stack.Push(c);
    }

    public void enqueueCharacter(char c)
    {
        queue.Enqueue(c);
    }


    public char popCharacter()
    {
        var ch = stack.Pop();
        return ch;
    }

    public char dequeueCharacter()
    {
        var ch = queue.Dequeue();
        return ch;
    }
}
/*A palindrome is a word, phrase, number, or other sequence of characters which reads the same backwards and forwards. Can you determine if a given string, s, is a palindrome?

To solve this challenge, we must first take each character in s, enqueue it in a queue, and also push that same character onto a stack. Once that's done, we must dequeue the first character from the queue and pop the top character off the stack, then compare the two characters to see if they are the same; as long as the characters match, we continue dequeueing, popping, and comparing each character until our containers are empty (a non-match means  isn't a palindrome).

Write the following declarations and implementations:

1. Two instance variables: one for your stack, and one for your queue.
2. A void pushCharacter(char ch) method that pushes a character onto a stack.
3. A void enqueueCharacter(char ch) method that enqueues a character in the queue instance variable.
4. A char popCharacter() method that pops and returns the character at the top of the stack instance variable.
5. A char dequeueCharacter() method that dequeues and returns the first character in the queue instance variable.

Input Format

You do not need to read anything from stdin. The locked stub code in your editor reads a single line containing string s. It then calls the methods specified above to pass each character to your instance variables.

Constraints

s is composed of lowercase English letters.

Output Format

You are not responsible for printing any output to stdout.
If your code is correctly written and s is a palindrome, the locked stub code will print The word, s, is a palindrome.; otherwise, it will print The word, s, is not a palindrome.

Sample Input
racecar

Sample Output
The word, racecar, is a palindrome.
 */
