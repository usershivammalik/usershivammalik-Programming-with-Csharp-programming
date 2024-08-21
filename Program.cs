using System;

namespace Programs
{
    class SumInRange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start of the range: ");
            if (!int.TryParse(Console.ReadLine(), out int start))
            {
                Console.WriteLine("Enter a valid integer for the start of range.");
                return;
            }
            Console.Write("Enter the end of the range: ");
            if (!int.TryParse(Console.ReadLine(), out int end))
            {
                Console.WriteLine("Enter a valid integer for end of range.");
                return;
            }
            if (start > end)
            {
                Console.WriteLine("Invalid range. ");
                return;
            }

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of numbers from {start} to {end} is {sum}.");
        }
    }
}
