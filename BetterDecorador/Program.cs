using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Identifies the first, second and third arguments
        /// and calls them with the method Decor
        /// </summary>
        /// <param name="args"></param>
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
        /// Returns a string representation of the decorated string
        /// with the corresponding text, decoration and the amount of repeat
        /// decorations
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="count"></param>
        /// <returns></returns>

        private static string Decor(string s, char dec, int count)
        {
            string decoration = new string(dec, count);
            return $"{decoration} {s} {decoration}";
        }
    }
}
