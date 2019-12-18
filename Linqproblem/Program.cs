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

            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            Console.ReadLine();
        }
        public static int Average(List<string> list) 
        {
            List<int> averages = new List<int>;
            for (int i = 0; i < list.Count; i++)
            {
                string t = list[i];
                foreach (char c in t)
                {
                    int o = 0;
                    int.TryParse(c.ToString(), out o);
                    if (o > 0 && o <= 100)
                        averages.Add(o);
                }
                ;
            }
           
            return 5;
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