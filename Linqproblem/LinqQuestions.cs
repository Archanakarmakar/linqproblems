using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqproblem
{
    class LinqQuestions
    {
 
        public void GetStringOfLetters()
        {
            string input = "Terrill";
            var result1 = input.ToUpper().ToArray().OrderBy(x => x);        //To Arry, OrderBy
            var result2 = result1.GroupBy(x => x).Select(x => $"{x.Last()}{x.Count()}");                //GroupBy and Count
            string result = "";
            foreach (var item in result2)
            {
                result += item.ToString();
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

    }

}