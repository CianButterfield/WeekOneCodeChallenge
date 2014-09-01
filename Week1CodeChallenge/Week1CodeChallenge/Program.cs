using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 10000;
            
            //FizzBuzz loop 0 to 20
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            //FizzBuzz loop 92 to 79
            for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }

            //Yodaizer
            Yodaizer("I like code");

            //TextStats
            TextStats("Once upon a midnight dreary, while I pondered, weak and weary, \nOver many a quaint and curious volume of forgotten lore— \nWhile I nodded, nearly napping, suddenly there came a tapping, \nAs of some one gently rapping, rapping at my chamber door. \n\"'Tis some visiter,\" I muttered, \"tapping at my chamber door— \nOnly this and nothing more.\" \n\nAh, distinctly I remember it was in the bleak December; \nAnd each separate dying ember wrought its ghost upon the floor.");
            
            //IsPrime loop
            for (int i = 1; i <= 25; i += 2)
            {
                IsPrime(i);
            }

            //DashInsert
            DashInsert(8675309);
            
            //keep the console open
            Console.ReadKey();

           
        }

        //2 FizzBuzz
        static void FizzBuzz(int number)
        {
            //check if 'number' is divisable by 5
            bool divisable5 = (number % 5 == 0);
            //check if 'number' is divisable by 3
            bool divisable3 = (number % 3 == 0);
            //if both print 'FizzBuzz'
            if (divisable3 && divisable5)
            {
                Console.WriteLine("FizzBuzz");
            }
            //if only divisable by 5 print 'Fizz'
            else if (divisable5)
            {
                Console.WriteLine("Fizz");
            }
            //if only divisable by 3 print 'Buzz'
            else if (divisable3)
            {
                Console.WriteLine("Buzz");
            }
            //if neither print 'number'
            else
            {
                Console.WriteLine(number);
            }
        }

        //3 Yodaizer
        static void Yodaizer(string text)
        {
            //split 'text' into a list 'words'
            List<string> words = text.Split(' ').ToList();
            //reverse the order of the items in the list 'words'
            words.Reverse();
            //join 'words' into a string and print
            Console.WriteLine(string.Join(" ", words));
        }

        //4 TextStats
        static void TextStats(string input)
        {
            //number of characters
            int numChars = input.Length;
            //number of words
            int numWords = input.Split(' ').ToList().Count;
            //number of vowels
            int numVowels = 0;
            //number of consonants
            int numConsonants = 0;
            //number of special characters
            int numSpecial = 0;

            //find the number of vowels, consonants and special characters
            for (int i = 0; i < numChars; i++)
            {
                if ("aeiou".Contains(input[i].ToString().ToLower()))
                {
                    numVowels++;
                }
                else if ("bcdfghjklmnpqrstvwxyz".Contains(input[i].ToString().ToLower()))
                {
                    numConsonants++;
                }
                else
                {
                    numSpecial++;
                }
            }

            //print outputs
            Console.WriteLine("Number of characters: " + numChars);
            Console.WriteLine("Number of words: " + numWords);
            Console.WriteLine("Number of vowels: " + numVowels);
            Console.WriteLine("Number of consonants: " + numConsonants);
            Console.WriteLine("Number of special characters: " + numSpecial);
        }

        //5 IsPrime
        static void IsPrime(int number)
        {
            //boolian to check if 'number' is 1 or 0
            bool mayBePrime = !(number == 1) && !(number == 0);
            //boolian to keep track of whether 'number' was divisable by anything
            bool isNotPrime = false;
            //boolian representing if 'number' is prime
            bool isPrime = false;
            //loop to check if 'number' is prime
            for (int i = 2; i < number && !isNotPrime; i++)
            {
                if (number % i == 0)
                {
                    isNotPrime = true;
                }
            }
            isPrime = (mayBePrime && !isNotPrime);
            //print out responces
            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static void DashInsert(int number)
        {
            string output = "";
            string input = number.ToString();
            output = output + input[0];
            //loop through 'input'
            for (int i = 1; i < input.Length; i++)
            {
                //check if two consecutive digets are odd and add a dash if they are
                if ("13579".Contains(input[i - 1]) && "13579".Contains(input[i]))
                {
                    output = output + "-";
                }
                output = output + input[i];
            }
            //print the output
            Console.WriteLine(output);
        }
    }
}
