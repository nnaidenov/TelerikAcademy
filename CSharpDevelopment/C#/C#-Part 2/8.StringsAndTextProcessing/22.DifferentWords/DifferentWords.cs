using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.DifferentWords
{
    class DifferentWords
    {
        static void Main(string[] args)
        {
            string str = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.".ToLower();

            string[] words = str.Split(' ');
            Array.Sort(words);

            List<string> wordsList = new List<string>(words.Length);

            for (int i = 0; i < words.Length; i++)
            {
                wordsList.Add(words[i]);
            }

            for (int i = 0; i < wordsList.Count; i++)
            {
                for (int j = i + 1; j < wordsList.Count; j++)
                {
                    if (wordsList[i] == wordsList[j])
                    {
                        wordsList.Remove(wordsList[j]);
                    }
                }
            }

            int[] count = new int[wordsList.Count];

            for (int i = 0; i < wordsList.Count; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (wordsList[i] == words[j])
                    {
                        count[i]++;
                    }
                }
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} {1} times", wordsList[i], count[i]);
                }
            }
        }
    }
}