using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());
            var fail = 0.0;
            var between_1 = 0.0;
            var between_2 = 0.0;
            var top = 0.0;
            var totalGrade = 0.0;
            for (int i = 1; i <= students; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade < 3.00)
                {
                    fail++;
                    totalGrade += grade;
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    between_1++;
                    totalGrade += grade;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    between_2++;
                    totalGrade += grade;
                }
                else if (grade >= 5.00)
                {
                    top++;
                    totalGrade += grade;
                }
            }

            var averageGrade = totalGrade / students;
            var topStudents = (top / students) * 100;
            var between_1_Students = (between_1 / students) * 100;
            var between_2_Students = (between_2 / students) * 100;
            var failStudents = (fail / students) * 100;


            Console.WriteLine($"Top students: {topStudents:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between_2_Students:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between_1_Students:F2}%");
            Console.WriteLine($"Fail: {failStudents:F2}%");
            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}
