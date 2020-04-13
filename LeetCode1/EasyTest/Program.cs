using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace EasyTest
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            HashSetSolution(Console.ReadLine());
        }

        private static void HashSetSolution(string testString)
        {
            HashSet<char> hs = new HashSet<char>();
            foreach (var ch in testString)
            {
                if (hs.Contains(ch))
                {
                    Console.WriteLine($"Char {ch} has been found multiple times");
                    break;
                }
                else
                {
                    hs.Add(ch);
                }
            }
        }
    }
}
