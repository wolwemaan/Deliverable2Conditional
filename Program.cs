//
// Author: Ettienne Voges
// Program Week 3 Conditional logic
//
//
using System;

namespace Deliverable2Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what grade they expect to get in ISM 4300
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            // Read the grade from standard input
            int expectedGrade = Convert.ToInt32(Console.ReadLine());

            // Create a character array with two elements
            char[] degree = new char[2];

            // Initilize element 0 as the lowest grade (Effectively a replacement of else in the following statement set)
            degree[0] = 'F';

            // Handle the "Tens" of the grade to get the letter grade
            if (expectedGrade >= 90)
                degree[0] = 'A';
            else if (expectedGrade >= 80)
                degree[0] = 'B';
            else if (expectedGrade >= 70)
                degree[0] = 'C';
            else if (expectedGrade >= 60)
                degree[0] = 'D';

            // Handle the "Ones" of the grade by means of a modulo calculation to get the letter grade's 
            // upper middle or lower indicator
            int modValue = expectedGrade % 10;
            if (modValue > 7)
                degree[1] = '+';
            else if (modValue > 1)
                degree[1] = ' ';
            else
                degree[1] = '-';

            // Initialize a new result string by using the character array
            string result = new string(degree);

            // Print a message with the result string
            Console.WriteLine("Your letter grade per the Syllabus is " + result);
        }
    }
}
