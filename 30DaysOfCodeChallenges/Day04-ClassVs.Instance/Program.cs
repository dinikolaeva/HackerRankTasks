using System;
using System.Collections.Generic;
using System.IO;

namespace Day4_ClassVs.Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());

                Person p = new Person(age);

                p.amIOld();

                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }

                p.amIOld();

                Console.WriteLine();
            }
        }

        class Person
        {
            public int age;

            public Person(int initialAge)
            {
                this.Age = initialAge;
            }

            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 0)
                    {
                        value = 0;
                        Console.WriteLine("Age is not valid, setting age to 0.");
                    }

                    age = value;
                }
            }

            public void amIOld()
            {
                // Do some computations in here and print out the correct statement to the console

                if (this.Age < 13)
                {
                    Console.WriteLine("You are young.");
                }
                else if (this.Age >= 13 && this.Age < 18)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are old.");
                }
            }

            public void yearPasses()
            {
                // Increment the age of the person in here
                this.Age++;
            }
        }
    }
}
/*
 * Task
Write a Person class with an instance variable, age, and a constructor that takes an integer, initialAge, as a parameter. The constructor must assign initialAge to age after confirming the argument passed as initialAge is not negative; if a negative argument is passed as initialAge, the constructor should set age to 0 and print Age is not valid, setting age to 0.. In addition, you must write the following instance methods:

1. yearPasses() should increase the age instance variable by 1.
2. amIOld() should perform the following conditional actions:

  a. If age < 13, print You are young..
  b. If age >= 13 and age < 18, print You are a teenager..
  c. Otherwise, print You are old..

To help you learn by example and complete this challenge, much of the code is provided for you, but you'll be writing everything in the future. The code that creates each instance of your Person class is in the main method. Don't worry if you don't understand it all quite yet!

Note: Do not remove or alter the stub code in the editor.

Input Format

Input is handled for you by the stub code in the editor.

The first line contains an integer, T (the number of test cases), and the T subsequent lines each contain an integer denoting the age of a Person instance.

Constraints

  a. 1 <= T <= 4
  b. -5 <= age <= 30

Output Format

Complete the method definitions provided in the editor so they meet the specifications outlined above; the code to test your work is already in the editor. If your methods are implemented correctly, each test case will print 2 or 3 lines (depending on whether or not a valid initialAge was passed to the constructor).

Sample Input
4
-1
10
16
18

Sample Output
Age is not valid, setting age to 0.
You are young.
You are young.

You are young.
You are a teenager.

You are a teenager.
You are old.

You are old.
You are old.
Explanation

Test Case 0: initialAge = -1
Because initialAge < 0, our code must set age to 0 and print the "Age is not valid..." message followed by the young message. Three years pass and age = 3, so we print the young message again.

Test Case 1: initialAge = 10
Because initialAge < 13, our code should print that the person is young. Three years pass and age = 13, so we print that the person is now a teenager.

Test Case 2: initialAge = 16
Because 13 <= initialAge < 18, our code should print that the person is a teenager. Three years pass and age = 19, so we print that the person is old.

Test Case 3: initialAge = 18
Because initialAge >= 18, our code should print that the person is old. Three years pass and the person is still old at age = 21, so we print the old message again.

The extra line at the end of the output is supposed to be there and is trimmed before being compared against the test case's expected output. If you're failing this challenge, check your logic and review your print statements for spelling errors.
 */
