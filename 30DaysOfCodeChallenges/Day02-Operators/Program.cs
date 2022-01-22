using System;

namespace Day2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            Result.solve(meal_cost, tip_percent, tax_percent);
        }
    }

    class Result
    {
        /*
         * Complete the 'solve' function below.
         *
         * The function accepts following parameters:
         *  1. DOUBLE meal_cost
         *  2. INTEGER tip_percent
         *  3. INTEGER tax_percent
         */

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost * tax_percent / 100;
            double totalCost = meal_cost + tip + tax;

            Console.WriteLine(Math.Round(totalCost));
        }

    }
}

/*
 * Task
Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip), 
and tax percent (the percentage of the meal price being added as tax) for a meal, find and print the meal's 
total cost. Round the result to the nearest integer.

Example

mealCoast = 100;
tipPercent = 15;
taxPercent = 8;

A tip of 15% * 100 = 15, and the taxes are 8% * 100 = 8. Print the value 123 and return from the function.

Function Description
Complete the solve function in the editor below.

solve has the following parameters:

int meal_cost: the cost of food before tip and tax
int tip_percent: the tip percentage
int tax_percent: the tax percentage
Returns The function returns nothing. Print the calculated value, rounded to the nearest integer.

Note: Be sure to use precise values for your calculations, or you may end up with an incorrectly rounded result.

Input Format

There are 3 lines of numeric input:
The first line has a double, meatCoast (the cost of the meal before tax and tip).
The second line has an integer, tipPercent (the percentage of  being added as tip).
The third line has an integer, taxPercent (the percentage of  being added as tax).

Sample Input

12.00
20
8

Sample Output
15

Explanation

Given:
meatCoast = 12,
tipPercent = 20,
taxPercent = 8

Calculations:
tip = 12 and 12 / 100 * 20 = 2.4
tax = 8 and 8 / 100 * 20 = 0.96
totalCost = meatCoast + tip + tax = 12 + 2.4 + 0.96 = 15.36
round(totalCost) = 15

We round  to the nearest integer and print the result, 15.
 */
