using System;

namespace BetterDecorador
{
    /// <summary>
    /// This program decorates a given string by surrounding it with a repeated character.
    /// If no arguments are provided, it uses a default message.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program. Parses command-line arguments and calls the appropriate Decor method.
        /// </summary>
        /// <param name="args">
        /// An array of strings containing:
        /// args[0] - The text to be decorated.
        /// args[1] - A single character used as the decorator.
        /// args[2] - An integer specifying how many times the decorator character should be repeated.
        /// If no arguments are provided, a default message is used.
        /// </param>
        private static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine(Decor());
                return;
            }

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
        /// Decorates a given string by surrounding it with a repeated character.
        /// </summary>
        /// <param name="s">The text to be decorated.</param>
        /// <param name="dec">The character used for decoration.</param>
        /// <param name="count">The number of times the decoration character should be repeated.</param>
        /// <returns>A formatted string with the decoration applied.</returns>
        private static string Decor(string s, char dec, int count)
        {
            string decoration = new string(dec, count);
            return $"{decoration} {s} {decoration}";
        }

        /// <summary>
        /// Returns a default decorated message when no arguments are provided.
        /// </summary>
        /// <returns>A default formatted string.</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
