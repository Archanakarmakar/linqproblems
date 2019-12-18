using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqproblem
{
    class LinqQuestions
    {
        public List<string> ReturnSubstringFromList(List<string> list)
        {
            List<string> thList = list.Where(t => t.Contains("th")).ToList();
            return thList;
                   }
        public List<string> GetStringNotDuplicate(List<string> list)
        {
            List<string> dupList = list.Distinct().ToList();
            return dupList;
        }
    }
}
