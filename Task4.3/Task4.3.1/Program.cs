using System.Linq;

namespace Task4._3._1;

class Program
{
    static void Main(string[] args)
    {

        List<string> vowels = new List<string>() { "a", "e","i","o","u" };
        static bool MYstring(string words, List<string> vowels)
        {
            foreach (char c in words.ToLower())
            {
                if (vowels.Contains(c.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        try
        {

            Console.WriteLine("Enter a word:");
            string  words =  Console.ReadLine();
            if (!MYstring(words, vowels))
            {

                throw new Exception("the word doesn't contains vowels");
            }
            Console.WriteLine($"the word {words} contains vowel ");

        }

        catch (Exception ex)
        {

            Console.WriteLine($"Error: {ex.Message}");

        }
    }
}

