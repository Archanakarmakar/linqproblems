﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqproblem
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqQuestions list = new LinqQuestions();

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> THwords = list.ReturnSubstringFromList(words);
            Console.ReadLine();
        }
    }
    
}