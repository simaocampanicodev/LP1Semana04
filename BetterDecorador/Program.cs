using System;

namespace BetterDecorador
{
    /// <summary>
    /// This program takes three command-line arguments: string, char and int.
    /// It decorates the given string surrounding it with the given char and
    /// with the amount of times given with the int.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Parse command-line arguments and then calls the Decor
        /// method to format the string.
        /// </summary>
        /// <param name="args">
        /// Array of strings containing:
        /// args[0] => Text in the middle of the decorator
        /// args[1] => The decorator
        /// args[2] => Many times the decorator is repeated
        // </param>
        private static void Main(string[] args)
        {
            string text = args[0];
            char decorator;
            int repeat;

            if (!char.TryParse(args[1], out decorator))
            {
                return;
            }

            if (!int.TryParse(args[2], out repeat) || repeat < 0)
            {
                return;
            }
            Console.WriteLine(Decor(text, decorator, repeat));
        }
        /// <summary>
        /// Decorates a string by surrounding it with a repeating character.
        /// </summary>
        /// <param name="s">Text in the middle of the decoration</param>
        /// <param name="dec">The character used for the decoration</param>
        /// <param name="count">Number of times the decoration repeat</param>
        /// <returns>A formatted string with the decoration applied</returns>

        private static string Decor(string s, char dec, int count)
        {
            string decoration = new string(dec, count);
            return $"{decoration} {s} {decoration}";
        }
    }
}
