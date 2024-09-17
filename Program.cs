using System;
using System.Linq;
using System.Collections.Generic;

namespace ADO.Net4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { -5, 2, -3, 8, 10, -1, 5 };

            var positiveNumbers = numbers1.Where(n => n > 0).OrderBy(n => n);

            Console.WriteLine("Task 1: Positive numbers sorted in ascending order:");
            foreach (var num in positiveNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int[] numbers2 = { -15, 22, -35, 18, 10, -21, 55 };

            var twoDigitPositiveNumbers = numbers2.Where(n => n >= 10 && n < 100);
            int count = twoDigitPositiveNumbers.Count();
            double average = twoDigitPositiveNumbers.Any() ? twoDigitPositiveNumbers.Average() : 0;

            Console.WriteLine("Task 2: Count of positive two-digit numbers: " + count);
            Console.WriteLine("Average of positive two-digit numbers: " + average);

            int[] years = { 1999, 2000, 2001, 2004, 1900, 1600, 2020 };

            var leapYears = years.Where(y => (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0)).OrderBy(y => y);

            Console.WriteLine("Task 3: Leap years sorted in ascending order:");
            foreach (var year in leapYears)
            {
                Console.Write(year + " ");
            }
            Console.WriteLine();

            int[] numbers4 = { 12, 5, 7, 22, 9, 14, 20 };

            var maxEvenNumber = numbers4.Where(n => n % 2 == 0).Max();

            Console.WriteLine("Task 4: Maximum even number: " + maxEvenNumber);

            List<string> strings5 = new List<string> { "Hello", "World", "LINQ" };

            var updatedStrings = strings5.Select(s => s + "!!!");

            Console.WriteLine("Task 5: Strings with three exclamation marks:");
            foreach (var str in updatedStrings)
            {
                Console.WriteLine(str);
            }

            char symbol = 'o';
            List<string> strings6 = new List<string> { "hello", "world", "code", "csharp" };

            var filteredStrings = strings6.Where(s => s.Contains(symbol));

            Console.WriteLine($"Task 6: Strings that contain the character '{symbol}':");
            foreach (var str in filteredStrings)
            {
                Console.WriteLine(str);
            }

            List<string> strings7 = new List<string> { "one", "three", "four", "twelve" };

            var groupedStrings = strings7.GroupBy(s => s.Length);

            Console.WriteLine("Task 7: Strings grouped by length:");
            foreach (var group in groupedStrings)
            {
                Console.WriteLine($"Length {group.Key}:");
                foreach (var str in group)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
