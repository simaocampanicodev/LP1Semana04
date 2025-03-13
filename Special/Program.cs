using System;

namespace Special
{
    /// <summary>
    /// This program calculates the n-th number of the special sequence.
    /// The sequence follows the rule:
    /// S(0) = 0, S(1) = 1, S(n) = S(n-1) + 2 * S(n-2) for n ≥ 2.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program. Prompts the user for a number and displays
        /// the corresponding special sequence value.
        /// </summary>
        private static void Main()
        {
            Console.Write("Insert n-th number of the special sequence: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                Console.WriteLine(GetSpecial(n));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }

        /// <summary>
        /// Recursively computes the n-th number in the special sequence.
        /// </summary>
        /// <param name="n">The position in the sequence (0-based).</param>
        /// <returns>The n-th number of the special sequence.</returns>
        private static int GetSpecial(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
        }
    }
}
