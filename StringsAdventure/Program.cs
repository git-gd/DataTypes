using System;

namespace StringsAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstsentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Enter a search term:");
            
            string search = Console.ReadLine();

            bool found = firstsentence.ToLower().Contains(search);

            int index = firstsentence.ToLower().IndexOf(search);

            int length = search.Length;

            int sentenceLength = firstsentence.Length;

            Console.WriteLine(found + " index:" + index + " length:" + length);

            // no error checking/handling.. 
            firstsentence = firstsentence.Substring(0, index) + firstsentence.Substring(index + length, sentenceLength - index - length);

            Console.WriteLine(firstsentence);
        }
    }
}
