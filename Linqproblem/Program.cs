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
            Console.WriteLine(GetStringOfLetters());
            Console.ReadLine();
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
           
            Console.WriteLine(Averagenum(classGrades));


            Console.ReadLine();
        }
        public static double Averagenum(List<string> list) 
        {
             List  <int> num = new List<int>();
            double r;
            List<double> num2 = new List<double>();
        
        for (int i = 0; i < list.Count; i++)
        {
           num =  list[i].Split(',').Select(n=>int.Parse(n)).OrderByDescending(n=>n).ToList();
                num.RemoveAt(4);
                num2.Add(num.Average());
        }
            return num2.Average();
            
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
        public static string GetStringOfLetters()
        {
            string input = Console.ReadLine();
            var result1 = input.ToUpper().ToArray().OrderBy(x => x);        //To Arry, OrderBy
            var result2 = result1.GroupBy(x => x).Select(x => $"{x.Last()}{x.Count()}");                //GroupBy and Count
            string result = "";
            foreach (var item in result2)
            {
                result += item.ToString();
            }

            return result;
        }
    }
    
}