using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            string rev = "";
            foreach (string word in arr)
            {
                string reverseWord = "";
                for (int i = 0; i < word.Length; i++)
                {
                    reverseWord += word[word.Length - 1 - i];

                }
                rev += reverseWord + " ";
            }
            Console.WriteLine(rev);
        }
    }
}
