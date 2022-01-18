using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManagment
{
    class Program
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            var employeesWithAge = new Dictionary<string, int>();

            var ec = new SortedDictionary<string, List<Employee>>();

            foreach (var e in employees)
            {
                if (ec.ContainsKey(e.Company))
                {
                    ec[e.Company].Add(new Employee
                    {
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        Age = e.Age,
                        Company = e.Company
                    });
                }
                else
                {
                    ec.Add(e.Company, new List<Employee> { e });
                }
            }

            foreach (var kvp in ec.Keys)
            {
                employeesWithAge.Add(kvp, (int)Math.Round(ec[kvp]
                                                   .Average(e => e.Age)));
            }

            return employeesWithAge;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {

            var employeesWithAge = new Dictionary<string, int>();

            var ec = new SortedDictionary<string, List<Employee>>();

            foreach (var e in employees)
            {
                if (ec.ContainsKey(e.Company))
                {
                    ec[e.Company].Add(new Employee
                    {
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        Age = e.Age,
                        Company = e.Company
                    });
                }
                else
                {
                    ec.Add(e.Company, new List<Employee> { e });
                }
            }

            foreach (var kvp in ec.Keys)
            {
                employeesWithAge.Add(kvp, ec[kvp].Count);
            }

            return employeesWithAge;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var employeesWithAge = new Dictionary<string, Employee>();

            var ec = new SortedDictionary<string, List<Employee>>();

            foreach (var e in employees)
            {
                if (ec.ContainsKey(e.Company))
                {
                    ec[e.Company].Add(new Employee
                    {
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        Age = e.Age,
                        Company = e.Company
                    });
                }
                else
                {
                    ec.Add(e.Company, new List<Employee> { e });
                }
            }

            foreach (var kvp in ec.Keys)
            {
                employeesWithAge.Add(kvp, ec[kvp].OrderByDescending(a => a.Age)
                                                 .First());
            }

            return employeesWithAge;
        }

        static void Main(string[] args)
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"the count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
/*
12
Ainslee Ginsie Galaxy 28
Libbey Apdell Starbucks 44
Illa Stebbings Berkshire 49
Laina Sycamore Berkshire 20
Abbe Parnell Amazon 20
Ludovika Reveley Berkshire 30
Rene Antos Galaxy 44
Vinson Beckenham Berkshire 45
Reed Lynock Amazon 41
Wyndham Bamfield Berkshire 34
Loraine Sappson Amazon 49
Abbe Antonutti Starbucks 47
*/

//Output:
//The average age for company Amazon is 37
//The average age for company Berkshire is 36
//The average age for company Galaxy is 36
//The average age for company Starbucks is 46
//The count of employees for company Amazon is 3
//The count of employees for company Berkshire is 5
//The count of employees for company Galaxy is 2
//The count of employees for company Starbucks is 2
//The oldest employee of company Amazon is Loraine Sappson having age 49
//The oldest employee of company Berkshire is Illa Stebbings having age 49
//The oldest employee of company Galaxy is Rene Antos having age 44
//The oldest employee of company Starbucks is Abbe Antonutti having age 47

/*
12
Sybila Fulle Kimberly 24
Scarface Stork Tesla 22
Ashli Crosseland Kimberly 36
Allene Stebbings Galaxy 19
Valentin Harbert Amazon 28
Gracie Pappin Tesla 44
Sadye Orcott Rockwell 30
Timoteo Pook Amazon 35
Marris Apdell Rockwell 43
Pen Ghilardini Rockwell 38
Bern Aizikov Rockwell 20
Sela Farrier Amazon 47
*/

//Output:
//The average age for company Amazon is 37
//The average age for company Galaxy is 19
//The average age for company Kimberly is 30
//The average age for company Rockwell is 33
//The average age for company Tesla is 33
//The count of employees for company Amazon is 3
//The count of employees for company Galaxy is 1
//The count of employees for company Kimberly is 2
//The count of employees for company Rockwell is 4
//The count of employees for company Tesla is 2
//The oldest employee of company Amazon is Sela Farrier having age 47
//The oldest employee of company Galaxy is Allene Stebbings having age 19
//The oldest employee of company Kimberly is Ashli Crosseland having age 36
//The oldest employee of company Rockwell is Marris Apdell having age 43
//The oldest employee of company Tesla is Gracie Pappin having age 44