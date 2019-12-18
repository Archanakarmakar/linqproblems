using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqproblem
{
    class Program
    {
        public delegate string GetthWords(string s);
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> thwords;  
            thwords = words.Where(w => w.Contains("th")).ToList();
            for (int i = 0; i < thwords.Count; i++)
            {

                Console.WriteLine(thwords[i]);
            }

            Console.ReadLine();
        }

     
    }
}
