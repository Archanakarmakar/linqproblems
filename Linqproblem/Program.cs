using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqproblem
{
    public delegate List<string> THwords(List<string> list);
    class Program
    {
       
        static void Main(string[] args)
        {

            

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            THwords newwords;
            List<string> wordsth;

            newwords = ReturnSubstringFromList;
            wordsth = newwords(words);
            List<string> depWord = new List<string>() { "Mike", "Brad", "Navin", "Zack", "Mike" };
            List<string> depWordSearch;
            newwords = GetStringNotDuplicate;
            depWordSearch = newwords(depWord);
            Console.ReadLine();
        }
        public static List<string> ReturnSubstringFromList(List<string> list)
        {
            List<string> thList = list.Where(t => t.Contains("th")).ToList();
            return thList;
        }
        public static List<string> GetStringNotDuplicate(List<string> list)
        {
            List<string> dupList = list.Distinct().ToList();
            return dupList;
        }

    }
    
}