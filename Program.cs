using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("This is a hangman game");
                Console.Clear();
            }
            {
                Console.WriteLine("Type any letter till you can spell the 6 letter word");
                Console.Clear();
            }

            char[] guessed = new char[26];
            char[] testword = "******".ToCharArray();
            char[] word = "school".ToCharArray();
            char[] copy = word;

            char guess;

            int index = 0;
            Console.WriteLine(testword);

            for (int i = 0; i < 10; i++)
            {

                Console.Write("Please enter a letter to guess: ");

                guess = char.Parse(Console.ReadLine());
                bool right = false;
                for (int j = 0; j < copy.Length; j++)
                {
                    if (copy[j] == guess)
                    {
                        Console.WriteLine("Your guess is correct.");
                        testword[j] = guess;
                        guessed[index] = guess;
                        index++;
                        right = true;
                    }
                }

                if (right != true)
                {
                    Console.WriteLine("Your guess is incorrect.");
                    
                }
                else
                {
                    right = false;
                }

                Console.WriteLine(testword);


            }

            Console.WriteLine("You have now completed my game ");

            Console.ReadLine();

        }
    }
}
