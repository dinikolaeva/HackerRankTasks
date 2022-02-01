using System;
using System.Linq;

namespace Day12_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }

    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }

    public void printPerson()
    {
        Console.WriteLine("Name: " + this.lastName + ", " + this.firstName + "\nID: " + this.id);
    }
}

class Student : Person
{
    private int[] testScores;

    public Student(string firstName, string lastName, int identification, int[] testScores) 
        : base(firstName, lastName, identification)
    {
        this.testScores = testScores;
    }

    public char Calculate()
    {
        int avrGrade = testScores.Sum() / testScores.Length;

        if (avrGrade >= 90 && avrGrade <= 100)
        {
            return 'O';
        }
        else if (avrGrade >= 80 && avrGrade < 90)
        {
            return 'E';
        }
        else if (avrGrade >= 70 && avrGrade < 80)
        {
            return 'A';
        }
        else if (avrGrade >= 55 && avrGrade < 70)
        {
            return 'P';
        }
        else if (avrGrade >= 40 && avrGrade < 55)
        {
            return 'D';
        }
        else
        {
            return 'T';
        }
    }

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
}

/*Task
You are given two classes, Person and Student, where Person is the base class and Student is the derived class. Completed code for Person and a declaration for Student are provided for you in the editor. Observe that Student inherits all the properties of Person.

Complete the Student class by writing the following:

A Student class constructor, which has 4 parameters:

1. A string, firstName.
2. A string, lastName.
3. An integer, idNumber.
4. An integer array (or vector) of test scores, scores.

A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:

Letter:         Average(a):

O              90 <= a <= 100
E              80 <= a < 90
A              70 <= a < 80
P              55 <= a < 70
D              40 <= a < 55
T                a < 40

Input Format:

The locked stub code in the editor reads the input and calls the Student class constructor with the necessary arguments. It also calls the calculate method which takes no arguments.

The first line contains firstName, lastName, and idNumber, separated by a space. The second line contains the number of test scores. The third line of space-separated integers describes scores.

Constraints:

1 <= lenght of firstName, lenght of lastName <= 10
length of idNumber == 7
0 <= scores <= 100

Output Format:

Output is handled by the locked stub code. Your output will be correct if your Student class constructor and calculate() method are properly implemented.

Sample Input

Heraldo Memelli 8135627
2
100 80

Sample Output

 Name: Memelli, Heraldo
 ID: 8135627
 Grade: O

Explanation

This student had 2 scores to average: 100 and 80. The student's average grade is (100 + 80) / 2 = 90. An average grade of 80 corresponds to the letter grade O, so the calculate() method should return the character 'O'.
 */
