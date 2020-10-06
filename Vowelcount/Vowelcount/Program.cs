using System;
using static System.Console;

namespace Vowelcount
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter your phrase: ");
            string phrase = Console.ReadLine();
            int vowelCount = 0;
            //string subbed = phrase.Substring(0);
            string letter = "";
            //WriteLine(subbed);
            WriteLine("Length of phrase is: " + phrase.Length);


            for (int i = 0;i < phrase.Length; i++)
            {
                letter = phrase.ToLower().Substring(i, 1);

                if (letter.Equals("a") || letter.Equals("e") || letter.Equals("i") || letter.Equals("o") || letter.Equals("u"))
                {
                    vowelCount++;
                }else if (letter.Equals("e"))
                {
                    vowelCount++;
                }
                else if (letter.Equals("i"))
                {
                    vowelCount++;
                }
                else if (letter.Equals("o"))
                {
                    vowelCount++;
                }
                else if (letter.Equals("u"))
                {
                    vowelCount++;
                }
            }

            WriteLine("You have {0} vowels", vowelCount);



        }
    }
}
