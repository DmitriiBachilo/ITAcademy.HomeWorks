using System;
using System.Collections.Generic;

namespace HW08_Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string text = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Delete longest word in string: \n{DeleteLongestWord(text)}");
            Console.WriteLine();

            Console.WriteLine($"Swap longest and shortest words: \n{ReplaceWords(text)}");
            Console.WriteLine();

            Console.WriteLine($"Calculate how many letters, punctuation marks are in a string: \n{CountLetters(text)}");
            Console.WriteLine();

            Console.WriteLine($"Sorting an array in descending order, the first index - longest word, the last - shortest: \n{TransformString(text)}");
        }

        static string DeleteLongestWord(string text)
        {
            int maxLength = -1;
            int maxIndex = -1;
            List<string> words = new List<string>(text.Split(' '));
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                    maxIndex = i;
                }
            }

            words.RemoveAt(maxIndex);
            return string.Join(" ", words);
        }

        static string ReplaceWords(string text)
        {
            int maxLength = -1;
            int minLength = int.MaxValue;
            int maxIndex = -1;
            int minIndex = -1;
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                    maxIndex = i;
                }

                if (words[i].Length < minLength)
                {
                    minLength = words[i].Length;
                    minIndex = i;
                }
            }

            string tmp = words[maxIndex];
            words[maxIndex] = words[minIndex];
            words[minIndex] = tmp;

            return string.Join(" ", words);
        }

        static (int, int) CountLetters(string text)
        {
            int lettersCount = 0;
            int punctCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    lettersCount++;
                }

                if (char.IsPunctuation(text[i]))
                {
                    punctCount++;
                }
            }

            return (lettersCount, punctCount);
        }

        static string TransformString(string text)
        {
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length - i - 1; j++)
                {
                    if (words[j].Length < words[j + 1].Length)
                    {
                        string tmp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = tmp;
                    }
                }
            }

            return string.Join(" ", words);
        }

    }
}
