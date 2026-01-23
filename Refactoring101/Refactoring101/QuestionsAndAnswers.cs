using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101
{
    using System;

    public class QuestionsAndAnswers
    {
        // 1. Clear Name (Mysterious Name → Intention-Revealing)
        public double GetMaximum(double first, double second)
        {
            return Math.Max(first, second);
        }

        // 2. Remove Duplicate Code
        public void Print()
        {
            PrintPerson("Mr.", "Harry Potter");
            PrintPerson("Ms.", "Mary Poppin");
            PrintPerson("Mr.", "Johny Black");
        }

        private void PrintPerson(string title, string name)
        {
            PrintHeader();
            Console.WriteLine($"   {title} {name}");
            PrintHeader();
            Console.WriteLine();
        }

        private void PrintHeader()
        {
            Console.WriteLine("***********************");
        }

        // 3. Fix Shotgun Surgery (Single Source of Truth)
        public class StudentService
        {
            private const int StudentCount = 48;

            public void DisplayStudents()
            {
                Console.WriteLine($"Student Count = {StudentCount}");
            }

            public void PrintTotal()
            {
                Console.WriteLine($"Total Students : {StudentCount}");
            }
        }

        // 4 & 5. Data Clump + Feature Envy
        public void PrintDate(Date date)
        {
            Console.WriteLine(date.Format());
        }
    }

    // Extracted class to fix Data Clump & Feature Envy
    public class Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string Format()
        {
            return $"{Day:00}/{Month:00}/{Year:0000}";
        }
    }
}

